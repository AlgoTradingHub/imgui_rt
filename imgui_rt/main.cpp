#include "windows.h"

#include "imgui.h"
#include <math.h>
#include "rasterizer.h"
#include "main.h"

namespace local_main
{
#define IDC_MYICON                      2
#define IDD_OPENGL_DIALOG               102
#define IDD_ABOUTBOX                    103
#define IDS_APP_TITLE                   103
#define IDM_ABOUT                       104
#define IDM_EXIT                        105
#define IDS_HELLO                       106
#define IDI_OPENGL_ICON                 107
#define IDC_OPENGL_MENU                 108
#define IDC_OPENGL_ACCELERATOR          109
#define IDC_OPENGL                      110
#define IDR_MAINFRAME                   128
#define IDC_STATIC                      -1

	WNDCLASSEXW m_winClass;
	HWND  m_hwnd;
	HDC   m_hdc;
	HDC	m_hdc2;
	DWORD* m_bitPointer;
	HBITMAP m_hbitmap;

	unsigned int* m_screen_surface;
	int m_screen_surface_width;
	int m_screen_surface_height;


	const wchar_t* m_window_class_name = L"PLATFORM_WINDOW_CLASS";
};
using namespace local_main;


struct CRGBATexture
{
	unsigned char* pixels;
	int width;
	int height;
};

CRGBATexture* m_font_texture;

void renderDrawLists(ImDrawData* draw_data)
{
	CRasterRGBTriangle2DInfo info;
	info.dest = (BYTE*)m_screen_surface;
	info.dest_width = m_screen_surface_width;
	info.dest_height = m_screen_surface_height;
	info.tex_repeat = false;

#define OFFSETOF(TYPE, ELEMENT) ((size_t)&(((TYPE *)0)->ELEMENT))
	for (int n = 0; n < draw_data->CmdListsCount; n++)
	{
		const ImDrawList* cmd_list = draw_data->CmdLists[n];
		const unsigned char* vtx_buffer = (const unsigned char*)&cmd_list->VtxBuffer.front();
		const ImDrawIdx* idx_buffer = &cmd_list->IdxBuffer.front();

		char* fvp = (char*)(vtx_buffer + OFFSETOF(ImDrawVert, pos));
		char* ftp = (char*)(vtx_buffer + OFFSETOF(ImDrawVert, uv));
		char* fcp = (char*)(vtx_buffer + OFFSETOF(ImDrawVert, col));

		for (int cmd_i = 0; cmd_i < cmd_list->CmdBuffer.size(); cmd_i++)
		{
			const ImDrawCmd* pcmd = &cmd_list->CmdBuffer[cmd_i];
			if (pcmd->UserCallback)
			{
				pcmd->UserCallback(cmd_list, pcmd);
			}
			else
			{
				int n_triangles = pcmd->ElemCount / 3;
				for (int i = 0; i < n_triangles; ++i)
				{
					int idx1 = idx_buffer[i * 3 + 0];
					int idx2 = idx_buffer[i * 3 + 1];
					int idx3 = idx_buffer[i * 3 + 2];

					float* _v0 = (float*)&fvp[sizeof(ImDrawVert) * idx1];
					float* _v1 = (float*)&fvp[sizeof(ImDrawVert) * idx2];
					float* _v2 = (float*)&fvp[sizeof(ImDrawVert) * idx3];

					float v0[2] = { _v0[0], m_screen_surface_height - _v0[1] };
					float v1[2] = { _v1[0], m_screen_surface_height - _v1[1] };
					float v2[2] = { _v2[0], m_screen_surface_height - _v2[1] };


					float* tv0 = (float*)&ftp[sizeof(ImDrawVert) * idx1];
					float* tv1 = (float*)&ftp[sizeof(ImDrawVert) * idx2];
					float* tv2 = (float*)&ftp[sizeof(ImDrawVert) * idx3];

					BYTE* cv0 = (BYTE*)&fcp[sizeof(ImDrawVert) * idx1];
					BYTE* cv1 = (BYTE*)&fcp[sizeof(ImDrawVert) * idx2];
					BYTE* cv2 = (BYTE*)&fcp[sizeof(ImDrawVert) * idx3];

					info.v0 = v0;
					info.v1 = v1;
					info.v2 = v2;
					info.tv0 = tv0;
					info.tv1 = tv1;
					info.tv2 = tv2;
					info.cv0 = cv0;
					info.cv1 = cv1;
					info.cv2 = cv2;

					CRGBATexture* rgba_texture = (CRGBATexture*)pcmd->TextureId;
					info.tex = rgba_texture->pixels;
					info.tex_width = rgba_texture->width;
					info.tex_height = rgba_texture->height;

					info.clip_left = pcmd->ClipRect.x;
					info.clip_right = info.clip_left + (pcmd->ClipRect.z - pcmd->ClipRect.x);
					info.clip_top = (m_screen_surface_height - pcmd->ClipRect.w);
					info.clip_bottom = info.clip_top + (pcmd->ClipRect.w - pcmd->ClipRect.y);

					raster_tri_rgb_swap_rb(info);
				}
			}
			idx_buffer += pcmd->ElemCount;
		}
	};
}

LRESULT __stdcall WindowProc(HWND   hWnd, UINT   msg, WPARAM wParam, LPARAM lParam)
{
	ImGuiIO& io = ImGui::GetIO();

	switch (msg)
	{
	case WM_SETFOCUS:
	{
		m_hwnd = hWnd;
		m_hdc = GetDC(m_hwnd);
		break;
	}

	case WM_KILLFOCUS:
	{
		break;
	}

	case WM_CHAR:
	{
		io.AddInputCharacter((wchar_t)wParam);
		break;
	}

	case WM_MOUSELEAVE:
	{
		io.MousePos = ImVec2(-1, -1);
		break;
	}

	case 0x020A: //WM_MOUSEWHEEL
	{
		short idelta = (short)HIWORD(wParam);
		float delta = idelta / 120.0;
		io.MouseWheel = delta;
		break;

	}

	case WM_LBUTTONDOWN:
	{
		io.MousePos = ImVec2(LOWORD(lParam), HIWORD(lParam));
		io.MouseDown[0] = true;
		break;
	}

	case WM_LBUTTONUP:
	{
		io.MousePos = ImVec2(LOWORD(lParam), HIWORD(lParam));
		io.MouseDown[0] = false;
		break;
	}

	case WM_MOUSEMOVE:
	{
		io.MousePos = ImVec2(LOWORD(lParam), HIWORD(lParam));
		break;
	}

	case WM_KEYDOWN:
	{
		io.KeysDown[wParam] = true;
		io.KeyCtrl = (GetKeyState(VK_LCONTROL) & 0x8000) | (GetKeyState(VK_RCONTROL) & 0x8000);
		io.KeyShift = (GetKeyState(VK_LSHIFT) & 0x8000) | (GetKeyState(VK_RSHIFT) & 0x8000);
		io.KeyAlt = (GetKeyState(VK_LMENU) & 0x8000) | (GetKeyState(VK_RMENU) & 0x8000);

		break;
	}

	case WM_KEYUP:
	{
		io.KeysDown[wParam] = false;
		io.KeyCtrl = (GetKeyState(VK_LCONTROL) & 0x8000) | (GetKeyState(VK_RCONTROL) & 0x8000);
		io.KeyShift = (GetKeyState(VK_LSHIFT) & 0x8000) | (GetKeyState(VK_RSHIFT) & 0x8000);
		io.KeyAlt = (GetKeyState(VK_LMENU) & 0x8000) | (GetKeyState(VK_RMENU) & 0x8000);
		break;
	}

	case WM_SIZE:
	{
		m_screen_surface_width = LOWORD(lParam);
		m_screen_surface_height = HIWORD(lParam);

		if (m_screen_surface)
			free(m_screen_surface);
		m_screen_surface = (unsigned int*)malloc(m_screen_surface_width*m_screen_surface_height * 4);

		io.DisplaySize.x = m_screen_surface_width;
		io.DisplaySize.y = m_screen_surface_height;
		if (!m_font_texture)
		{
			CRGBATexture* rgba_texture = (CRGBATexture*)malloc(sizeof(CRGBATexture));

			unsigned char* rgba_pixels;

			io.Fonts->GetTexDataAsRGBA32(&rgba_pixels, &rgba_texture->width, &rgba_texture->height);

			rgba_texture->pixels = (unsigned char*)malloc(rgba_texture->width*rgba_texture->height * 4);
			memcpy(rgba_texture->pixels, rgba_pixels, rgba_texture->width*rgba_texture->height * 4);

			io.Fonts->TexID = (void*)rgba_texture;

			io.Fonts->ClearInputData();
			io.Fonts->ClearTexData();
		}

		break;
	}

	case WM_PAINT:
	{
		static DWORD last_tick;

		DWORD current_tick = GetTickCount();
		if (!last_tick) last_tick = current_tick;

		io.DeltaTime = (float)(current_tick - last_tick) / 1000.0;

		last_tick = current_tick;

		memset(m_screen_surface, 0xFFFFFFFF, m_screen_surface_width*m_screen_surface_height * 4);
		ImGui::NewFrame();
		renderCallback();
		ImGui::Render();

		BITMAPINFO bi;
		bi.bmiHeader.biSize = sizeof(BITMAPINFOHEADER);
		bi.bmiHeader.biWidth = m_screen_surface_width;
		bi.bmiHeader.biHeight = m_screen_surface_height;
		bi.bmiHeader.biPlanes = 1;
		bi.bmiHeader.biBitCount = 32;
		bi.bmiHeader.biCompression = BI_RGB;
		bi.bmiHeader.biSizeImage = m_screen_surface_width * 4 * m_screen_surface_height;
		bi.bmiHeader.biClrUsed = 0;
		bi.bmiHeader.biClrImportant = 0;

		SetDIBitsToDevice(m_hdc, 0, 0, m_screen_surface_width, m_screen_surface_height, 0, 0, 0, m_screen_surface_height, m_screen_surface, &bi, 0);

		break;
	}

	case WM_CLOSE:
	case WM_DESTROY:
	{
		PostQuitMessage(0);
		break;
	}

	default:
	{
		return DefWindowProc(hWnd, msg, wParam, lParam);
		break;
	}
	}
	return 0;
}


void  testRenderCallback() {
	ImGui::ShowTestWindow();
}

API void setRenderCallback(void( *rc)(void)) {
	renderCallback = rc;
}

API bool setupAll() {
	setRenderCallback(testRenderCallback);

	m_winClass.lpszClassName = m_window_class_name;
	m_winClass.cbSize = sizeof(WNDCLASSEXW);
	m_winClass.style = CS_HREDRAW | CS_VREDRAW | CS_OWNDC;
	m_winClass.lpfnWndProc = WindowProc;
	m_winClass.hInstance = GetModuleHandle(NULL);
	m_winClass.hIcon = LoadIcon(NULL, (LPCTSTR)IDI_OPENGL_ICON);
	m_winClass.hIconSm = LoadIcon(NULL, (LPCTSTR)IDI_OPENGL_ICON);
	m_winClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	m_winClass.hbrBackground = 0;
	m_winClass.lpszMenuName = NULL;
	m_winClass.cbClsExtra = 0;
	m_winClass.cbWndExtra = 0;

	if (!RegisterClassExW(&m_winClass)) return false;

	RECT	rect;
	rect.left = 100;
	rect.top = 100;
	rect.right = 800;
	rect.bottom = 600;

	AdjustWindowRect(&rect, (WS_OVERLAPPEDWINDOW | WS_VISIBLE), false);

	ImGuiIO& io = ImGui::GetIO();
	io.KeyMap[ImGuiKey_Tab] = VK_TAB;
	io.KeyMap[ImGuiKey_LeftArrow] = VK_LEFT;
	io.KeyMap[ImGuiKey_RightArrow] = VK_RIGHT;
	io.KeyMap[ImGuiKey_UpArrow] = VK_UP;
	io.KeyMap[ImGuiKey_DownArrow] = VK_DOWN;
	io.KeyMap[ImGuiKey_PageUp] = VK_PRIOR;
	io.KeyMap[ImGuiKey_PageDown] = VK_NEXT;
	io.KeyMap[ImGuiKey_Home] = VK_HOME;
	io.KeyMap[ImGuiKey_End] = VK_END;
	io.KeyMap[ImGuiKey_Delete] = VK_DELETE;
	io.KeyMap[ImGuiKey_Backspace] = VK_BACK;
	io.KeyMap[ImGuiKey_Enter] = VK_RETURN;
	io.KeyMap[ImGuiKey_Escape] = VK_ESCAPE;
	io.KeyMap[ImGuiKey_A] = 'A';
	io.KeyMap[ImGuiKey_C] = 'C';
	io.KeyMap[ImGuiKey_V] = 'V';
	io.KeyMap[ImGuiKey_X] = 'X';
	io.KeyMap[ImGuiKey_Y] = 'Y';
	io.KeyMap[ImGuiKey_Z] = 'Z';

	io.RenderDrawListsFn = renderDrawLists;
	io.DeltaTime = 1.0f / 60.0f;

	// TODO parameterize this
	m_hwnd = CreateWindowExW(NULL, m_window_class_name, L"IMGUI",
		(WS_OVERLAPPEDWINDOW | WS_VISIBLE),
		rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top, NULL, NULL, m_winClass.hInstance, NULL);

	if (m_hwnd == NULL) return false;

	ShowWindow(m_hwnd, SW_SHOW);
	UpdateWindow(m_hwnd);
	return true;
}

API void mainLoop() {
	MSG uMsg; memset(&uMsg, 0, sizeof(MSG));
	while (uMsg.message != WM_QUIT)
	{
		if (PeekMessage(&uMsg, NULL, 0, 0, PM_REMOVE))
		{
			TranslateMessage(&uMsg);
			DispatchMessage(&uMsg);
		}
	}
}

API void destroyAll() {
	if (m_screen_surface)
	{
		free(m_screen_surface);
		m_screen_surface = NULL;
	}
	ImGui::Shutdown();

	if (m_hdc != NULL)
	{
		ReleaseDC(m_hwnd, m_hdc);
		m_hdc = NULL;
	}
	DestroyWindow(m_hwnd);
	m_hwnd = NULL;


	UnregisterClassW(m_window_class_name, m_winClass.hInstance);
}

extern void(*renderCallback)(void) = 0;

// usage
//int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nShowCmd)
//{
//	if (!setupAll()) return false;
//
//	mainLoop();
//
//	destroyAll();
//	return 0;
//}
//


