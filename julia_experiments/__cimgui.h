typedef unsigned int uintptr_t;
typedef char* va_list;


typedef unsigned int     size_t;
typedef int              ptrdiff_t;
typedef int              intptr_t;
                
     
struct ImDrawCmd;
struct ImDrawList;
struct ImDrawData;
struct ImFont;
struct ImFontAtlas;
struct ImColor;
struct ImGuiIO;
struct ImGuiStorage;
struct ImGuiStyle;typedef unsigned int ImU32;
typedef unsigned short ImWchar;     
typedef void* ImTextureID;          
typedef ImU32 ImGuiID;              
typedef int ImGuiCol;               
typedef int ImGuiStyleVar;          
typedef int ImGuiKey;               
typedef int ImGuiAlign;             
typedef int ImGuiColorEditMode;     
typedef int ImGuiMouseCursor;       
typedef int ImGuiWindowFlags;       
typedef int ImGuiSetCond;           
typedef int ImGuiInputTextFlags;    
typedef int ImGuiSelectableFlags;   
struct ImGuiTextEditCallbackData;   
typedef int (*ImGuiTextEditCallback)(ImGuiTextEditCallbackData *data);

struct ImVec2
{
    float x, y;
};

struct ImVec4
{
    float x, y, z, w;
};

enum ImGuiWindowFlags_
{
    
    ImGuiWindowFlags_NoTitleBar             = 1 << 0,   
    ImGuiWindowFlags_NoResize               = 1 << 1,   
    ImGuiWindowFlags_NoMove                 = 1 << 2,   
    ImGuiWindowFlags_NoScrollbar            = 1 << 3,   
    ImGuiWindowFlags_NoScrollWithMouse      = 1 << 4,   
    ImGuiWindowFlags_NoCollapse             = 1 << 5,   
    ImGuiWindowFlags_AlwaysAutoResize       = 1 << 6,   
    ImGuiWindowFlags_ShowBorders            = 1 << 7,   
    ImGuiWindowFlags_NoSavedSettings        = 1 << 8,   
    ImGuiWindowFlags_NoInputs               = 1 << 9,   
    ImGuiWindowFlags_MenuBar                = 1 << 10,  
    ImGuiWindowFlags_HorizontalScrollbar    = 1 << 11,  
    ImGuiWindowFlags_NoFocusOnAppearing     = 1 << 12,  
    ImGuiWindowFlags_NoBringToFrontOnFocus  = 1 << 13,  
    
    ImGuiWindowFlags_ChildWindow            = 1 << 20,  
    ImGuiWindowFlags_ChildWindowAutoFitX    = 1 << 21,  
    ImGuiWindowFlags_ChildWindowAutoFitY    = 1 << 22,  
    ImGuiWindowFlags_ComboBox               = 1 << 23,  
    ImGuiWindowFlags_Tooltip                = 1 << 24,  
    ImGuiWindowFlags_Popup                  = 1 << 25,  
    ImGuiWindowFlags_Modal                  = 1 << 26,  
    ImGuiWindowFlags_ChildMenu              = 1 << 27   
};
enum ImGuiInputTextFlags_
{
    
    ImGuiInputTextFlags_CharsDecimal        = 1 << 0,   
    ImGuiInputTextFlags_CharsHexadecimal    = 1 << 1,   
    ImGuiInputTextFlags_CharsUppercase      = 1 << 2,   
    ImGuiInputTextFlags_CharsNoBlank        = 1 << 3,   
    ImGuiInputTextFlags_AutoSelectAll       = 1 << 4,   
    ImGuiInputTextFlags_EnterReturnsTrue    = 1 << 5,   
    ImGuiInputTextFlags_CallbackCompletion  = 1 << 6,   
    ImGuiInputTextFlags_CallbackHistory     = 1 << 7,   
    ImGuiInputTextFlags_CallbackAlways      = 1 << 8,   
    ImGuiInputTextFlags_CallbackCharFilter  = 1 << 9,   
    ImGuiInputTextFlags_AllowTabInput       = 1 << 10,  
    ImGuiInputTextFlags_CtrlEnterForNewLine = 1 << 11,  
    ImGuiInputTextFlags_NoHorizontalScroll  = 1 << 12,  
    ImGuiInputTextFlags_AlwaysInsertMode    = 1 << 13,  
    ImGuiInputTextFlags_ReadOnly            = 1 << 14,  
    ImGuiInputTextFlags_Password            = 1 << 15,  
    
    ImGuiInputTextFlags_Multiline           = 1 << 20   
};
enum ImGuiSelectableFlags_
{
    
    ImGuiSelectableFlags_DontClosePopups    = 1 << 0,   
    ImGuiSelectableFlags_SpanAllColumns     = 1 << 1    
};
enum ImGuiKey_
{
    ImGuiKey_Tab,       
    ImGuiKey_LeftArrow, 
    ImGuiKey_RightArrow,
    ImGuiKey_UpArrow,   
    ImGuiKey_DownArrow, 
    ImGuiKey_PageUp,
    ImGuiKey_PageDown,
    ImGuiKey_Home,      
    ImGuiKey_End,       
    ImGuiKey_Delete,    
    ImGuiKey_Backspace, 
    ImGuiKey_Enter,     
    ImGuiKey_Escape,    
    ImGuiKey_A,         
    ImGuiKey_C,         
    ImGuiKey_V,         
    ImGuiKey_X,         
    ImGuiKey_Y,         
    ImGuiKey_Z,         
    ImGuiKey_COUNT
};
enum ImGuiCol_
{
    ImGuiCol_Text,
    ImGuiCol_TextDisabled,
    ImGuiCol_WindowBg,
    ImGuiCol_ChildWindowBg,
    ImGuiCol_Border,
    ImGuiCol_BorderShadow,
    ImGuiCol_FrameBg,               
    ImGuiCol_FrameBgHovered,
    ImGuiCol_FrameBgActive,
    ImGuiCol_TitleBg,
    ImGuiCol_TitleBgCollapsed,
    ImGuiCol_TitleBgActive,
    ImGuiCol_MenuBarBg,
    ImGuiCol_ScrollbarBg,
    ImGuiCol_ScrollbarGrab,
    ImGuiCol_ScrollbarGrabHovered,
    ImGuiCol_ScrollbarGrabActive,
    ImGuiCol_ComboBg,
    ImGuiCol_CheckMark,
    ImGuiCol_SliderGrab,
    ImGuiCol_SliderGrabActive,
    ImGuiCol_Button,
    ImGuiCol_ButtonHovered,
    ImGuiCol_ButtonActive,
    ImGuiCol_Header,
    ImGuiCol_HeaderHovered,
    ImGuiCol_HeaderActive,
    ImGuiCol_Column,
    ImGuiCol_ColumnHovered,
    ImGuiCol_ColumnActive,
    ImGuiCol_ResizeGrip,
    ImGuiCol_ResizeGripHovered,
    ImGuiCol_ResizeGripActive,
    ImGuiCol_CloseButton,
    ImGuiCol_CloseButtonHovered,
    ImGuiCol_CloseButtonActive,
    ImGuiCol_PlotLines,
    ImGuiCol_PlotLinesHovered,
    ImGuiCol_PlotHistogram,
    ImGuiCol_PlotHistogramHovered,
    ImGuiCol_TextSelectedBg,
    ImGuiCol_TooltipBg,
    ImGuiCol_ModalWindowDarkening,  
    ImGuiCol_COUNT
};enum ImGuiStyleVar_
{
    ImGuiStyleVar_Alpha,               
    ImGuiStyleVar_WindowPadding,       
    ImGuiStyleVar_WindowRounding,      
    ImGuiStyleVar_WindowMinSize,       
    ImGuiStyleVar_ChildWindowRounding, 
    ImGuiStyleVar_FramePadding,        
    ImGuiStyleVar_FrameRounding,       
    ImGuiStyleVar_ItemSpacing,         
    ImGuiStyleVar_ItemInnerSpacing,    
    ImGuiStyleVar_IndentSpacing,       
    ImGuiStyleVar_GrabMinSize          
};enum ImGuiAlign_
{
    ImGuiAlign_Left     = 1 << 0,
    ImGuiAlign_Center   = 1 << 1,
    ImGuiAlign_Right    = 1 << 2,
    ImGuiAlign_Top      = 1 << 3,
    ImGuiAlign_VCenter  = 1 << 4,
    ImGuiAlign_Default  = ImGuiAlign_Left | ImGuiAlign_Top
};
enum ImGuiColorEditMode_
{
    ImGuiColorEditMode_UserSelect = -2,
    ImGuiColorEditMode_UserSelectShowButton = -1,
    ImGuiColorEditMode_RGB = 0,
    ImGuiColorEditMode_HSV = 1,
    ImGuiColorEditMode_HEX = 2
};
enum ImGuiMouseCursor_
{
    ImGuiMouseCursor_Arrow = 0,
    ImGuiMouseCursor_TextInput,         
    ImGuiMouseCursor_Move,              
    ImGuiMouseCursor_ResizeNS,          
    ImGuiMouseCursor_ResizeEW,          
    ImGuiMouseCursor_ResizeNESW,        
    ImGuiMouseCursor_ResizeNWSE,        
    ImGuiMouseCursor_Count_
};
enum ImGuiSetCond_
{
    ImGuiSetCond_Always        = 1 << 0, 
    ImGuiSetCond_Once          = 1 << 1, 
    ImGuiSetCond_FirstUseEver  = 1 << 2, 
    ImGuiSetCond_Appearing     = 1 << 3  
};
struct ImGuiStyle
{
    float       Alpha;                      
    ImVec2      WindowPadding;              
    ImVec2      WindowMinSize;              
    float       WindowRounding;             
    ImGuiAlign  WindowTitleAlign;           
    float       ChildWindowRounding;        
    ImVec2      FramePadding;               
    float       FrameRounding;              
    ImVec2      ItemSpacing;                
    ImVec2      ItemInnerSpacing;           
    ImVec2      TouchExtraPadding;          
    float       WindowFillAlphaDefault;     
    float       IndentSpacing;              
    float       ColumnsMinSpacing;          
    float       ScrollbarSize;              
    float       ScrollbarRounding;          
    float       GrabMinSize;                
    float       GrabRounding;               
    ImVec2      DisplayWindowPadding;       
    ImVec2      DisplaySafeAreaPadding;     
    bool        AntiAliasedLines;           
    bool        AntiAliasedShapes;          
    float       CurveTessellationTol;       
    ImVec4      Colors[ImGuiCol_COUNT];     
    //ImGuiStyle();
};
struct ImGuiIO
{
    
    
        ImVec2        DisplaySize;              
    float         DeltaTime;                
    float         IniSavingRate;            
    const char*   IniFilename;              
    const char*   LogFilename;              
    float         MouseDoubleClickTime;     
    float         MouseDoubleClickMaxDist;  
    float         MouseDragThreshold;       
    int           KeyMap[ImGuiKey_COUNT];   
    float         KeyRepeatDelay;           
    float         KeyRepeatRate;            
    void*         UserData;                     ImFontAtlas*  Fonts;                    
    float         FontGlobalScale;          
    bool          FontAllowUserScaling;     
    ImVec2        DisplayFramebufferScale;  
    ImVec2        DisplayVisibleMin;        
    ImVec2        DisplayVisibleMax;            
    
        
    
    
    void        (*RenderDrawListsFn)(ImDrawData* data);    
    
    const char* (*GetClipboardTextFn)();
    void        (*SetClipboardTextFn)(const char* text);    
    
    void*       (*MemAllocFn)(size_t sz);
    void        (*MemFreeFn)(void* ptr);    
    
    void        (*ImeSetInputScreenPosFn)(int x, int y);
    void*       ImeWindowHandle;                
    
        ImVec2      MousePos;                   
    bool        MouseDown[5];               
    float       MouseWheel;                 
    bool        MouseDrawCursor;            
    bool        KeyCtrl;                    
    bool        KeyShift;                   
    bool        KeyAlt;                     
    bool        KeysDown[512];              
    ImWchar     InputCharacters[16+1];          
     //void AddInputCharacter(ImWchar c);                        
     //void AddInputCharactersUTF8(const char* utf8_chars);      
     //void ClearInputCharacters() { InputCharacters[0] = 0; }       
    
        bool        WantCaptureMouse;           
    bool        WantCaptureKeyboard;        
    bool        WantTextInput;              
    float       Framerate;                  
    int         MetricsAllocs;              
    int         MetricsRenderVertices;      
    int         MetricsRenderIndices;       
    int         MetricsActiveWindows;           
    
        ImVec2      MousePosPrev;               
    ImVec2      MouseDelta;                 
    bool        MouseClicked[5];            
    ImVec2      MouseClickedPos[5];         
    float       MouseClickedTime[5];        
    bool        MouseDoubleClicked[5];      
    bool        MouseReleased[5];           
    bool        MouseDownOwned[5];          
    float       MouseDownDuration[5];       
    float       MouseDownDurationPrev[5];   
    float       MouseDragMaxDistanceSqr[5]; 
    float       KeysDownDuration[512];      
    float       KeysDownDurationPrev[512];        
    // ImGuiIO();
};
struct ImGuiOnceUponAFrame
{
    //ImGuiOnceUponAFrame() { RefFrame = -1; }
    //mutable
     int RefFrame;
    //operator bool() const { int current_frame = ImGui::GetFrameCount(); if (RefFrame == current_frame) return false; RefFrame = current_frame; return true; }
};
struct ImGuiTextFilter
{
};
struct ImGuiTextBuffer
{
    
};struct ImGuiStorage
{
    
};
struct ImGuiTextEditCallbackData
{
    ImGuiInputTextFlags EventFlag;      
    ImGuiInputTextFlags Flags;          
    void*               UserData;       
    bool                ReadOnly;           
    ImWchar             EventChar;          
    ImGuiKey            EventKey;       
    char*               Buf;            
    int                 BufSize;        
    bool                BufDirty;       
    int                 CursorPos;      
    int                 SelectionStart; 
    int                 SelectionEnd;       
    // void    DeleteChars(int pos, int bytes_count);
    // void    InsertChars(int pos, const char* text, const char* text_end = 0);
    // bool    HasSelection() const { return SelectionStart != SelectionEnd; }
};struct ImColor
{
    ImVec4              Value;  
    //   ImColor()                                                       { Value.x = Value.y = Value.z = Value.w = 0.0f; }
    // ImColor(int r, int g, int b, int a = 255)                       { float sc = 1.0f/255.0f; Value.x = (float)r * sc; Value.y = (float)g * sc; Value.z = (float)b * sc; Value.w = (float)a * sc; }
    // ImColor(ImU32 rgba)                                             { float sc = 1.0f/255.0f; Value.x = (float)(rgba&0xFF) * sc; Value.y = (float)((rgba>>8)&0xFF) * sc; Value.z = (float)((rgba>>16)&0xFF) * sc; Value.w = (float)(rgba >> 24) * sc; }
    // ImColor(float r, float g, float b, float a = 1.0f)              { Value.x = r; Value.y = g; Value.z = b; Value.w = a; }
    // ImColor(const ImVec4& col)                                      { Value = col; }
    // inline operator ImU32() const                                   { return ImGui::ColorConvertFloat4ToU32(Value); }
    // inline operator ImVec4() const                                  { return Value; }    inline void    SetHSV(float h, float s, float v, float a = 1.0f){ ImGui::ColorConvertHSVtoRGB(h, s, v, Value.x, Value.y, Value.z); Value.w = a; }    static ImColor HSV(float h, float s, float v, float a = 1.0f)   { float r,g,b; ImGui::ColorConvertHSVtoRGB(h, s, v, r, g, b); return ImColor(r,g,b,a); }
};struct ImGuiListClipper
{
    float   ItemsHeight;
    int     ItemsCount, DisplayStart, DisplayEnd; 

};typedef void (*ImDrawCallback)(const ImDrawList* parent_list, const ImDrawCmd* cmd);
struct ImDrawCmd
{
    unsigned int    ElemCount;              
    ImVec4          ClipRect;               
    ImTextureID     TextureId;              
    ImDrawCallback  UserCallback;           
    //void*           UserCallbackData;           ImDrawCmd() { ElemCount = 0; ClipRect.x = ClipRect.y = -8192.0f; ClipRect.z = ClipRect.w = +8192.0f; TextureId = 0; UserCallback = 0; UserCallbackData = 0; }
};typedef unsigned short ImDrawIdx;
struct ImDrawVert
{
    ImVec2  pos;
    ImVec2  uv;
    ImU32   col;
};struct ImDrawChannel
{
    // ImVector<ImDrawCmd>     CmdBuffer;
    // ImVector<ImDrawIdx>     IdxBuffer;
};
struct ImDrawList
{
};
struct ImDrawData
{
    bool            Valid;                  
    ImDrawList**    CmdLists;
    int             CmdListsCount;
    int             TotalVtxCount;          
    int             TotalIdxCount;              
    // ImDrawData() { Valid = false; CmdLists = 0; CmdListsCount = TotalVtxCount = TotalIdxCount = 0; }
    //  void DeIndexAllBuffers();               
    //  void ScaleClipRects(const ImVec2& sc);  
};struct ImFontConfig
{
    void*           FontData;                   
    int             FontDataSize;               
    bool            FontDataOwnedByAtlas;       
    int             FontNo;                     
    float           SizePixels;                 
    int             OversampleH, OversampleV;   
    bool            PixelSnapH;                 
    ImVec2          GlyphExtraSpacing;          
    const ImWchar*  GlyphRanges;                
    bool            MergeMode;                  
    bool            MergeGlyphCenterV;              
    char            Name[32];                               
    ImFont*         DstFont;   
    //  ImFontConfig();
};struct ImFontAtlas
{
};struct ImFont
{
    
    float                       FontSize;           
    float                       Scale;              
    ImVec2                      DisplayOffset;      
    ImWchar                     FallbackChar;       
    ImFontConfig*               ConfigData;         
    int                         ConfigDataCount;        
    struct Glyph
    {
        ImWchar                 Codepoint;
        float                   XAdvance;
        float                   X0, Y0, X1, Y1;
        float                   U0, V0, U1, V1;     
    };
    float                       Ascent, Descent;    
    ImFontAtlas*                ContainerAtlas;     
};
typedef int ImGuiSetCond;
typedef int ImGuiColorEditMode;

extern "C" __declspec(dllexport) int igTest(int test1, int test2);extern "C" __declspec(dllexport) ImGuiIO*         igGetIO();
extern "C" __declspec(dllexport) ImGuiStyle*      igGetStyle();
extern "C" __declspec(dllexport) ImDrawData*      igGetDrawData();
extern "C" __declspec(dllexport) void             igNewFrame();
extern "C" __declspec(dllexport) void             igRender();
extern "C" __declspec(dllexport) void             igShutdown();
extern "C" __declspec(dllexport) void             igShowUserGuide();
extern "C" __declspec(dllexport) void             igShowStyleEditor(ImGuiStyle* ref);
extern "C" __declspec(dllexport) void             igShowTestWindow(bool* opened);
extern "C" __declspec(dllexport) void             igShowMetricsWindow(bool* opened);
extern "C" __declspec(dllexport) bool             igBegin(const char* name, bool* p_opened, ImGuiWindowFlags flags);
extern "C" __declspec(dllexport) bool             igBegin2(const char* name, bool* p_opened, const struct ImVec2 size_on_first_use, float bg_alpha, ImGuiWindowFlags flags);
extern "C" __declspec(dllexport) void             igEnd();
extern "C" __declspec(dllexport) bool             igBeginChild(const char* str_id, const struct ImVec2 size, bool border, ImGuiWindowFlags extra_flags);
extern "C" __declspec(dllexport) bool             igBeginChildEx(ImGuiID id, const struct ImVec2 size, bool border, ImGuiWindowFlags extra_flags);
extern "C" __declspec(dllexport) void             igEndChild();
extern "C" __declspec(dllexport) void             igGetContentRegionMax(struct ImVec2* out);
extern "C" __declspec(dllexport) void             igGetContentRegionAvail(struct ImVec2* out);
extern "C" __declspec(dllexport) float            igGetContentRegionAvailWidth();
extern "C" __declspec(dllexport) void             igGetWindowContentRegionMin(struct ImVec2* out);
extern "C" __declspec(dllexport) void             igGetWindowContentRegionMax(struct ImVec2* out);
extern "C" __declspec(dllexport) float            igGetWindowContentRegionWidth();
extern "C" __declspec(dllexport) ImDrawList*      igGetWindowDrawList();
extern "C" __declspec(dllexport) ImFont*          igGetWindowFont();
extern "C" __declspec(dllexport) float            igGetWindowFontSize(); 
extern "C" __declspec(dllexport) void             igSetWindowFontScale(float scale);
extern "C" __declspec(dllexport) void             igGetWindowPos(struct ImVec2* out);
extern "C" __declspec(dllexport) void             igGetWindowSize(struct ImVec2* out);
extern "C" __declspec(dllexport) float            igGetWindowWidth();
extern "C" __declspec(dllexport) float            igGetWindowHeight();
extern "C" __declspec(dllexport) bool             igIsWindowCollapsed();extern "C" __declspec(dllexport) void             igSetNextWindowPos(const struct ImVec2 pos, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetNextWindowPosCenter(ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetNextWindowSize(const struct ImVec2 size, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetNextWindowContentSize(const ImVec2 size);
extern "C" __declspec(dllexport) void             igSetNextWindowContentWidth(float width);
extern "C" __declspec(dllexport) void             igSetNextWindowCollapsed(bool collapsed, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetNextWindowFocus();
extern "C" __declspec(dllexport) void             igSetWindowPos(const struct ImVec2 pos, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetWindowSize(const struct ImVec2 size, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetWindowCollapsed(bool collapsed, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetWindowFocus();
extern "C" __declspec(dllexport) void             igSetWindowPosByName(const char* name, const struct ImVec2 pos, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetWindowSize2(const char* name, const struct ImVec2 size, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetWindowCollapsed2(const char* name, bool collapsed, ImGuiSetCond cond);
extern "C" __declspec(dllexport) void             igSetWindowFocus2(const char* name);extern "C" __declspec(dllexport) float            igGetScrollX();
extern "C" __declspec(dllexport) float            igGetScrollY();
extern "C" __declspec(dllexport) float            igGetScrollMaxX();
extern "C" __declspec(dllexport) float            igGetScrollMaxY();
extern "C" __declspec(dllexport) void             igSetScrollX(float scroll_x);
extern "C" __declspec(dllexport) void             igSetScrollY(float scroll_y);
extern "C" __declspec(dllexport) void             igSetScrollHere(float center_y_ratio);
extern "C" __declspec(dllexport) void             igSetScrollFromPosY(float pos_y, float center_y_ratio);
extern "C" __declspec(dllexport) void             igSetKeyboardFocusHere(int offset);
extern "C" __declspec(dllexport) void             igSetStateStorage(ImGuiStorage* tree);
extern "C" __declspec(dllexport) ImGuiStorage*    igGetStateStorage();
extern "C" __declspec(dllexport) void             igPushFont(ImFont* font);
extern "C" __declspec(dllexport) void             igPopFont();
extern "C" __declspec(dllexport) void             igPushStyleColor(ImGuiCol idx, const struct ImVec4 col);
extern "C" __declspec(dllexport) void             igPopStyleColor(int count);
extern "C" __declspec(dllexport) void             igPushStyleVar(ImGuiStyleVar idx, float val);
extern "C" __declspec(dllexport) void             igPushStyleVarVec(ImGuiStyleVar idx, const struct ImVec2 val);
extern "C" __declspec(dllexport) void             igPopStyleVar(int count);
extern "C" __declspec(dllexport) ImU32            igGetColorU32(ImGuiCol idx, float alpha_mul);
extern "C" __declspec(dllexport) ImU32            igGetColorU32Vec(const ImVec4* col);extern "C" __declspec(dllexport) void             igPushItemWidth(float item_width);
extern "C" __declspec(dllexport) void             igPopItemWidth();
extern "C" __declspec(dllexport) float            igCalcItemWidth();
extern "C" __declspec(dllexport) void             igPushTextWrapPos(float wrap_pos_x);
extern "C" __declspec(dllexport) void             igPopTextWrapPos();
extern "C" __declspec(dllexport) void             igPushAllowKeyboardFocus(bool v);
extern "C" __declspec(dllexport) void             igPopAllowKeyboardFocus();
extern "C" __declspec(dllexport) void             igPushButtonRepeat(bool repeat);
extern "C" __declspec(dllexport) void             igPopButtonRepeat();
extern "C" __declspec(dllexport) void             igBeginGroup();
extern "C" __declspec(dllexport) void             igEndGroup();
extern "C" __declspec(dllexport) void             igSeparator();
extern "C" __declspec(dllexport) void             igSameLine(float local_pos_x, float spacing_w);
extern "C" __declspec(dllexport) void             igSpacing();
extern "C" __declspec(dllexport) void             igDummy(const ImVec2* size);
extern "C" __declspec(dllexport) void             igIndent();
extern "C" __declspec(dllexport) void             igUnindent();
extern "C" __declspec(dllexport) void             igColumns(int count, const char* id, bool border);
extern "C" __declspec(dllexport) void             igNextColumn();
extern "C" __declspec(dllexport) int              igGetColumnIndex();
extern "C" __declspec(dllexport) float            igGetColumnOffset(int column_index);
extern "C" __declspec(dllexport) void             igSetColumnOffset(int column_index, float offset_x);
extern "C" __declspec(dllexport) float            igGetColumnWidth(int column_index);
extern "C" __declspec(dllexport) int              igGetColumnsCount();
extern "C" __declspec(dllexport) void             igGetCursorPos(struct ImVec2* pOut);
extern "C" __declspec(dllexport) float            igGetCursorPosX();
extern "C" __declspec(dllexport) float            igGetCursorPosY();
extern "C" __declspec(dllexport) void             igSetCursorPos(const struct ImVec2 local_pos);
extern "C" __declspec(dllexport) void             igSetCursorPosX(float x);
extern "C" __declspec(dllexport) void             igSetCursorPosY(float y);
extern "C" __declspec(dllexport) void             igGetCursorStartPos(struct ImVec2* pOut);
extern "C" __declspec(dllexport) void             igGetCursorScreenPos(struct ImVec2* pOut);
extern "C" __declspec(dllexport) void             igSetCursorScreenPos(const struct ImVec2 pos);
extern "C" __declspec(dllexport) void             igAlignFirstTextHeightToWidgets();
extern "C" __declspec(dllexport) float            igGetTextLineHeight();
extern "C" __declspec(dllexport) float            igGetTextLineHeightWithSpacing();
extern "C" __declspec(dllexport) float            igGetItemsLineHeightWithSpacing();
extern "C" __declspec(dllexport) void             igPushIdStr(const char* str_id);
extern "C" __declspec(dllexport) void             igPushIdStrRange(const char* str_begin, const char* str_end);
extern "C" __declspec(dllexport) void             igPushIdPtr(const void* ptr_id);
extern "C" __declspec(dllexport) void             igPushIdInt(int int_id);
extern "C" __declspec(dllexport) void             igPopId();
extern "C" __declspec(dllexport) ImGuiID          igGetIdStr(const char* str_id);
extern "C" __declspec(dllexport) ImGuiID          igGetIdStrRange(const char* str_begin,const char* str_end);
extern "C" __declspec(dllexport) ImGuiID          igGetIdPtr(const void* ptr_id);
extern "C" __declspec(dllexport) void             igText(const char* fmt, ...);
extern "C" __declspec(dllexport) void             igTextV(const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igTextColored(const struct ImVec4 col, const char* fmt, ...);
extern "C" __declspec(dllexport) void             igTextColoredV(const struct ImVec4 col, const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igTextDisabled(const char* fmt, ...);
extern "C" __declspec(dllexport) void             igTextDisabledV(const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igTextWrapped(const char* fmt, ...);
extern "C" __declspec(dllexport) void             igTextWrappedV(const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igTextUnformatted(const char* text, const char* text_end);
extern "C" __declspec(dllexport) void             igLabelText(const char* label, const char* fmt, ...);
extern "C" __declspec(dllexport) void             igLabelTextV(const char* label, const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igBullet();
extern "C" __declspec(dllexport) void             igBulletText(const char* fmt, ...);
extern "C" __declspec(dllexport) void             igBulletTextV(const char* fmt, va_list args);
extern "C" __declspec(dllexport) bool             igButton(const char* label, const struct ImVec2 size);
extern "C" __declspec(dllexport) bool             igSmallButton(const char* label);
extern "C" __declspec(dllexport) bool             igInvisibleButton(const char* str_id, const struct ImVec2 size);
extern "C" __declspec(dllexport) void             igImage(ImTextureID user_texture_id, const struct ImVec2 size, const struct ImVec2 uv0, const struct ImVec2 uv1, const struct ImVec4 tint_col, const struct ImVec4 border_col);
extern "C" __declspec(dllexport) bool             igImageButton(ImTextureID user_texture_id, const struct ImVec2 size, const struct ImVec2 uv0, const struct ImVec2 uv1, int frame_padding, const struct ImVec4 bg_col, const struct ImVec4 tint_col);
extern "C" __declspec(dllexport) bool             igCollapsingHeader(const char* label, const char* str_id, bool display_frame, bool default_open);
extern "C" __declspec(dllexport) bool             igCheckbox(const char* label, bool* v);
extern "C" __declspec(dllexport) bool             igCheckboxFlags(const char* label, unsigned int* flags, unsigned int flags_value);
extern "C" __declspec(dllexport) bool             igRadioButtonBool(const char* label, bool active);
extern "C" __declspec(dllexport) bool             igRadioButton(const char* label, int* v, int v_button);
extern "C" __declspec(dllexport) bool             igCombo(const char* label, int* current_item, const char** items, int items_count, int height_in_items);
extern "C" __declspec(dllexport) bool             igCombo2(const char* label, int* current_item, const char* items_separated_by_zeros, int height_in_items);
extern "C" __declspec(dllexport) bool             igCombo3(const char* label, int* current_item, bool(*items_getter)(void* data, int idx, const char** out_text), void* data, int items_count, int height_in_items);
extern "C" __declspec(dllexport) bool             igColorButton(const struct ImVec4 col, bool small_height, bool outline_border);
extern "C" __declspec(dllexport) bool             igColorEdit3(const char* label, float col[]);
extern "C" __declspec(dllexport) bool             igColorEdit4(const char* label, float col[], bool show_alpha);
extern "C" __declspec(dllexport) void             igColorEditMode(ImGuiColorEditMode mode);
extern "C" __declspec(dllexport) void             igPlotLines(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size, int stride);
extern "C" __declspec(dllexport) void             igPlotLines2(const char* label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size);
extern "C" __declspec(dllexport) void             igPlotHistogram(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size, int stride);
extern "C" __declspec(dllexport) void             igPlotHistogram2(const char* label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size);
extern "C" __declspec(dllexport) void             igProgressBar(float fraction, const ImVec2* size_arg, const char* overlay);extern "C" __declspec(dllexport) bool             igSliderFloat(const char* label, float* v, float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igSliderFloat2(const char* label, float v[], float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igSliderFloat3(const char* label, float v[], float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igSliderFloat4(const char* label, float v[], float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igSliderAngle(const char* label, float* v_rad, float v_degrees_min, float v_degrees_max);
extern "C" __declspec(dllexport) bool             igSliderInt(const char* label, int* v, int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igSliderInt2(const char* label, int v[], int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igSliderInt3(const char* label, int v[], int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igSliderInt4(const char* label, int v[], int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igVSliderFloat(const char* label, const struct ImVec2 size, float* v, float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igVSliderInt(const char* label, const struct ImVec2 size, int* v, int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igDragFloat(const char* label, float* v, float v_speed, float v_min, float v_max, const char* display_format, float power);     
extern "C" __declspec(dllexport) bool             igDragFloat2(const char* label, float v[], float v_speed, float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igDragFloat3(const char* label, float v[], float v_speed, float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igDragFloat4(const char* label, float v[], float v_speed, float v_min, float v_max, const char* display_format, float power);
extern "C" __declspec(dllexport) bool             igDragFloatRange2(const char* label, float* v_current_min, float* v_current_max, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, const char* display_format = "%.3f", const char* display_format_max = 0, float power = 1.0f);
extern "C" __declspec(dllexport) bool             igDragInt(const char* label, int* v, float v_speed, int v_min, int v_max, const char* display_format);                                       
extern "C" __declspec(dllexport) bool             igDragInt2(const char* label, int v[], float v_speed, int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igDragInt3(const char* label, int v[], float v_speed, int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igDragInt4(const char* label, int v[], float v_speed, int v_min, int v_max, const char* display_format);
extern "C" __declspec(dllexport) bool             igDragIntRange2(const char* label, int* v_current_min, int* v_current_max, float v_speed = 1.0f, int v_min = 0, int v_max = 0, const char* display_format = "%.0f", const char* display_format_max = 0);extern "C" __declspec(dllexport) bool             igInputText(const char* label, char* buf, size_t buf_size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
extern "C" __declspec(dllexport) bool             igInputTextMultiline(const char* label, char* buf, size_t buf_size, const ImVec2 size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
extern "C" __declspec(dllexport) bool             igInputFloat(const char* label, float* v, float step, float step_fast, int decimal_precision, ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputFloat2(const char* label, float v[], int decimal_precision, ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputFloat3(const char* label, float v[], int decimal_precision, ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputFloat4(const char* label, float v[], int decimal_precision, ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputInt(const char* label, int* v, int step, int step_fast, ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputInt2(const char* label, int v[], ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputInt3(const char* label, int v[], ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igInputInt4(const char* label, int v[], ImGuiInputTextFlags extra_flags);
extern "C" __declspec(dllexport) bool             igTreeNode(const char* str_label_id);
extern "C" __declspec(dllexport) bool             igTreeNodeStr(const char* str_id, const char* fmt, ...);
extern "C" __declspec(dllexport) bool             igTreeNodePtr(const void* ptr_id, const char* fmt, ...);
extern "C" __declspec(dllexport) bool             igTreeNodeStrV(const char* str_id, const char* fmt, va_list args);
extern "C" __declspec(dllexport) bool             igTreeNodePtrV(const void* ptr_id, const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igTreePushStr(const char* str_id);
extern "C" __declspec(dllexport) void             igTreePushPtr(const void* ptr_id);
extern "C" __declspec(dllexport) void             igTreePop();
extern "C" __declspec(dllexport) void             igSetNextTreeNodeOpened(bool opened, ImGuiSetCond cond);
extern "C" __declspec(dllexport) bool             igSelectable(const char* label, bool selected, ImGuiSelectableFlags flags, const ImVec2 size);
extern "C" __declspec(dllexport) bool             igSelectableEx(const char* label, bool* p_selected, ImGuiSelectableFlags flags, const ImVec2 size);
extern "C" __declspec(dllexport) bool             igListBox(const char* label, int* current_item, const char** items, int items_count, int height_in_items);
extern "C" __declspec(dllexport) bool             igListBox2(const char* label, int* current_item, bool(*items_getter)(void* data, int idx, const char** out_text), void* data, int items_count, int height_in_items);
extern "C" __declspec(dllexport) bool             igListBoxHeader(const char* label, const struct ImVec2 size);
extern "C" __declspec(dllexport) bool             igListBoxHeader2(const char* label, int items_count, int height_in_items);
extern "C" __declspec(dllexport) void             igListBoxFooter();
extern "C" __declspec(dllexport) void             igValueBool(const char* prefix, bool b);
extern "C" __declspec(dllexport) void             igValueInt(const char* prefix, int v);
extern "C" __declspec(dllexport) void             igValueUInt(const char* prefix, unsigned int v);
extern "C" __declspec(dllexport) void             igValueFloat(const char* prefix, float v, const char* float_format);
extern "C" __declspec(dllexport) void             igValueColor(const char* prefix, const struct ImVec4 v);
extern "C" __declspec(dllexport) void             igValueColor2(const char* prefix, unsigned int v);
extern "C" __declspec(dllexport) void             igSetTooltip(const char* fmt, ...);
extern "C" __declspec(dllexport) void             igSetTooltipV(const char* fmt, va_list args);
extern "C" __declspec(dllexport) void             igBeginTooltip();
extern "C" __declspec(dllexport) void             igEndTooltip();
extern "C" __declspec(dllexport) bool             igBeginMainMenuBar();
extern "C" __declspec(dllexport) void             igEndMainMenuBar();
extern "C" __declspec(dllexport) bool             igBeginMenuBar();
extern "C" __declspec(dllexport) void             igEndMenuBar();
extern "C" __declspec(dllexport) bool             igBeginMenu(const char* label, bool enabled);
extern "C" __declspec(dllexport) void             igEndMenu();
extern "C" __declspec(dllexport) bool             igMenuItem(const char* label, const char* shortcut, bool selected, bool enabled);
extern "C" __declspec(dllexport) bool             igMenuItemPtr(const char* label, const char* shortcut, bool* p_selected, bool enabled);
extern "C" __declspec(dllexport) void             igOpenPopup(const char* str_id);
extern "C" __declspec(dllexport) bool             igBeginPopup(const char* str_id);
extern "C" __declspec(dllexport) bool             igBeginPopupModal(const char* name, bool* p_opened, ImGuiWindowFlags extra_flags);
extern "C" __declspec(dllexport) bool             igBeginPopupContextItem(const char* str_id, int mouse_button);
extern "C" __declspec(dllexport) bool             igBeginPopupContextWindow(bool also_over_items, const char* str_id, int mouse_button);
extern "C" __declspec(dllexport) bool             igBeginPopupContextVoid(const char* str_id, int mouse_button);
extern "C" __declspec(dllexport) void             igEndPopup();
extern "C" __declspec(dllexport) void             igCloseCurrentPopup();
extern "C" __declspec(dllexport) void             igLogToTTY(int max_depth);
extern "C" __declspec(dllexport) void             igLogToFile(int max_depth, const char* filename);
extern "C" __declspec(dllexport) void             igLogToClipboard(int max_depth);
extern "C" __declspec(dllexport) void             igLogFinish();
extern "C" __declspec(dllexport) void             igLogButtons();
extern "C" __declspec(dllexport) void             igLogText(const char* fmt, ...);
extern "C" __declspec(dllexport) bool             igIsItemHovered();
extern "C" __declspec(dllexport) bool             igIsItemHoveredRect();
extern "C" __declspec(dllexport) bool             igIsItemActive();
extern "C" __declspec(dllexport) bool             igIsItemVisible();
extern "C" __declspec(dllexport) bool             igIsAnyItemHovered();
extern "C" __declspec(dllexport) bool             igIsAnyItemActive();
extern "C" __declspec(dllexport) void             igGetItemRectMin(struct ImVec2* pOut);
extern "C" __declspec(dllexport) void             igGetItemRectMax(struct ImVec2* pOut);
extern "C" __declspec(dllexport) void             igGetItemRectSize(struct ImVec2* pOut);
extern "C" __declspec(dllexport) bool             igIsWindowHovered();
extern "C" __declspec(dllexport) bool             igIsWindowFocused();
extern "C" __declspec(dllexport) bool             igIsRootWindowFocused();
extern "C" __declspec(dllexport) bool             igIsRootWindowOrAnyChildFocused();
extern "C" __declspec(dllexport) bool             igIsRectVisible(const struct ImVec2 item_size);
extern "C" __declspec(dllexport) bool             igIsPosHoveringAnyWindow(const struct ImVec2 pos);
extern "C" __declspec(dllexport) float            igGetTime();
extern "C" __declspec(dllexport) int              igGetFrameCount();
extern "C" __declspec(dllexport) const char*      igGetStyleColName(ImGuiCol idx);
extern "C" __declspec(dllexport) void             igCalcItemRectClosestPoint(struct ImVec2* pOut, const struct ImVec2 pos, bool on_edge, float outward);
extern "C" __declspec(dllexport) void             igCalcTextSize(struct ImVec2* pOut, const char* text, const char* text_end, bool hide_text_after_double_hash, float wrap_width);
extern "C" __declspec(dllexport) void             igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);extern "C" __declspec(dllexport) bool             igBeginChildFrame(ImGuiID id, const struct ImVec2 size, ImGuiWindowFlags extra_flags);
extern "C" __declspec(dllexport) void             igEndChildFrame();extern "C" __declspec(dllexport) void             igColorConvertU32ToFloat4(ImVec4* pOut, ImU32 in);
extern "C" __declspec(dllexport) ImU32            igColorConvertFloat4ToU32(const struct ImVec4 in);
extern "C" __declspec(dllexport) void             igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
extern "C" __declspec(dllexport) void             igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);extern "C" __declspec(dllexport) int              igGetKeyIndex(ImGuiKey key);
extern "C" __declspec(dllexport) bool             igIsKeyDown(int key_index);
extern "C" __declspec(dllexport) bool             igIsKeyPressed(int key_index, bool repeat);
extern "C" __declspec(dllexport) bool             igIsKeyReleased(int key_index);
extern "C" __declspec(dllexport) bool             igIsMouseDown(int button);
extern "C" __declspec(dllexport) bool             igIsMouseClicked(int button, bool repeat);
extern "C" __declspec(dllexport) bool             igIsMouseDoubleClicked(int button);
extern "C" __declspec(dllexport) bool             igIsMouseReleased(int button);
extern "C" __declspec(dllexport) bool             igIsMouseHoveringWindow();
extern "C" __declspec(dllexport) bool             igIsMouseHoveringAnyWindow();
extern "C" __declspec(dllexport) bool             igIsMouseHoveringRect(const struct ImVec2 pos_min, const struct ImVec2 pos_max, bool clip);
extern "C" __declspec(dllexport) bool             igIsMouseDragging(int button, float lock_threshold);
extern "C" __declspec(dllexport) void             igGetMousePos(struct ImVec2* pOut);
extern "C" __declspec(dllexport) void             igGetMousePosOnOpeningCurrentPopup(ImVec2* pOut);
extern "C" __declspec(dllexport) void             igGetMouseDragDelta(struct ImVec2* pOut, int button, float lock_threshold);
extern "C" __declspec(dllexport) void             igResetMouseDragDelta(int button);
extern "C" __declspec(dllexport) ImGuiMouseCursor igGetMouseCursor();
extern "C" __declspec(dllexport) void             igSetMouseCursor(ImGuiMouseCursor type);
extern "C" __declspec(dllexport) void             igCaptureKeyboardFromApp();
extern "C" __declspec(dllexport) void             igCaptureMouseFromApp();
extern "C" __declspec(dllexport) void*            igMemAlloc(size_t sz);
extern "C" __declspec(dllexport) void             igMemFree(void* ptr);
extern "C" __declspec(dllexport) const char*      igGetClipboardText();
extern "C" __declspec(dllexport) void             igSetClipboardText(const char* text);
extern "C" __declspec(dllexport) const char*      igGetVersion();
extern "C" __declspec(dllexport) void*            igGetInternalState();
extern "C" __declspec(dllexport) size_t           igGetInternalStateSize();
extern "C" __declspec(dllexport) void             igSetInternalState(void* state, bool construct);extern "C" __declspec(dllexport) void             ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* atlas, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
extern "C" __declspec(dllexport) void             ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* atlas, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
extern "C" __declspec(dllexport) void             ImFontAtlas_SetTexID(ImFontAtlas* atlas, void* tex);
extern "C" __declspec(dllexport) ImFont*          ImFontAtlas_AddFont(ImFontAtlas* atlas, const ImFontConfig* font_cfg);
extern "C" __declspec(dllexport) ImFont*          ImFontAtlas_AddFontDefault(ImFontAtlas* atlas, const ImFontConfig* font_cfg);
extern "C" __declspec(dllexport) ImFont*          ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* atlas, const char* filename, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern "C" __declspec(dllexport) ImFont*          ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* atlas, void* ttf_data, int ttf_size, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern "C" __declspec(dllexport) ImFont*          ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* atlas, const void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern "C" __declspec(dllexport) ImFont*          ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* atlas, const char* compressed_ttf_data_base85, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern "C" __declspec(dllexport) void             ImFontAtlas_ClearTexData(ImFontAtlas* atlas);
extern "C" __declspec(dllexport) void             ImFontAtlas_Clear(ImFontAtlas* atlas);extern "C" __declspec(dllexport) void             ImGuiIO_AddInputCharacter(unsigned short c);
extern "C" __declspec(dllexport) void             ImGuiIO_AddInputCharactersUTF8(const char* utf8_chars);
extern "C" __declspec(dllexport) void             ImGuiIO_ClearInputCharacters();
extern "C" __declspec(dllexport) void             ImDrawData_DeIndexAllBuffers(ImDrawData* drawData);
extern "C" __declspec(dllexport) int              ImDrawList_GetVertexBufferSize(ImDrawList* list);
extern "C" __declspec(dllexport) ImDrawVert*      ImDrawList_GetVertexPtr(ImDrawList* list, int n);
extern "C" __declspec(dllexport) int              ImDrawList_GetIndexBufferSize(ImDrawList* list);
extern "C" __declspec(dllexport) ImDrawIdx*       ImDrawList_GetIndexPtr(ImDrawList* list, int n);
extern "C" __declspec(dllexport) int              ImDrawList_GetCmdSize(ImDrawList* list);
extern "C" __declspec(dllexport) ImDrawCmd*       ImDrawList_GetCmdPtr(ImDrawList* list, int n);extern "C" __declspec(dllexport) void             ImDrawList_Clear(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_ClearFreeMemory(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_PushClipRect(ImDrawList* list, const struct ImVec4 clip_rect); 
extern "C" __declspec(dllexport) void             ImDrawList_PushClipRectFullScreen(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_PopClipRect(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_PushTextureID(ImDrawList* list, const ImTextureID texture_id);
extern "C" __declspec(dllexport) void             ImDrawList_PopTextureID(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_AddLine(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col, float thickness);
extern "C" __declspec(dllexport) void             ImDrawList_AddRect(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col, float rounding, int rounding_corners);
extern "C" __declspec(dllexport) void             ImDrawList_AddRectFilled(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col, float rounding, int rounding_corners);
extern "C" __declspec(dllexport) void             ImDrawList_AddRectFilledMultiColor(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col_upr_left, ImU32 col_upr_right, ImU32 col_bot_right, ImU32 col_bot_left);
extern "C" __declspec(dllexport) void             ImDrawList_AddTriangleFilled(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, const struct ImVec2 c, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_AddCircle(ImDrawList* list, const struct ImVec2 centre, float radius, ImU32 col, int num_segments);
extern "C" __declspec(dllexport) void             ImDrawList_AddCircleFilled(ImDrawList* list, const struct ImVec2 centre, float radius, ImU32 col, int num_segments);
extern "C" __declspec(dllexport) void             ImDrawList_AddText(ImDrawList* list, const struct ImVec2 pos, ImU32 col, const char* text_begin, const char* text_end);
extern "C" __declspec(dllexport) void             ImDrawList_AddTextExt(ImDrawList* list, const ImFont* font, float font_size, const struct ImVec2 pos, ImU32 col, const char* text_begin, const char* text_end, float wrap_width, const ImVec4* cpu_fine_clip_rect);
extern "C" __declspec(dllexport) void             ImDrawList_AddImage(ImDrawList* list, ImTextureID user_texture_id, const struct ImVec2 a, const struct ImVec2 b, const struct ImVec2 uv0, const struct ImVec2 uv1, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_AddPolyline(ImDrawList* list, const ImVec2* points, const int num_points, ImU32 col, bool closed, float thickness, bool anti_aliased);
extern "C" __declspec(dllexport) void             ImDrawList_AddConvexPolyFilled(ImDrawList* list, const ImVec2* points, const int num_points, ImU32 col, bool anti_aliased);
extern "C" __declspec(dllexport) void             ImDrawList_AddBezierCurve(ImDrawList* list, const struct ImVec2 pos0, const struct ImVec2 cp0, const struct ImVec2 cp1, const struct ImVec2 pos1, ImU32 col, float thickness, int num_segments);
extern "C" __declspec(dllexport) void             ImDrawList_PathClear(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_PathLineTo(ImDrawList* list, const struct ImVec2 pos);
extern "C" __declspec(dllexport) void             ImDrawList_PathLineToMergeDuplicate(ImDrawList* list, const struct ImVec2 pos);
extern "C" __declspec(dllexport) void             ImDrawList_PathFill(ImDrawList* list, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_PathStroke(ImDrawList* list, ImU32 col, bool closed, float thickness);
extern "C" __declspec(dllexport) void             ImDrawList_PathArcTo(ImDrawList* list, const struct ImVec2 centre, float radius, float a_min, float a_max, int num_segments);
extern "C" __declspec(dllexport) void             ImDrawList_PathArcToFast(ImDrawList* list, const struct ImVec2 centre, float radius, int a_min_of_12, int a_max_of_12); 
extern "C" __declspec(dllexport) void             ImDrawList_PathBezierCurveTo(ImDrawList* list, const struct ImVec2 p1, const struct ImVec2 p2, const struct ImVec2 p3, int num_segments);
extern "C" __declspec(dllexport) void             ImDrawList_PathRect(ImDrawList* list, const struct ImVec2 rect_min, const struct ImVec2 rect_max, float rounding, int rounding_corners);
extern "C" __declspec(dllexport) void             ImDrawList_ChannelsSplit(ImDrawList* list, int channels_count);
extern "C" __declspec(dllexport) void             ImDrawList_ChannelsMerge(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_ChannelsSetCurrent(ImDrawList* list, int channel_index);
extern "C" __declspec(dllexport) void             ImDrawList_AddCallback(ImDrawList* list, ImDrawCallback callback, void* callback_data); 
extern "C" __declspec(dllexport) void             ImDrawList_AddDrawCmd(ImDrawList* list); 
extern "C" __declspec(dllexport) void             ImDrawList_PrimReserve(ImDrawList* list, int idx_count, int vtx_count);
extern "C" __declspec(dllexport) void             ImDrawList_PrimRect(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_PrimRectUV(ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, const struct ImVec2 uv_a, const struct ImVec2 uv_b, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_PrimVtx(ImDrawList* list, const struct ImVec2 pos, const struct ImVec2 uv, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_PrimWriteVtx(ImDrawList* list, const struct ImVec2 pos, const struct ImVec2 uv, ImU32 col);
extern "C" __declspec(dllexport) void             ImDrawList_PrimWriteIdx(ImDrawList* list, ImDrawIdx idx);
extern "C" __declspec(dllexport) void             ImDrawList_UpdateClipRect(ImDrawList* list);
extern "C" __declspec(dllexport) void             ImDrawList_UpdateTextureID(ImDrawList* list);
