# Julia wrapper for header: /home/oleksandr/ath/julia/_cimgui.h
# Automatically generated using Clang.jl wrap_c, version 0.0.0

const cimgui = "..\\cimgui\\Debug\\imgui_sw.dll"

function igTest(test1::Cint,test2::Cint)
    ccall((:igTest,cimgui),Cint,(Cint,Cint),test1,test2)
end

function igGetIO()
    ccall((:igGetIO,cimgui),Ptr{ImGuiIO},())
end

function igGetStyle()
    ccall((:igGetStyle,cimgui),Ptr{ImGuiStyle},())
end

function igGetDrawData()
    ccall((:igGetDrawData,cimgui),Ptr{ImDrawData},())
end

function igNewFrame()
    ccall((:igNewFrame,cimgui),Void,())
end

function igRender()
    ccall((:igRender,cimgui),Void,())
end

function igShutdown()
    ccall((:igShutdown,cimgui),Void,())
end

function igShowUserGuide()
    ccall((:igShowUserGuide,cimgui),Void,())
end

function igShowStyleEditor(ref::Ptr{ImGuiStyle})
    ccall((:igShowStyleEditor,cimgui),Void,(Ptr{ImGuiStyle},),ref)
end

function igShowTestWindow(opened::Ptr{bool})
    ccall((:igShowTestWindow,cimgui),Void,(Ptr{bool},),opened)
end

function igShowMetricsWindow(opened::Ptr{bool})
    ccall((:igShowMetricsWindow,cimgui),Void,(Ptr{bool},),opened)
end

function igBegin(name::ASCIIString,p_opened::Ptr{bool},flags::ImGuiWindowFlags)
    ccall((:igBegin,cimgui),bool,(Cstring,Ptr{bool},ImGuiWindowFlags),name,p_opened,flags)
end

function igBegin2(name::Ptr{UInt8},p_opened::Ptr{bool},size_on_first_use::ImVec2,bg_alpha::Cfloat,flags::ImGuiWindowFlags)
    ccall((:igBegin2,cimgui),bool,(Ptr{UInt8},Ptr{bool},ImVec2,Cfloat,ImGuiWindowFlags),name,p_opened,size_on_first_use,bg_alpha,flags)
end

function igEnd()
    ccall((:igEnd,cimgui),Void,())
end

function igBeginChild(str_id::Ptr{UInt8},size::ImVec2,border::bool,extra_flags::ImGuiWindowFlags)
    ccall((:igBeginChild,cimgui),bool,(Ptr{UInt8},ImVec2,bool,ImGuiWindowFlags),str_id,size,border,extra_flags)
end

function igBeginChildEx(id::ImGuiID,size::ImVec2,border::bool,extra_flags::ImGuiWindowFlags)
    ccall((:igBeginChildEx,cimgui),bool,(ImGuiID,ImVec2,bool,ImGuiWindowFlags),id,size,border,extra_flags)
end

function igEndChild()
    ccall((:igEndChild,cimgui),Void,())
end

function igGetContentRegionMax(out::Ptr{ImVec2})
    ccall((:igGetContentRegionMax,cimgui),Void,(Ptr{ImVec2},),out)
end

function igGetContentRegionAvail(out::Ptr{ImVec2})
    ccall((:igGetContentRegionAvail,cimgui),Void,(Ptr{ImVec2},),out)
end

function igGetContentRegionAvailWidth()
    ccall((:igGetContentRegionAvailWidth,cimgui),Cfloat,())
end

function igGetWindowContentRegionMin(out::Ptr{ImVec2})
    ccall((:igGetWindowContentRegionMin,cimgui),Void,(Ptr{ImVec2},),out)
end

function igGetWindowContentRegionMax(out::Ptr{ImVec2})
    ccall((:igGetWindowContentRegionMax,cimgui),Void,(Ptr{ImVec2},),out)
end

function igGetWindowContentRegionWidth()
    ccall((:igGetWindowContentRegionWidth,cimgui),Cfloat,())
end

function igGetWindowDrawList()
    ccall((:igGetWindowDrawList,cimgui),Ptr{ImDrawList},())
end

function igGetWindowFont()
    ccall((:igGetWindowFont,cimgui),Ptr{ImFont},())
end

function igGetWindowFontSize()
    ccall((:igGetWindowFontSize,cimgui),Cfloat,())
end

function igSetWindowFontScale(scale::Cfloat)
    ccall((:igSetWindowFontScale,cimgui),Void,(Cfloat,),scale)
end

function igGetWindowPos(out::Ptr{ImVec2})
    ccall((:igGetWindowPos,cimgui),Void,(Ptr{ImVec2},),out)
end

function igGetWindowSize(out::Ptr{ImVec2})
    ccall((:igGetWindowSize,cimgui),Void,(Ptr{ImVec2},),out)
end

function igGetWindowWidth()
    ccall((:igGetWindowWidth,cimgui),Cfloat,())
end

function igGetWindowHeight()
    ccall((:igGetWindowHeight,cimgui),Cfloat,())
end

function igIsWindowCollapsed()
    ccall((:igIsWindowCollapsed,cimgui),bool,())
end

function igSetNextWindowPos(pos::ImVec2,cond::ImGuiSetCond)
    ccall((:igSetNextWindowPos,cimgui),Void,(ImVec2,ImGuiSetCond),pos,cond)
end

function igSetNextWindowPosCenter(cond::ImGuiSetCond)
    ccall((:igSetNextWindowPosCenter,cimgui),Void,(ImGuiSetCond,),cond)
end

function igSetNextWindowSize(size::ImVec2,cond::ImGuiSetCond)
    ccall((:igSetNextWindowSize,cimgui),Void,(ImVec2,ImGuiSetCond),size,cond)
end

function igSetNextWindowContentSize(size::ImVec2)
    ccall((:igSetNextWindowContentSize,cimgui),Void,(ImVec2,),size)
end

function igSetNextWindowContentWidth(width::Cfloat)
    ccall((:igSetNextWindowContentWidth,cimgui),Void,(Cfloat,),width)
end

function igSetNextWindowCollapsed(collapsed::bool,cond::ImGuiSetCond)
    ccall((:igSetNextWindowCollapsed,cimgui),Void,(bool,ImGuiSetCond),collapsed,cond)
end

function igSetNextWindowFocus()
    ccall((:igSetNextWindowFocus,cimgui),Void,())
end

function igSetWindowPos(pos::ImVec2,cond::ImGuiSetCond)
    ccall((:igSetWindowPos,cimgui),Void,(ImVec2,ImGuiSetCond),pos,cond)
end

function igSetWindowSize(size::ImVec2,cond::ImGuiSetCond)
    ccall((:igSetWindowSize,cimgui),Void,(ImVec2,ImGuiSetCond),size,cond)
end

function igSetWindowCollapsed(collapsed::bool,cond::ImGuiSetCond)
    ccall((:igSetWindowCollapsed,cimgui),Void,(bool,ImGuiSetCond),collapsed,cond)
end

function igSetWindowFocus()
    ccall((:igSetWindowFocus,cimgui),Void,())
end

function igSetWindowPosByName(name::Ptr{UInt8},pos::ImVec2,cond::ImGuiSetCond)
    ccall((:igSetWindowPosByName,cimgui),Void,(Ptr{UInt8},ImVec2,ImGuiSetCond),name,pos,cond)
end

function igSetWindowSize2(name::Ptr{UInt8},size::ImVec2,cond::ImGuiSetCond)
    ccall((:igSetWindowSize2,cimgui),Void,(Ptr{UInt8},ImVec2,ImGuiSetCond),name,size,cond)
end

function igSetWindowCollapsed2(name::Ptr{UInt8},collapsed::bool,cond::ImGuiSetCond)
    ccall((:igSetWindowCollapsed2,cimgui),Void,(Ptr{UInt8},bool,ImGuiSetCond),name,collapsed,cond)
end

function igSetWindowFocus2(name::Ptr{UInt8})
    ccall((:igSetWindowFocus2,cimgui),Void,(Ptr{UInt8},),name)
end

function igGetScrollX()
    ccall((:igGetScrollX,cimgui),Cfloat,())
end

function igGetScrollY()
    ccall((:igGetScrollY,cimgui),Cfloat,())
end

function igGetScrollMaxX()
    ccall((:igGetScrollMaxX,cimgui),Cfloat,())
end

function igGetScrollMaxY()
    ccall((:igGetScrollMaxY,cimgui),Cfloat,())
end

function igSetScrollX(scroll_x::Cfloat)
    ccall((:igSetScrollX,cimgui),Void,(Cfloat,),scroll_x)
end

function igSetScrollY(scroll_y::Cfloat)
    ccall((:igSetScrollY,cimgui),Void,(Cfloat,),scroll_y)
end

function igSetScrollHere(center_y_ratio::Cfloat)
    ccall((:igSetScrollHere,cimgui),Void,(Cfloat,),center_y_ratio)
end

function igSetScrollFromPosY(pos_y::Cfloat,center_y_ratio::Cfloat)
    ccall((:igSetScrollFromPosY,cimgui),Void,(Cfloat,Cfloat),pos_y,center_y_ratio)
end

function igSetKeyboardFocusHere(offset::Cint)
    ccall((:igSetKeyboardFocusHere,cimgui),Void,(Cint,),offset)
end

function igSetStateStorage(tree::Ptr{ImGuiStorage})
    ccall((:igSetStateStorage,cimgui),Void,(Ptr{ImGuiStorage},),tree)
end

function igGetStateStorage()
    ccall((:igGetStateStorage,cimgui),Ptr{ImGuiStorage},())
end

function igPushFont(font::Ptr{ImFont})
    ccall((:igPushFont,cimgui),Void,(Ptr{ImFont},),font)
end

function igPopFont()
    ccall((:igPopFont,cimgui),Void,())
end

function igPushStyleColor(idx::ImGuiCol,col::ImVec4)
    ccall((:igPushStyleColor,cimgui),Void,(ImGuiCol,ImVec4),idx,col)
end

function igPopStyleColor(count::Cint)
    ccall((:igPopStyleColor,cimgui),Void,(Cint,),count)
end

function igPushStyleVar(idx::ImGuiStyleVar,val::Cfloat)
    ccall((:igPushStyleVar,cimgui),Void,(ImGuiStyleVar,Cfloat),idx,val)
end

function igPushStyleVarVec(idx::ImGuiStyleVar,val::ImVec2)
    ccall((:igPushStyleVarVec,cimgui),Void,(ImGuiStyleVar,ImVec2),idx,val)
end

function igPopStyleVar(count::Cint)
    ccall((:igPopStyleVar,cimgui),Void,(Cint,),count)
end

function igGetColorU32(idx::ImGuiCol,alpha_mul::Cfloat)
    ccall((:igGetColorU32,cimgui),ImU32,(ImGuiCol,Cfloat),idx,alpha_mul)
end

function igGetColorU32Vec(col::Ptr{ImVec4})
    ccall((:igGetColorU32Vec,cimgui),ImU32,(Ptr{ImVec4},),col)
end

function igPushItemWidth(item_width::Cfloat)
    ccall((:igPushItemWidth,cimgui),Void,(Cfloat,),item_width)
end

function igPopItemWidth()
    ccall((:igPopItemWidth,cimgui),Void,())
end

function igCalcItemWidth()
    ccall((:igCalcItemWidth,cimgui),Cfloat,())
end

function igPushTextWrapPos(wrap_pos_x::Cfloat)
    ccall((:igPushTextWrapPos,cimgui),Void,(Cfloat,),wrap_pos_x)
end

function igPopTextWrapPos()
    ccall((:igPopTextWrapPos,cimgui),Void,())
end

function igPushAllowKeyboardFocus(v::bool)
    ccall((:igPushAllowKeyboardFocus,cimgui),Void,(bool,),v)
end

function igPopAllowKeyboardFocus()
    ccall((:igPopAllowKeyboardFocus,cimgui),Void,())
end

function igPushButtonRepeat(repeat::bool)
    ccall((:igPushButtonRepeat,cimgui),Void,(bool,),repeat)
end

function igPopButtonRepeat()
    ccall((:igPopButtonRepeat,cimgui),Void,())
end

function igBeginGroup()
    ccall((:igBeginGroup,cimgui),Void,())
end

function igEndGroup()
    ccall((:igEndGroup,cimgui),Void,())
end

function igSeparator()
    ccall((:igSeparator,cimgui),Void,())
end

function igSameLine(local_pos_x::Cfloat,spacing_w::Cfloat)
    ccall((:igSameLine,cimgui),Void,(Cfloat,Cfloat),local_pos_x,spacing_w)
end

function igSpacing()
    ccall((:igSpacing,cimgui),Void,())
end

function igDummy(size::Ptr{ImVec2})
    ccall((:igDummy,cimgui),Void,(Ptr{ImVec2},),size)
end

function igIndent()
    ccall((:igIndent,cimgui),Void,())
end

function igUnindent()
    ccall((:igUnindent,cimgui),Void,())
end

function igColumns(count::Cint,id::Ptr{UInt8},border::bool)
    ccall((:igColumns,cimgui),Void,(Cint,Ptr{UInt8},bool),count,id,border)
end

function igNextColumn()
    ccall((:igNextColumn,cimgui),Void,())
end

function igGetColumnIndex()
    ccall((:igGetColumnIndex,cimgui),Cint,())
end

function igGetColumnOffset(column_index::Cint)
    ccall((:igGetColumnOffset,cimgui),Cfloat,(Cint,),column_index)
end

function igSetColumnOffset(column_index::Cint,offset_x::Cfloat)
    ccall((:igSetColumnOffset,cimgui),Void,(Cint,Cfloat),column_index,offset_x)
end

function igGetColumnWidth(column_index::Cint)
    ccall((:igGetColumnWidth,cimgui),Cfloat,(Cint,),column_index)
end

function igGetColumnsCount()
    ccall((:igGetColumnsCount,cimgui),Cint,())
end

function igGetCursorPos(pOut::Ptr{ImVec2})
    ccall((:igGetCursorPos,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igGetCursorPosX()
    ccall((:igGetCursorPosX,cimgui),Cfloat,())
end

function igGetCursorPosY()
    ccall((:igGetCursorPosY,cimgui),Cfloat,())
end

function igSetCursorPos(local_pos::ImVec2)
    ccall((:igSetCursorPos,cimgui),Void,(ImVec2,),local_pos)
end

function igSetCursorPosX(x::Cfloat)
    ccall((:igSetCursorPosX,cimgui),Void,(Cfloat,),x)
end

function igSetCursorPosY(y::Cfloat)
    ccall((:igSetCursorPosY,cimgui),Void,(Cfloat,),y)
end

function igGetCursorStartPos(pOut::Ptr{ImVec2})
    ccall((:igGetCursorStartPos,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igGetCursorScreenPos(pOut::Ptr{ImVec2})
    ccall((:igGetCursorScreenPos,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igSetCursorScreenPos(pos::ImVec2)
    ccall((:igSetCursorScreenPos,cimgui),Void,(ImVec2,),pos)
end

function igAlignFirstTextHeightToWidgets()
    ccall((:igAlignFirstTextHeightToWidgets,cimgui),Void,())
end

function igGetTextLineHeight()
    ccall((:igGetTextLineHeight,cimgui),Cfloat,())
end

function igGetTextLineHeightWithSpacing()
    ccall((:igGetTextLineHeightWithSpacing,cimgui),Cfloat,())
end

function igGetItemsLineHeightWithSpacing()
    ccall((:igGetItemsLineHeightWithSpacing,cimgui),Cfloat,())
end

function igPushIdStr(str_id::Ptr{UInt8})
    ccall((:igPushIdStr,cimgui),Void,(Ptr{UInt8},),str_id)
end

function igPushIdStrRange(str_begin::Ptr{UInt8},str_end::Ptr{UInt8})
    ccall((:igPushIdStrRange,cimgui),Void,(Ptr{UInt8},Ptr{UInt8}),str_begin,str_end)
end

function igPushIdPtr(ptr_id::Ptr{Void})
    ccall((:igPushIdPtr,cimgui),Void,(Ptr{Void},),ptr_id)
end

function igPushIdInt(int_id::Cint)
    ccall((:igPushIdInt,cimgui),Void,(Cint,),int_id)
end

function igPopId()
    ccall((:igPopId,cimgui),Void,())
end

function igGetIdStr(str_id::Ptr{UInt8})
    ccall((:igGetIdStr,cimgui),ImGuiID,(Ptr{UInt8},),str_id)
end

function igGetIdStrRange(str_begin::Ptr{UInt8},str_end::Ptr{UInt8})
    ccall((:igGetIdStrRange,cimgui),ImGuiID,(Ptr{UInt8},Ptr{UInt8}),str_begin,str_end)
end

function igGetIdPtr(ptr_id::Ptr{Void})
    ccall((:igGetIdPtr,cimgui),ImGuiID,(Ptr{Void},),ptr_id)
end

function igTextV(fmt::Ptr{UInt8},args::va_list)
    ccall((:igTextV,cimgui),Void,(Ptr{UInt8},va_list),fmt,args)
end

function igTextColoredV(col::ImVec4,fmt::Ptr{UInt8},args::va_list)
    ccall((:igTextColoredV,cimgui),Void,(ImVec4,Ptr{UInt8},va_list),col,fmt,args)
end

function igTextDisabledV(fmt::Ptr{UInt8},args::va_list)
    ccall((:igTextDisabledV,cimgui),Void,(Ptr{UInt8},va_list),fmt,args)
end

function igTextWrappedV(fmt::Ptr{UInt8},args::va_list)
    ccall((:igTextWrappedV,cimgui),Void,(Ptr{UInt8},va_list),fmt,args)
end

function igTextUnformatted(text::Ptr{UInt8},text_end::Ptr{UInt8})
    ccall((:igTextUnformatted,cimgui),Void,(Ptr{UInt8},Ptr{UInt8}),text,text_end)
end

function igLabelTextV(label::Ptr{UInt8},fmt::Ptr{UInt8},args::va_list)
    ccall((:igLabelTextV,cimgui),Void,(Ptr{UInt8},Ptr{UInt8},va_list),label,fmt,args)
end

function igBullet()
    ccall((:igBullet,cimgui),Void,())
end

function igBulletTextV(fmt::Ptr{UInt8},args::va_list)
    ccall((:igBulletTextV,cimgui),Void,(Ptr{UInt8},va_list),fmt,args)
end

function igButton(label::ASCIIString,size::ImVec2)
    ccall((:igButton,cimgui),bool,(Cstring,ImVec2),label,size)
end

function igSmallButton(label::Ptr{UInt8})
    ccall((:igSmallButton,cimgui),bool,(Ptr{UInt8},),label)
end

function igInvisibleButton(str_id::Ptr{UInt8},size::ImVec2)
    ccall((:igInvisibleButton,cimgui),bool,(Ptr{UInt8},ImVec2),str_id,size)
end

function igImage(user_texture_id::ImTextureID,size::ImVec2,uv0::ImVec2,uv1::ImVec2,tint_col::ImVec4,border_col::ImVec4)
    ccall((:igImage,cimgui),Void,(ImTextureID,ImVec2,ImVec2,ImVec2,ImVec4,ImVec4),user_texture_id,size,uv0,uv1,tint_col,border_col)
end

function igImageButton(user_texture_id::ImTextureID,size::ImVec2,uv0::ImVec2,uv1::ImVec2,frame_padding::Cint,bg_col::ImVec4,tint_col::ImVec4)
    ccall((:igImageButton,cimgui),bool,(ImTextureID,ImVec2,ImVec2,ImVec2,Cint,ImVec4,ImVec4),user_texture_id,size,uv0,uv1,frame_padding,bg_col,tint_col)
end

function igCollapsingHeader(label::Ptr{UInt8},str_id::Ptr{UInt8},display_frame::bool,default_open::bool)
    ccall((:igCollapsingHeader,cimgui),bool,(Ptr{UInt8},Ptr{UInt8},bool,bool),label,str_id,display_frame,default_open)
end

function igCheckbox(label::Ptr{UInt8},v::Ptr{bool})
    ccall((:igCheckbox,cimgui),bool,(Ptr{UInt8},Ptr{bool}),label,v)
end

function igCheckboxFlags(label::Ptr{UInt8},flags::Ptr{UInt32},flags_value::UInt32)
    ccall((:igCheckboxFlags,cimgui),bool,(Ptr{UInt8},Ptr{UInt32},UInt32),label,flags,flags_value)
end

function igRadioButtonBool(label::Ptr{UInt8},active::bool)
    ccall((:igRadioButtonBool,cimgui),bool,(Ptr{UInt8},bool),label,active)
end

function igRadioButton(label::Ptr{UInt8},v::Ptr{Cint},v_button::Cint)
    ccall((:igRadioButton,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cint),label,v,v_button)
end

function igCombo(label::Ptr{UInt8},current_item::Ptr{Cint},items::Ptr{Ptr{UInt8}},items_count::Cint,height_in_items::Cint)
    ccall((:igCombo,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Ptr{Ptr{UInt8}},Cint,Cint),label,current_item,items,items_count,height_in_items)
end

function igCombo2(label::Ptr{UInt8},current_item::Ptr{Cint},items_separated_by_zeros::Ptr{UInt8},height_in_items::Cint)
    ccall((:igCombo2,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Ptr{UInt8},Cint),label,current_item,items_separated_by_zeros,height_in_items)
end

function igCombo3(label::Ptr{UInt8},current_item::Ptr{Cint},items_getter::Ptr{Void},data::Ptr{Void},items_count::Cint,height_in_items::Cint)
    ccall((:igCombo3,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Ptr{Void},Ptr{Void},Cint,Cint),label,current_item,items_getter,data,items_count,height_in_items)
end

function igColorButton(col::ImVec4,small_height::bool,outline_border::bool)
    ccall((:igColorButton,cimgui),bool,(ImVec4,bool,bool),col,small_height,outline_border)
end

function igColorEdit3(label::Ptr{UInt8},col::Ptr{Cfloat})
    ccall((:igColorEdit3,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat}),label,col)
end

function igColorEdit4(label::Ptr{UInt8},col::Ptr{Cfloat},show_alpha::bool)
    ccall((:igColorEdit4,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},bool),label,col,show_alpha)
end

function igColorEditMode(mode::ImGuiColorEditMode)
    ccall((:igColorEditMode,cimgui),Void,(ImGuiColorEditMode,),mode)
end

function igPlotLines(label::Ptr{UInt8},values::Ptr{Cfloat},values_count::Cint,values_offset::Cint,overlay_text::Ptr{UInt8},scale_min::Cfloat,scale_max::Cfloat,graph_size::ImVec2,stride::Cint)
    ccall((:igPlotLines,cimgui),Void,(Ptr{UInt8},Ptr{Cfloat},Cint,Cint,Ptr{UInt8},Cfloat,Cfloat,ImVec2,Cint),label,values,values_count,values_offset,overlay_text,scale_min,scale_max,graph_size,stride)
end

function igPlotLines2(label::Ptr{UInt8},values_getter::Ptr{Void},data::Ptr{Void},values_count::Cint,values_offset::Cint,overlay_text::Ptr{UInt8},scale_min::Cfloat,scale_max::Cfloat,graph_size::ImVec2)
    ccall((:igPlotLines2,cimgui),Void,(Ptr{UInt8},Ptr{Void},Ptr{Void},Cint,Cint,Ptr{UInt8},Cfloat,Cfloat,ImVec2),label,values_getter,data,values_count,values_offset,overlay_text,scale_min,scale_max,graph_size)
end

function igPlotHistogram(label::Ptr{UInt8},values::Ptr{Cfloat},values_count::Cint,values_offset::Cint,overlay_text::Ptr{UInt8},scale_min::Cfloat,scale_max::Cfloat,graph_size::ImVec2,stride::Cint)
    ccall((:igPlotHistogram,cimgui),Void,(Ptr{UInt8},Ptr{Cfloat},Cint,Cint,Ptr{UInt8},Cfloat,Cfloat,ImVec2,Cint),label,values,values_count,values_offset,overlay_text,scale_min,scale_max,graph_size,stride)
end

function igPlotHistogram2(label::Ptr{UInt8},values_getter::Ptr{Void},data::Ptr{Void},values_count::Cint,values_offset::Cint,overlay_text::Ptr{UInt8},scale_min::Cfloat,scale_max::Cfloat,graph_size::ImVec2)
    ccall((:igPlotHistogram2,cimgui),Void,(Ptr{UInt8},Ptr{Void},Ptr{Void},Cint,Cint,Ptr{UInt8},Cfloat,Cfloat,ImVec2),label,values_getter,data,values_count,values_offset,overlay_text,scale_min,scale_max,graph_size)
end

function igProgressBar(fraction::Cfloat,size_arg::Ptr{ImVec2},overlay::Ptr{UInt8})
    ccall((:igProgressBar,cimgui),Void,(Cfloat,Ptr{ImVec2},Ptr{UInt8}),fraction,size_arg,overlay)
end

function igSliderFloat(label::Ptr{UInt8},v::Ptr{Cfloat},v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igSliderFloat,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_min,v_max,display_format,power)
end

function igSliderFloat2(label::Ptr{UInt8},v::Ptr{Cfloat},v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igSliderFloat2,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_min,v_max,display_format,power)
end

function igSliderFloat3(label::Ptr{UInt8},v::Ptr{Cfloat},v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igSliderFloat3,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_min,v_max,display_format,power)
end

function igSliderFloat4(label::Ptr{UInt8},v::Ptr{Cfloat},v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igSliderFloat4,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_min,v_max,display_format,power)
end

function igSliderAngle(label::Ptr{UInt8},v_rad::Ptr{Cfloat},v_degrees_min::Cfloat,v_degrees_max::Cfloat)
    ccall((:igSliderAngle,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat),label,v_rad,v_degrees_min,v_degrees_max)
end

function igSliderInt(label::Ptr{UInt8},v::Ptr{Cint},v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igSliderInt,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cint,Cint,Ptr{UInt8}),label,v,v_min,v_max,display_format)
end

function igSliderInt2(label::Ptr{UInt8},v::Ptr{Cint},v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igSliderInt2,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cint,Cint,Ptr{UInt8}),label,v,v_min,v_max,display_format)
end

function igSliderInt3(label::Ptr{UInt8},v::Ptr{Cint},v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igSliderInt3,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cint,Cint,Ptr{UInt8}),label,v,v_min,v_max,display_format)
end

function igSliderInt4(label::Ptr{UInt8},v::Ptr{Cint},v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igSliderInt4,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cint,Cint,Ptr{UInt8}),label,v,v_min,v_max,display_format)
end

function igVSliderFloat(label::Ptr{UInt8},size::ImVec2,v::Ptr{Cfloat},v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igVSliderFloat,cimgui),bool,(Ptr{UInt8},ImVec2,Ptr{Cfloat},Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,size,v,v_min,v_max,display_format,power)
end

function igVSliderInt(label::Ptr{UInt8},size::ImVec2,v::Ptr{Cint},v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igVSliderInt,cimgui),bool,(Ptr{UInt8},ImVec2,Ptr{Cint},Cint,Cint,Ptr{UInt8}),label,size,v,v_min,v_max,display_format)
end

function igDragFloat(label::Ptr{UInt8},v::Ptr{Cfloat},v_speed::Cfloat,v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igDragFloat,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_speed,v_min,v_max,display_format,power)
end

function igDragFloat2(label::Ptr{UInt8},v::Ptr{Cfloat},v_speed::Cfloat,v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igDragFloat2,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_speed,v_min,v_max,display_format,power)
end

function igDragFloat3(label::Ptr{UInt8},v::Ptr{Cfloat},v_speed::Cfloat,v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igDragFloat3,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_speed,v_min,v_max,display_format,power)
end

function igDragFloat4(label::Ptr{UInt8},v::Ptr{Cfloat},v_speed::Cfloat,v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},power::Cfloat)
    ccall((:igDragFloat4,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Cfloat,Ptr{UInt8},Cfloat),label,v,v_speed,v_min,v_max,display_format,power)
end

function igDragFloatRange2(label::Ptr{UInt8},v_current_min::Ptr{Cfloat},v_current_max::Ptr{Cfloat},v_speed::Cfloat,v_min::Cfloat,v_max::Cfloat,display_format::Ptr{UInt8},display_format_max::Ptr{UInt8},power::Cfloat)
    ccall((:igDragFloatRange2,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Ptr{Cfloat},Cfloat,Cfloat,Cfloat,Ptr{UInt8},Ptr{UInt8},Cfloat),label,v_current_min,v_current_max,v_speed,v_min,v_max,display_format,display_format_max,power)
end

function igDragInt(label::Ptr{UInt8},v::Ptr{Cint},v_speed::Cfloat,v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igDragInt,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cfloat,Cint,Cint,Ptr{UInt8}),label,v,v_speed,v_min,v_max,display_format)
end

function igDragInt2(label::Ptr{UInt8},v::Ptr{Cint},v_speed::Cfloat,v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igDragInt2,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cfloat,Cint,Cint,Ptr{UInt8}),label,v,v_speed,v_min,v_max,display_format)
end

function igDragInt3(label::Ptr{UInt8},v::Ptr{Cint},v_speed::Cfloat,v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igDragInt3,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cfloat,Cint,Cint,Ptr{UInt8}),label,v,v_speed,v_min,v_max,display_format)
end

function igDragInt4(label::Ptr{UInt8},v::Ptr{Cint},v_speed::Cfloat,v_min::Cint,v_max::Cint,display_format::Ptr{UInt8})
    ccall((:igDragInt4,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cfloat,Cint,Cint,Ptr{UInt8}),label,v,v_speed,v_min,v_max,display_format)
end

function igDragIntRange2(label::Ptr{UInt8},v_current_min::Ptr{Cint},v_current_max::Ptr{Cint},v_speed::Cfloat,v_min::Cint,v_max::Cint,display_format::Ptr{UInt8},display_format_max::Ptr{UInt8})
    ccall((:igDragIntRange2,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Ptr{Cint},Cfloat,Cint,Cint,Ptr{UInt8},Ptr{UInt8}),label,v_current_min,v_current_max,v_speed,v_min,v_max,display_format,display_format_max)
end

function igInputText(label::Ptr{UInt8},buf::Ptr{UInt8},buf_size::Csize_t,flags::ImGuiInputTextFlags,callback::ImGuiTextEditCallback,user_data::Ptr{Void})
    ccall((:igInputText,cimgui),bool,(Ptr{UInt8},Ptr{UInt8},Csize_t,ImGuiInputTextFlags,ImGuiTextEditCallback,Ptr{Void}),label,buf,buf_size,flags,callback,user_data)
end

function igInputTextMultiline(label::Ptr{UInt8},buf::Ptr{UInt8},buf_size::Csize_t,size::ImVec2,flags::ImGuiInputTextFlags,callback::ImGuiTextEditCallback,user_data::Ptr{Void})
    ccall((:igInputTextMultiline,cimgui),bool,(Ptr{UInt8},Ptr{UInt8},Csize_t,ImVec2,ImGuiInputTextFlags,ImGuiTextEditCallback,Ptr{Void}),label,buf,buf_size,size,flags,callback,user_data)
end

function igInputFloat(label::Ptr{UInt8},v::Ptr{Cfloat},step::Cfloat,step_fast::Cfloat,decimal_precision::Cint,extra_flags::ImGuiInputTextFlags)
    ccall((:igInputFloat,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cfloat,Cfloat,Cint,ImGuiInputTextFlags),label,v,step,step_fast,decimal_precision,extra_flags)
end

function igInputFloat2(label::Ptr{UInt8},v::Ptr{Cfloat},decimal_precision::Cint,extra_flags::ImGuiInputTextFlags)
    ccall((:igInputFloat2,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cint,ImGuiInputTextFlags),label,v,decimal_precision,extra_flags)
end

function igInputFloat3(label::Ptr{UInt8},v::Ptr{Cfloat},decimal_precision::Cint,extra_flags::ImGuiInputTextFlags)
    ccall((:igInputFloat3,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cint,ImGuiInputTextFlags),label,v,decimal_precision,extra_flags)
end

function igInputFloat4(label::Ptr{UInt8},v::Ptr{Cfloat},decimal_precision::Cint,extra_flags::ImGuiInputTextFlags)
    ccall((:igInputFloat4,cimgui),bool,(Ptr{UInt8},Ptr{Cfloat},Cint,ImGuiInputTextFlags),label,v,decimal_precision,extra_flags)
end

function igInputInt(label::Ptr{UInt8},v::Ptr{Cint},step::Cint,step_fast::Cint,extra_flags::ImGuiInputTextFlags)
    ccall((:igInputInt,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Cint,Cint,ImGuiInputTextFlags),label,v,step,step_fast,extra_flags)
end

function igInputInt2(label::Ptr{UInt8},v::Ptr{Cint},extra_flags::ImGuiInputTextFlags)
    ccall((:igInputInt2,cimgui),bool,(Ptr{UInt8},Ptr{Cint},ImGuiInputTextFlags),label,v,extra_flags)
end

function igInputInt3(label::Ptr{UInt8},v::Ptr{Cint},extra_flags::ImGuiInputTextFlags)
    ccall((:igInputInt3,cimgui),bool,(Ptr{UInt8},Ptr{Cint},ImGuiInputTextFlags),label,v,extra_flags)
end

function igInputInt4(label::Ptr{UInt8},v::Ptr{Cint},extra_flags::ImGuiInputTextFlags)
    ccall((:igInputInt4,cimgui),bool,(Ptr{UInt8},Ptr{Cint},ImGuiInputTextFlags),label,v,extra_flags)
end

function igTreeNode(str_label_id::Ptr{UInt8})
    ccall((:igTreeNode,cimgui),bool,(Ptr{UInt8},),str_label_id)
end

function igTreeNodeStrV(str_id::Ptr{UInt8},fmt::Ptr{UInt8},args::va_list)
    ccall((:igTreeNodeStrV,cimgui),bool,(Ptr{UInt8},Ptr{UInt8},va_list),str_id,fmt,args)
end

function igTreeNodePtrV(ptr_id::Ptr{Void},fmt::Ptr{UInt8},args::va_list)
    ccall((:igTreeNodePtrV,cimgui),bool,(Ptr{Void},Ptr{UInt8},va_list),ptr_id,fmt,args)
end

function igTreePushStr(str_id::Ptr{UInt8})
    ccall((:igTreePushStr,cimgui),Void,(Ptr{UInt8},),str_id)
end

function igTreePushPtr(ptr_id::Ptr{Void})
    ccall((:igTreePushPtr,cimgui),Void,(Ptr{Void},),ptr_id)
end

function igTreePop()
    ccall((:igTreePop,cimgui),Void,())
end

function igSetNextTreeNodeOpened(opened::bool,cond::ImGuiSetCond)
    ccall((:igSetNextTreeNodeOpened,cimgui),Void,(bool,ImGuiSetCond),opened,cond)
end

function igSelectable(label::Ptr{UInt8},selected::bool,flags::ImGuiSelectableFlags,size::ImVec2)
    ccall((:igSelectable,cimgui),bool,(Ptr{UInt8},bool,ImGuiSelectableFlags,ImVec2),label,selected,flags,size)
end

function igSelectableEx(label::Ptr{UInt8},p_selected::Ptr{bool},flags::ImGuiSelectableFlags,size::ImVec2)
    ccall((:igSelectableEx,cimgui),bool,(Ptr{UInt8},Ptr{bool},ImGuiSelectableFlags,ImVec2),label,p_selected,flags,size)
end

function igListBox(label::Ptr{UInt8},current_item::Ptr{Cint},items::Ptr{Ptr{UInt8}},items_count::Cint,height_in_items::Cint)
    ccall((:igListBox,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Ptr{Ptr{UInt8}},Cint,Cint),label,current_item,items,items_count,height_in_items)
end

function igListBox2(label::Ptr{UInt8},current_item::Ptr{Cint},items_getter::Ptr{Void},data::Ptr{Void},items_count::Cint,height_in_items::Cint)
    ccall((:igListBox2,cimgui),bool,(Ptr{UInt8},Ptr{Cint},Ptr{Void},Ptr{Void},Cint,Cint),label,current_item,items_getter,data,items_count,height_in_items)
end

function igListBoxHeader(label::Ptr{UInt8},size::ImVec2)
    ccall((:igListBoxHeader,cimgui),bool,(Ptr{UInt8},ImVec2),label,size)
end

function igListBoxHeader2(label::Ptr{UInt8},items_count::Cint,height_in_items::Cint)
    ccall((:igListBoxHeader2,cimgui),bool,(Ptr{UInt8},Cint,Cint),label,items_count,height_in_items)
end

function igListBoxFooter()
    ccall((:igListBoxFooter,cimgui),Void,())
end

function igValueBool(prefix::Ptr{UInt8},b::bool)
    ccall((:igValueBool,cimgui),Void,(Ptr{UInt8},bool),prefix,b)
end

function igValueInt(prefix::Ptr{UInt8},v::Cint)
    ccall((:igValueInt,cimgui),Void,(Ptr{UInt8},Cint),prefix,v)
end

function igValueUInt(prefix::Ptr{UInt8},v::UInt32)
    ccall((:igValueUInt,cimgui),Void,(Ptr{UInt8},UInt32),prefix,v)
end

function igValueFloat(prefix::Ptr{UInt8},v::Cfloat,float_format::Ptr{UInt8})
    ccall((:igValueFloat,cimgui),Void,(Ptr{UInt8},Cfloat,Ptr{UInt8}),prefix,v,float_format)
end

function igValueColor(prefix::Ptr{UInt8},v::ImVec4)
    ccall((:igValueColor,cimgui),Void,(Ptr{UInt8},ImVec4),prefix,v)
end

function igValueColor2(prefix::Ptr{UInt8},v::UInt32)
    ccall((:igValueColor2,cimgui),Void,(Ptr{UInt8},UInt32),prefix,v)
end

function igSetTooltipV(fmt::Ptr{UInt8},args::va_list)
    ccall((:igSetTooltipV,cimgui),Void,(Ptr{UInt8},va_list),fmt,args)
end

function igBeginTooltip()
    ccall((:igBeginTooltip,cimgui),Void,())
end

function igEndTooltip()
    ccall((:igEndTooltip,cimgui),Void,())
end

function igBeginMainMenuBar()
    ccall((:igBeginMainMenuBar,cimgui),bool,())
end

function igEndMainMenuBar()
    ccall((:igEndMainMenuBar,cimgui),Void,())
end

function igBeginMenuBar()
    ccall((:igBeginMenuBar,cimgui),bool,())
end

function igEndMenuBar()
    ccall((:igEndMenuBar,cimgui),Void,())
end

function igBeginMenu(label::Ptr{UInt8},enabled::bool)
    ccall((:igBeginMenu,cimgui),bool,(Ptr{UInt8},bool),label,enabled)
end

function igEndMenu()
    ccall((:igEndMenu,cimgui),Void,())
end

function igMenuItem(label::Ptr{UInt8},shortcut::Ptr{UInt8},selected::bool,enabled::bool)
    ccall((:igMenuItem,cimgui),bool,(Ptr{UInt8},Ptr{UInt8},bool,bool),label,shortcut,selected,enabled)
end

function igMenuItemPtr(label::Ptr{UInt8},shortcut::Ptr{UInt8},p_selected::Ptr{bool},enabled::bool)
    ccall((:igMenuItemPtr,cimgui),bool,(Ptr{UInt8},Ptr{UInt8},Ptr{bool},bool),label,shortcut,p_selected,enabled)
end

function igOpenPopup(str_id::Ptr{UInt8})
    ccall((:igOpenPopup,cimgui),Void,(Ptr{UInt8},),str_id)
end

function igBeginPopup(str_id::Ptr{UInt8})
    ccall((:igBeginPopup,cimgui),bool,(Ptr{UInt8},),str_id)
end

function igBeginPopupModal(name::Ptr{UInt8},p_opened::Ptr{bool},extra_flags::ImGuiWindowFlags)
    ccall((:igBeginPopupModal,cimgui),bool,(Ptr{UInt8},Ptr{bool},ImGuiWindowFlags),name,p_opened,extra_flags)
end

function igBeginPopupContextItem(str_id::Ptr{UInt8},mouse_button::Cint)
    ccall((:igBeginPopupContextItem,cimgui),bool,(Ptr{UInt8},Cint),str_id,mouse_button)
end

function igBeginPopupContextWindow(also_over_items::bool,str_id::Ptr{UInt8},mouse_button::Cint)
    ccall((:igBeginPopupContextWindow,cimgui),bool,(bool,Ptr{UInt8},Cint),also_over_items,str_id,mouse_button)
end

function igBeginPopupContextVoid(str_id::Ptr{UInt8},mouse_button::Cint)
    ccall((:igBeginPopupContextVoid,cimgui),bool,(Ptr{UInt8},Cint),str_id,mouse_button)
end

function igEndPopup()
    ccall((:igEndPopup,cimgui),Void,())
end

function igCloseCurrentPopup()
    ccall((:igCloseCurrentPopup,cimgui),Void,())
end

function igLogToTTY(max_depth::Cint)
    ccall((:igLogToTTY,cimgui),Void,(Cint,),max_depth)
end

function igLogToFile(max_depth::Cint,filename::Ptr{UInt8})
    ccall((:igLogToFile,cimgui),Void,(Cint,Ptr{UInt8}),max_depth,filename)
end

function igLogToClipboard(max_depth::Cint)
    ccall((:igLogToClipboard,cimgui),Void,(Cint,),max_depth)
end

function igLogFinish()
    ccall((:igLogFinish,cimgui),Void,())
end

function igLogButtons()
    ccall((:igLogButtons,cimgui),Void,())
end

function igIsItemHovered()
    ccall((:igIsItemHovered,cimgui),bool,())
end

function igIsItemHoveredRect()
    ccall((:igIsItemHoveredRect,cimgui),bool,())
end

function igIsItemActive()
    ccall((:igIsItemActive,cimgui),bool,())
end

function igIsItemVisible()
    ccall((:igIsItemVisible,cimgui),bool,())
end

function igIsAnyItemHovered()
    ccall((:igIsAnyItemHovered,cimgui),bool,())
end

function igIsAnyItemActive()
    ccall((:igIsAnyItemActive,cimgui),bool,())
end

function igGetItemRectMin(pOut::Ptr{ImVec2})
    ccall((:igGetItemRectMin,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igGetItemRectMax(pOut::Ptr{ImVec2})
    ccall((:igGetItemRectMax,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igGetItemRectSize(pOut::Ptr{ImVec2})
    ccall((:igGetItemRectSize,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igIsWindowHovered()
    ccall((:igIsWindowHovered,cimgui),bool,())
end

function igIsWindowFocused()
    ccall((:igIsWindowFocused,cimgui),bool,())
end

function igIsRootWindowFocused()
    ccall((:igIsRootWindowFocused,cimgui),bool,())
end

function igIsRootWindowOrAnyChildFocused()
    ccall((:igIsRootWindowOrAnyChildFocused,cimgui),bool,())
end

function igIsRectVisible(item_size::ImVec2)
    ccall((:igIsRectVisible,cimgui),bool,(ImVec2,),item_size)
end

function igIsPosHoveringAnyWindow(pos::ImVec2)
    ccall((:igIsPosHoveringAnyWindow,cimgui),bool,(ImVec2,),pos)
end

function igGetTime()
    ccall((:igGetTime,cimgui),Cfloat,())
end

function igGetFrameCount()
    ccall((:igGetFrameCount,cimgui),Cint,())
end

function igGetStyleColName(idx::ImGuiCol)
    ccall((:igGetStyleColName,cimgui),Ptr{UInt8},(ImGuiCol,),idx)
end

function igCalcItemRectClosestPoint(pOut::Ptr{ImVec2},pos::ImVec2,on_edge::bool,outward::Cfloat)
    ccall((:igCalcItemRectClosestPoint,cimgui),Void,(Ptr{ImVec2},ImVec2,bool,Cfloat),pOut,pos,on_edge,outward)
end

function igCalcTextSize(pOut::Ptr{ImVec2},text::Ptr{UInt8},text_end::Ptr{UInt8},hide_text_after_double_hash::bool,wrap_width::Cfloat)
    ccall((:igCalcTextSize,cimgui),Void,(Ptr{ImVec2},Ptr{UInt8},Ptr{UInt8},bool,Cfloat),pOut,text,text_end,hide_text_after_double_hash,wrap_width)
end

function igCalcListClipping(items_count::Cint,items_height::Cfloat,out_items_display_start::Ptr{Cint},out_items_display_end::Ptr{Cint})
    ccall((:igCalcListClipping,cimgui),Void,(Cint,Cfloat,Ptr{Cint},Ptr{Cint}),items_count,items_height,out_items_display_start,out_items_display_end)
end

function igBeginChildFrame(id::ImGuiID,size::ImVec2,extra_flags::ImGuiWindowFlags)
    ccall((:igBeginChildFrame,cimgui),bool,(ImGuiID,ImVec2,ImGuiWindowFlags),id,size,extra_flags)
end

function igEndChildFrame()
    ccall((:igEndChildFrame,cimgui),Void,())
end

function igColorConvertU32ToFloat4(pOut::Ptr{ImVec4},_in::ImU32)
    ccall((:igColorConvertU32ToFloat4,cimgui),Void,(Ptr{ImVec4},ImU32),pOut,_in)
end

function igColorConvertFloat4ToU32(_in::ImVec4)
    ccall((:igColorConvertFloat4ToU32,cimgui),ImU32,(ImVec4,),_in)
end

function igColorConvertRGBtoHSV(r::Cfloat,g::Cfloat,b::Cfloat,out_h::Ptr{Cfloat},out_s::Ptr{Cfloat},out_v::Ptr{Cfloat})
    ccall((:igColorConvertRGBtoHSV,cimgui),Void,(Cfloat,Cfloat,Cfloat,Ptr{Cfloat},Ptr{Cfloat},Ptr{Cfloat}),r,g,b,out_h,out_s,out_v)
end

function igColorConvertHSVtoRGB(h::Cfloat,s::Cfloat,v::Cfloat,out_r::Ptr{Cfloat},out_g::Ptr{Cfloat},out_b::Ptr{Cfloat})
    ccall((:igColorConvertHSVtoRGB,cimgui),Void,(Cfloat,Cfloat,Cfloat,Ptr{Cfloat},Ptr{Cfloat},Ptr{Cfloat}),h,s,v,out_r,out_g,out_b)
end

function igGetKeyIndex(key::ImGuiKey)
    ccall((:igGetKeyIndex,cimgui),Cint,(ImGuiKey,),key)
end

function igIsKeyDown(key_index::Cint)
    ccall((:igIsKeyDown,cimgui),bool,(Cint,),key_index)
end

function igIsKeyPressed(key_index::Cint,repeat::bool)
    ccall((:igIsKeyPressed,cimgui),bool,(Cint,bool),key_index,repeat)
end

function igIsKeyReleased(key_index::Cint)
    ccall((:igIsKeyReleased,cimgui),bool,(Cint,),key_index)
end

function igIsMouseDown(button::Cint)
    ccall((:igIsMouseDown,cimgui),bool,(Cint,),button)
end

function igIsMouseClicked(button::Cint,repeat::bool)
    ccall((:igIsMouseClicked,cimgui),bool,(Cint,bool),button,repeat)
end

function igIsMouseDoubleClicked(button::Cint)
    ccall((:igIsMouseDoubleClicked,cimgui),bool,(Cint,),button)
end

function igIsMouseReleased(button::Cint)
    ccall((:igIsMouseReleased,cimgui),bool,(Cint,),button)
end

function igIsMouseHoveringWindow()
    ccall((:igIsMouseHoveringWindow,cimgui),bool,())
end

function igIsMouseHoveringAnyWindow()
    ccall((:igIsMouseHoveringAnyWindow,cimgui),bool,())
end

function igIsMouseHoveringRect(pos_min::ImVec2,pos_max::ImVec2,clip::bool)
    ccall((:igIsMouseHoveringRect,cimgui),bool,(ImVec2,ImVec2,bool),pos_min,pos_max,clip)
end

function igIsMouseDragging(button::Cint,lock_threshold::Cfloat)
    ccall((:igIsMouseDragging,cimgui),bool,(Cint,Cfloat),button,lock_threshold)
end

function igGetMousePos(pOut::Ptr{ImVec2})
    ccall((:igGetMousePos,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igGetMousePosOnOpeningCurrentPopup(pOut::Ptr{ImVec2})
    ccall((:igGetMousePosOnOpeningCurrentPopup,cimgui),Void,(Ptr{ImVec2},),pOut)
end

function igGetMouseDragDelta(pOut::Ptr{ImVec2},button::Cint,lock_threshold::Cfloat)
    ccall((:igGetMouseDragDelta,cimgui),Void,(Ptr{ImVec2},Cint,Cfloat),pOut,button,lock_threshold)
end

function igResetMouseDragDelta(button::Cint)
    ccall((:igResetMouseDragDelta,cimgui),Void,(Cint,),button)
end

function igGetMouseCursor()
    ccall((:igGetMouseCursor,cimgui),ImGuiMouseCursor,())
end

function igSetMouseCursor(_type::ImGuiMouseCursor)
    ccall((:igSetMouseCursor,cimgui),Void,(ImGuiMouseCursor,),_type)
end

function igCaptureKeyboardFromApp()
    ccall((:igCaptureKeyboardFromApp,cimgui),Void,())
end

function igCaptureMouseFromApp()
    ccall((:igCaptureMouseFromApp,cimgui),Void,())
end

function igMemAlloc(sz::Csize_t)
    ccall((:igMemAlloc,cimgui),Ptr{Void},(Csize_t,),sz)
end

function igMemFree(ptr::Ptr{Void})
    ccall((:igMemFree,cimgui),Void,(Ptr{Void},),ptr)
end

function igGetClipboardText()
    ccall((:igGetClipboardText,cimgui),Ptr{UInt8},())
end

function igSetClipboardText(text::Ptr{UInt8})
    ccall((:igSetClipboardText,cimgui),Void,(Ptr{UInt8},),text)
end

function igGetVersion()
    ccall((:igGetVersion,cimgui),Ptr{UInt8},())
end

function igGetInternalState()
    ccall((:igGetInternalState,cimgui),Ptr{Void},())
end

function igGetInternalStateSize()
    ccall((:igGetInternalStateSize,cimgui),Csize_t,())
end

function igSetInternalState(state::Ptr{Void},construct::bool)
    ccall((:igSetInternalState,cimgui),Void,(Ptr{Void},bool),state,construct)
end

function ImFontAtlas_GetTexDataAsRGBA32(atlas::Ptr{ImFontAtlas},out_pixels::Ptr{Ptr{Cuchar}},out_width::Ptr{Cint},out_height::Ptr{Cint},out_bytes_per_pixel::Ptr{Cint})
    ccall((:ImFontAtlas_GetTexDataAsRGBA32,cimgui),Void,(Ptr{ImFontAtlas},Ptr{Ptr{Cuchar}},Ptr{Cint},Ptr{Cint},Ptr{Cint}),atlas,out_pixels,out_width,out_height,out_bytes_per_pixel)
end

function ImFontAtlas_GetTexDataAsAlpha8(atlas::Ptr{ImFontAtlas},out_pixels::Ptr{Ptr{Cuchar}},out_width::Ptr{Cint},out_height::Ptr{Cint},out_bytes_per_pixel::Ptr{Cint})
    ccall((:ImFontAtlas_GetTexDataAsAlpha8,cimgui),Void,(Ptr{ImFontAtlas},Ptr{Ptr{Cuchar}},Ptr{Cint},Ptr{Cint},Ptr{Cint}),atlas,out_pixels,out_width,out_height,out_bytes_per_pixel)
end

function ImFontAtlas_SetTexID(atlas::Ptr{ImFontAtlas},tex::Ptr{Void})
    ccall((:ImFontAtlas_SetTexID,cimgui),Void,(Ptr{ImFontAtlas},Ptr{Void}),atlas,tex)
end

function ImFontAtlas_AddFont(atlas::Ptr{ImFontAtlas},font_cfg::Ptr{ImFontConfig})
    ccall((:ImFontAtlas_AddFont,cimgui),Ptr{ImFont},(Ptr{ImFontAtlas},Ptr{ImFontConfig}),atlas,font_cfg)
end

function ImFontAtlas_AddFontDefault(atlas::Ptr{ImFontAtlas},font_cfg::Ptr{ImFontConfig})
    ccall((:ImFontAtlas_AddFontDefault,cimgui),Ptr{ImFont},(Ptr{ImFontAtlas},Ptr{ImFontConfig}),atlas,font_cfg)
end

function ImFontAtlas_AddFontFromFileTTF(atlas::Ptr{ImFontAtlas},filename::Ptr{UInt8},size_pixels::Cfloat,font_cfg::Ptr{ImFontConfig},glyph_ranges::Ptr{ImWchar})
    ccall((:ImFontAtlas_AddFontFromFileTTF,cimgui),Ptr{ImFont},(Ptr{ImFontAtlas},Ptr{UInt8},Cfloat,Ptr{ImFontConfig},Ptr{ImWchar}),atlas,filename,size_pixels,font_cfg,glyph_ranges)
end

function ImFontAtlas_AddFontFromMemoryTTF(atlas::Ptr{ImFontAtlas},ttf_data::Ptr{Void},ttf_size::Cint,size_pixels::Cfloat,font_cfg::Ptr{ImFontConfig},glyph_ranges::Ptr{ImWchar})
    ccall((:ImFontAtlas_AddFontFromMemoryTTF,cimgui),Ptr{ImFont},(Ptr{ImFontAtlas},Ptr{Void},Cint,Cfloat,Ptr{ImFontConfig},Ptr{ImWchar}),atlas,ttf_data,ttf_size,size_pixels,font_cfg,glyph_ranges)
end

function ImFontAtlas_AddFontFromMemoryCompressedTTF(atlas::Ptr{ImFontAtlas},compressed_ttf_data::Ptr{Void},compressed_ttf_size::Cint,size_pixels::Cfloat,font_cfg::Ptr{ImFontConfig},glyph_ranges::Ptr{ImWchar})
    ccall((:ImFontAtlas_AddFontFromMemoryCompressedTTF,cimgui),Ptr{ImFont},(Ptr{ImFontAtlas},Ptr{Void},Cint,Cfloat,Ptr{ImFontConfig},Ptr{ImWchar}),atlas,compressed_ttf_data,compressed_ttf_size,size_pixels,font_cfg,glyph_ranges)
end

function ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(atlas::Ptr{ImFontAtlas},compressed_ttf_data_base85::Ptr{UInt8},size_pixels::Cfloat,font_cfg::Ptr{ImFontConfig},glyph_ranges::Ptr{ImWchar})
    ccall((:ImFontAtlas_AddFontFromMemoryCompressedBase85TTF,cimgui),Ptr{ImFont},(Ptr{ImFontAtlas},Ptr{UInt8},Cfloat,Ptr{ImFontConfig},Ptr{ImWchar}),atlas,compressed_ttf_data_base85,size_pixels,font_cfg,glyph_ranges)
end

function ImFontAtlas_ClearTexData(atlas::Ptr{ImFontAtlas})
    ccall((:ImFontAtlas_ClearTexData,cimgui),Void,(Ptr{ImFontAtlas},),atlas)
end

function ImFontAtlas_Clear(atlas::Ptr{ImFontAtlas})
    ccall((:ImFontAtlas_Clear,cimgui),Void,(Ptr{ImFontAtlas},),atlas)
end

function ImGuiIO_AddInputCharacter(c::UInt16)
    ccall((:ImGuiIO_AddInputCharacter,cimgui),Void,(UInt16,),c)
end

function ImGuiIO_AddInputCharactersUTF8(utf8_chars::Ptr{UInt8})
    ccall((:ImGuiIO_AddInputCharactersUTF8,cimgui),Void,(Ptr{UInt8},),utf8_chars)
end

function ImGuiIO_ClearInputCharacters()
    ccall((:ImGuiIO_ClearInputCharacters,cimgui),Void,())
end

function ImDrawData_DeIndexAllBuffers(drawData::Ptr{ImDrawData})
    ccall((:ImDrawData_DeIndexAllBuffers,cimgui),Void,(Ptr{ImDrawData},),drawData)
end

function ImDrawList_GetVertexBufferSize(list::Ptr{ImDrawList})
    ccall((:ImDrawList_GetVertexBufferSize,cimgui),Cint,(Ptr{ImDrawList},),list)
end

function ImDrawList_GetVertexPtr(list::Ptr{ImDrawList},n::Cint)
    ccall((:ImDrawList_GetVertexPtr,cimgui),Ptr{ImDrawVert},(Ptr{ImDrawList},Cint),list,n)
end

function ImDrawList_GetIndexBufferSize(list::Ptr{ImDrawList})
    ccall((:ImDrawList_GetIndexBufferSize,cimgui),Cint,(Ptr{ImDrawList},),list)
end

function ImDrawList_GetIndexPtr(list::Ptr{ImDrawList},n::Cint)
    ccall((:ImDrawList_GetIndexPtr,cimgui),Ptr{ImDrawIdx},(Ptr{ImDrawList},Cint),list,n)
end

function ImDrawList_GetCmdSize(list::Ptr{ImDrawList})
    ccall((:ImDrawList_GetCmdSize,cimgui),Cint,(Ptr{ImDrawList},),list)
end

function ImDrawList_GetCmdPtr(list::Ptr{ImDrawList},n::Cint)
    ccall((:ImDrawList_GetCmdPtr,cimgui),Ptr{ImDrawCmd},(Ptr{ImDrawList},Cint),list,n)
end

function ImDrawList_Clear(list::Ptr{ImDrawList})
    ccall((:ImDrawList_Clear,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_ClearFreeMemory(list::Ptr{ImDrawList})
    ccall((:ImDrawList_ClearFreeMemory,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_PushClipRect(list::Ptr{ImDrawList},clip_rect::ImVec4)
    ccall((:ImDrawList_PushClipRect,cimgui),Void,(Ptr{ImDrawList},ImVec4),list,clip_rect)
end

function ImDrawList_PushClipRectFullScreen(list::Ptr{ImDrawList})
    ccall((:ImDrawList_PushClipRectFullScreen,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_PopClipRect(list::Ptr{ImDrawList})
    ccall((:ImDrawList_PopClipRect,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_PushTextureID(list::Ptr{ImDrawList},texture_id::ImTextureID)
    ccall((:ImDrawList_PushTextureID,cimgui),Void,(Ptr{ImDrawList},ImTextureID),list,texture_id)
end

function ImDrawList_PopTextureID(list::Ptr{ImDrawList})
    ccall((:ImDrawList_PopTextureID,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_AddLine(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,col::ImU32,thickness::Cfloat)
    ccall((:ImDrawList_AddLine,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32,Cfloat),list,a,b,col,thickness)
end

function ImDrawList_AddRect(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,col::ImU32,rounding::Cfloat,rounding_corners::Cint)
    ccall((:ImDrawList_AddRect,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32,Cfloat,Cint),list,a,b,col,rounding,rounding_corners)
end

function ImDrawList_AddRectFilled(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,col::ImU32,rounding::Cfloat,rounding_corners::Cint)
    ccall((:ImDrawList_AddRectFilled,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32,Cfloat,Cint),list,a,b,col,rounding,rounding_corners)
end

function ImDrawList_AddRectFilledMultiColor(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,col_upr_left::ImU32,col_upr_right::ImU32,col_bot_right::ImU32,col_bot_left::ImU32)
    ccall((:ImDrawList_AddRectFilledMultiColor,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32,ImU32,ImU32,ImU32),list,a,b,col_upr_left,col_upr_right,col_bot_right,col_bot_left)
end

function ImDrawList_AddTriangleFilled(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,c::ImVec2,col::ImU32)
    ccall((:ImDrawList_AddTriangleFilled,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImVec2,ImU32),list,a,b,c,col)
end

function ImDrawList_AddCircle(list::Ptr{ImDrawList},centre::ImVec2,radius::Cfloat,col::ImU32,num_segments::Cint)
    ccall((:ImDrawList_AddCircle,cimgui),Void,(Ptr{ImDrawList},ImVec2,Cfloat,ImU32,Cint),list,centre,radius,col,num_segments)
end

function ImDrawList_AddCircleFilled(list::Ptr{ImDrawList},centre::ImVec2,radius::Cfloat,col::ImU32,num_segments::Cint)
    ccall((:ImDrawList_AddCircleFilled,cimgui),Void,(Ptr{ImDrawList},ImVec2,Cfloat,ImU32,Cint),list,centre,radius,col,num_segments)
end

function ImDrawList_AddText(list::Ptr{ImDrawList},pos::ImVec2,col::ImU32,text_begin::Ptr{UInt8},text_end::Ptr{UInt8})
    ccall((:ImDrawList_AddText,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImU32,Ptr{UInt8},Ptr{UInt8}),list,pos,col,text_begin,text_end)
end

function ImDrawList_AddTextExt(list::Ptr{ImDrawList},font::Ptr{ImFont},font_size::Cfloat,pos::ImVec2,col::ImU32,text_begin::Ptr{UInt8},text_end::Ptr{UInt8},wrap_width::Cfloat,cpu_fine_clip_rect::Ptr{ImVec4})
    ccall((:ImDrawList_AddTextExt,cimgui),Void,(Ptr{ImDrawList},Ptr{ImFont},Cfloat,ImVec2,ImU32,Ptr{UInt8},Ptr{UInt8},Cfloat,Ptr{ImVec4}),list,font,font_size,pos,col,text_begin,text_end,wrap_width,cpu_fine_clip_rect)
end

function ImDrawList_AddImage(list::Ptr{ImDrawList},user_texture_id::ImTextureID,a::ImVec2,b::ImVec2,uv0::ImVec2,uv1::ImVec2,col::ImU32)
    ccall((:ImDrawList_AddImage,cimgui),Void,(Ptr{ImDrawList},ImTextureID,ImVec2,ImVec2,ImVec2,ImVec2,ImU32),list,user_texture_id,a,b,uv0,uv1,col)
end

function ImDrawList_AddPolyline(list::Ptr{ImDrawList},points::Ptr{ImVec2},num_points::Cint,col::ImU32,closed::bool,thickness::Cfloat,anti_aliased::bool)
    ccall((:ImDrawList_AddPolyline,cimgui),Void,(Ptr{ImDrawList},Ptr{ImVec2},Cint,ImU32,bool,Cfloat,bool),list,points,num_points,col,closed,thickness,anti_aliased)
end

function ImDrawList_AddConvexPolyFilled(list::Ptr{ImDrawList},points::Ptr{ImVec2},num_points::Cint,col::ImU32,anti_aliased::bool)
    ccall((:ImDrawList_AddConvexPolyFilled,cimgui),Void,(Ptr{ImDrawList},Ptr{ImVec2},Cint,ImU32,bool),list,points,num_points,col,anti_aliased)
end

function ImDrawList_AddBezierCurve(list::Ptr{ImDrawList},pos0::ImVec2,cp0::ImVec2,cp1::ImVec2,pos1::ImVec2,col::ImU32,thickness::Cfloat,num_segments::Cint)
    ccall((:ImDrawList_AddBezierCurve,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImVec2,ImVec2,ImU32,Cfloat,Cint),list,pos0,cp0,cp1,pos1,col,thickness,num_segments)
end

function ImDrawList_PathClear(list::Ptr{ImDrawList})
    ccall((:ImDrawList_PathClear,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_PathLineTo(list::Ptr{ImDrawList},pos::ImVec2)
    ccall((:ImDrawList_PathLineTo,cimgui),Void,(Ptr{ImDrawList},ImVec2),list,pos)
end

function ImDrawList_PathLineToMergeDuplicate(list::Ptr{ImDrawList},pos::ImVec2)
    ccall((:ImDrawList_PathLineToMergeDuplicate,cimgui),Void,(Ptr{ImDrawList},ImVec2),list,pos)
end

function ImDrawList_PathFill(list::Ptr{ImDrawList},col::ImU32)
    ccall((:ImDrawList_PathFill,cimgui),Void,(Ptr{ImDrawList},ImU32),list,col)
end

function ImDrawList_PathStroke(list::Ptr{ImDrawList},col::ImU32,closed::bool,thickness::Cfloat)
    ccall((:ImDrawList_PathStroke,cimgui),Void,(Ptr{ImDrawList},ImU32,bool,Cfloat),list,col,closed,thickness)
end

function ImDrawList_PathArcTo(list::Ptr{ImDrawList},centre::ImVec2,radius::Cfloat,a_min::Cfloat,a_max::Cfloat,num_segments::Cint)
    ccall((:ImDrawList_PathArcTo,cimgui),Void,(Ptr{ImDrawList},ImVec2,Cfloat,Cfloat,Cfloat,Cint),list,centre,radius,a_min,a_max,num_segments)
end

function ImDrawList_PathArcToFast(list::Ptr{ImDrawList},centre::ImVec2,radius::Cfloat,a_min_of_12::Cint,a_max_of_12::Cint)
    ccall((:ImDrawList_PathArcToFast,cimgui),Void,(Ptr{ImDrawList},ImVec2,Cfloat,Cint,Cint),list,centre,radius,a_min_of_12,a_max_of_12)
end

function ImDrawList_PathBezierCurveTo(list::Ptr{ImDrawList},p1::ImVec2,p2::ImVec2,p3::ImVec2,num_segments::Cint)
    ccall((:ImDrawList_PathBezierCurveTo,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImVec2,Cint),list,p1,p2,p3,num_segments)
end

function ImDrawList_PathRect(list::Ptr{ImDrawList},rect_min::ImVec2,rect_max::ImVec2,rounding::Cfloat,rounding_corners::Cint)
    ccall((:ImDrawList_PathRect,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,Cfloat,Cint),list,rect_min,rect_max,rounding,rounding_corners)
end

function ImDrawList_ChannelsSplit(list::Ptr{ImDrawList},channels_count::Cint)
    ccall((:ImDrawList_ChannelsSplit,cimgui),Void,(Ptr{ImDrawList},Cint),list,channels_count)
end

function ImDrawList_ChannelsMerge(list::Ptr{ImDrawList})
    ccall((:ImDrawList_ChannelsMerge,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_ChannelsSetCurrent(list::Ptr{ImDrawList},channel_index::Cint)
    ccall((:ImDrawList_ChannelsSetCurrent,cimgui),Void,(Ptr{ImDrawList},Cint),list,channel_index)
end

function ImDrawList_AddCallback(list::Ptr{ImDrawList},callback::ImDrawCallback,callback_data::Ptr{Void})
    ccall((:ImDrawList_AddCallback,cimgui),Void,(Ptr{ImDrawList},ImDrawCallback,Ptr{Void}),list,callback,callback_data)
end

function ImDrawList_AddDrawCmd(list::Ptr{ImDrawList})
    ccall((:ImDrawList_AddDrawCmd,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_PrimReserve(list::Ptr{ImDrawList},idx_count::Cint,vtx_count::Cint)
    ccall((:ImDrawList_PrimReserve,cimgui),Void,(Ptr{ImDrawList},Cint,Cint),list,idx_count,vtx_count)
end

function ImDrawList_PrimRect(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,col::ImU32)
    ccall((:ImDrawList_PrimRect,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32),list,a,b,col)
end

function ImDrawList_PrimRectUV(list::Ptr{ImDrawList},a::ImVec2,b::ImVec2,uv_a::ImVec2,uv_b::ImVec2,col::ImU32)
    ccall((:ImDrawList_PrimRectUV,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImVec2,ImVec2,ImU32),list,a,b,uv_a,uv_b,col)
end

function ImDrawList_PrimVtx(list::Ptr{ImDrawList},pos::ImVec2,uv::ImVec2,col::ImU32)
    ccall((:ImDrawList_PrimVtx,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32),list,pos,uv,col)
end

function ImDrawList_PrimWriteVtx(list::Ptr{ImDrawList},pos::ImVec2,uv::ImVec2,col::ImU32)
    ccall((:ImDrawList_PrimWriteVtx,cimgui),Void,(Ptr{ImDrawList},ImVec2,ImVec2,ImU32),list,pos,uv,col)
end

function ImDrawList_PrimWriteIdx(list::Ptr{ImDrawList},idx::ImDrawIdx)
    ccall((:ImDrawList_PrimWriteIdx,cimgui),Void,(Ptr{ImDrawList},ImDrawIdx),list,idx)
end

function ImDrawList_UpdateClipRect(list::Ptr{ImDrawList})
    ccall((:ImDrawList_UpdateClipRect,cimgui),Void,(Ptr{ImDrawList},),list)
end

function ImDrawList_UpdateTextureID(list::Ptr{ImDrawList})
    ccall((:ImDrawList_UpdateTextureID,cimgui),Void,(Ptr{ImDrawList},),list)
end

function setRenderCallback(rc::Function)
    const rrc = cfunction(rc, Void, ())
    ccall((:setRenderCallback,cimgui),Void,(Ptr{Void},),rrc)
end

function setupAll()
    ccall((:setupAll,cimgui),bool,())
end

function mainLoop()
    ccall((:mainLoop,cimgui),Void,())
end

function destroyAll()
    ccall((:destroyAll,cimgui),Void,())
end
