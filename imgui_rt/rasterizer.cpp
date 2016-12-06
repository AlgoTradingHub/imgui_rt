#include "rasterizer.h"
#include <math.h>

#define frac(x) ((float)(x)-floor((float)x))
#define FIXED_ONE       0x00000800
#define FIXED_HALF      0x00000400
#define FIXED_FRAC_MASK 0x000007FF
#define FIXED_INT_MASK  (~FIXED_FRAC_MASK)
#define FIXED_EPSILON   1
#define FIXED_SCALE     2048.0f
#define FIXED_SHIFT     11
#define FloatToFixed(X) ((int) ((X) * FIXED_SCALE))
#define IntToFixed(I)   ((I) << FIXED_SHIFT)
#define FixedToInt(X)   ((X) >> FIXED_SHIFT)
#define FixedToUns(X)   (((unsigned int)(X)) >> 11)
#define FixedCeil(X)    (((X) + FIXED_ONE - FIXED_EPSILON) & FIXED_INT_MASK)
#define FixedFloor(X)   ((X) & FIXED_INT_MASK)
#define FixedToFloat(X) ((X) * 0.00048828125f)
#define PosFloatToFixed(X)      FloatToFixed(X)
#define SignedFloatToFixed(X)   FloatToFixed(X)

#pragma warning(disable:4244)

void raster_tri_rgb_swap_rb(CRasterRGBTriangle2DInfo& info)
{
	if (info.clip_left < 0)
		info.clip_left = 0;
	if (info.clip_right > info.dest_width)
		info.clip_right = info.dest_width;
	if (info.clip_top < 0)
		info.clip_top = 0;
	if (info.clip_bottom > info.dest_height)
		info.clip_bottom = info.dest_height;

	typedef struct
	{
		float* v0, *v1;			/* Y(v0) < Y(v1) */
		float* tv0, *tv1;
		BYTE* cv0, *cv1;
		float dx;				/* X(v1) - X(v0) */
		float dy;				/* Y(v1) - Y(v0) */
		int fdxdy;				/* dx/dy in fixed-point */
		int fsx;				/* first sample point x coord */
		int fsy;
		float adjy;				/* adjust from v[0]->fy to fsy, scaled */
		int lines;				/* number of lines to be sampled on this edge */
		int fx0;				/* fixed pt X of lower endpoint */
	} EdgeT;

	EdgeT eMaj, eTop, eBot;
	float oneOverArea;

	float* vMin, *vMid, *vMax;       /* vertex indices:  Y(vMin)<=Y(vMid)<=Y(vMax) */
	float* tvMin, *tvMid, *tvMax;
	BYTE* cvMin, *cvMid, *cvMax;

	/* find the order of the 3 vertices along the Y axis */
	float y0 = info.v0[1];
	float y1 = info.v1[1];
	float y2 = info.v2[1];

	if (y0 <= y1) {
		if (y1 <= y2) {
			vMin = info.v0;   vMid = info.v1;   vMax = info.v2;   /* y0<=y1<=y2 */
			tvMin = info.tv0;   tvMid = info.tv1;   tvMax = info.tv2;   /* y0<=y1<=y2 */
			cvMin = info.cv0;   cvMid = info.cv1;   cvMax = info.cv2;   /* y0<=y1<=y2 */
		}
		else if (y2 <= y0) {
			vMin = info.v2;   vMid = info.v0;   vMax = info.v1;   /* y2<=y0<=y1 */
			tvMin = info.tv2;   tvMid = info.tv0;   tvMax = info.tv1;   /* y2<=y0<=y1 */
			cvMin = info.cv2;   cvMid = info.cv0;   cvMax = info.cv1;   /* y2<=y0<=y1 */
		}
		else {
			vMin = info.v0;   vMid = info.v2;   vMax = info.v1;   /* y0<=y2<=y1 */
			tvMin = info.tv0;   tvMid = info.tv2;   tvMax = info.tv1;   /* y0<=y2<=y1 */
			cvMin = info.cv0;   cvMid = info.cv2;   cvMax = info.cv1;   /* y0<=y2<=y1 */
		}
	}
	else {
		if (y0 <= y2) {
			vMin = info.v1;   vMid = info.v0;   vMax = info.v2;   /* y1<=y0<=y2 */
			tvMin = info.tv1;   tvMid = info.tv0;   tvMax = info.tv2;   /* y1<=y0<=y2 */
			cvMin = info.cv1;   cvMid = info.cv0;   cvMax = info.cv2;   /* y1<=y0<=y2 */
		}
		else if (y2 <= y1) {
			vMin = info.v2;   vMid = info.v1;   vMax = info.v0;   /* y2<=y1<=y0 */
			tvMin = info.tv2;  tvMid = info.tv1;   tvMax = info.tv0;   /* y2<=y1<=y0 */
			cvMin = info.cv2;  cvMid = info.cv1;   cvMax = info.cv0;   /* y2<=y1<=y0 */
		}
		else {
			vMin = info.v1;   vMid = info.v2;   vMax = info.v0;   /* y1<=y2<=y0 */
			tvMin = info.tv1;   tvMid = info.tv2;   tvMax = info.tv0;   /* y1<=y2<=y0 */
			cvMin = info.cv1;   cvMid = info.cv2;   cvMax = info.cv0;   /* y1<=y2<=y0 */
		}
	}

	/* vertex/edge relationship */
	eMaj.v0 = vMin;   eMaj.v1 = vMax;
	eTop.v0 = vMid;   eTop.v1 = vMax;
	eBot.v0 = vMin;   eBot.v1 = vMid;

	eMaj.tv0 = tvMin;   eMaj.tv1 = tvMax;
	eTop.tv0 = tvMid;   eTop.tv1 = tvMax;
	eBot.tv0 = tvMin;   eBot.tv1 = tvMid;

	eMaj.cv0 = cvMin;   eMaj.cv1 = cvMax;
	eTop.cv0 = cvMid;   eTop.cv1 = cvMax;
	eBot.cv0 = cvMin;   eBot.cv1 = cvMid;

	/* compute deltas for each edge:  vertex[v1] - vertex[v0] */
	eMaj.dx = vMax[0] - vMin[0];
	eMaj.dy = vMax[1] - vMin[1];
	eTop.dx = vMax[0] - vMid[0];
	eTop.dy = vMax[1] - vMid[1];
	eBot.dx = vMid[0] - vMin[0];
	eBot.dy = vMid[1] - vMin[1];

	float area = eMaj.dx * eBot.dy - eBot.dx * eMaj.dy;
	if (area > -0.05f && area < 0.05f)
		return;  /* very small; CULLED */

	oneOverArea = 1.0F / area;

	/* fixed point Y coordinates */
	int vMin_fx = FloatToFixed(vMin[0] + 0.5F);
	int vMin_fy = FloatToFixed(vMin[1] - 0.5F);
	int vMid_fx = FloatToFixed(vMid[0] + 0.5F);
	int vMid_fy = FloatToFixed(vMid[1] - 0.5F);
	int vMax_fy = FloatToFixed(vMax[1] - 0.5F);

	eMaj.fsy = FixedCeil(vMin_fy);
	eMaj.lines = FixedToInt(vMax_fy + FIXED_ONE - FIXED_EPSILON - eMaj.fsy);
	if (eMaj.lines > 0)
	{
		float dxdy = eMaj.dx / eMaj.dy;
		eMaj.fdxdy = SignedFloatToFixed(dxdy);
		eMaj.adjy = (float)(eMaj.fsy - vMin_fy);  /* SCALED! */
		eMaj.fx0 = vMin_fx;
		eMaj.fsx = eMaj.fx0 + (int)(eMaj.adjy * dxdy);
	}
	else
		return;  /*CULLED*/

	eTop.fsy = FixedCeil(vMid_fy);
	eTop.lines = FixedToInt(vMax_fy + FIXED_ONE - FIXED_EPSILON - eTop.fsy);
	if (eTop.lines > 0) {
		float dxdy = eTop.dx / eTop.dy;
		eTop.fdxdy = SignedFloatToFixed(dxdy);
		eTop.adjy = (float)(eTop.fsy - vMid_fy); /* SCALED! */
		eTop.fx0 = vMid_fx;
		eTop.fsx = eTop.fx0 + (int)(eTop.adjy * dxdy);
	}

	eBot.fsy = FixedCeil(vMin_fy);
	eBot.lines = FixedToInt(vMid_fy + FIXED_ONE - FIXED_EPSILON - eBot.fsy);
	if (eBot.lines > 0) {
		float dxdy = eBot.dx / eBot.dy;
		eBot.fdxdy = SignedFloatToFixed(dxdy);
		eBot.adjy = (float)(eBot.fsy - vMin_fy);  /* SCALED! */
		eBot.fx0 = vMin_fx;
		eBot.fsx = eBot.fx0 + (int)(eBot.adjy * dxdy);
	}

	int ltor = (oneOverArea < 0.0F);

	float drdx, drdy;      int fdrdx;
	float dgdx, dgdy;      int fdgdx;
	float dbdx, dbdy;      int fdbdx;
	float dadx, dady;      int fdadx;
	{
		float eMaj_dr, eBot_dr;
		eMaj_dr = (int)cvMax[0] - (int)cvMin[0];
		eBot_dr = (int)cvMid[0] - (int)cvMin[0];
		drdx = oneOverArea * (eMaj_dr * eBot.dy - eMaj.dy * eBot_dr);
		fdrdx = SignedFloatToFixed(drdx);
		drdy = oneOverArea * (eMaj.dx * eBot_dr - eMaj_dr * eBot.dx);
	}
	{
		float eMaj_dg, eBot_dg;
		eMaj_dg = (int)cvMax[1] - (int)cvMin[1];
		eBot_dg = (int)cvMid[1] - (int)cvMin[1];
		dgdx = oneOverArea * (eMaj_dg * eBot.dy - eMaj.dy * eBot_dg);
		fdgdx = SignedFloatToFixed(dgdx);
		dgdy = oneOverArea * (eMaj.dx * eBot_dg - eMaj_dg * eBot.dx);
	}
	{
		float eMaj_db, eBot_db;
		eMaj_db = (int)cvMax[2] - (int)cvMin[2];
		eBot_db = (int)cvMid[2] - (int)cvMin[2];
		dbdx = oneOverArea * (eMaj_db * eBot.dy - eMaj.dy * eBot_db);
		fdbdx = SignedFloatToFixed(dbdx);
		dbdy = oneOverArea * (eMaj.dx * eBot_db - eMaj_db * eBot.dx);
	}

	{
		float eMaj_da, eBot_da;
		eMaj_da = (int)cvMax[3] - (int)cvMin[3];
		eBot_da = (int)cvMid[3] - (int)cvMin[3];
		dadx = oneOverArea * (eMaj_da * eBot.dy - eMaj.dy * eBot_da);
		fdadx = SignedFloatToFixed(dadx);
		dady = oneOverArea * (eMaj.dx * eBot_da - eMaj_da * eBot.dx);
	}



	float wMax = 1.0F;
	float wMin = 1.0F;
	float wMid = 1.0F;

	float eMaj_ds = tvMax[0] * wMax - tvMin[0] * wMin;
	float eBot_ds = tvMid[0] * wMid - tvMin[0] * wMin;
	float eMaj_dt = tvMax[1] * wMax - tvMin[1] * wMin;
	float eBot_dt = tvMid[1] * wMid - tvMin[1] * wMin;

	float dsdx = oneOverArea * (eMaj_ds * eBot.dy - eMaj.dy * eBot_ds);
	float dsdy = oneOverArea * (eMaj.dx * eBot_ds - eMaj_ds * eBot.dx);
	float dtdx = oneOverArea * (eMaj_dt * eBot.dy - eMaj.dy * eBot_dt);
	float dtdy = oneOverArea * (eMaj.dx * eBot_dt - eMaj_dt * eBot.dx);

	int fx, fxLeftEdge, fxRightEdge, fdxLeftEdge, fdxRightEdge;
	int fdxOuter;
	int idxOuter;
	float dxOuter;
	int fError, fdError;
	float adjx, adjy;
	int fy;
	int iy;

	int fr, fdrOuter, fdrInner;
	int fg, fdgOuter, fdgInner;
	int fb, fdbOuter, fdbInner;
	int fa, fdaOuter, fdaInner;

	float sLeft, dsOuter, dsInner;
	float tLeft, dtOuter, dtInner;


	for (int subTriangle = 0; subTriangle <= 1; subTriangle++)
	{
		EdgeT *eLeft, *eRight;
		int setupLeft, setupRight;
		int lines;

		if (subTriangle == 0) {
			/* bottom half */
			if (ltor) {
				eLeft = &eMaj;
				eRight = &eBot;
				lines = eRight->lines;
				setupLeft = 1;
				setupRight = 1;
			}
			else {
				eLeft = &eBot;
				eRight = &eMaj;
				lines = eLeft->lines;
				setupLeft = 1;
				setupRight = 1;
			}
		}
		else {
			/* top half */
			if (ltor)
			{
				eLeft = &eMaj;
				eRight = &eTop;
				lines = eRight->lines;
				setupLeft = 0;
				setupRight = 1;
			}
			else
			{
				eLeft = &eTop;
				eRight = &eMaj;
				lines = eLeft->lines;
				setupLeft = 1;
				setupRight = 0;
			}
			if (lines == 0) return;
		}

		if (setupLeft && eLeft->lines > 0)
		{
			int fsx = eLeft->fsx;
			fx = FixedCeil(fsx);
			fError = fx - fsx - FIXED_ONE;
			fxLeftEdge = fsx - FIXED_EPSILON;
			fdxLeftEdge = eLeft->fdxdy;
			fdxOuter = FixedFloor(fdxLeftEdge - FIXED_EPSILON);
			fdError = fdxOuter - fdxLeftEdge + FIXED_ONE;
			idxOuter = FixedToInt(fdxOuter);
			dxOuter = (float)idxOuter;

			fy = eLeft->fsy;
			iy = FixedToInt(fy);

			adjx = (float)(fx - eLeft->fx0);  /* SCALED! */
			adjy = eLeft->adjy;				 /* SCALED! */

			float* vLower = eLeft->v0;
			float* tvLower = eLeft->tv0;
			BYTE* cvLower = eLeft->cv0;

			sLeft = tvLower[0] * 1.0F + (dsdx * adjx + dsdy * adjy) * (1.0F / FIXED_SCALE);
			dsOuter = dsdy + dxOuter * dsdx;

			tLeft = tvLower[1] * 1.0F + (dtdx * adjx + dtdy * adjy) * (1.0F / FIXED_SCALE);
			dtOuter = dtdy + dxOuter * dtdx;

			fr = (int)(IntToFixed(cvLower[0]) + drdx * adjx + drdy * adjy) + FIXED_HALF;
			fdrOuter = SignedFloatToFixed(drdy + dxOuter * drdx);

			fg = (int)(IntToFixed(cvLower[1]) + dgdx * adjx + dgdy * adjy) + FIXED_HALF;
			fdgOuter = SignedFloatToFixed(dgdy + dxOuter * dgdx);

			fb = (int)(IntToFixed(cvLower[2]) + dbdx * adjx + dbdy * adjy) + FIXED_HALF;
			fdbOuter = SignedFloatToFixed(dbdy + dxOuter * dbdx);

			fa = (int)(IntToFixed(cvLower[3]) + dadx * adjx + dady * adjy) + FIXED_HALF;
			fdaOuter = SignedFloatToFixed(dady + dxOuter * dadx);
		}

		if (setupRight && eRight->lines > 0)
		{
			fxRightEdge = eRight->fsx - FIXED_EPSILON;
			fdxRightEdge = eRight->fdxdy;
		}

		if (lines == 0)
			continue;

		fdrInner = fdrOuter + fdrdx;
		fdgInner = fdgOuter + fdgdx;
		fdbInner = fdbOuter + fdbdx;
		fdaInner = fdaOuter + fdadx;

		dsInner = dsOuter + dsdx;
		dtInner = dtOuter + dtdx;

		if (iy + lines >= info.clip_bottom)
			lines = info.clip_bottom - iy;

		while (lines > 0)
		{
			float ss = sLeft, tt = tLeft;
			int ffr = fr, ffg = fg, ffb = fb;
			int ffa = fa;

			int left = FixedToInt(fxLeftEdge);
			int right = FixedToInt(fxRightEdge);

			int ffrend = ffr + (right - left - 1)*fdrdx;
			int ffgend = ffg + (right - left - 1)*fdgdx;
			int ffbend = ffb + (right - left - 1)*fdbdx;
			if (ffrend < 0) ffr -= ffrend;
			if (ffgend < 0) ffg -= ffgend;
			if (ffbend < 0) ffb -= ffbend;
			if (ffr < 0) ffr = 0;
			if (ffg < 0) ffg = 0;
			if (ffb < 0) ffb = 0;

			int ffaend = ffa + (right - left - 1)*fdadx;
			if (ffaend < 0) ffa -= ffaend;
			if (ffa < 0) ffa = 0;

			int i;
			int n = right - left;

			if (iy >= info.clip_top)
			{

				if (n > 0)
					if (left < info.clip_left)
					{
						int diff = info.clip_left - left;
						ss += dsdx	 *diff;
						tt += dtdx	 *diff;
						ffr += fdrdx *diff;
						ffg += fdgdx *diff;
						ffb += fdbdx *diff;
						ffa += fdadx *diff;

						n -= diff;

						left = info.clip_left;
					}

				if (n > 0)
					if (left + n >= info.clip_right)
					{
						n = info.clip_right - left;
					}

				if (n > 0)
					for (i = 0; i < n; i++)
					{
						int i0, j0, i1, j1;
						float u, v;

						u = ss * info.tex_width;
						v = tt * info.tex_height;



						i0 = (int)floor(u - 0.5F);
						i1 = i0 + 1;
						j0 = (int)floor(v - 0.5F);
						j1 = j0 + 1;


						float a = frac(u - 0.5F);
						float b = frac(v - 0.5F);

						int w00 = (int)((1.0F - a)*(1.0F - b) * 256.0F);
						int w10 = (int)(a *(1.0F - b) * 256.0F);
						int w01 = (int)((1.0F - a)*      b  * 256.0F);
						int w11 = (int)(a *      b  * 256.0F);

						unsigned char red00, green00, blue00, alpha00;
						unsigned char red10, green10, blue10, alpha10;
						unsigned char red01, green01, blue01, alpha01;
						unsigned char red11, green11, blue11, alpha11;

						const unsigned char* texel;

						if (info.tex_repeat)
						{
							if (i0 < 0)
								i0 = info.tex_width + i0;
							else
								if (i0 >= info.tex_width)
									i0 = i0 - info.tex_width;

							if (i1 < 0)
								i1 = info.tex_width + i0;
							else
								if (i1 >= info.tex_width)
									i1 = i1 - info.tex_width;

							if (j0 < 0)
								j0 = info.tex_height + j0;
							else
								if (j0 >= info.tex_height)
									j0 = j0 - info.tex_height;

							if (j1 < 0)
								j1 = info.tex_height + j1;
							else
								if (j1 >= info.tex_height)
									j1 = j1 - info.tex_height;
						}

						BYTE* ppix = (BYTE*)(info.dest + (iy*info.dest_width + left) * 4);
						BYTE pix_r = ppix[i * 4 + 0];
						BYTE pix_g = ppix[i * 4 + 1];
						BYTE pix_b = ppix[i * 4 + 2];
						BYTE pix_a = ppix[i * 4 + 3];

						BYTE border_r = pix_r; //mesa3d cannot do this :)
						BYTE border_g = pix_g;
						BYTE border_b = pix_b;
						BYTE border_a = 0;

						bool i0_border = (i0 < 0 || i0 >= info.tex_width);
						bool i1_border = (i1 < 0 || i1 >= info.tex_width);
						bool j0_border = (j0 < 0 || j0 >= info.tex_height);
						bool j1_border = (j1 < 0 || j1 >= info.tex_height);

						if (i0_border | j0_border)
						{
							red00 = border_r;
							green00 = border_g;
							blue00 = border_b;
							alpha00 = border_a;
						}
						else
						{
							texel = info.tex + (info.tex_width * j0 + i0) * 4;
							red00 = texel[0];
							green00 = texel[1];
							blue00 = texel[2];
							alpha00 = texel[3];
						}

						if (i1_border | j0_border)
						{
							red10 = border_r;
							green10 = border_g;
							blue10 = border_b;
							alpha10 = border_a;
						}
						else
						{
							texel = info.tex + (info.tex_width * j0 + i1) * 4;
							red10 = texel[0];
							green10 = texel[1];
							blue10 = texel[2];
							alpha10 = texel[3];
						}

						if (j1_border | i0_border)
						{
							red01 = border_r;
							green01 = border_g;
							blue01 = border_b;
							alpha01 = border_a;
						}
						else
						{
							texel = info.tex + (info.tex_width * j1 + i0) * 4;
							red01 = texel[0];
							green01 = texel[1];
							blue01 = texel[2];
							alpha01 = texel[3];
						}

						if (i1_border | j1_border)
						{
							red11 = border_r;
							green11 = border_g;
							blue11 = border_b;
							alpha11 = border_a;
						}
						else
						{
							texel = info.tex + (info.tex_width * j1 + i1) * 4;
							red11 = texel[0];
							green11 = texel[1];
							blue11 = texel[2];
							alpha11 = texel[3];
						}

						BYTE _r = (w00*red00 + w10*red10 + w01*red01 + w11*red11) / 256;
						BYTE _g = (w00*green00 + w10*green10 + w01*green01 + w11*green11) / 256;
						BYTE _b = (w00*blue00 + w10*blue10 + w01*blue01 + w11*blue11) / 256;
						BYTE _a = (w00*alpha00 + w10*alpha10 + w01*alpha01 + w11*alpha11) / 256;


						_r = (_r * FixedToInt(ffr)) / 256;
						_g = (_g * FixedToInt(ffg)) / 256;
						_b = (_b * FixedToInt(ffb)) / 256;
						_a = (_a * FixedToInt(ffa)) / 256;

						int t = _a;
						int s = 255 - t;

						ppix[i * 4 + 0] = (_b * t + pix_r * s) / 256; //swap rb
						ppix[i * 4 + 1] = (_g * t + pix_g * s) / 256;
						ppix[i * 4 + 2] = (_r * t + pix_b * s) / 256;
						ppix[i * 4 + 3] = (_a * t + pix_a * s) / 256;

						ss += dsdx;
						tt += dtdx;
						ffr += fdrdx;
						ffg += fdgdx;
						ffb += fdbdx;
						ffa += fdadx;
					}
			}

			iy++;
			lines--;

			fxLeftEdge += fdxLeftEdge;
			fxRightEdge += fdxRightEdge;


			fError += fdError;
			if (fError >= 0)
			{
				fError -= FIXED_ONE;

				sLeft += dsOuter;
				tLeft += dtOuter;
				fr += fdrOuter;
				fg += fdgOuter;
				fb += fdbOuter;
				fa += fdaOuter;
			}
			else {
				sLeft += dsInner;
				tLeft += dtInner;
				fr += fdrInner;
				fg += fdgInner;
				fb += fdbInner;
				fa += fdaInner;
			}
		}
	}
}