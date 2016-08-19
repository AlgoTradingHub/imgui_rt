#pragma once

#define API extern "C" __declspec(dllexport) 

extern void(*renderCallback)(void);
extern HWND hwnd;

void  testRenderCallback();

API void setRenderCallback(void(*rc)(void));
API bool setupAll();
API void mainLoop();
API void destroyAll();

API bool setupAll_dx10();
API void mainLoop_dx10();
API void destroyAll_dx10();

API void setTitle(char* text);
