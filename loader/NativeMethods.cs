
/// Return Type: int
///data: ImGuiTextEditCallbackData*
public delegate int ImGuiTextEditCallback(ref ImGuiTextEditCallbackData data);

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImVec2
{

    /// float
    public float x;

    /// float
    public float y;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImVec4
{

    /// float
    public float x;

    /// float
    public float y;

    /// float
    public float z;

    /// float
    public float w;
}

public enum ImGuiWindowFlags_
{

    /// ImGuiWindowFlags_NoTitleBar -> 1<<0
    ImGuiWindowFlags_NoTitleBar = (1) << (0),

    /// ImGuiWindowFlags_NoResize -> 1<<1
    ImGuiWindowFlags_NoResize = (1) << (1),

    /// ImGuiWindowFlags_NoMove -> 1<<2
    ImGuiWindowFlags_NoMove = (1) << (2),

    /// ImGuiWindowFlags_NoScrollbar -> 1<<3
    ImGuiWindowFlags_NoScrollbar = (1) << (3),

    /// ImGuiWindowFlags_NoScrollWithMouse -> 1<<4
    ImGuiWindowFlags_NoScrollWithMouse = (1) << (4),

    /// ImGuiWindowFlags_NoCollapse -> 1<<5
    ImGuiWindowFlags_NoCollapse = (1) << (5),

    /// ImGuiWindowFlags_AlwaysAutoResize -> 1<<6
    ImGuiWindowFlags_AlwaysAutoResize = (1) << (6),

    /// ImGuiWindowFlags_ShowBorders -> 1<<7
    ImGuiWindowFlags_ShowBorders = (1) << (7),

    /// ImGuiWindowFlags_NoSavedSettings -> 1<<8
    ImGuiWindowFlags_NoSavedSettings = (1) << (8),

    /// ImGuiWindowFlags_NoInputs -> 1<<9
    ImGuiWindowFlags_NoInputs = (1) << (9),

    /// ImGuiWindowFlags_MenuBar -> 1<<10
    ImGuiWindowFlags_MenuBar = (1) << (10),

    /// ImGuiWindowFlags_HorizontalScrollbar -> 1<<11
    ImGuiWindowFlags_HorizontalScrollbar = (1) << (11),

    /// ImGuiWindowFlags_NoFocusOnAppearing -> 1<<12
    ImGuiWindowFlags_NoFocusOnAppearing = (1) << (12),

    /// ImGuiWindowFlags_NoBringToFrontOnFocus -> 1<<13
    ImGuiWindowFlags_NoBringToFrontOnFocus = (1) << (13),

    /// ImGuiWindowFlags_ChildWindow -> 1<<20
    ImGuiWindowFlags_ChildWindow = (1) << (20),

    /// ImGuiWindowFlags_ChildWindowAutoFitX -> 1<<21
    ImGuiWindowFlags_ChildWindowAutoFitX = (1) << (21),

    /// ImGuiWindowFlags_ChildWindowAutoFitY -> 1<<22
    ImGuiWindowFlags_ChildWindowAutoFitY = (1) << (22),

    /// ImGuiWindowFlags_ComboBox -> 1<<23
    ImGuiWindowFlags_ComboBox = (1) << (23),

    /// ImGuiWindowFlags_Tooltip -> 1<<24
    ImGuiWindowFlags_Tooltip = (1) << (24),

    /// ImGuiWindowFlags_Popup -> 1<<25
    ImGuiWindowFlags_Popup = (1) << (25),

    /// ImGuiWindowFlags_Modal -> 1<<26
    ImGuiWindowFlags_Modal = (1) << (26),

    /// ImGuiWindowFlags_ChildMenu -> 1<<27
    ImGuiWindowFlags_ChildMenu = (1) << (27),
}

public enum ImGuiInputTextFlags_
{

    /// ImGuiInputTextFlags_CharsDecimal -> 1<<0
    ImGuiInputTextFlags_CharsDecimal = (1) << (0),

    /// ImGuiInputTextFlags_CharsHexadecimal -> 1<<1
    ImGuiInputTextFlags_CharsHexadecimal = (1) << (1),

    /// ImGuiInputTextFlags_CharsUppercase -> 1<<2
    ImGuiInputTextFlags_CharsUppercase = (1) << (2),

    /// ImGuiInputTextFlags_CharsNoBlank -> 1<<3
    ImGuiInputTextFlags_CharsNoBlank = (1) << (3),

    /// ImGuiInputTextFlags_AutoSelectAll -> 1<<4
    ImGuiInputTextFlags_AutoSelectAll = (1) << (4),

    /// ImGuiInputTextFlags_EnterReturnsTrue -> 1<<5
    ImGuiInputTextFlags_EnterReturnsTrue = (1) << (5),

    /// ImGuiInputTextFlags_CallbackCompletion -> 1<<6
    ImGuiInputTextFlags_CallbackCompletion = (1) << (6),

    /// ImGuiInputTextFlags_CallbackHistory -> 1<<7
    ImGuiInputTextFlags_CallbackHistory = (1) << (7),

    /// ImGuiInputTextFlags_CallbackAlways -> 1<<8
    ImGuiInputTextFlags_CallbackAlways = (1) << (8),

    /// ImGuiInputTextFlags_CallbackCharFilter -> 1<<9
    ImGuiInputTextFlags_CallbackCharFilter = (1) << (9),

    /// ImGuiInputTextFlags_AllowTabInput -> 1<<10
    ImGuiInputTextFlags_AllowTabInput = (1) << (10),

    /// ImGuiInputTextFlags_CtrlEnterForNewLine -> 1<<11
    ImGuiInputTextFlags_CtrlEnterForNewLine = (1) << (11),

    /// ImGuiInputTextFlags_NoHorizontalScroll -> 1<<12
    ImGuiInputTextFlags_NoHorizontalScroll = (1) << (12),

    /// ImGuiInputTextFlags_AlwaysInsertMode -> 1<<13
    ImGuiInputTextFlags_AlwaysInsertMode = (1) << (13),

    /// ImGuiInputTextFlags_ReadOnly -> 1<<14
    ImGuiInputTextFlags_ReadOnly = (1) << (14),

    /// ImGuiInputTextFlags_Password -> 1<<15
    ImGuiInputTextFlags_Password = (1) << (15),

    /// ImGuiInputTextFlags_Multiline -> 1<<20
    ImGuiInputTextFlags_Multiline = (1) << (20),
}

public enum ImGuiSelectableFlags_
{

    /// ImGuiSelectableFlags_DontClosePopups -> 1<<0
    ImGuiSelectableFlags_DontClosePopups = (1) << (0),

    /// ImGuiSelectableFlags_SpanAllColumns -> 1<<1
    ImGuiSelectableFlags_SpanAllColumns = (1) << (1),
}

public enum ImGuiKey_
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

    ImGuiKey_COUNT,
}

public enum ImGuiCol_
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

    ImGuiCol_COUNT,
}

public enum ImGuiStyleVar_
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

    ImGuiStyleVar_GrabMinSize,
}

public enum ImGuiAlign_
{

    /// ImGuiAlign_Left -> 1<<0
    ImGuiAlign_Left = (1) << (0),

    /// ImGuiAlign_Center -> 1<<1
    ImGuiAlign_Center = (1) << (1),

    /// ImGuiAlign_Right -> 1<<2
    ImGuiAlign_Right = (1) << (2),

    /// ImGuiAlign_Top -> 1<<3
    ImGuiAlign_Top = (1) << (3),

    /// ImGuiAlign_VCenter -> 1<<4
    ImGuiAlign_VCenter = (1) << (4),

    /// ImGuiAlign_Default -> ImGuiAlign_Left|ImGuiAlign_Top
    ImGuiAlign_Default = (ImGuiAlign_.ImGuiAlign_Left | ImGuiAlign_.ImGuiAlign_Top),
}

public enum ImGuiColorEditMode_
{

    /// ImGuiColorEditMode_UserSelect -> -2
    ImGuiColorEditMode_UserSelect = -2,

    /// ImGuiColorEditMode_UserSelectShowButton -> -1
    ImGuiColorEditMode_UserSelectShowButton = -1,

    /// ImGuiColorEditMode_RGB -> 0
    ImGuiColorEditMode_RGB = 0,

    /// ImGuiColorEditMode_HSV -> 1
    ImGuiColorEditMode_HSV = 1,

    /// ImGuiColorEditMode_HEX -> 2
    ImGuiColorEditMode_HEX = 2,
}

public enum ImGuiMouseCursor_
{

    /// ImGuiMouseCursor_Arrow -> 0
    ImGuiMouseCursor_Arrow = 0,

    ImGuiMouseCursor_TextInput,

    ImGuiMouseCursor_Move,

    ImGuiMouseCursor_ResizeNS,

    ImGuiMouseCursor_ResizeEW,

    ImGuiMouseCursor_ResizeNESW,

    ImGuiMouseCursor_ResizeNWSE,

    ImGuiMouseCursor_Count_,
}

public enum ImGuiSetCond_
{

    /// ImGuiSetCond_Always -> 1<<0
    ImGuiSetCond_Always = (1) << (0),

    /// ImGuiSetCond_Once -> 1<<1
    ImGuiSetCond_Once = (1) << (1),

    /// ImGuiSetCond_FirstUseEver -> 1<<2
    ImGuiSetCond_FirstUseEver = (1) << (2),

    /// ImGuiSetCond_Appearing -> 1<<3
    ImGuiSetCond_Appearing = (1) << (3),
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiStyle
{

    /// float
    public float Alpha;

    /// ImVec2
    public ImVec2 WindowPadding;

    /// ImVec2
    public ImVec2 WindowMinSize;

    /// float
    public float WindowRounding;

    /// ImGuiAlign->int
    public int WindowTitleAlign;

    /// float
    public float ChildWindowRounding;

    /// ImVec2
    public ImVec2 FramePadding;

    /// float
    public float FrameRounding;

    /// ImVec2
    public ImVec2 ItemSpacing;

    /// ImVec2
    public ImVec2 ItemInnerSpacing;

    /// ImVec2
    public ImVec2 TouchExtraPadding;

    /// float
    public float WindowFillAlphaDefault;

    /// float
    public float IndentSpacing;

    /// float
    public float ColumnsMinSpacing;

    /// float
    public float ScrollbarSize;

    /// float
    public float ScrollbarRounding;

    /// float
    public float GrabMinSize;

    /// float
    public float GrabRounding;

    /// ImVec2
    public ImVec2 DisplayWindowPadding;

    /// ImVec2
    public ImVec2 DisplaySafeAreaPadding;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool AntiAliasedLines;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool AntiAliasedShapes;

    /// float
    public float CurveTessellationTol;

    /// ImVec4[]
    public ImVec4[] Colors;
}

/// Return Type: void
///data: ImDrawData*
public delegate void ImGuiIO_RenderDrawListsFn(ref ImDrawData data);

/// Return Type: char*
public delegate System.IntPtr ImGuiIO_GetClipboardTextFn();

/// Return Type: void
///text: char*
public delegate void ImGuiIO_SetClipboardTextFn([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text);

/// Return Type: void*
///sz: size_t->unsigned int
public delegate System.IntPtr ImGuiIO_MemAllocFn(System.IntPtr sz);

/// Return Type: void
///ptr: void*
public delegate void ImGuiIO_MemFreeFn(System.IntPtr ptr);

/// Return Type: void
///x: int
///y: int
public delegate void ImGuiIO_ImeSetInputScreenPosFn(int x, int y);

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiIO
{

    /// ImVec2
    public ImVec2 DisplaySize;

    /// float
    public float DeltaTime;

    /// float
    public float IniSavingRate;

    /// char*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string IniFilename;

    /// char*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string LogFilename;

    /// float
    public float MouseDoubleClickTime;

    /// float
    public float MouseDoubleClickMaxDist;

    /// float
    public float MouseDragThreshold;

    /// int[]
    public int[] KeyMap;

    /// float
    public float KeyRepeatDelay;

    /// float
    public float KeyRepeatRate;

    /// void*
    public System.IntPtr UserData;

    /// ImFontAtlas*
    public System.IntPtr Fonts;

    /// float
    public float FontGlobalScale;

    /// boolean
    public bool FontAllowUserScaling;

    /// ImVec2
    public ImVec2 DisplayFramebufferScale;

    /// ImVec2
    public ImVec2 DisplayVisibleMin;

    /// ImVec2
    public ImVec2 DisplayVisibleMax;

    /// ImGuiIO_RenderDrawListsFn
    public ImGuiIO_RenderDrawListsFn AnonymousMember1;

    /// ImGuiIO_GetClipboardTextFn
    public ImGuiIO_GetClipboardTextFn AnonymousMember2;

    /// ImGuiIO_SetClipboardTextFn
    public ImGuiIO_SetClipboardTextFn AnonymousMember3;

    /// ImGuiIO_MemAllocFn
    public ImGuiIO_MemAllocFn AnonymousMember4;

    /// ImGuiIO_MemFreeFn
    public ImGuiIO_MemFreeFn AnonymousMember5;

    /// ImGuiIO_ImeSetInputScreenPosFn
    public ImGuiIO_ImeSetInputScreenPosFn AnonymousMember6;

    /// void*
    public System.IntPtr ImeWindowHandle;

    /// ImVec2
    public ImVec2 MousePos;

    /// boolean[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Bool)]
    public bool[] MouseDown;

    /// float
    public float MouseWheel;

    /// boolean
    public bool MouseDrawCursor;

    /// boolean
    public bool KeyCtrl;

    /// boolean
    public bool KeyShift;

    /// boolean
    public bool KeyAlt;

    /// boolean[512]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Bool)]
    public bool[] KeysDown;

    /// ImWchar[17]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 17, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U2)]
    public ushort[] InputCharacters;

    /// boolean
    public bool WantCaptureMouse;

    /// boolean
    public bool WantCaptureKeyboard;

    /// boolean
    public bool WantTextInput;

    /// float
    public float Framerate;

    /// int
    public int MetricsAllocs;

    /// int
    public int MetricsRenderVertices;

    /// int
    public int MetricsRenderIndices;

    /// int
    public int MetricsActiveWindows;

    /// ImVec2
    public ImVec2 MousePosPrev;

    /// ImVec2
    public ImVec2 MouseDelta;

    /// boolean[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Bool)]
    public bool[] MouseClicked;

    /// ImVec2[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Struct)]
    public ImVec2[] MouseClickedPos;

    /// float[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.R4)]
    public float[] MouseClickedTime;

    /// boolean[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Bool)]
    public bool[] MouseDoubleClicked;

    /// boolean[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Bool)]
    public bool[] MouseReleased;

    /// boolean[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.Bool)]
    public bool[] MouseDownOwned;

    /// float[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.R4)]
    public float[] MouseDownDuration;

    /// float[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.R4)]
    public float[] MouseDownDurationPrev;

    /// float[5]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = System.Runtime.InteropServices.UnmanagedType.R4)]
    public float[] MouseDragMaxDistanceSqr;

    /// float[512]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = System.Runtime.InteropServices.UnmanagedType.R4)]
    public float[] KeysDownDuration;

    /// float[512]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = System.Runtime.InteropServices.UnmanagedType.R4)]
    public float[] KeysDownDurationPrev;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiOnceUponAFrame
{

    /// int
    public int RefFrame;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiTextFilter
{
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiTextBuffer
{
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiStorage
{
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiTextEditCallbackData
{

    /// ImGuiInputTextFlags->int
    public int EventFlag;

    /// ImGuiInputTextFlags->int
    public int Flags;

    /// void*
    public System.IntPtr UserData;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool ReadOnly;

    /// ImWchar->unsigned short
    public ushort EventChar;

    /// ImGuiKey->int
    public int EventKey;

    /// char*
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
    public string Buf;

    /// int
    public int BufSize;

    /// boolean
    public bool BufDirty;

    /// int
    public int CursorPos;

    /// int
    public int SelectionStart;

    /// int
    public int SelectionEnd;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImColor
{

    /// ImVec4
    public ImVec4 Value;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImGuiListClipper
{

    /// float
    public float ItemsHeight;

    /// int
    public int ItemsCount;

    /// int
    public int DisplayStart;

    /// int
    public int DisplayEnd;
}

/// Return Type: void
///parent_list: ImDrawList*
///cmd: ImDrawCmd*
public delegate void ImDrawCallback(ref ImDrawList parent_list, ref ImDrawCmd cmd);

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImDrawCmd
{

    /// unsigned int
    public uint ElemCount;

    /// ImVec4
    public ImVec4 ClipRect;

    /// ImTextureID->void*
    public System.IntPtr TextureId;

    /// ImDrawCallback
    public ImDrawCallback UserCallback;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImDrawVert
{

    /// ImVec2
    public ImVec2 pos;

    /// ImVec2
    public ImVec2 uv;

    /// ImU32->unsigned int
    public uint col;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImDrawChannel
{
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImDrawList
{
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImDrawData
{

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool Valid;

    /// ImDrawList**
    public System.IntPtr CmdLists;

    /// int
    public int CmdListsCount;

    /// int
    public int TotalVtxCount;

    /// int
    public int TotalIdxCount;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
public struct ImFontConfig
{

    /// void*
    public System.IntPtr FontData;

    /// int
    public int FontDataSize;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool FontDataOwnedByAtlas;

    /// int
    public int FontNo;

    /// float
    public float SizePixels;

    /// int
    public int OversampleH;

    /// int
    public int OversampleV;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool PixelSnapH;

    /// ImVec2
    public ImVec2 GlyphExtraSpacing;

    /// ImWchar*
    public System.IntPtr GlyphRanges;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool MergeMode;

    /// boolean
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public bool MergeGlyphCenterV;

    /// char[32]
    [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
    public string Name;

    /// ImFont*
    public System.IntPtr DstFont;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImFontAtlas
{
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImFont_Glyph
{

    /// ImWchar->unsigned short
    public ushort Codepoint;

    /// float
    public float XAdvance;

    /// float
    public float X0;

    /// float
    public float Y0;

    /// float
    public float X1;

    /// float
    public float Y1;

    /// float
    public float U0;

    /// float
    public float V0;

    /// float
    public float U1;

    /// float
    public float V1;
}

[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
public struct ImFont
{

    /// float
    public float FontSize;

    /// float
    public float Scale;

    /// ImVec2
    public ImVec2 DisplayOffset;

    /// ImWchar->unsigned short
    public ushort FallbackChar;

    /// ImFontConfig*
    public System.IntPtr ConfigData;

    /// int
    public int ConfigDataCount;

    /// ImFont_Glyph
    public ImFont_Glyph Struct1;

    /// float
    public float Ascent;

    /// float
    public float Descent;

    /// ImFontAtlas*
    public System.IntPtr ContainerAtlas;
}

/// Return Type: boolean
///data: void*
///idx: int
///out_text: char**
public delegate bool Anonymous_a62b41d2_9218_42b9_96f8_135684c2a07b(System.IntPtr data, int idx, ref System.IntPtr out_text);

/// Return Type: float
///data: void*
///idx: int
public delegate float Anonymous_1e0f9ba8_3416_456e_8461_16596ed51c9b(System.IntPtr data, int idx);

/// Return Type: float
///data: void*
///idx: int
public delegate float Anonymous_6f11d397_491b_4862_b0a6_3c73b2e84040(System.IntPtr data, int idx);

/// Return Type: boolean
///data: void*
///idx: int
///out_text: char**
public delegate bool Anonymous_e024a44b_f599_4138_b005_186f87f12bb5(System.IntPtr data, int idx, ref System.IntPtr out_text);

public partial class NativeMethods
{

    /// Return Type: int
    ///test1: int
    ///test2: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTest")]
    public static extern int igTest(int test1, int test2);


    /// Return Type: ImGuiIO*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetIO")]
    public static extern System.IntPtr igGetIO();


    /// Return Type: ImGuiStyle*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetStyle")]
    public static extern System.IntPtr igGetStyle();


    /// Return Type: ImDrawData*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetDrawData")]
    public static extern System.IntPtr igGetDrawData();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igNewFrame")]
    public static extern void igNewFrame();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igRender")]
    public static extern void igRender();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igShutdown")]
    public static extern void igShutdown();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igShowUserGuide")]
    public static extern void igShowUserGuide();


    /// Return Type: void
    ///ref: ImGuiStyle*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igShowStyleEditor")]
    public static extern void igShowStyleEditor(ref ImGuiStyle @ref);


    /// Return Type: void
    ///opened: boolean*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igShowTestWindow")]
    public static extern void igShowTestWindow(ref bool opened);


    /// Return Type: void
    ///opened: boolean*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igShowMetricsWindow")]
    public static extern void igShowMetricsWindow(ref bool opened);


    /// Return Type: boolean
    ///name: char*
    ///p_opened: boolean*
    ///flags: ImGuiWindowFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBegin")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBegin([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, ref bool p_opened, int flags);


    /// Return Type: boolean
    ///name: char*
    ///p_opened: boolean*
    ///size_on_first_use: ImVec2
    ///bg_alpha: float
    ///flags: ImGuiWindowFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBegin2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBegin2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, ref bool p_opened, ImVec2 size_on_first_use, float bg_alpha, int flags);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEnd")]
    public static extern void igEnd();


    /// Return Type: boolean
    ///str_id: char*
    ///size: ImVec2
    ///border: boolean
    ///extra_flags: ImGuiWindowFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginChild")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginChild([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, ImVec2 size, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool border, int extra_flags);


    /// Return Type: boolean
    ///id: ImGuiID->ImU32->unsigned int
    ///size: ImVec2
    ///border: boolean
    ///extra_flags: ImGuiWindowFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginChildEx")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginChildEx(uint id, ImVec2 size, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool border, int extra_flags);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndChild")]
    public static extern void igEndChild();


    /// Return Type: void
    ///out: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetContentRegionMax")]
    public static extern void igGetContentRegionMax(ref ImVec2 @out);


    /// Return Type: void
    ///out: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetContentRegionAvail")]
    public static extern void igGetContentRegionAvail(ref ImVec2 @out);


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetContentRegionAvailWidth")]
    public static extern float igGetContentRegionAvailWidth();


    /// Return Type: void
    ///out: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowContentRegionMin")]
    public static extern void igGetWindowContentRegionMin(ref ImVec2 @out);


    /// Return Type: void
    ///out: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowContentRegionMax")]
    public static extern void igGetWindowContentRegionMax(ref ImVec2 @out);


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowContentRegionWidth")]
    public static extern float igGetWindowContentRegionWidth();


    /// Return Type: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowDrawList")]
    public static extern System.IntPtr igGetWindowDrawList();


    /// Return Type: ImFont*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowFont")]
    public static extern System.IntPtr igGetWindowFont();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowFontSize")]
    public static extern float igGetWindowFontSize();


    /// Return Type: void
    ///scale: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowFontScale")]
    public static extern void igSetWindowFontScale(float scale);


    /// Return Type: void
    ///out: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowPos")]
    public static extern void igGetWindowPos(ref ImVec2 @out);


    /// Return Type: void
    ///out: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowSize")]
    public static extern void igGetWindowSize(ref ImVec2 @out);


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowWidth")]
    public static extern float igGetWindowWidth();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetWindowHeight")]
    public static extern float igGetWindowHeight();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsWindowCollapsed")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsWindowCollapsed();


    /// Return Type: void
    ///pos: ImVec2
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowPos")]
    public static extern void igSetNextWindowPos(ImVec2 pos, int cond);


    /// Return Type: void
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowPosCenter")]
    public static extern void igSetNextWindowPosCenter(int cond);


    /// Return Type: void
    ///size: ImVec2
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowSize")]
    public static extern void igSetNextWindowSize(ImVec2 size, int cond);


    /// Return Type: void
    ///size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowContentSize")]
    public static extern void igSetNextWindowContentSize(ImVec2 size);


    /// Return Type: void
    ///width: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowContentWidth")]
    public static extern void igSetNextWindowContentWidth(float width);


    /// Return Type: void
    ///collapsed: boolean
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowCollapsed")]
    public static extern void igSetNextWindowCollapsed([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool collapsed, int cond);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextWindowFocus")]
    public static extern void igSetNextWindowFocus();


    /// Return Type: void
    ///pos: ImVec2
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowPos")]
    public static extern void igSetWindowPos(ImVec2 pos, int cond);


    /// Return Type: void
    ///size: ImVec2
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowSize")]
    public static extern void igSetWindowSize(ImVec2 size, int cond);


    /// Return Type: void
    ///collapsed: boolean
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowCollapsed")]
    public static extern void igSetWindowCollapsed([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool collapsed, int cond);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowFocus")]
    public static extern void igSetWindowFocus();


    /// Return Type: void
    ///name: char*
    ///pos: ImVec2
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowPosByName")]
    public static extern void igSetWindowPosByName([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, ImVec2 pos, int cond);


    /// Return Type: void
    ///name: char*
    ///size: ImVec2
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowSize2")]
    public static extern void igSetWindowSize2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, ImVec2 size, int cond);


    /// Return Type: void
    ///name: char*
    ///collapsed: boolean
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowCollapsed2")]
    public static extern void igSetWindowCollapsed2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool collapsed, int cond);


    /// Return Type: void
    ///name: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetWindowFocus2")]
    public static extern void igSetWindowFocus2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name);


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetScrollX")]
    public static extern float igGetScrollX();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetScrollY")]
    public static extern float igGetScrollY();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetScrollMaxX")]
    public static extern float igGetScrollMaxX();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetScrollMaxY")]
    public static extern float igGetScrollMaxY();


    /// Return Type: void
    ///scroll_x: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetScrollX")]
    public static extern void igSetScrollX(float scroll_x);


    /// Return Type: void
    ///scroll_y: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetScrollY")]
    public static extern void igSetScrollY(float scroll_y);


    /// Return Type: void
    ///center_y_ratio: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetScrollHere")]
    public static extern void igSetScrollHere(float center_y_ratio);


    /// Return Type: void
    ///pos_y: float
    ///center_y_ratio: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetScrollFromPosY")]
    public static extern void igSetScrollFromPosY(float pos_y, float center_y_ratio);


    /// Return Type: void
    ///offset: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetKeyboardFocusHere")]
    public static extern void igSetKeyboardFocusHere(int offset);


    /// Return Type: void
    ///tree: ImGuiStorage*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetStateStorage")]
    public static extern void igSetStateStorage(ref ImGuiStorage tree);


    /// Return Type: ImGuiStorage*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetStateStorage")]
    public static extern System.IntPtr igGetStateStorage();


    /// Return Type: void
    ///font: ImFont*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushFont")]
    public static extern void igPushFont(ref ImFont font);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopFont")]
    public static extern void igPopFont();


    /// Return Type: void
    ///idx: ImGuiCol->int
    ///col: ImVec4
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushStyleColor")]
    public static extern void igPushStyleColor(int idx, ImVec4 col);


    /// Return Type: void
    ///count: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopStyleColor")]
    public static extern void igPopStyleColor(int count);


    /// Return Type: void
    ///idx: ImGuiStyleVar->int
    ///val: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushStyleVar")]
    public static extern void igPushStyleVar(int idx, float val);


    /// Return Type: void
    ///idx: ImGuiStyleVar->int
    ///val: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushStyleVarVec")]
    public static extern void igPushStyleVarVec(int idx, ImVec2 val);


    /// Return Type: void
    ///count: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopStyleVar")]
    public static extern void igPopStyleVar(int count);


    /// Return Type: ImU32->unsigned int
    ///idx: ImGuiCol->int
    ///alpha_mul: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetColorU32")]
    public static extern uint igGetColorU32(int idx, float alpha_mul);


    /// Return Type: ImU32->unsigned int
    ///col: ImVec4*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetColorU32Vec")]
    public static extern uint igGetColorU32Vec(ref ImVec4 col);


    /// Return Type: void
    ///item_width: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushItemWidth")]
    public static extern void igPushItemWidth(float item_width);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopItemWidth")]
    public static extern void igPopItemWidth();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCalcItemWidth")]
    public static extern float igCalcItemWidth();


    /// Return Type: void
    ///wrap_pos_x: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushTextWrapPos")]
    public static extern void igPushTextWrapPos(float wrap_pos_x);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopTextWrapPos")]
    public static extern void igPopTextWrapPos();


    /// Return Type: void
    ///v: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushAllowKeyboardFocus")]
    public static extern void igPushAllowKeyboardFocus([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool v);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopAllowKeyboardFocus")]
    public static extern void igPopAllowKeyboardFocus();


    /// Return Type: void
    ///repeat: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushButtonRepeat")]
    public static extern void igPushButtonRepeat([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool repeat);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopButtonRepeat")]
    public static extern void igPopButtonRepeat();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginGroup")]
    public static extern void igBeginGroup();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndGroup")]
    public static extern void igEndGroup();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSeparator")]
    public static extern void igSeparator();


    /// Return Type: void
    ///local_pos_x: float
    ///spacing_w: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSameLine")]
    public static extern void igSameLine(float local_pos_x, float spacing_w);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSpacing")]
    public static extern void igSpacing();


    /// Return Type: void
    ///size: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDummy")]
    public static extern void igDummy(ref ImVec2 size);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIndent")]
    public static extern void igIndent();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igUnindent")]
    public static extern void igUnindent();


    /// Return Type: void
    ///count: int
    ///id: char*
    ///border: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColumns")]
    public static extern void igColumns(int count, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string id, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool border);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igNextColumn")]
    public static extern void igNextColumn();


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetColumnIndex")]
    public static extern int igGetColumnIndex();


    /// Return Type: float
    ///column_index: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetColumnOffset")]
    public static extern float igGetColumnOffset(int column_index);


    /// Return Type: void
    ///column_index: int
    ///offset_x: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetColumnOffset")]
    public static extern void igSetColumnOffset(int column_index, float offset_x);


    /// Return Type: float
    ///column_index: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetColumnWidth")]
    public static extern float igGetColumnWidth(int column_index);


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetColumnsCount")]
    public static extern int igGetColumnsCount();


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetCursorPos")]
    public static extern void igGetCursorPos(ref ImVec2 pOut);


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetCursorPosX")]
    public static extern float igGetCursorPosX();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetCursorPosY")]
    public static extern float igGetCursorPosY();


    /// Return Type: void
    ///local_pos: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetCursorPos")]
    public static extern void igSetCursorPos(ImVec2 local_pos);


    /// Return Type: void
    ///x: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetCursorPosX")]
    public static extern void igSetCursorPosX(float x);


    /// Return Type: void
    ///y: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetCursorPosY")]
    public static extern void igSetCursorPosY(float y);


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetCursorStartPos")]
    public static extern void igGetCursorStartPos(ref ImVec2 pOut);


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetCursorScreenPos")]
    public static extern void igGetCursorScreenPos(ref ImVec2 pOut);


    /// Return Type: void
    ///pos: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetCursorScreenPos")]
    public static extern void igSetCursorScreenPos(ImVec2 pos);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igAlignFirstTextHeightToWidgets")]
    public static extern void igAlignFirstTextHeightToWidgets();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetTextLineHeight")]
    public static extern float igGetTextLineHeight();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetTextLineHeightWithSpacing")]
    public static extern float igGetTextLineHeightWithSpacing();


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetItemsLineHeightWithSpacing")]
    public static extern float igGetItemsLineHeightWithSpacing();


    /// Return Type: void
    ///str_id: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushIdStr")]
    public static extern void igPushIdStr([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id);


    /// Return Type: void
    ///str_begin: char*
    ///str_end: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushIdStrRange")]
    public static extern void igPushIdStrRange([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_begin, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_end);


    /// Return Type: void
    ///ptr_id: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushIdPtr")]
    public static extern void igPushIdPtr(System.IntPtr ptr_id);


    /// Return Type: void
    ///int_id: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPushIdInt")]
    public static extern void igPushIdInt(int int_id);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPopId")]
    public static extern void igPopId();


    /// Return Type: ImGuiID->ImU32->unsigned int
    ///str_id: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetIdStr")]
    public static extern uint igGetIdStr([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id);


    /// Return Type: ImGuiID->ImU32->unsigned int
    ///str_begin: char*
    ///str_end: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetIdStrRange")]
    public static extern uint igGetIdStrRange([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_begin, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_end);


    /// Return Type: ImGuiID->ImU32->unsigned int
    ///ptr_id: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetIdPtr")]
    public static extern uint igGetIdPtr(System.IntPtr ptr_id);


    /// Return Type: void
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTextV")]
    public static extern void igTextV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    ///col: ImVec4
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTextColoredV")]
    public static extern void igTextColoredV(ImVec4 col, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTextDisabledV")]
    public static extern void igTextDisabledV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTextWrappedV")]
    public static extern void igTextWrappedV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    ///text: char*
    ///text_end: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTextUnformatted")]
    public static extern void igTextUnformatted([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text_end);


    /// Return Type: void
    ///label: char*
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igLabelTextV")]
    public static extern void igLabelTextV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBullet")]
    public static extern void igBullet();


    /// Return Type: void
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBulletTextV")]
    public static extern void igBulletTextV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: boolean
    ///label: char*
    ///size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igButton")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igButton([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ImVec2 size);


    /// Return Type: boolean
    ///label: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSmallButton")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSmallButton([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label);


    /// Return Type: boolean
    ///str_id: char*
    ///size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInvisibleButton")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInvisibleButton([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, ImVec2 size);


    /// Return Type: void
    ///user_texture_id: ImTextureID->void*
    ///size: ImVec2
    ///uv0: ImVec2
    ///uv1: ImVec2
    ///tint_col: ImVec4
    ///border_col: ImVec4
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igImage")]
    public static extern void igImage(System.IntPtr user_texture_id, ImVec2 size, ImVec2 uv0, ImVec2 uv1, ImVec4 tint_col, ImVec4 border_col);


    /// Return Type: boolean
    ///user_texture_id: ImTextureID->void*
    ///size: ImVec2
    ///uv0: ImVec2
    ///uv1: ImVec2
    ///frame_padding: int
    ///bg_col: ImVec4
    ///tint_col: ImVec4
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igImageButton")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igImageButton(System.IntPtr user_texture_id, ImVec2 size, ImVec2 uv0, ImVec2 uv1, int frame_padding, ImVec4 bg_col, ImVec4 tint_col);


    /// Return Type: boolean
    ///label: char*
    ///str_id: char*
    ///display_frame: boolean
    ///default_open: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCollapsingHeader")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igCollapsingHeader([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool display_frame, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool default_open);


    /// Return Type: boolean
    ///label: char*
    ///v: boolean*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCheckbox")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igCheckbox([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref bool v);


    /// Return Type: boolean
    ///label: char*
    ///flags: unsigned int*
    ///flags_value: unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCheckboxFlags")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igCheckboxFlags([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref uint flags, uint flags_value);


    /// Return Type: boolean
    ///label: char*
    ///active: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igRadioButtonBool")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igRadioButtonBool([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool active);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igRadioButton")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igRadioButton([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int v_button);


    /// Return Type: boolean
    ///label: char*
    ///current_item: int*
    ///items: char**
    ///items_count: int
    ///height_in_items: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCombo")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igCombo([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int current_item, ref System.IntPtr items, int items_count, int height_in_items);


    /// Return Type: boolean
    ///label: char*
    ///current_item: int*
    ///items_separated_by_zeros: char*
    ///height_in_items: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCombo2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igCombo2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int current_item, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string items_separated_by_zeros, int height_in_items);


    /// Return Type: boolean
    ///label: char*
    ///current_item: int*
    ///items_getter: Anonymous_a62b41d2_9218_42b9_96f8_135684c2a07b
    ///data: void*
    ///items_count: int
    ///height_in_items: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCombo3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igCombo3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int current_item, Anonymous_a62b41d2_9218_42b9_96f8_135684c2a07b items_getter, System.IntPtr data, int items_count, int height_in_items);


    /// Return Type: boolean
    ///col: ImVec4
    ///small_height: boolean
    ///outline_border: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorButton")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igColorButton(ImVec4 col, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool small_height, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool outline_border);


    /// Return Type: boolean
    ///label: char*
    ///col: float*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorEdit3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igColorEdit3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float col);


    /// Return Type: boolean
    ///label: char*
    ///col: float*
    ///show_alpha: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorEdit4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igColorEdit4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float col, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool show_alpha);


    /// Return Type: void
    ///mode: ImGuiColorEditMode->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorEditMode")]
    public static extern void igColorEditMode(int mode);


    /// Return Type: void
    ///label: char*
    ///values: float*
    ///values_count: int
    ///values_offset: int
    ///overlay_text: char*
    ///scale_min: float
    ///scale_max: float
    ///graph_size: ImVec2
    ///stride: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPlotLines")]
    public static extern void igPlotLines([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float values, int values_count, int values_offset, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);


    /// Return Type: void
    ///label: char*
    ///values_getter: Anonymous_1e0f9ba8_3416_456e_8461_16596ed51c9b
    ///data: void*
    ///values_count: int
    ///values_offset: int
    ///overlay_text: char*
    ///scale_min: float
    ///scale_max: float
    ///graph_size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPlotLines2")]
    public static extern void igPlotLines2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, Anonymous_1e0f9ba8_3416_456e_8461_16596ed51c9b values_getter, System.IntPtr data, int values_count, int values_offset, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string overlay_text, float scale_min, float scale_max, ImVec2 graph_size);


    /// Return Type: void
    ///label: char*
    ///values: float*
    ///values_count: int
    ///values_offset: int
    ///overlay_text: char*
    ///scale_min: float
    ///scale_max: float
    ///graph_size: ImVec2
    ///stride: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPlotHistogram")]
    public static extern void igPlotHistogram([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float values, int values_count, int values_offset, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);


    /// Return Type: void
    ///label: char*
    ///values_getter: Anonymous_6f11d397_491b_4862_b0a6_3c73b2e84040
    ///data: void*
    ///values_count: int
    ///values_offset: int
    ///overlay_text: char*
    ///scale_min: float
    ///scale_max: float
    ///graph_size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igPlotHistogram2")]
    public static extern void igPlotHistogram2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, Anonymous_6f11d397_491b_4862_b0a6_3c73b2e84040 values_getter, System.IntPtr data, int values_count, int values_offset, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string overlay_text, float scale_min, float scale_max, ImVec2 graph_size);


    /// Return Type: void
    ///fraction: float
    ///size_arg: ImVec2*
    ///overlay: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igProgressBar")]
    public static extern void igProgressBar(float fraction, ref ImVec2 size_arg, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string overlay);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderFloat")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderFloat([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderFloat2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderFloat2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderFloat3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderFloat3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderFloat4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderFloat4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v_rad: float*
    ///v_degrees_min: float
    ///v_degrees_max: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderAngle")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderAngle([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v_rad, float v_degrees_min, float v_degrees_max);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderInt")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderInt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderInt2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderInt2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderInt3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderInt3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSliderInt4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSliderInt4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///size: ImVec2
    ///v: float*
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igVSliderFloat")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igVSliderFloat([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ImVec2 size, ref float v, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///size: ImVec2
    ///v: int*
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igVSliderInt")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igVSliderInt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ImVec2 size, ref int v, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_speed: float
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragFloat")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragFloat([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_speed, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_speed: float
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragFloat2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragFloat2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_speed, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_speed: float
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragFloat3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragFloat3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_speed, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///v_speed: float
    ///v_min: float
    ///v_max: float
    ///display_format: char*
    ///power: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragFloat4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragFloat4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float v_speed, float v_min, float v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format, float power);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_speed: float
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragInt")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragInt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, float v_speed, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_speed: float
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragInt2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragInt2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, float v_speed, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_speed: float
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragInt3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragInt3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, float v_speed, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///v_speed: float
    ///v_min: int
    ///v_max: int
    ///display_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igDragInt4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igDragInt4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, float v_speed, int v_min, int v_max, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string display_format);


    /// Return Type: boolean
    ///label: char*
    ///buf: char*
    ///buf_size: size_t->unsigned int
    ///flags: ImGuiInputTextFlags->int
    ///callback: ImGuiTextEditCallback
    ///user_data: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputText")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, System.IntPtr buf, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysUInt)] uint buf_size, int flags, ImGuiTextEditCallback callback, System.IntPtr user_data);


    /// Return Type: boolean
    ///label: char*
    ///buf: char*
    ///buf_size: size_t->unsigned int
    ///size: ImVec2
    ///flags: ImGuiInputTextFlags->int
    ///callback: ImGuiTextEditCallback
    ///user_data: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputTextMultiline")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputTextMultiline([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, System.IntPtr buf, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysUInt)] uint buf_size, ImVec2 size, int flags, ImGuiTextEditCallback callback, System.IntPtr user_data);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///step: float
    ///step_fast: float
    ///decimal_precision: int
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputFloat")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputFloat([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, float step, float step_fast, int decimal_precision, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///decimal_precision: int
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputFloat2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputFloat2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, int decimal_precision, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///decimal_precision: int
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputFloat3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputFloat3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, int decimal_precision, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: float*
    ///decimal_precision: int
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputFloat4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputFloat4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref float v, int decimal_precision, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///step: int
    ///step_fast: int
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputInt")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputInt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int step, int step_fast, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputInt2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputInt2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputInt3")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputInt3([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int extra_flags);


    /// Return Type: boolean
    ///label: char*
    ///v: int*
    ///extra_flags: ImGuiInputTextFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputInt4")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputInt4([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int v, int extra_flags);


    /// Return Type: boolean
    ///str_label_id: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTreeNode")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igTreeNode([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_label_id);


    /// Return Type: boolean
    ///str_id: char*
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTreeNodeStrV")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igTreeNodeStrV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: boolean
    ///ptr_id: void*
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTreeNodePtrV")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igTreeNodePtrV(System.IntPtr ptr_id, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    ///str_id: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTreePushStr")]
    public static extern void igTreePushStr([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id);


    /// Return Type: void
    ///ptr_id: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTreePushPtr")]
    public static extern void igTreePushPtr(System.IntPtr ptr_id);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igTreePop")]
    public static extern void igTreePop();


    /// Return Type: void
    ///opened: boolean
    ///cond: ImGuiSetCond->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetNextTreeNodeOpened")]
    public static extern void igSetNextTreeNodeOpened([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool opened, int cond);


    /// Return Type: boolean
    ///label: char*
    ///selected: boolean
    ///flags: ImGuiSelectableFlags->int
    ///size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSelectable")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSelectable([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool selected, int flags, ImVec2 size);


    /// Return Type: boolean
    ///label: char*
    ///p_selected: boolean*
    ///flags: ImGuiSelectableFlags->int
    ///size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSelectableEx")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igSelectableEx([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref bool p_selected, int flags, ImVec2 size);


    /// Return Type: boolean
    ///label: char*
    ///current_item: int*
    ///items: char**
    ///items_count: int
    ///height_in_items: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igListBox")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igListBox([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int current_item, ref System.IntPtr items, int items_count, int height_in_items);


    /// Return Type: boolean
    ///label: char*
    ///current_item: int*
    ///items_getter: Anonymous_e024a44b_f599_4138_b005_186f87f12bb5
    ///data: void*
    ///items_count: int
    ///height_in_items: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igListBox2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igListBox2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ref int current_item, Anonymous_e024a44b_f599_4138_b005_186f87f12bb5 items_getter, System.IntPtr data, int items_count, int height_in_items);


    /// Return Type: boolean
    ///label: char*
    ///size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igListBoxHeader")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igListBoxHeader([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, ImVec2 size);


    /// Return Type: boolean
    ///label: char*
    ///items_count: int
    ///height_in_items: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igListBoxHeader2")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igListBoxHeader2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, int items_count, int height_in_items);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igListBoxFooter")]
    public static extern void igListBoxFooter();


    /// Return Type: void
    ///prefix: char*
    ///b: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igValueBool")]
    public static extern void igValueBool([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string prefix, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool b);


    /// Return Type: void
    ///prefix: char*
    ///v: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igValueInt")]
    public static extern void igValueInt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string prefix, int v);


    /// Return Type: void
    ///prefix: char*
    ///v: unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igValueUInt")]
    public static extern void igValueUInt([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string prefix, uint v);


    /// Return Type: void
    ///prefix: char*
    ///v: float
    ///float_format: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igValueFloat")]
    public static extern void igValueFloat([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string prefix, float v, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string float_format);


    /// Return Type: void
    ///prefix: char*
    ///v: ImVec4
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igValueColor")]
    public static extern void igValueColor([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string prefix, ImVec4 v);


    /// Return Type: void
    ///prefix: char*
    ///v: unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igValueColor2")]
    public static extern void igValueColor2([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string prefix, uint v);


    /// Return Type: void
    ///fmt: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetTooltipV")]
    public static extern void igSetTooltipV([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fmt, System.IntPtr args);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginTooltip")]
    public static extern void igBeginTooltip();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndTooltip")]
    public static extern void igEndTooltip();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginMainMenuBar")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginMainMenuBar();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndMainMenuBar")]
    public static extern void igEndMainMenuBar();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginMenuBar")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginMenuBar();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndMenuBar")]
    public static extern void igEndMenuBar();


    /// Return Type: boolean
    ///label: char*
    ///enabled: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginMenu")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginMenu([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enabled);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndMenu")]
    public static extern void igEndMenu();


    /// Return Type: boolean
    ///label: char*
    ///shortcut: char*
    ///selected: boolean
    ///enabled: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igMenuItem")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igMenuItem([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string shortcut, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool selected, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enabled);


    /// Return Type: boolean
    ///label: char*
    ///shortcut: char*
    ///p_selected: boolean*
    ///enabled: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igMenuItemPtr")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igMenuItemPtr([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string shortcut, ref bool p_selected, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enabled);


    /// Return Type: void
    ///str_id: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igOpenPopup")]
    public static extern void igOpenPopup([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id);


    /// Return Type: boolean
    ///str_id: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginPopup")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginPopup([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id);


    /// Return Type: boolean
    ///name: char*
    ///p_opened: boolean*
    ///extra_flags: ImGuiWindowFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginPopupModal")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginPopupModal([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, ref bool p_opened, int extra_flags);


    /// Return Type: boolean
    ///str_id: char*
    ///mouse_button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginPopupContextItem")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginPopupContextItem([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, int mouse_button);


    /// Return Type: boolean
    ///also_over_items: boolean
    ///str_id: char*
    ///mouse_button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginPopupContextWindow")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginPopupContextWindow([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool also_over_items, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, int mouse_button);


    /// Return Type: boolean
    ///str_id: char*
    ///mouse_button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginPopupContextVoid")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginPopupContextVoid([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string str_id, int mouse_button);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndPopup")]
    public static extern void igEndPopup();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCloseCurrentPopup")]
    public static extern void igCloseCurrentPopup();


    /// Return Type: void
    ///max_depth: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igLogToTTY")]
    public static extern void igLogToTTY(int max_depth);


    /// Return Type: void
    ///max_depth: int
    ///filename: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igLogToFile")]
    public static extern void igLogToFile(int max_depth, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename);


    /// Return Type: void
    ///max_depth: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igLogToClipboard")]
    public static extern void igLogToClipboard(int max_depth);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igLogFinish")]
    public static extern void igLogFinish();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igLogButtons")]
    public static extern void igLogButtons();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsItemHovered")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsItemHovered();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsItemHoveredRect")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsItemHoveredRect();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsItemActive")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsItemActive();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsItemVisible")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsItemVisible();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsAnyItemHovered")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsAnyItemHovered();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsAnyItemActive")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsAnyItemActive();


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetItemRectMin")]
    public static extern void igGetItemRectMin(ref ImVec2 pOut);


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetItemRectMax")]
    public static extern void igGetItemRectMax(ref ImVec2 pOut);


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetItemRectSize")]
    public static extern void igGetItemRectSize(ref ImVec2 pOut);


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsWindowHovered")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsWindowHovered();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsWindowFocused")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsWindowFocused();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsRootWindowFocused")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsRootWindowFocused();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsRootWindowOrAnyChildFocused")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsRootWindowOrAnyChildFocused();


    /// Return Type: boolean
    ///item_size: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsRectVisible")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsRectVisible(ImVec2 item_size);


    /// Return Type: boolean
    ///pos: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsPosHoveringAnyWindow")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsPosHoveringAnyWindow(ImVec2 pos);


    /// Return Type: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetTime")]
    public static extern float igGetTime();


    /// Return Type: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetFrameCount")]
    public static extern int igGetFrameCount();


    /// Return Type: char*
    ///idx: ImGuiCol->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetStyleColName")]
    public static extern System.IntPtr igGetStyleColName(int idx);


    /// Return Type: void
    ///pOut: ImVec2*
    ///pos: ImVec2
    ///on_edge: boolean
    ///outward: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCalcItemRectClosestPoint")]
    public static extern void igCalcItemRectClosestPoint(ref ImVec2 pOut, ImVec2 pos, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool on_edge, float outward);


    /// Return Type: void
    ///pOut: ImVec2*
    ///text: char*
    ///text_end: char*
    ///hide_text_after_double_hash: boolean
    ///wrap_width: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCalcTextSize")]
    public static extern void igCalcTextSize(ref ImVec2 pOut, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text_end, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool hide_text_after_double_hash, float wrap_width);


    /// Return Type: void
    ///items_count: int
    ///items_height: float
    ///out_items_display_start: int*
    ///out_items_display_end: int*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCalcListClipping")]
    public static extern void igCalcListClipping(int items_count, float items_height, ref int out_items_display_start, ref int out_items_display_end);


    /// Return Type: boolean
    ///id: ImGuiID->ImU32->unsigned int
    ///size: ImVec2
    ///extra_flags: ImGuiWindowFlags->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igBeginChildFrame")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igBeginChildFrame(uint id, ImVec2 size, int extra_flags);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igEndChildFrame")]
    public static extern void igEndChildFrame();


    /// Return Type: void
    ///pOut: ImVec4*
    ///in: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorConvertU32ToFloat4")]
    public static extern void igColorConvertU32ToFloat4(ref ImVec4 pOut, uint @in);


    /// Return Type: ImU32->unsigned int
    ///in: ImVec4
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorConvertFloat4ToU32")]
    public static extern uint igColorConvertFloat4ToU32(ImVec4 @in);


    /// Return Type: void
    ///r: float
    ///g: float
    ///b: float
    ///out_h: float*
    ///out_s: float*
    ///out_v: float*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorConvertRGBtoHSV")]
    public static extern void igColorConvertRGBtoHSV(float r, float g, float b, ref float out_h, ref float out_s, ref float out_v);


    /// Return Type: void
    ///h: float
    ///s: float
    ///v: float
    ///out_r: float*
    ///out_g: float*
    ///out_b: float*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igColorConvertHSVtoRGB")]
    public static extern void igColorConvertHSVtoRGB(float h, float s, float v, ref float out_r, ref float out_g, ref float out_b);


    /// Return Type: int
    ///key: ImGuiKey->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetKeyIndex")]
    public static extern int igGetKeyIndex(int key);


    /// Return Type: boolean
    ///key_index: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsKeyDown")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsKeyDown(int key_index);


    /// Return Type: boolean
    ///key_index: int
    ///repeat: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsKeyPressed")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsKeyPressed(int key_index, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool repeat);


    /// Return Type: boolean
    ///key_index: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsKeyReleased")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsKeyReleased(int key_index);


    /// Return Type: boolean
    ///button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseDown")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseDown(int button);


    /// Return Type: boolean
    ///button: int
    ///repeat: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseClicked")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseClicked(int button, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool repeat);


    /// Return Type: boolean
    ///button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseDoubleClicked")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseDoubleClicked(int button);


    /// Return Type: boolean
    ///button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseReleased")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseReleased(int button);


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseHoveringWindow")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseHoveringWindow();


    /// Return Type: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseHoveringAnyWindow")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseHoveringAnyWindow();


    /// Return Type: boolean
    ///pos_min: ImVec2
    ///pos_max: ImVec2
    ///clip: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseHoveringRect")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseHoveringRect(ImVec2 pos_min, ImVec2 pos_max, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool clip);


    /// Return Type: boolean
    ///button: int
    ///lock_threshold: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igIsMouseDragging")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igIsMouseDragging(int button, float lock_threshold);


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetMousePos")]
    public static extern void igGetMousePos(ref ImVec2 pOut);


    /// Return Type: void
    ///pOut: ImVec2*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetMousePosOnOpeningCurrentPopup")]
    public static extern void igGetMousePosOnOpeningCurrentPopup(ref ImVec2 pOut);


    /// Return Type: void
    ///pOut: ImVec2*
    ///button: int
    ///lock_threshold: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetMouseDragDelta")]
    public static extern void igGetMouseDragDelta(ref ImVec2 pOut, int button, float lock_threshold);


    /// Return Type: void
    ///button: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igResetMouseDragDelta")]
    public static extern void igResetMouseDragDelta(int button);


    /// Return Type: ImGuiMouseCursor->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetMouseCursor")]
    public static extern int igGetMouseCursor();


    /// Return Type: void
    ///type: ImGuiMouseCursor->int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetMouseCursor")]
    public static extern void igSetMouseCursor(int type);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCaptureKeyboardFromApp")]
    public static extern void igCaptureKeyboardFromApp();


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igCaptureMouseFromApp")]
    public static extern void igCaptureMouseFromApp();


    /// Return Type: void*
    ///sz: size_t->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igMemAlloc")]
    public static extern System.IntPtr igMemAlloc([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysUInt)] uint sz);


    /// Return Type: void
    ///ptr: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igMemFree")]
    public static extern void igMemFree(System.IntPtr ptr);


    /// Return Type: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetClipboardText")]
    public static extern System.IntPtr igGetClipboardText();


    /// Return Type: void
    ///text: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetClipboardText")]
    public static extern void igSetClipboardText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text);


    /// Return Type: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetVersion")]
    public static extern System.IntPtr igGetVersion();


    /// Return Type: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetInternalState")]
    public static extern System.IntPtr igGetInternalState();


    /// Return Type: size_t->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igGetInternalStateSize")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysUInt)]
    public static extern uint igGetInternalStateSize();


    /// Return Type: void
    ///state: void*
    ///construct: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igSetInternalState")]
    public static extern void igSetInternalState(System.IntPtr state, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool construct);


    /// Return Type: void
    ///atlas: ImFontAtlas*
    ///out_pixels: unsigned char**
    ///out_width: int*
    ///out_height: int*
    ///out_bytes_per_pixel: int*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetTexDataAsRGBA32")]
    public static extern void ImFontAtlas_GetTexDataAsRGBA32(ref ImFontAtlas atlas, ref System.IntPtr out_pixels, ref int out_width, ref int out_height, ref int out_bytes_per_pixel);


    /// Return Type: void
    ///atlas: ImFontAtlas*
    ///out_pixels: unsigned char**
    ///out_width: int*
    ///out_height: int*
    ///out_bytes_per_pixel: int*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetTexDataAsAlpha8")]
    public static extern void ImFontAtlas_GetTexDataAsAlpha8(ref ImFontAtlas atlas, ref System.IntPtr out_pixels, ref int out_width, ref int out_height, ref int out_bytes_per_pixel);


    /// Return Type: void
    ///atlas: ImFontAtlas*
    ///tex: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_SetTexID")]
    public static extern void ImFontAtlas_SetTexID(ref ImFontAtlas atlas, System.IntPtr tex);


    /// Return Type: ImFont*
    ///atlas: ImFontAtlas*
    ///font_cfg: ImFontConfig*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFont")]
    public static extern System.IntPtr ImFontAtlas_AddFont(ref ImFontAtlas atlas, ref ImFontConfig font_cfg);


    /// Return Type: ImFont*
    ///atlas: ImFontAtlas*
    ///font_cfg: ImFontConfig*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontDefault")]
    public static extern System.IntPtr ImFontAtlas_AddFontDefault(ref ImFontAtlas atlas, ref ImFontConfig font_cfg);


    /// Return Type: ImFont*
    ///atlas: ImFontAtlas*
    ///filename: char*
    ///size_pixels: float
    ///font_cfg: ImFontConfig*
    ///glyph_ranges: ImWchar*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromFileTTF")]
    public static extern System.IntPtr ImFontAtlas_AddFontFromFileTTF(ref ImFontAtlas atlas, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges);


    /// Return Type: ImFont*
    ///atlas: ImFontAtlas*
    ///ttf_data: void*
    ///ttf_size: int
    ///size_pixels: float
    ///font_cfg: ImFontConfig*
    ///glyph_ranges: ImWchar*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromMemoryTTF")]
    public static extern System.IntPtr ImFontAtlas_AddFontFromMemoryTTF(ref ImFontAtlas atlas, System.IntPtr ttf_data, int ttf_size, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges);


    /// Return Type: ImFont*
    ///atlas: ImFontAtlas*
    ///compressed_ttf_data: void*
    ///compressed_ttf_size: int
    ///size_pixels: float
    ///font_cfg: ImFontConfig*
    ///glyph_ranges: ImWchar*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedTTF")]
    public static extern System.IntPtr ImFontAtlas_AddFontFromMemoryCompressedTTF(ref ImFontAtlas atlas, System.IntPtr compressed_ttf_data, int compressed_ttf_size, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges);


    /// Return Type: ImFont*
    ///atlas: ImFontAtlas*
    ///compressed_ttf_data_base85: char*
    ///size_pixels: float
    ///font_cfg: ImFontConfig*
    ///glyph_ranges: ImWchar*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedBase85TTF")]
    public static extern System.IntPtr ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ref ImFontAtlas atlas, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string compressed_ttf_data_base85, float size_pixels, ref ImFontConfig font_cfg, ref ushort glyph_ranges);


    /// Return Type: void
    ///atlas: ImFontAtlas*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_ClearTexData")]
    public static extern void ImFontAtlas_ClearTexData(ref ImFontAtlas atlas);


    /// Return Type: void
    ///atlas: ImFontAtlas*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_Clear")]
    public static extern void ImFontAtlas_Clear(ref ImFontAtlas atlas);


    /// Return Type: void
    ///c: unsigned short
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddInputCharacter")]
    public static extern void ImGuiIO_AddInputCharacter(ushort c);


    /// Return Type: void
    ///utf8_chars: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddInputCharactersUTF8")]
    public static extern void ImGuiIO_AddInputCharactersUTF8([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string utf8_chars);


    /// Return Type: void
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImGuiIO_ClearInputCharacters")]
    public static extern void ImGuiIO_ClearInputCharacters();


    /// Return Type: void
    ///drawData: ImDrawData*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawData_DeIndexAllBuffers")]
    public static extern void ImDrawData_DeIndexAllBuffers(ref ImDrawData drawData);


    /// Return Type: int
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetVertexBufferSize")]
    public static extern int ImDrawList_GetVertexBufferSize(ref ImDrawList list);


    /// Return Type: ImDrawVert*
    ///list: ImDrawList*
    ///n: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetVertexPtr")]
    public static extern System.IntPtr ImDrawList_GetVertexPtr(ref ImDrawList list, int n);


    /// Return Type: int
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetIndexBufferSize")]
    public static extern int ImDrawList_GetIndexBufferSize(ref ImDrawList list);


    /// Return Type: ImDrawIdx*
    ///list: ImDrawList*
    ///n: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetIndexPtr")]
    public static extern System.IntPtr ImDrawList_GetIndexPtr(ref ImDrawList list, int n);


    /// Return Type: int
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetCmdSize")]
    public static extern int ImDrawList_GetCmdSize(ref ImDrawList list);


    /// Return Type: ImDrawCmd*
    ///list: ImDrawList*
    ///n: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetCmdPtr")]
    public static extern System.IntPtr ImDrawList_GetCmdPtr(ref ImDrawList list, int n);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_Clear")]
    public static extern void ImDrawList_Clear(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_ClearFreeMemory")]
    public static extern void ImDrawList_ClearFreeMemory(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    ///clip_rect: ImVec4
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PushClipRect")]
    public static extern void ImDrawList_PushClipRect(ref ImDrawList list, ImVec4 clip_rect);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PushClipRectFullScreen")]
    public static extern void ImDrawList_PushClipRectFullScreen(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PopClipRect")]
    public static extern void ImDrawList_PopClipRect(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    ///texture_id: ImTextureID->void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PushTextureID")]
    public static extern void ImDrawList_PushTextureID(ref ImDrawList list, System.IntPtr texture_id);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PopTextureID")]
    public static extern void ImDrawList_PopTextureID(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///col: ImU32->unsigned int
    ///thickness: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddLine")]
    public static extern void ImDrawList_AddLine(ref ImDrawList list, ImVec2 a, ImVec2 b, uint col, float thickness);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///col: ImU32->unsigned int
    ///rounding: float
    ///rounding_corners: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRect")]
    public static extern void ImDrawList_AddRect(ref ImDrawList list, ImVec2 a, ImVec2 b, uint col, float rounding, int rounding_corners);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///col: ImU32->unsigned int
    ///rounding: float
    ///rounding_corners: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRectFilled")]
    public static extern void ImDrawList_AddRectFilled(ref ImDrawList list, ImVec2 a, ImVec2 b, uint col, float rounding, int rounding_corners);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///col_upr_left: ImU32->unsigned int
    ///col_upr_right: ImU32->unsigned int
    ///col_bot_right: ImU32->unsigned int
    ///col_bot_left: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRectFilledMultiColor")]
    public static extern void ImDrawList_AddRectFilledMultiColor(ref ImDrawList list, ImVec2 a, ImVec2 b, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///c: ImVec2
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTriangleFilled")]
    public static extern void ImDrawList_AddTriangleFilled(ref ImDrawList list, ImVec2 a, ImVec2 b, ImVec2 c, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///centre: ImVec2
    ///radius: float
    ///col: ImU32->unsigned int
    ///num_segments: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCircle")]
    public static extern void ImDrawList_AddCircle(ref ImDrawList list, ImVec2 centre, float radius, uint col, int num_segments);


    /// Return Type: void
    ///list: ImDrawList*
    ///centre: ImVec2
    ///radius: float
    ///col: ImU32->unsigned int
    ///num_segments: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCircleFilled")]
    public static extern void ImDrawList_AddCircleFilled(ref ImDrawList list, ImVec2 centre, float radius, uint col, int num_segments);


    /// Return Type: void
    ///list: ImDrawList*
    ///pos: ImVec2
    ///col: ImU32->unsigned int
    ///text_begin: char*
    ///text_end: char*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddText")]
    public static extern void ImDrawList_AddText(ref ImDrawList list, ImVec2 pos, uint col, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text_begin, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text_end);


    /// Return Type: void
    ///list: ImDrawList*
    ///font: ImFont*
    ///font_size: float
    ///pos: ImVec2
    ///col: ImU32->unsigned int
    ///text_begin: char*
    ///text_end: char*
    ///wrap_width: float
    ///cpu_fine_clip_rect: ImVec4*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTextExt")]
    public static extern void ImDrawList_AddTextExt(ref ImDrawList list, ref ImFont font, float font_size, ImVec2 pos, uint col, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text_begin, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string text_end, float wrap_width, ref ImVec4 cpu_fine_clip_rect);


    /// Return Type: void
    ///list: ImDrawList*
    ///user_texture_id: ImTextureID->void*
    ///a: ImVec2
    ///b: ImVec2
    ///uv0: ImVec2
    ///uv1: ImVec2
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddImage")]
    public static extern void ImDrawList_AddImage(ref ImDrawList list, System.IntPtr user_texture_id, ImVec2 a, ImVec2 b, ImVec2 uv0, ImVec2 uv1, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///points: ImVec2*
    ///num_points: int
    ///col: ImU32->unsigned int
    ///closed: boolean
    ///thickness: float
    ///anti_aliased: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddPolyline")]
    public static extern void ImDrawList_AddPolyline(ref ImDrawList list, ref ImVec2 points, int num_points, uint col, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool closed, float thickness, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool anti_aliased);


    /// Return Type: void
    ///list: ImDrawList*
    ///points: ImVec2*
    ///num_points: int
    ///col: ImU32->unsigned int
    ///anti_aliased: boolean
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddConvexPolyFilled")]
    public static extern void ImDrawList_AddConvexPolyFilled(ref ImDrawList list, ref ImVec2 points, int num_points, uint col, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool anti_aliased);


    /// Return Type: void
    ///list: ImDrawList*
    ///pos0: ImVec2
    ///cp0: ImVec2
    ///cp1: ImVec2
    ///pos1: ImVec2
    ///col: ImU32->unsigned int
    ///thickness: float
    ///num_segments: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddBezierCurve")]
    public static extern void ImDrawList_AddBezierCurve(ref ImDrawList list, ImVec2 pos0, ImVec2 cp0, ImVec2 cp1, ImVec2 pos1, uint col, float thickness, int num_segments);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathClear")]
    public static extern void ImDrawList_PathClear(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    ///pos: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathLineTo")]
    public static extern void ImDrawList_PathLineTo(ref ImDrawList list, ImVec2 pos);


    /// Return Type: void
    ///list: ImDrawList*
    ///pos: ImVec2
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathLineToMergeDuplicate")]
    public static extern void ImDrawList_PathLineToMergeDuplicate(ref ImDrawList list, ImVec2 pos);


    /// Return Type: void
    ///list: ImDrawList*
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathFill")]
    public static extern void ImDrawList_PathFill(ref ImDrawList list, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///col: ImU32->unsigned int
    ///closed: boolean
    ///thickness: float
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathStroke")]
    public static extern void ImDrawList_PathStroke(ref ImDrawList list, uint col, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool closed, float thickness);


    /// Return Type: void
    ///list: ImDrawList*
    ///centre: ImVec2
    ///radius: float
    ///a_min: float
    ///a_max: float
    ///num_segments: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathArcTo")]
    public static extern void ImDrawList_PathArcTo(ref ImDrawList list, ImVec2 centre, float radius, float a_min, float a_max, int num_segments);


    /// Return Type: void
    ///list: ImDrawList*
    ///centre: ImVec2
    ///radius: float
    ///a_min_of_12: int
    ///a_max_of_12: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathArcToFast")]
    public static extern void ImDrawList_PathArcToFast(ref ImDrawList list, ImVec2 centre, float radius, int a_min_of_12, int a_max_of_12);


    /// Return Type: void
    ///list: ImDrawList*
    ///p1: ImVec2
    ///p2: ImVec2
    ///p3: ImVec2
    ///num_segments: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathBezierCurveTo")]
    public static extern void ImDrawList_PathBezierCurveTo(ref ImDrawList list, ImVec2 p1, ImVec2 p2, ImVec2 p3, int num_segments);


    /// Return Type: void
    ///list: ImDrawList*
    ///rect_min: ImVec2
    ///rect_max: ImVec2
    ///rounding: float
    ///rounding_corners: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathRect")]
    public static extern void ImDrawList_PathRect(ref ImDrawList list, ImVec2 rect_min, ImVec2 rect_max, float rounding, int rounding_corners);


    /// Return Type: void
    ///list: ImDrawList*
    ///channels_count: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_ChannelsSplit")]
    public static extern void ImDrawList_ChannelsSplit(ref ImDrawList list, int channels_count);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_ChannelsMerge")]
    public static extern void ImDrawList_ChannelsMerge(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    ///channel_index: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_ChannelsSetCurrent")]
    public static extern void ImDrawList_ChannelsSetCurrent(ref ImDrawList list, int channel_index);


    /// Return Type: void
    ///list: ImDrawList*
    ///callback: ImDrawCallback
    ///callback_data: void*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCallback")]
    public static extern void ImDrawList_AddCallback(ref ImDrawList list, ImDrawCallback callback, System.IntPtr callback_data);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddDrawCmd")]
    public static extern void ImDrawList_AddDrawCmd(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    ///idx_count: int
    ///vtx_count: int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimReserve")]
    public static extern void ImDrawList_PrimReserve(ref ImDrawList list, int idx_count, int vtx_count);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimRect")]
    public static extern void ImDrawList_PrimRect(ref ImDrawList list, ImVec2 a, ImVec2 b, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///a: ImVec2
    ///b: ImVec2
    ///uv_a: ImVec2
    ///uv_b: ImVec2
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimRectUV")]
    public static extern void ImDrawList_PrimRectUV(ref ImDrawList list, ImVec2 a, ImVec2 b, ImVec2 uv_a, ImVec2 uv_b, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///pos: ImVec2
    ///uv: ImVec2
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimVtx")]
    public static extern void ImDrawList_PrimVtx(ref ImDrawList list, ImVec2 pos, ImVec2 uv, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///pos: ImVec2
    ///uv: ImVec2
    ///col: ImU32->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimWriteVtx")]
    public static extern void ImDrawList_PrimWriteVtx(ref ImDrawList list, ImVec2 pos, ImVec2 uv, uint col);


    /// Return Type: void
    ///list: ImDrawList*
    ///idx: ImDrawIdx->unsigned short
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimWriteIdx")]
    public static extern void ImDrawList_PrimWriteIdx(ref ImDrawList list, ushort idx);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_UpdateClipRect")]
    public static extern void ImDrawList_UpdateClipRect(ref ImDrawList list);


    /// Return Type: void
    ///list: ImDrawList*
    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ImDrawList_UpdateTextureID")]
    public static extern void ImDrawList_UpdateTextureID(ref ImDrawList list);


    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputText")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputText([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, System.IntPtr buf, System.IntPtr buf_size, int flags, ImGuiTextEditCallback callback, System.IntPtr user_data);


    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igInputTextMultiline")]
    [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)]
    public static extern bool igInputTextMultiline([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label, System.IntPtr buf, System.IntPtr buf_size, ImVec2 size, int flags, ImGuiTextEditCallback callback, System.IntPtr user_data);


    [System.Runtime.InteropServices.DllImportAttribute("imgui_rt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "igMemAlloc")]
    public static extern System.IntPtr igMemAlloc(System.IntPtr sz);

}
