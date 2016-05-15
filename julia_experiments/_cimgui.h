typedef unsigned int uintptr_t;
typedef char* va_list;


typedef unsigned int     size_t;
typedef int              ptrdiff_t;
typedef int              intptr_t;
typedef char bool;                
     
struct ImDrawCmd;
struct ImDrawList;
struct ImDrawData;
struct ImFont;
struct ImFontAtlas;
struct ImColor;
struct ImGuiIO;
struct ImGuiStorage;
struct ImGuiStyle;
typedef unsigned int ImU32;
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
typedef int (*ImGuiTextEditCallback)(struct ImGuiTextEditCallbackData *data);

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
    ImGuiColorEditMode_RGB /*= 0*/,
    ImGuiColorEditMode_HSV = 1,
    ImGuiColorEditMode_HEX = 2
};
enum ImGuiMouseCursor_
{
    ImGuiMouseCursor_Arrow /*= 0*/,
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
    struct ImVec2      WindowPadding;              
    struct ImVec2      WindowMinSize;              
    float       WindowRounding;             
    ImGuiAlign  WindowTitleAlign;           
    float       ChildWindowRounding;        
    struct ImVec2      FramePadding;               
    float       FrameRounding;              
    struct ImVec2      ItemSpacing;                
    struct ImVec2      ItemInnerSpacing;           
    struct ImVec2      TouchExtraPadding;          
    float       WindowFillAlphaDefault;     
    float       IndentSpacing;              
    float       ColumnsMinSpacing;          
    float       ScrollbarSize;              
    float       ScrollbarRounding;          
    float       GrabMinSize;                
    float       GrabRounding;               
    struct ImVec2      DisplayWindowPadding;       
    struct ImVec2      DisplaySafeAreaPadding;     
    bool        AntiAliasedLines;           
    bool        AntiAliasedShapes;          
    float       CurveTessellationTol;       
    struct ImVec4      Colors[ImGuiCol_COUNT];     
    //struct ImGuiStyle(void);
};
struct ImGuiIO
{
    
    
        struct ImVec2        DisplaySize;              
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
    void*         UserData;                     struct ImFontAtlas*  Fonts;                    
    float         FontGlobalScale;          
    bool          FontAllowUserScaling;     
    struct ImVec2        DisplayFramebufferScale;  
    struct ImVec2        DisplayVisibleMin;        
    struct ImVec2        DisplayVisibleMax;            
    
        
    
    
    void        (*RenderDrawListsFn)(struct ImDrawData* data);    
    
    const char* (*GetClipboardTextFn)(void);
    void        (*SetClipboardTextFn)(const char* text);    
    
    void*       (*MemAllocFn)(size_t sz);
    void        (*MemFreeFn)(void* ptr);    
    
    void        (*ImeSetInputScreenPosFn)(int x, int y);
    void*       ImeWindowHandle;                
    
        struct ImVec2      MousePos;                   
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
    
        struct ImVec2      MousePosPrev;               
    struct ImVec2      MouseDelta;                 
    bool        MouseClicked[5];            
    struct ImVec2      MouseClickedPos[5];         
    float       MouseClickedTime[5];        
    bool        MouseDoubleClicked[5];      
    bool        MouseReleased[5];           
    bool        MouseDownOwned[5];          
    float       MouseDownDuration[5];       
    float       MouseDownDurationPrev[5];   
    float       MouseDragMaxDistanceSqr[5]; 
    float       KeysDownDuration[512];      
    float       KeysDownDurationPrev[512];        
    // struct ImGuiIO(void);
};
struct ImGuiOnceUponAFrame
{
    //ImGuiOnceUponAFrame() { RefFrame = -1; }
    //mutable
     int RefFrame;
    //operator bool() const { int current_frame = ImGui::GetFrameCount(void); if (RefFrame == current_frame) return false; RefFrame = current_frame; return true; }
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
    struct ImVec4              Value;  
    //   struct ImColor()                                                       { Value.x = Value.y = Value.z = Value.w = 0.0f; }
    // struct ImColor(int r, int g, int b, int a = 255)                       { float sc/*=1.0f*//255.0f; Value.x = (float)r * sc; Value.y = (float)g * sc; Value.z = (float)b * sc; Value.w = (float)a * sc; }
    // struct ImColor(ImU32 rgba)                                             { float sc/*=1.0f*//255.0f; Value.x = (float)(rgba&0xFF) * sc; Value.y = (float)((rgba>>8)&0xFF) * sc; Value.z = (float)((rgba>>16)&0xFF) * sc; Value.w = (float)(rgba >> 24) * sc; }
    // struct ImColor(float r, float g, float b, float a/*=1.0f*/)              { Value.x = r; Value.y = g; Value.z = b; Value.w = a; }
    // struct ImColor(const struct ImVec4& col)                                      { Value = col; }
    // inline operator ImU32() const                                   { return ImGui::ColorConvertFloat4ToU32(Value); }
    // inline operator struct ImVec4() const                                  { return Value; }    inline void    SetHSV(float h, float s, float v, float a/*=1.0f*/){ ImGui::ColorConvertHSVtoRGB(h, s, v, Value.x, Value.y, Value.z); Value.w = a; }    static struct ImColor HSV(float h, float s, float v, float a/*=1.0f*/)   { float r,g,b; ImGui::ColorConvertHSVtoRGB(h, s, v, r, g, b); return struct ImColor(r,g,b,a); }
};struct ImGuiListClipper
{
    float   ItemsHeight;
    int     ItemsCount, DisplayStart, DisplayEnd; 

};typedef void (*ImDrawCallback)(const struct ImDrawList* parent_list, const struct ImDrawCmd* cmd);
struct ImDrawCmd
{
    unsigned int    ElemCount;              
    struct ImVec4          ClipRect;               
    ImTextureID     TextureId;              
    ImDrawCallback  UserCallback;           
    //void*           UserCallbackData;           struct ImDrawCmd() { ElemCount = 0; ClipRect.x = ClipRect.y = -8192.0f; ClipRect.z = ClipRect.w = +8192.0f; TextureId = 0; UserCallback = 0; UserCallbackData = 0; }
};typedef unsigned short ImDrawIdx;
struct ImDrawVert
{
    struct ImVec2  pos;
    struct ImVec2  uv;
    ImU32   col;
};struct ImDrawChannel
{
    // struct ImVector<struct ImDrawCmd>     CmdBuffer;
    // struct ImVector<ImDrawIdx>     IdxBuffer;
};
struct ImDrawList
{
};
struct ImDrawData
{
    bool            Valid;                  
    struct ImDrawList**    CmdLists;
    int             CmdListsCount;
    int             TotalVtxCount;          
    int             TotalIdxCount;              
    // struct ImDrawData() { Valid = false; CmdLists = 0; CmdListsCount = TotalVtxCount = TotalIdxCount = 0; }
    //  void DeIndexAllBuffers(void);               
    //  void ScaleClipRects(const struct ImVec2& sc);  
};struct ImFontConfig
{
    void*           FontData;                   
    int             FontDataSize;               
    bool            FontDataOwnedByAtlas;       
    int             FontNo;                     
    float           SizePixels;                 
    int             OversampleH, OversampleV;   
    bool            PixelSnapH;                 
    struct ImVec2          GlyphExtraSpacing;          
    const ImWchar*  GlyphRanges;                
    bool            MergeMode;                  
    bool            MergeGlyphCenterV;              
    char            Name[32];                               
    struct ImFont*         DstFont;   
    //  struct ImFontConfig(void);
};struct ImFontAtlas
{
};struct ImFont
{
    
    float                       FontSize;           
    float                       Scale;              
    struct ImVec2                      DisplayOffset;      
    ImWchar                     FallbackChar;       
    struct ImFontConfig*               ConfigData;         
    int                         ConfigDataCount;        
    // struct Glyph
    // {
    //     ImWchar                 Codepoint;
    //     float                   XAdvance;
    //     float                   X0, Y0, X1, Y1;
    //     float                   U0, V0, U1, V1;     
    // };
    float                       Ascent, Descent;    
    struct ImFontAtlas*                ContainerAtlas;     
};
typedef int ImGuiSetCond;
typedef int ImGuiColorEditMode;

extern int igTest(int test1, int test2);
extern struct ImGuiIO*         igGetIO(void);
extern struct ImGuiStyle*      igGetStyle(void);
extern struct ImDrawData*      igGetDrawData(void);
extern void             igNewFrame(void);
extern void             igRender(void);
extern void             igShutdown(void);
extern void             igShowUserGuide(void);
extern void             igShowStyleEditor(struct ImGuiStyle* ref);
extern void             igShowTestWindow(bool* opened);
extern void             igShowMetricsWindow(bool* opened);
extern bool             igBegin(const char* name, bool* p_opened, ImGuiWindowFlags flags);
extern bool             igBegin2(const char* name, bool* p_opened, const struct ImVec2 size_on_first_use, float bg_alpha, ImGuiWindowFlags flags);
extern void             igEnd(void);
extern bool             igBeginChild(const char* str_id, const struct ImVec2 size, bool border, ImGuiWindowFlags extra_flags);
extern bool             igBeginChildEx(ImGuiID id, const struct ImVec2 size, bool border, ImGuiWindowFlags extra_flags);
extern void             igEndChild(void);
extern void             igGetContentRegionMax(struct ImVec2* out);
extern void             igGetContentRegionAvail(struct ImVec2* out);
extern float            igGetContentRegionAvailWidth(void);
extern void             igGetWindowContentRegionMin(struct ImVec2* out);
extern void             igGetWindowContentRegionMax(struct ImVec2* out);
extern float            igGetWindowContentRegionWidth(void);
extern struct ImDrawList*      igGetWindowDrawList(void);
extern struct ImFont*          igGetWindowFont(void);
extern float            igGetWindowFontSize(void); 
extern void             igSetWindowFontScale(float scale);
extern void             igGetWindowPos(struct ImVec2* out);
extern void             igGetWindowSize(struct ImVec2* out);
extern float            igGetWindowWidth(void);
extern float            igGetWindowHeight(void);
extern bool             igIsWindowCollapsed(void);extern void             igSetNextWindowPos(const struct ImVec2 pos, ImGuiSetCond cond);
extern void             igSetNextWindowPosCenter(ImGuiSetCond cond);
extern void             igSetNextWindowSize(const struct ImVec2 size, ImGuiSetCond cond);
extern void             igSetNextWindowContentSize(const struct ImVec2 size);
extern void             igSetNextWindowContentWidth(float width);
extern void             igSetNextWindowCollapsed(bool collapsed, ImGuiSetCond cond);
extern void             igSetNextWindowFocus(void);
extern void             igSetWindowPos(const struct ImVec2 pos, ImGuiSetCond cond);
extern void             igSetWindowSize(const struct ImVec2 size, ImGuiSetCond cond);
extern void             igSetWindowCollapsed(bool collapsed, ImGuiSetCond cond);
extern void             igSetWindowFocus(void);
extern void             igSetWindowPosByName(const char* name, const struct ImVec2 pos, ImGuiSetCond cond);
extern void             igSetWindowSize2(const char* name, const struct ImVec2 size, ImGuiSetCond cond);
extern void             igSetWindowCollapsed2(const char* name, bool collapsed, ImGuiSetCond cond);
extern void             igSetWindowFocus2(const char* name);extern float            igGetScrollX(void);
extern float            igGetScrollY(void);
extern float            igGetScrollMaxX(void);
extern float            igGetScrollMaxY(void);
extern void             igSetScrollX(float scroll_x);
extern void             igSetScrollY(float scroll_y);
extern void             igSetScrollHere(float center_y_ratio);
extern void             igSetScrollFromPosY(float pos_y, float center_y_ratio);
extern void             igSetKeyboardFocusHere(int offset);
extern void             igSetStateStorage(struct ImGuiStorage* tree);
extern struct ImGuiStorage*    igGetStateStorage(void);
extern void             igPushFont(struct ImFont* font);
extern void             igPopFont(void);
extern void             igPushStyleColor(ImGuiCol idx, const struct ImVec4 col);
extern void             igPopStyleColor(int count);
extern void             igPushStyleVar(ImGuiStyleVar idx, float val);
extern void             igPushStyleVarVec(ImGuiStyleVar idx, const struct ImVec2 val);
extern void             igPopStyleVar(int count);
extern ImU32            igGetColorU32(ImGuiCol idx, float alpha_mul);
extern ImU32            igGetColorU32Vec(const struct ImVec4* col);extern void             igPushItemWidth(float item_width);
extern void             igPopItemWidth(void);
extern float            igCalcItemWidth(void);
extern void             igPushTextWrapPos(float wrap_pos_x);
extern void             igPopTextWrapPos(void);
extern void             igPushAllowKeyboardFocus(bool v);
extern void             igPopAllowKeyboardFocus(void);
extern void             igPushButtonRepeat(bool repeat);
extern void             igPopButtonRepeat(void);
extern void             igBeginGroup(void);
extern void             igEndGroup(void);
extern void             igSeparator(void);
extern void             igSameLine(float local_pos_x, float spacing_w);
extern void             igSpacing(void);
extern void             igDummy(const struct ImVec2* size);
extern void             igIndent(void);
extern void             igUnindent(void);
extern void             igColumns(int count, const char* id, bool border);
extern void             igNextColumn(void);
extern int              igGetColumnIndex(void);
extern float            igGetColumnOffset(int column_index);
extern void             igSetColumnOffset(int column_index, float offset_x);
extern float            igGetColumnWidth(int column_index);
extern int              igGetColumnsCount(void);
extern void             igGetCursorPos(struct ImVec2* pOut);
extern float            igGetCursorPosX(void);
extern float            igGetCursorPosY(void);
extern void             igSetCursorPos(const struct ImVec2 local_pos);
extern void             igSetCursorPosX(float x);
extern void             igSetCursorPosY(float y);
extern void             igGetCursorStartPos(struct ImVec2* pOut);
extern void             igGetCursorScreenPos(struct ImVec2* pOut);
extern void             igSetCursorScreenPos(const struct ImVec2 pos);
extern void             igAlignFirstTextHeightToWidgets(void);
extern float            igGetTextLineHeight(void);
extern float            igGetTextLineHeightWithSpacing(void);
extern float            igGetItemsLineHeightWithSpacing(void);
extern void             igPushIdStr(const char* str_id);
extern void             igPushIdStrRange(const char* str_begin, const char* str_end);
extern void             igPushIdPtr(const void* ptr_id);
extern void             igPushIdInt(int int_id);
extern void             igPopId(void);
extern ImGuiID          igGetIdStr(const char* str_id);
extern ImGuiID          igGetIdStrRange(const char* str_begin,const char* str_end);
extern ImGuiID          igGetIdPtr(const void* ptr_id);
extern void             igText(const char* fmt, ...);
extern void             igTextV(const char* fmt, va_list args);
extern void             igTextColored(const struct ImVec4 col, const char* fmt, ...);
extern void             igTextColoredV(const struct ImVec4 col, const char* fmt, va_list args);
extern void             igTextDisabled(const char* fmt, ...);
extern void             igTextDisabledV(const char* fmt, va_list args);
extern void             igTextWrapped(const char* fmt, ...);
extern void             igTextWrappedV(const char* fmt, va_list args);
extern void             igTextUnformatted(const char* text, const char* text_end);
extern void             igLabelText(const char* label, const char* fmt, ...);
extern void             igLabelTextV(const char* label, const char* fmt, va_list args);
extern void             igBullet(void);
extern void             igBulletText(const char* fmt, ...);
extern void             igBulletTextV(const char* fmt, va_list args);
extern bool             igButton(const char* label, const struct ImVec2 size);
extern bool             igSmallButton(const char* label);
extern bool             igInvisibleButton(const char* str_id, const struct ImVec2 size);
extern void             igImage(ImTextureID user_texture_id, const struct ImVec2 size, const struct ImVec2 uv0, const struct ImVec2 uv1, const struct ImVec4 tint_col, const struct ImVec4 border_col);
extern bool             igImageButton(ImTextureID user_texture_id, const struct ImVec2 size, const struct ImVec2 uv0, const struct ImVec2 uv1, int frame_padding, const struct ImVec4 bg_col, const struct ImVec4 tint_col);
extern bool             igCollapsingHeader(const char* label, const char* str_id, bool display_frame, bool default_open);
extern bool             igCheckbox(const char* label, bool* v);
extern bool             igCheckboxFlags(const char* label, unsigned int* flags, unsigned int flags_value);
extern bool             igRadioButtonBool(const char* label, bool active);
extern bool             igRadioButton(const char* label, int* v, int v_button);
extern bool             igCombo(const char* label, int* current_item, const char** items, int items_count, int height_in_items);
extern bool             igCombo2(const char* label, int* current_item, const char* items_separated_by_zeros, int height_in_items);
extern bool             igCombo3(const char* label, int* current_item, bool(*items_getter)(void* data, int idx, const char** out_text), void* data, int items_count, int height_in_items);
extern bool             igColorButton(const struct ImVec4 col, bool small_height, bool outline_border);
extern bool             igColorEdit3(const char* label, float col[]);
extern bool             igColorEdit4(const char* label, float col[], bool show_alpha);
extern void             igColorEditMode(ImGuiColorEditMode mode);
extern void             igPlotLines(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size, int stride);
extern void             igPlotLines2(const char* label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size);
extern void             igPlotHistogram(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size, int stride);
extern void             igPlotHistogram2(const char* label, float(*values_getter)(void* data, int idx), void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, struct ImVec2 graph_size);
extern void             igProgressBar(float fraction, const struct ImVec2* size_arg, const char* overlay);extern bool             igSliderFloat(const char* label, float* v, float v_min, float v_max, const char* display_format, float power);
extern bool             igSliderFloat2(const char* label, float v[], float v_min, float v_max, const char* display_format, float power);
extern bool             igSliderFloat3(const char* label, float v[], float v_min, float v_max, const char* display_format, float power);
extern bool             igSliderFloat4(const char* label, float v[], float v_min, float v_max, const char* display_format, float power);
extern bool             igSliderAngle(const char* label, float* v_rad, float v_degrees_min, float v_degrees_max);
extern bool             igSliderInt(const char* label, int* v, int v_min, int v_max, const char* display_format);
extern bool             igSliderInt2(const char* label, int v[], int v_min, int v_max, const char* display_format);
extern bool             igSliderInt3(const char* label, int v[], int v_min, int v_max, const char* display_format);
extern bool             igSliderInt4(const char* label, int v[], int v_min, int v_max, const char* display_format);
extern bool             igVSliderFloat(const char* label, const struct ImVec2 size, float* v, float v_min, float v_max, const char* display_format, float power);
extern bool             igVSliderInt(const char* label, const struct ImVec2 size, int* v, int v_min, int v_max, const char* display_format);
extern bool             igDragFloat(const char* label, float* v, float v_speed, float v_min, float v_max, const char* display_format, float power);     
extern bool             igDragFloat2(const char* label, float v[], float v_speed, float v_min, float v_max, const char* display_format, float power);
extern bool             igDragFloat3(const char* label, float v[], float v_speed, float v_min, float v_max, const char* display_format, float power);
extern bool             igDragFloat4(const char* label, float v[], float v_speed, float v_min, float v_max, const char* display_format, float power);
extern bool             igDragFloatRange2(const char* label, float* v_current_min, float* v_current_max, float v_speed/*=1.0f*/, float v_min/*=0.0f*/, float v_max/*=0.0f*/, const char* display_format/* = "%.3f"*/, const char* display_format_max /*= 0*/, float power/*=1.0f*/);
extern bool             igDragInt(const char* label, int* v, float v_speed, int v_min, int v_max, const char* display_format);                                       
extern bool             igDragInt2(const char* label, int v[], float v_speed, int v_min, int v_max, const char* display_format);
extern bool             igDragInt3(const char* label, int v[], float v_speed, int v_min, int v_max, const char* display_format);
extern bool             igDragInt4(const char* label, int v[], float v_speed, int v_min, int v_max, const char* display_format);
extern bool             igDragIntRange2(const char* label, int* v_current_min, int* v_current_max, float v_speed/*=1.0f*/, int v_min /*= 0*/, int v_max /*= 0*/, const char* display_format/* = "%.0f"*/, const char* display_format_max/* = 0*/);extern bool             igInputText(const char* label, char* buf, size_t buf_size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
extern bool             igInputTextMultiline(const char* label, char* buf, size_t buf_size, const struct ImVec2 size, ImGuiInputTextFlags flags, ImGuiTextEditCallback callback, void* user_data);
extern bool             igInputFloat(const char* label, float* v, float step, float step_fast, int decimal_precision, ImGuiInputTextFlags extra_flags);
extern bool             igInputFloat2(const char* label, float v[], int decimal_precision, ImGuiInputTextFlags extra_flags);
extern bool             igInputFloat3(const char* label, float v[], int decimal_precision, ImGuiInputTextFlags extra_flags);
extern bool             igInputFloat4(const char* label, float v[], int decimal_precision, ImGuiInputTextFlags extra_flags);
extern bool             igInputInt(const char* label, int* v, int step, int step_fast, ImGuiInputTextFlags extra_flags);
extern bool             igInputInt2(const char* label, int v[], ImGuiInputTextFlags extra_flags);
extern bool             igInputInt3(const char* label, int v[], ImGuiInputTextFlags extra_flags);
extern bool             igInputInt4(const char* label, int v[], ImGuiInputTextFlags extra_flags);
extern bool             igTreeNode(const char* str_label_id);
extern bool             igTreeNodeStr(const char* str_id, const char* fmt, ...);
extern bool             igTreeNodePtr(const void* ptr_id, const char* fmt, ...);
extern bool             igTreeNodeStrV(const char* str_id, const char* fmt, va_list args);
extern bool             igTreeNodePtrV(const void* ptr_id, const char* fmt, va_list args);
extern void             igTreePushStr(const char* str_id);
extern void             igTreePushPtr(const void* ptr_id);
extern void             igTreePop(void);
extern void             igSetNextTreeNodeOpened(bool opened, ImGuiSetCond cond);
extern bool             igSelectable(const char* label, bool selected, ImGuiSelectableFlags flags, const struct ImVec2 size);
extern bool             igSelectableEx(const char* label, bool* p_selected, ImGuiSelectableFlags flags, const struct ImVec2 size);
extern bool             igListBox(const char* label, int* current_item, const char** items, int items_count, int height_in_items);
extern bool             igListBox2(const char* label, int* current_item, bool(*items_getter)(void* data, int idx, const char** out_text), void* data, int items_count, int height_in_items);
extern bool             igListBoxHeader(const char* label, const struct ImVec2 size);
extern bool             igListBoxHeader2(const char* label, int items_count, int height_in_items);
extern void             igListBoxFooter(void);
extern void             igValueBool(const char* prefix, bool b);
extern void             igValueInt(const char* prefix, int v);
extern void             igValueUInt(const char* prefix, unsigned int v);
extern void             igValueFloat(const char* prefix, float v, const char* float_format);
extern void             igValueColor(const char* prefix, const struct ImVec4 v);
extern void             igValueColor2(const char* prefix, unsigned int v);
extern void             igSetTooltip(const char* fmt, ...);
extern void             igSetTooltipV(const char* fmt, va_list args);
extern void             igBeginTooltip(void);
extern void             igEndTooltip(void);
extern bool             igBeginMainMenuBar(void);
extern void             igEndMainMenuBar(void);
extern bool             igBeginMenuBar(void);
extern void             igEndMenuBar(void);
extern bool             igBeginMenu(const char* label, bool enabled);
extern void             igEndMenu(void);
extern bool             igMenuItem(const char* label, const char* shortcut, bool selected, bool enabled);
extern bool             igMenuItemPtr(const char* label, const char* shortcut, bool* p_selected, bool enabled);
extern void             igOpenPopup(const char* str_id);
extern bool             igBeginPopup(const char* str_id);
extern bool             igBeginPopupModal(const char* name, bool* p_opened, ImGuiWindowFlags extra_flags);
extern bool             igBeginPopupContextItem(const char* str_id, int mouse_button);
extern bool             igBeginPopupContextWindow(bool also_over_items, const char* str_id, int mouse_button);
extern bool             igBeginPopupContextVoid(const char* str_id, int mouse_button);
extern void             igEndPopup(void);
extern void             igCloseCurrentPopup(void);
extern void             igLogToTTY(int max_depth);
extern void             igLogToFile(int max_depth, const char* filename);
extern void             igLogToClipboard(int max_depth);
extern void             igLogFinish(void);
extern void             igLogButtons(void);
extern void             igLogText(const char* fmt, ...);
extern bool             igIsItemHovered(void);
extern bool             igIsItemHoveredRect(void);
extern bool             igIsItemActive(void);
extern bool             igIsItemVisible(void);
extern bool             igIsAnyItemHovered(void);
extern bool             igIsAnyItemActive(void);
extern void             igGetItemRectMin(struct ImVec2* pOut);
extern void             igGetItemRectMax(struct ImVec2* pOut);
extern void             igGetItemRectSize(struct ImVec2* pOut);
extern bool             igIsWindowHovered(void);
extern bool             igIsWindowFocused(void);
extern bool             igIsRootWindowFocused(void);
extern bool             igIsRootWindowOrAnyChildFocused(void);
extern bool             igIsRectVisible(const struct ImVec2 item_size);
extern bool             igIsPosHoveringAnyWindow(const struct ImVec2 pos);
extern float            igGetTime(void);
extern int              igGetFrameCount(void);
extern const char*      igGetStyleColName(ImGuiCol idx);
extern void             igCalcItemRectClosestPoint(struct ImVec2* pOut, const struct ImVec2 pos, bool on_edge, float outward);
extern void             igCalcTextSize(struct ImVec2* pOut, const char* text, const char* text_end, bool hide_text_after_double_hash, float wrap_width);
extern void             igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);extern bool             igBeginChildFrame(ImGuiID id, const struct ImVec2 size, ImGuiWindowFlags extra_flags);
extern void             igEndChildFrame(void);extern void             igColorConvertU32ToFloat4(struct ImVec4* pOut, ImU32 in);
extern ImU32            igColorConvertFloat4ToU32(const struct ImVec4 in);
extern void             igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
extern void             igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);extern int              igGetKeyIndex(ImGuiKey key);
extern bool             igIsKeyDown(int key_index);
extern bool             igIsKeyPressed(int key_index, bool repeat);
extern bool             igIsKeyReleased(int key_index);
extern bool             igIsMouseDown(int button);
extern bool             igIsMouseClicked(int button, bool repeat);
extern bool             igIsMouseDoubleClicked(int button);
extern bool             igIsMouseReleased(int button);
extern bool             igIsMouseHoveringWindow(void);
extern bool             igIsMouseHoveringAnyWindow(void);
extern bool             igIsMouseHoveringRect(const struct ImVec2 pos_min, const struct ImVec2 pos_max, bool clip);
extern bool             igIsMouseDragging(int button, float lock_threshold);
extern void             igGetMousePos(struct ImVec2* pOut);
extern void             igGetMousePosOnOpeningCurrentPopup(struct ImVec2* pOut);
extern void             igGetMouseDragDelta(struct ImVec2* pOut, int button, float lock_threshold);
extern void             igResetMouseDragDelta(int button);
extern ImGuiMouseCursor igGetMouseCursor(void);
extern void             igSetMouseCursor(ImGuiMouseCursor type);
extern void             igCaptureKeyboardFromApp(void);
extern void             igCaptureMouseFromApp(void);
extern void*            igMemAlloc(size_t sz);
extern void             igMemFree(void* ptr);
extern const char*      igGetClipboardText(void);
extern void             igSetClipboardText(const char* text);
extern const char*      igGetVersion(void);
extern void*            igGetInternalState(void);
extern size_t           igGetInternalStateSize(void);
extern void             igSetInternalState(void* state, bool construct);
extern void             ImFontAtlas_GetTexDataAsRGBA32(struct ImFontAtlas* atlas, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
extern void             ImFontAtlas_GetTexDataAsAlpha8(struct ImFontAtlas* atlas, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
extern void             ImFontAtlas_SetTexID(struct ImFontAtlas* atlas, void* tex);
extern struct ImFont*             ImFontAtlas_AddFont(struct ImFontAtlas* atlas, const struct ImFontConfig* font_cfg);
extern struct ImFont*             ImFontAtlas_AddFontDefault(struct ImFontAtlas* atlas, const struct ImFontConfig* font_cfg);
extern struct ImFont*             ImFontAtlas_AddFontFromFileTTF(struct ImFontAtlas* atlas, const char* filename, float size_pixels, const struct ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern struct ImFont*             ImFontAtlas_AddFontFromMemoryTTF(struct ImFontAtlas* atlas, void* ttf_data, int ttf_size, float size_pixels, const struct ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern struct ImFont*             ImFontAtlas_AddFontFromMemoryCompressedTTF(struct ImFontAtlas* atlas, const void* compressed_ttf_data, int compressed_ttf_size, float size_pixels, const struct ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern struct ImFont*             ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(struct ImFontAtlas* atlas, const char* compressed_ttf_data_base85, float size_pixels, const struct ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
extern void             ImFontAtlas_ClearTexData(struct ImFontAtlas* atlas);
extern void             ImFontAtlas_Clear(struct ImFontAtlas* atlas);extern void             ImGuiIO_AddInputCharacter(unsigned short c);
extern void             ImGuiIO_AddInputCharactersUTF8(const char* utf8_chars);
extern void             ImGuiIO_ClearInputCharacters(void);
extern void             ImDrawData_DeIndexAllBuffers(struct ImDrawData* drawData);
extern int             ImDrawList_GetVertexBufferSize(struct ImDrawList* list);
extern struct ImDrawVert*      ImDrawList_GetVertexPtr(struct ImDrawList* list, int n);
extern int             ImDrawList_GetIndexBufferSize(struct ImDrawList* list);
extern ImDrawIdx*       ImDrawList_GetIndexPtr(struct ImDrawList* list, int n);
extern int             ImDrawList_GetCmdSize(struct ImDrawList* list);
extern struct ImDrawCmd*       ImDrawList_GetCmdPtr(struct ImDrawList* list, int n);extern void             ImDrawList_Clear(struct ImDrawList* list);
extern void             ImDrawList_ClearFreeMemory(struct ImDrawList* list);
extern void             ImDrawList_PushClipRect(struct ImDrawList* list, const struct ImVec4 clip_rect); 
extern void             ImDrawList_PushClipRectFullScreen(struct ImDrawList* list);
extern void             ImDrawList_PopClipRect(struct ImDrawList* list);
extern void             ImDrawList_PushTextureID(struct ImDrawList* list, const ImTextureID texture_id);
extern void             ImDrawList_PopTextureID(struct ImDrawList* list);
extern void             ImDrawList_AddLine(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col, float thickness);
extern void             ImDrawList_AddRect(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col, float rounding, int rounding_corners);
extern void             ImDrawList_AddRectFilled(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col, float rounding, int rounding_corners);
extern void             ImDrawList_AddRectFilledMultiColor(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col_upr_left, ImU32 col_upr_right, ImU32 col_bot_right, ImU32 col_bot_left);
extern void             ImDrawList_AddTriangleFilled(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, const struct ImVec2 c, ImU32 col);
extern void             ImDrawList_AddCircle(struct ImDrawList* list, const struct ImVec2 centre, float radius, ImU32 col, int num_segments);
extern void             ImDrawList_AddCircleFilled(struct ImDrawList* list, const struct ImVec2 centre, float radius, ImU32 col, int num_segments);
extern void             ImDrawList_AddText(struct ImDrawList* list, const struct ImVec2 pos, ImU32 col, const char* text_begin, const char* text_end);
extern void             ImDrawList_AddTextExt(struct ImDrawList* list, const struct ImFont* font, float font_size, const struct ImVec2 pos, ImU32 col, const char* text_begin, const char* text_end, float wrap_width, const struct ImVec4* cpu_fine_clip_rect);
extern void             ImDrawList_AddImage(struct ImDrawList* list, ImTextureID user_texture_id, const struct ImVec2 a, const struct ImVec2 b, const struct ImVec2 uv0, const struct ImVec2 uv1, ImU32 col);
extern void             ImDrawList_AddPolyline(struct ImDrawList* list, const struct ImVec2* points, const int num_points, ImU32 col, bool closed, float thickness, bool anti_aliased);
extern void             ImDrawList_AddConvexPolyFilled(struct ImDrawList* list, const struct ImVec2* points, const int num_points, ImU32 col, bool anti_aliased);
extern void             ImDrawList_AddBezierCurve(struct ImDrawList* list, const struct ImVec2 pos0, const struct ImVec2 cp0, const struct ImVec2 cp1, const struct ImVec2 pos1, ImU32 col, float thickness, int num_segments);
extern void             ImDrawList_PathClear(struct ImDrawList* list);
extern void             ImDrawList_PathLineTo(struct ImDrawList* list, const struct ImVec2 pos);
extern void             ImDrawList_PathLineToMergeDuplicate(struct ImDrawList* list, const struct ImVec2 pos);
extern void             ImDrawList_PathFill(struct ImDrawList* list, ImU32 col);
extern void             ImDrawList_PathStroke(struct ImDrawList* list, ImU32 col, bool closed, float thickness);
extern void             ImDrawList_PathArcTo(struct ImDrawList* list, const struct ImVec2 centre, float radius, float a_min, float a_max, int num_segments);
extern void             ImDrawList_PathArcToFast(struct ImDrawList* list, const struct ImVec2 centre, float radius, int a_min_of_12, int a_max_of_12); 
extern void             ImDrawList_PathBezierCurveTo(struct ImDrawList* list, const struct ImVec2 p1, const struct ImVec2 p2, const struct ImVec2 p3, int num_segments);
extern void             ImDrawList_PathRect(struct ImDrawList* list, const struct ImVec2 rect_min, const struct ImVec2 rect_max, float rounding, int rounding_corners);
extern void             ImDrawList_ChannelsSplit(struct ImDrawList* list, int channels_count);
extern void             ImDrawList_ChannelsMerge(struct ImDrawList* list);
extern void             ImDrawList_ChannelsSetCurrent(struct ImDrawList* list, int channel_index);
extern void             ImDrawList_AddCallback(struct ImDrawList* list, ImDrawCallback callback, void* callback_data); 
extern void             ImDrawList_AddDrawCmd(struct ImDrawList* list); 
extern void             ImDrawList_PrimReserve(struct ImDrawList* list, int idx_count, int vtx_count);
extern void             ImDrawList_PrimRect(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, ImU32 col);
extern void             ImDrawList_PrimRectUV(struct ImDrawList* list, const struct ImVec2 a, const struct ImVec2 b, const struct ImVec2 uv_a, const struct ImVec2 uv_b, ImU32 col);
extern void             ImDrawList_PrimVtx(struct ImDrawList* list, const struct ImVec2 pos, const struct ImVec2 uv, ImU32 col);
extern void             ImDrawList_PrimWriteVtx(struct ImDrawList* list, const struct ImVec2 pos, const struct ImVec2 uv, ImU32 col);
extern void             ImDrawList_PrimWriteIdx(struct ImDrawList* list, ImDrawIdx idx);
extern void             ImDrawList_UpdateClipRect(struct ImDrawList* list);
extern void             ImDrawList_UpdateTextureID(struct ImDrawList* list);

void (*renderCallback)(void);
extern void setRenderCallback(void(*rc)(void));
extern bool setupAll(void);
extern void mainLoop(void);
extern void destroyAll(void);

