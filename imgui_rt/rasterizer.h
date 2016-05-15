#ifndef __RASTERIZER_H__
#define __RASTERIZER_H__

typedef unsigned char BYTE;

struct CRasterRGBTriangle2DInfo
{
	float* v0; //vertex [2]
	float* v1;
	float* v2;
	float* tv0; //texcoord [2]
	float* tv1;
	float* tv2;

	BYTE* cv0; //color[4]
	BYTE* cv1;
	BYTE* cv2;

	int clip_left;
	int clip_right;
	int clip_top;
	int clip_bottom;

	const BYTE* tex;
	int tex_width;
	int tex_height;
	bool tex_repeat;

	BYTE* dest;
	int dest_width;
	int dest_height;
};


extern void raster_tri_rgb_swap_rb( CRasterRGBTriangle2DInfo& info );

#endif //__RASTERIZER_H__