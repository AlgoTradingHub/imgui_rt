# Automatically generated using Clang.jl wrap_c, version 0.0.0

using Compat

const unix = 1
const linux = 1

typealias uintptr_t UInt32
typealias va_list Ptr{UInt8}
typealias size_t UInt32
typealias ptrdiff_t Cint
typealias intptr_t Cint
typealias bool Bool

type ImVec4
    x::Cfloat
    y::Cfloat
    z::Cfloat
    w::Cfloat
end

typealias ImTextureID Ptr{Void}
typealias ImDrawCallback Ptr{Void}

type ImDrawCmd
    ElemCount::UInt32
    ClipRect::ImVec4
    TextureId::ImTextureID
    UserCallback::ImDrawCallback
end

type ImDrawList
end

type ImDrawData
    Valid::bool
    CmdLists::Ptr{Ptr{ImDrawList}}
    CmdListsCount::Cint
    TotalVtxCount::Cint
    TotalIdxCount::Cint
end

type ImVec2
    x::Cfloat
    y::Cfloat
end

typealias ImWchar UInt16

immutable Array_32_UInt8
    d1::UInt8
    d2::UInt8
    d3::UInt8
    d4::UInt8
    d5::UInt8
    d6::UInt8
    d7::UInt8
    d8::UInt8
    d9::UInt8
    d10::UInt8
    d11::UInt8
    d12::UInt8
    d13::UInt8
    d14::UInt8
    d15::UInt8
    d16::UInt8
    d17::UInt8
    d18::UInt8
    d19::UInt8
    d20::UInt8
    d21::UInt8
    d22::UInt8
    d23::UInt8
    d24::UInt8
    d25::UInt8
    d26::UInt8
    d27::UInt8
    d28::UInt8
    d29::UInt8
    d30::UInt8
    d31::UInt8
    d32::UInt8
end

zero(::Type{Array_32_UInt8}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_32_UInt8(fill(zero(UInt8),32)...)
    end

type ImFont
    FontSize::Cfloat
    Scale::Cfloat
    DisplayOffset::ImVec2
    FallbackChar::ImWchar
    ConfigData::Ptr{Cint} #Ptr{ImFontConfig} TODO fix circular decl
    ConfigDataCount::Cint
    Ascent::Cfloat
    Descent::Cfloat
    ContainerAtlas::Ptr{Cint} #Ptr{ImFontAtlas}
end

type ImFontConfig
    FontData::Ptr{Void}
    FontDataSize::Cint
    FontDataOwnedByAtlas::bool
    FontNo::Cint
    SizePixels::Cfloat
    OversampleH::Cint
    OversampleV::Cint
    PixelSnapH::bool
    GlyphExtraSpacing::ImVec2
    GlyphRanges::Ptr{ImWchar}
    MergeMode::bool
    MergeGlyphCenterV::bool
    Name::Array_32_UInt8
    DstFont::Ptr{ImFont}
end

type ImFontAtlas
end



type ImColor
    Value::ImVec4
end

immutable Array_19_Cint
    d1::Cint
    d2::Cint
    d3::Cint
    d4::Cint
    d5::Cint
    d6::Cint
    d7::Cint
    d8::Cint
    d9::Cint
    d10::Cint
    d11::Cint
    d12::Cint
    d13::Cint
    d14::Cint
    d15::Cint
    d16::Cint
    d17::Cint
    d18::Cint
    d19::Cint
end

zero(::Type{Array_19_Cint}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_19_Cint(fill(zero(Cint),19)...)
    end

immutable Array_5_bool
    d1::bool
    d2::bool
    d3::bool
    d4::bool
    d5::bool
end

zero(::Type{Array_5_bool}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_5_bool(fill(zero(bool),5)...)
    end

immutable Array_512_bool
    d1::bool
    d2::bool
    d3::bool
    d4::bool
    d5::bool
    d6::bool
    d7::bool
    d8::bool
    d9::bool
    d10::bool
    d11::bool
    d12::bool
    d13::bool
    d14::bool
    d15::bool
    d16::bool
    d17::bool
    d18::bool
    d19::bool
    d20::bool
    d21::bool
    d22::bool
    d23::bool
    d24::bool
    d25::bool
    d26::bool
    d27::bool
    d28::bool
    d29::bool
    d30::bool
    d31::bool
    d32::bool
    d33::bool
    d34::bool
    d35::bool
    d36::bool
    d37::bool
    d38::bool
    d39::bool
    d40::bool
    d41::bool
    d42::bool
    d43::bool
    d44::bool
    d45::bool
    d46::bool
    d47::bool
    d48::bool
    d49::bool
    d50::bool
    d51::bool
    d52::bool
    d53::bool
    d54::bool
    d55::bool
    d56::bool
    d57::bool
    d58::bool
    d59::bool
    d60::bool
    d61::bool
    d62::bool
    d63::bool
    d64::bool
    d65::bool
    d66::bool
    d67::bool
    d68::bool
    d69::bool
    d70::bool
    d71::bool
    d72::bool
    d73::bool
    d74::bool
    d75::bool
    d76::bool
    d77::bool
    d78::bool
    d79::bool
    d80::bool
    d81::bool
    d82::bool
    d83::bool
    d84::bool
    d85::bool
    d86::bool
    d87::bool
    d88::bool
    d89::bool
    d90::bool
    d91::bool
    d92::bool
    d93::bool
    d94::bool
    d95::bool
    d96::bool
    d97::bool
    d98::bool
    d99::bool
    d100::bool
    d101::bool
    d102::bool
    d103::bool
    d104::bool
    d105::bool
    d106::bool
    d107::bool
    d108::bool
    d109::bool
    d110::bool
    d111::bool
    d112::bool
    d113::bool
    d114::bool
    d115::bool
    d116::bool
    d117::bool
    d118::bool
    d119::bool
    d120::bool
    d121::bool
    d122::bool
    d123::bool
    d124::bool
    d125::bool
    d126::bool
    d127::bool
    d128::bool
    d129::bool
    d130::bool
    d131::bool
    d132::bool
    d133::bool
    d134::bool
    d135::bool
    d136::bool
    d137::bool
    d138::bool
    d139::bool
    d140::bool
    d141::bool
    d142::bool
    d143::bool
    d144::bool
    d145::bool
    d146::bool
    d147::bool
    d148::bool
    d149::bool
    d150::bool
    d151::bool
    d152::bool
    d153::bool
    d154::bool
    d155::bool
    d156::bool
    d157::bool
    d158::bool
    d159::bool
    d160::bool
    d161::bool
    d162::bool
    d163::bool
    d164::bool
    d165::bool
    d166::bool
    d167::bool
    d168::bool
    d169::bool
    d170::bool
    d171::bool
    d172::bool
    d173::bool
    d174::bool
    d175::bool
    d176::bool
    d177::bool
    d178::bool
    d179::bool
    d180::bool
    d181::bool
    d182::bool
    d183::bool
    d184::bool
    d185::bool
    d186::bool
    d187::bool
    d188::bool
    d189::bool
    d190::bool
    d191::bool
    d192::bool
    d193::bool
    d194::bool
    d195::bool
    d196::bool
    d197::bool
    d198::bool
    d199::bool
    d200::bool
    d201::bool
    d202::bool
    d203::bool
    d204::bool
    d205::bool
    d206::bool
    d207::bool
    d208::bool
    d209::bool
    d210::bool
    d211::bool
    d212::bool
    d213::bool
    d214::bool
    d215::bool
    d216::bool
    d217::bool
    d218::bool
    d219::bool
    d220::bool
    d221::bool
    d222::bool
    d223::bool
    d224::bool
    d225::bool
    d226::bool
    d227::bool
    d228::bool
    d229::bool
    d230::bool
    d231::bool
    d232::bool
    d233::bool
    d234::bool
    d235::bool
    d236::bool
    d237::bool
    d238::bool
    d239::bool
    d240::bool
    d241::bool
    d242::bool
    d243::bool
    d244::bool
    d245::bool
    d246::bool
    d247::bool
    d248::bool
    d249::bool
    d250::bool
    d251::bool
    d252::bool
    d253::bool
    d254::bool
    d255::bool
    d256::bool
    d257::bool
    d258::bool
    d259::bool
    d260::bool
    d261::bool
    d262::bool
    d263::bool
    d264::bool
    d265::bool
    d266::bool
    d267::bool
    d268::bool
    d269::bool
    d270::bool
    d271::bool
    d272::bool
    d273::bool
    d274::bool
    d275::bool
    d276::bool
    d277::bool
    d278::bool
    d279::bool
    d280::bool
    d281::bool
    d282::bool
    d283::bool
    d284::bool
    d285::bool
    d286::bool
    d287::bool
    d288::bool
    d289::bool
    d290::bool
    d291::bool
    d292::bool
    d293::bool
    d294::bool
    d295::bool
    d296::bool
    d297::bool
    d298::bool
    d299::bool
    d300::bool
    d301::bool
    d302::bool
    d303::bool
    d304::bool
    d305::bool
    d306::bool
    d307::bool
    d308::bool
    d309::bool
    d310::bool
    d311::bool
    d312::bool
    d313::bool
    d314::bool
    d315::bool
    d316::bool
    d317::bool
    d318::bool
    d319::bool
    d320::bool
    d321::bool
    d322::bool
    d323::bool
    d324::bool
    d325::bool
    d326::bool
    d327::bool
    d328::bool
    d329::bool
    d330::bool
    d331::bool
    d332::bool
    d333::bool
    d334::bool
    d335::bool
    d336::bool
    d337::bool
    d338::bool
    d339::bool
    d340::bool
    d341::bool
    d342::bool
    d343::bool
    d344::bool
    d345::bool
    d346::bool
    d347::bool
    d348::bool
    d349::bool
    d350::bool
    d351::bool
    d352::bool
    d353::bool
    d354::bool
    d355::bool
    d356::bool
    d357::bool
    d358::bool
    d359::bool
    d360::bool
    d361::bool
    d362::bool
    d363::bool
    d364::bool
    d365::bool
    d366::bool
    d367::bool
    d368::bool
    d369::bool
    d370::bool
    d371::bool
    d372::bool
    d373::bool
    d374::bool
    d375::bool
    d376::bool
    d377::bool
    d378::bool
    d379::bool
    d380::bool
    d381::bool
    d382::bool
    d383::bool
    d384::bool
    d385::bool
    d386::bool
    d387::bool
    d388::bool
    d389::bool
    d390::bool
    d391::bool
    d392::bool
    d393::bool
    d394::bool
    d395::bool
    d396::bool
    d397::bool
    d398::bool
    d399::bool
    d400::bool
    d401::bool
    d402::bool
    d403::bool
    d404::bool
    d405::bool
    d406::bool
    d407::bool
    d408::bool
    d409::bool
    d410::bool
    d411::bool
    d412::bool
    d413::bool
    d414::bool
    d415::bool
    d416::bool
    d417::bool
    d418::bool
    d419::bool
    d420::bool
    d421::bool
    d422::bool
    d423::bool
    d424::bool
    d425::bool
    d426::bool
    d427::bool
    d428::bool
    d429::bool
    d430::bool
    d431::bool
    d432::bool
    d433::bool
    d434::bool
    d435::bool
    d436::bool
    d437::bool
    d438::bool
    d439::bool
    d440::bool
    d441::bool
    d442::bool
    d443::bool
    d444::bool
    d445::bool
    d446::bool
    d447::bool
    d448::bool
    d449::bool
    d450::bool
    d451::bool
    d452::bool
    d453::bool
    d454::bool
    d455::bool
    d456::bool
    d457::bool
    d458::bool
    d459::bool
    d460::bool
    d461::bool
    d462::bool
    d463::bool
    d464::bool
    d465::bool
    d466::bool
    d467::bool
    d468::bool
    d469::bool
    d470::bool
    d471::bool
    d472::bool
    d473::bool
    d474::bool
    d475::bool
    d476::bool
    d477::bool
    d478::bool
    d479::bool
    d480::bool
    d481::bool
    d482::bool
    d483::bool
    d484::bool
    d485::bool
    d486::bool
    d487::bool
    d488::bool
    d489::bool
    d490::bool
    d491::bool
    d492::bool
    d493::bool
    d494::bool
    d495::bool
    d496::bool
    d497::bool
    d498::bool
    d499::bool
    d500::bool
    d501::bool
    d502::bool
    d503::bool
    d504::bool
    d505::bool
    d506::bool
    d507::bool
    d508::bool
    d509::bool
    d510::bool
    d511::bool
    d512::bool
end

zero(::Type{Array_512_bool}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_512_bool(fill(zero(bool),512)...)
    end

immutable Array_17_ImWchar
    d1::ImWchar
    d2::ImWchar
    d3::ImWchar
    d4::ImWchar
    d5::ImWchar
    d6::ImWchar
    d7::ImWchar
    d8::ImWchar
    d9::ImWchar
    d10::ImWchar
    d11::ImWchar
    d12::ImWchar
    d13::ImWchar
    d14::ImWchar
    d15::ImWchar
    d16::ImWchar
    d17::ImWchar
end

zero(::Type{Array_17_ImWchar}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_17_ImWchar(fill(zero(ImWchar),17)...)
    end

immutable Array_5_ImVec2
    d1::ImVec2
    d2::ImVec2
    d3::ImVec2
    d4::ImVec2
    d5::ImVec2
end

zero(::Type{Array_5_ImVec2}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_5_ImVec2(fill(zero(ImVec2),5)...)
    end

immutable Array_5_Cfloat
    d1::Cfloat
    d2::Cfloat
    d3::Cfloat
    d4::Cfloat
    d5::Cfloat
end

zero(::Type{Array_5_Cfloat}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_5_Cfloat(fill(zero(Cfloat),5)...)
    end

immutable Array_512_Cfloat
    d1::Cfloat
    d2::Cfloat
    d3::Cfloat
    d4::Cfloat
    d5::Cfloat
    d6::Cfloat
    d7::Cfloat
    d8::Cfloat
    d9::Cfloat
    d10::Cfloat
    d11::Cfloat
    d12::Cfloat
    d13::Cfloat
    d14::Cfloat
    d15::Cfloat
    d16::Cfloat
    d17::Cfloat
    d18::Cfloat
    d19::Cfloat
    d20::Cfloat
    d21::Cfloat
    d22::Cfloat
    d23::Cfloat
    d24::Cfloat
    d25::Cfloat
    d26::Cfloat
    d27::Cfloat
    d28::Cfloat
    d29::Cfloat
    d30::Cfloat
    d31::Cfloat
    d32::Cfloat
    d33::Cfloat
    d34::Cfloat
    d35::Cfloat
    d36::Cfloat
    d37::Cfloat
    d38::Cfloat
    d39::Cfloat
    d40::Cfloat
    d41::Cfloat
    d42::Cfloat
    d43::Cfloat
    d44::Cfloat
    d45::Cfloat
    d46::Cfloat
    d47::Cfloat
    d48::Cfloat
    d49::Cfloat
    d50::Cfloat
    d51::Cfloat
    d52::Cfloat
    d53::Cfloat
    d54::Cfloat
    d55::Cfloat
    d56::Cfloat
    d57::Cfloat
    d58::Cfloat
    d59::Cfloat
    d60::Cfloat
    d61::Cfloat
    d62::Cfloat
    d63::Cfloat
    d64::Cfloat
    d65::Cfloat
    d66::Cfloat
    d67::Cfloat
    d68::Cfloat
    d69::Cfloat
    d70::Cfloat
    d71::Cfloat
    d72::Cfloat
    d73::Cfloat
    d74::Cfloat
    d75::Cfloat
    d76::Cfloat
    d77::Cfloat
    d78::Cfloat
    d79::Cfloat
    d80::Cfloat
    d81::Cfloat
    d82::Cfloat
    d83::Cfloat
    d84::Cfloat
    d85::Cfloat
    d86::Cfloat
    d87::Cfloat
    d88::Cfloat
    d89::Cfloat
    d90::Cfloat
    d91::Cfloat
    d92::Cfloat
    d93::Cfloat
    d94::Cfloat
    d95::Cfloat
    d96::Cfloat
    d97::Cfloat
    d98::Cfloat
    d99::Cfloat
    d100::Cfloat
    d101::Cfloat
    d102::Cfloat
    d103::Cfloat
    d104::Cfloat
    d105::Cfloat
    d106::Cfloat
    d107::Cfloat
    d108::Cfloat
    d109::Cfloat
    d110::Cfloat
    d111::Cfloat
    d112::Cfloat
    d113::Cfloat
    d114::Cfloat
    d115::Cfloat
    d116::Cfloat
    d117::Cfloat
    d118::Cfloat
    d119::Cfloat
    d120::Cfloat
    d121::Cfloat
    d122::Cfloat
    d123::Cfloat
    d124::Cfloat
    d125::Cfloat
    d126::Cfloat
    d127::Cfloat
    d128::Cfloat
    d129::Cfloat
    d130::Cfloat
    d131::Cfloat
    d132::Cfloat
    d133::Cfloat
    d134::Cfloat
    d135::Cfloat
    d136::Cfloat
    d137::Cfloat
    d138::Cfloat
    d139::Cfloat
    d140::Cfloat
    d141::Cfloat
    d142::Cfloat
    d143::Cfloat
    d144::Cfloat
    d145::Cfloat
    d146::Cfloat
    d147::Cfloat
    d148::Cfloat
    d149::Cfloat
    d150::Cfloat
    d151::Cfloat
    d152::Cfloat
    d153::Cfloat
    d154::Cfloat
    d155::Cfloat
    d156::Cfloat
    d157::Cfloat
    d158::Cfloat
    d159::Cfloat
    d160::Cfloat
    d161::Cfloat
    d162::Cfloat
    d163::Cfloat
    d164::Cfloat
    d165::Cfloat
    d166::Cfloat
    d167::Cfloat
    d168::Cfloat
    d169::Cfloat
    d170::Cfloat
    d171::Cfloat
    d172::Cfloat
    d173::Cfloat
    d174::Cfloat
    d175::Cfloat
    d176::Cfloat
    d177::Cfloat
    d178::Cfloat
    d179::Cfloat
    d180::Cfloat
    d181::Cfloat
    d182::Cfloat
    d183::Cfloat
    d184::Cfloat
    d185::Cfloat
    d186::Cfloat
    d187::Cfloat
    d188::Cfloat
    d189::Cfloat
    d190::Cfloat
    d191::Cfloat
    d192::Cfloat
    d193::Cfloat
    d194::Cfloat
    d195::Cfloat
    d196::Cfloat
    d197::Cfloat
    d198::Cfloat
    d199::Cfloat
    d200::Cfloat
    d201::Cfloat
    d202::Cfloat
    d203::Cfloat
    d204::Cfloat
    d205::Cfloat
    d206::Cfloat
    d207::Cfloat
    d208::Cfloat
    d209::Cfloat
    d210::Cfloat
    d211::Cfloat
    d212::Cfloat
    d213::Cfloat
    d214::Cfloat
    d215::Cfloat
    d216::Cfloat
    d217::Cfloat
    d218::Cfloat
    d219::Cfloat
    d220::Cfloat
    d221::Cfloat
    d222::Cfloat
    d223::Cfloat
    d224::Cfloat
    d225::Cfloat
    d226::Cfloat
    d227::Cfloat
    d228::Cfloat
    d229::Cfloat
    d230::Cfloat
    d231::Cfloat
    d232::Cfloat
    d233::Cfloat
    d234::Cfloat
    d235::Cfloat
    d236::Cfloat
    d237::Cfloat
    d238::Cfloat
    d239::Cfloat
    d240::Cfloat
    d241::Cfloat
    d242::Cfloat
    d243::Cfloat
    d244::Cfloat
    d245::Cfloat
    d246::Cfloat
    d247::Cfloat
    d248::Cfloat
    d249::Cfloat
    d250::Cfloat
    d251::Cfloat
    d252::Cfloat
    d253::Cfloat
    d254::Cfloat
    d255::Cfloat
    d256::Cfloat
    d257::Cfloat
    d258::Cfloat
    d259::Cfloat
    d260::Cfloat
    d261::Cfloat
    d262::Cfloat
    d263::Cfloat
    d264::Cfloat
    d265::Cfloat
    d266::Cfloat
    d267::Cfloat
    d268::Cfloat
    d269::Cfloat
    d270::Cfloat
    d271::Cfloat
    d272::Cfloat
    d273::Cfloat
    d274::Cfloat
    d275::Cfloat
    d276::Cfloat
    d277::Cfloat
    d278::Cfloat
    d279::Cfloat
    d280::Cfloat
    d281::Cfloat
    d282::Cfloat
    d283::Cfloat
    d284::Cfloat
    d285::Cfloat
    d286::Cfloat
    d287::Cfloat
    d288::Cfloat
    d289::Cfloat
    d290::Cfloat
    d291::Cfloat
    d292::Cfloat
    d293::Cfloat
    d294::Cfloat
    d295::Cfloat
    d296::Cfloat
    d297::Cfloat
    d298::Cfloat
    d299::Cfloat
    d300::Cfloat
    d301::Cfloat
    d302::Cfloat
    d303::Cfloat
    d304::Cfloat
    d305::Cfloat
    d306::Cfloat
    d307::Cfloat
    d308::Cfloat
    d309::Cfloat
    d310::Cfloat
    d311::Cfloat
    d312::Cfloat
    d313::Cfloat
    d314::Cfloat
    d315::Cfloat
    d316::Cfloat
    d317::Cfloat
    d318::Cfloat
    d319::Cfloat
    d320::Cfloat
    d321::Cfloat
    d322::Cfloat
    d323::Cfloat
    d324::Cfloat
    d325::Cfloat
    d326::Cfloat
    d327::Cfloat
    d328::Cfloat
    d329::Cfloat
    d330::Cfloat
    d331::Cfloat
    d332::Cfloat
    d333::Cfloat
    d334::Cfloat
    d335::Cfloat
    d336::Cfloat
    d337::Cfloat
    d338::Cfloat
    d339::Cfloat
    d340::Cfloat
    d341::Cfloat
    d342::Cfloat
    d343::Cfloat
    d344::Cfloat
    d345::Cfloat
    d346::Cfloat
    d347::Cfloat
    d348::Cfloat
    d349::Cfloat
    d350::Cfloat
    d351::Cfloat
    d352::Cfloat
    d353::Cfloat
    d354::Cfloat
    d355::Cfloat
    d356::Cfloat
    d357::Cfloat
    d358::Cfloat
    d359::Cfloat
    d360::Cfloat
    d361::Cfloat
    d362::Cfloat
    d363::Cfloat
    d364::Cfloat
    d365::Cfloat
    d366::Cfloat
    d367::Cfloat
    d368::Cfloat
    d369::Cfloat
    d370::Cfloat
    d371::Cfloat
    d372::Cfloat
    d373::Cfloat
    d374::Cfloat
    d375::Cfloat
    d376::Cfloat
    d377::Cfloat
    d378::Cfloat
    d379::Cfloat
    d380::Cfloat
    d381::Cfloat
    d382::Cfloat
    d383::Cfloat
    d384::Cfloat
    d385::Cfloat
    d386::Cfloat
    d387::Cfloat
    d388::Cfloat
    d389::Cfloat
    d390::Cfloat
    d391::Cfloat
    d392::Cfloat
    d393::Cfloat
    d394::Cfloat
    d395::Cfloat
    d396::Cfloat
    d397::Cfloat
    d398::Cfloat
    d399::Cfloat
    d400::Cfloat
    d401::Cfloat
    d402::Cfloat
    d403::Cfloat
    d404::Cfloat
    d405::Cfloat
    d406::Cfloat
    d407::Cfloat
    d408::Cfloat
    d409::Cfloat
    d410::Cfloat
    d411::Cfloat
    d412::Cfloat
    d413::Cfloat
    d414::Cfloat
    d415::Cfloat
    d416::Cfloat
    d417::Cfloat
    d418::Cfloat
    d419::Cfloat
    d420::Cfloat
    d421::Cfloat
    d422::Cfloat
    d423::Cfloat
    d424::Cfloat
    d425::Cfloat
    d426::Cfloat
    d427::Cfloat
    d428::Cfloat
    d429::Cfloat
    d430::Cfloat
    d431::Cfloat
    d432::Cfloat
    d433::Cfloat
    d434::Cfloat
    d435::Cfloat
    d436::Cfloat
    d437::Cfloat
    d438::Cfloat
    d439::Cfloat
    d440::Cfloat
    d441::Cfloat
    d442::Cfloat
    d443::Cfloat
    d444::Cfloat
    d445::Cfloat
    d446::Cfloat
    d447::Cfloat
    d448::Cfloat
    d449::Cfloat
    d450::Cfloat
    d451::Cfloat
    d452::Cfloat
    d453::Cfloat
    d454::Cfloat
    d455::Cfloat
    d456::Cfloat
    d457::Cfloat
    d458::Cfloat
    d459::Cfloat
    d460::Cfloat
    d461::Cfloat
    d462::Cfloat
    d463::Cfloat
    d464::Cfloat
    d465::Cfloat
    d466::Cfloat
    d467::Cfloat
    d468::Cfloat
    d469::Cfloat
    d470::Cfloat
    d471::Cfloat
    d472::Cfloat
    d473::Cfloat
    d474::Cfloat
    d475::Cfloat
    d476::Cfloat
    d477::Cfloat
    d478::Cfloat
    d479::Cfloat
    d480::Cfloat
    d481::Cfloat
    d482::Cfloat
    d483::Cfloat
    d484::Cfloat
    d485::Cfloat
    d486::Cfloat
    d487::Cfloat
    d488::Cfloat
    d489::Cfloat
    d490::Cfloat
    d491::Cfloat
    d492::Cfloat
    d493::Cfloat
    d494::Cfloat
    d495::Cfloat
    d496::Cfloat
    d497::Cfloat
    d498::Cfloat
    d499::Cfloat
    d500::Cfloat
    d501::Cfloat
    d502::Cfloat
    d503::Cfloat
    d504::Cfloat
    d505::Cfloat
    d506::Cfloat
    d507::Cfloat
    d508::Cfloat
    d509::Cfloat
    d510::Cfloat
    d511::Cfloat
    d512::Cfloat
end

zero(::Type{Array_512_Cfloat}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_512_Cfloat(fill(zero(Cfloat),512)...)
    end

type ImGuiIO
    DisplaySize::ImVec2
    DeltaTime::Cfloat
    IniSavingRate::Cfloat
    IniFilename::Ptr{UInt8}
    LogFilename::Ptr{UInt8}
    MouseDoubleClickTime::Cfloat
    MouseDoubleClickMaxDist::Cfloat
    MouseDragThreshold::Cfloat
    KeyMap::Array_19_Cint
    KeyRepeatDelay::Cfloat
    KeyRepeatRate::Cfloat
    UserData::Ptr{Void}
    Fonts::Ptr{ImFontAtlas}
    FontGlobalScale::Cfloat
    FontAllowUserScaling::bool
    DisplayFramebufferScale::ImVec2
    DisplayVisibleMin::ImVec2
    DisplayVisibleMax::ImVec2
    RenderDrawListsFn::Ptr{Void}
    GetClipboardTextFn::Ptr{Void}
    SetClipboardTextFn::Ptr{Void}
    MemAllocFn::Ptr{Void}
    MemFreeFn::Ptr{Void}
    ImeSetInputScreenPosFn::Ptr{Void}
    ImeWindowHandle::Ptr{Void}
    MousePos::ImVec2
    MouseDown::Array_5_bool
    MouseWheel::Cfloat
    MouseDrawCursor::bool
    KeyCtrl::bool
    KeyShift::bool
    KeyAlt::bool
    KeysDown::Array_512_bool
    InputCharacters::Array_17_ImWchar
    WantCaptureMouse::bool
    WantCaptureKeyboard::bool
    WantTextInput::bool
    Framerate::Cfloat
    MetricsAllocs::Cint
    MetricsRenderVertices::Cint
    MetricsRenderIndices::Cint
    MetricsActiveWindows::Cint
    MousePosPrev::ImVec2
    MouseDelta::ImVec2
    MouseClicked::Array_5_bool
    MouseClickedPos::Array_5_ImVec2
    MouseClickedTime::Array_5_Cfloat
    MouseDoubleClicked::Array_5_bool
    MouseReleased::Array_5_bool
    MouseDownOwned::Array_5_bool
    MouseDownDuration::Array_5_Cfloat
    MouseDownDurationPrev::Array_5_Cfloat
    MouseDragMaxDistanceSqr::Array_5_Cfloat
    KeysDownDuration::Array_512_Cfloat
    KeysDownDurationPrev::Array_512_Cfloat
end

type ImGuiStorage
end

typealias ImGuiAlign Cint

immutable Array_43_ImVec4
    d1::ImVec4
    d2::ImVec4
    d3::ImVec4
    d4::ImVec4
    d5::ImVec4
    d6::ImVec4
    d7::ImVec4
    d8::ImVec4
    d9::ImVec4
    d10::ImVec4
    d11::ImVec4
    d12::ImVec4
    d13::ImVec4
    d14::ImVec4
    d15::ImVec4
    d16::ImVec4
    d17::ImVec4
    d18::ImVec4
    d19::ImVec4
    d20::ImVec4
    d21::ImVec4
    d22::ImVec4
    d23::ImVec4
    d24::ImVec4
    d25::ImVec4
    d26::ImVec4
    d27::ImVec4
    d28::ImVec4
    d29::ImVec4
    d30::ImVec4
    d31::ImVec4
    d32::ImVec4
    d33::ImVec4
    d34::ImVec4
    d35::ImVec4
    d36::ImVec4
    d37::ImVec4
    d38::ImVec4
    d39::ImVec4
    d40::ImVec4
    d41::ImVec4
    d42::ImVec4
    d43::ImVec4
end

zero(::Type{Array_43_ImVec4}) = begin  # /home/oleksandr/.julia/v0.5/Clang/src/wrap_c.jl, line 266:
        Array_43_ImVec4(fill(zero(ImVec4),43)...)
    end

type ImGuiStyle
    Alpha::Cfloat
    WindowPadding::ImVec2
    WindowMinSize::ImVec2
    WindowRounding::Cfloat
    WindowTitleAlign::ImGuiAlign
    ChildWindowRounding::Cfloat
    FramePadding::ImVec2
    FrameRounding::Cfloat
    ItemSpacing::ImVec2
    ItemInnerSpacing::ImVec2
    TouchExtraPadding::ImVec2
    WindowFillAlphaDefault::Cfloat
    IndentSpacing::Cfloat
    ColumnsMinSpacing::Cfloat
    ScrollbarSize::Cfloat
    ScrollbarRounding::Cfloat
    GrabMinSize::Cfloat
    GrabRounding::Cfloat
    DisplayWindowPadding::ImVec2
    DisplaySafeAreaPadding::ImVec2
    AntiAliasedLines::bool
    AntiAliasedShapes::bool
    CurveTessellationTol::Cfloat
    Colors::Array_43_ImVec4
end

typealias ImU32 UInt32
typealias ImGuiID ImU32
typealias ImGuiCol Cint
typealias ImGuiStyleVar Cint
typealias ImGuiKey Cint
typealias ImGuiColorEditMode Cint
typealias ImGuiMouseCursor Cint
typealias ImGuiWindowFlags Cint
typealias ImGuiSetCond Cint
typealias ImGuiInputTextFlags Cint
typealias ImGuiSelectableFlags Cint

type ImGuiTextEditCallbackData
    EventFlag::ImGuiInputTextFlags
    Flags::ImGuiInputTextFlags
    UserData::Ptr{Void}
    ReadOnly::bool
    EventChar::ImWchar
    EventKey::ImGuiKey
    Buf::Ptr{UInt8}
    BufSize::Cint
    BufDirty::bool
    CursorPos::Cint
    SelectionStart::Cint
    SelectionEnd::Cint
end

typealias ImGuiTextEditCallback Ptr{Void}

# begin enum ImGuiWindowFlags_
typealias ImGuiWindowFlags_ UInt32
const ImGuiWindowFlags_NoTitleBar = (UInt32)(1)
const ImGuiWindowFlags_NoResize = (UInt32)(2)
const ImGuiWindowFlags_NoMove = (UInt32)(4)
const ImGuiWindowFlags_NoScrollbar = (UInt32)(8)
const ImGuiWindowFlags_NoScrollWithMouse = (UInt32)(16)
const ImGuiWindowFlags_NoCollapse = (UInt32)(32)
const ImGuiWindowFlags_AlwaysAutoResize = (UInt32)(64)
const ImGuiWindowFlags_ShowBorders = (UInt32)(128)
const ImGuiWindowFlags_NoSavedSettings = (UInt32)(256)
const ImGuiWindowFlags_NoInputs = (UInt32)(512)
const ImGuiWindowFlags_MenuBar = (UInt32)(1024)
const ImGuiWindowFlags_HorizontalScrollbar = (UInt32)(2048)
const ImGuiWindowFlags_NoFocusOnAppearing = (UInt32)(4096)
const ImGuiWindowFlags_NoBringToFrontOnFocus = (UInt32)(8192)
const ImGuiWindowFlags_ChildWindow = (UInt32)(1048576)
const ImGuiWindowFlags_ChildWindowAutoFitX = (UInt32)(2097152)
const ImGuiWindowFlags_ChildWindowAutoFitY = (UInt32)(4194304)
const ImGuiWindowFlags_ComboBox = (UInt32)(8388608)
const ImGuiWindowFlags_Tooltip = (UInt32)(16777216)
const ImGuiWindowFlags_Popup = (UInt32)(33554432)
const ImGuiWindowFlags_Modal = (UInt32)(67108864)
const ImGuiWindowFlags_ChildMenu = (UInt32)(134217728)
# end enum ImGuiWindowFlags_

# begin enum ImGuiInputTextFlags_
typealias ImGuiInputTextFlags_ UInt32
const ImGuiInputTextFlags_CharsDecimal = (UInt32)(1)
const ImGuiInputTextFlags_CharsHexadecimal = (UInt32)(2)
const ImGuiInputTextFlags_CharsUppercase = (UInt32)(4)
const ImGuiInputTextFlags_CharsNoBlank = (UInt32)(8)
const ImGuiInputTextFlags_AutoSelectAll = (UInt32)(16)
const ImGuiInputTextFlags_EnterReturnsTrue = (UInt32)(32)
const ImGuiInputTextFlags_CallbackCompletion = (UInt32)(64)
const ImGuiInputTextFlags_CallbackHistory = (UInt32)(128)
const ImGuiInputTextFlags_CallbackAlways = (UInt32)(256)
const ImGuiInputTextFlags_CallbackCharFilter = (UInt32)(512)
const ImGuiInputTextFlags_AllowTabInput = (UInt32)(1024)
const ImGuiInputTextFlags_CtrlEnterForNewLine = (UInt32)(2048)
const ImGuiInputTextFlags_NoHorizontalScroll = (UInt32)(4096)
const ImGuiInputTextFlags_AlwaysInsertMode = (UInt32)(8192)
const ImGuiInputTextFlags_ReadOnly = (UInt32)(16384)
const ImGuiInputTextFlags_Password = (UInt32)(32768)
const ImGuiInputTextFlags_Multiline = (UInt32)(1048576)
# end enum ImGuiInputTextFlags_

# begin enum ImGuiSelectableFlags_
typealias ImGuiSelectableFlags_ UInt32
const ImGuiSelectableFlags_DontClosePopups = (UInt32)(1)
const ImGuiSelectableFlags_SpanAllColumns = (UInt32)(2)
# end enum ImGuiSelectableFlags_

# begin enum ImGuiKey_
typealias ImGuiKey_ UInt32
const ImGuiKey_Tab = (UInt32)(0)
const ImGuiKey_LeftArrow = (UInt32)(1)
const ImGuiKey_RightArrow = (UInt32)(2)
const ImGuiKey_UpArrow = (UInt32)(3)
const ImGuiKey_DownArrow = (UInt32)(4)
const ImGuiKey_PageUp = (UInt32)(5)
const ImGuiKey_PageDown = (UInt32)(6)
const ImGuiKey_Home = (UInt32)(7)
const ImGuiKey_End = (UInt32)(8)
const ImGuiKey_Delete = (UInt32)(9)
const ImGuiKey_Backspace = (UInt32)(10)
const ImGuiKey_Enter = (UInt32)(11)
const ImGuiKey_Escape = (UInt32)(12)
const ImGuiKey_A = (UInt32)(13)
const ImGuiKey_C = (UInt32)(14)
const ImGuiKey_V = (UInt32)(15)
const ImGuiKey_X = (UInt32)(16)
const ImGuiKey_Y = (UInt32)(17)
const ImGuiKey_Z = (UInt32)(18)
const ImGuiKey_COUNT = (UInt32)(19)
# end enum ImGuiKey_

# begin enum ImGuiCol_
typealias ImGuiCol_ UInt32
const ImGuiCol_Text = (UInt32)(0)
const ImGuiCol_TextDisabled = (UInt32)(1)
const ImGuiCol_WindowBg = (UInt32)(2)
const ImGuiCol_ChildWindowBg = (UInt32)(3)
const ImGuiCol_Border = (UInt32)(4)
const ImGuiCol_BorderShadow = (UInt32)(5)
const ImGuiCol_FrameBg = (UInt32)(6)
const ImGuiCol_FrameBgHovered = (UInt32)(7)
const ImGuiCol_FrameBgActive = (UInt32)(8)
const ImGuiCol_TitleBg = (UInt32)(9)
const ImGuiCol_TitleBgCollapsed = (UInt32)(10)
const ImGuiCol_TitleBgActive = (UInt32)(11)
const ImGuiCol_MenuBarBg = (UInt32)(12)
const ImGuiCol_ScrollbarBg = (UInt32)(13)
const ImGuiCol_ScrollbarGrab = (UInt32)(14)
const ImGuiCol_ScrollbarGrabHovered = (UInt32)(15)
const ImGuiCol_ScrollbarGrabActive = (UInt32)(16)
const ImGuiCol_ComboBg = (UInt32)(17)
const ImGuiCol_CheckMark = (UInt32)(18)
const ImGuiCol_SliderGrab = (UInt32)(19)
const ImGuiCol_SliderGrabActive = (UInt32)(20)
const ImGuiCol_Button = (UInt32)(21)
const ImGuiCol_ButtonHovered = (UInt32)(22)
const ImGuiCol_ButtonActive = (UInt32)(23)
const ImGuiCol_Header = (UInt32)(24)
const ImGuiCol_HeaderHovered = (UInt32)(25)
const ImGuiCol_HeaderActive = (UInt32)(26)
const ImGuiCol_Column = (UInt32)(27)
const ImGuiCol_ColumnHovered = (UInt32)(28)
const ImGuiCol_ColumnActive = (UInt32)(29)
const ImGuiCol_ResizeGrip = (UInt32)(30)
const ImGuiCol_ResizeGripHovered = (UInt32)(31)
const ImGuiCol_ResizeGripActive = (UInt32)(32)
const ImGuiCol_CloseButton = (UInt32)(33)
const ImGuiCol_CloseButtonHovered = (UInt32)(34)
const ImGuiCol_CloseButtonActive = (UInt32)(35)
const ImGuiCol_PlotLines = (UInt32)(36)
const ImGuiCol_PlotLinesHovered = (UInt32)(37)
const ImGuiCol_PlotHistogram = (UInt32)(38)
const ImGuiCol_PlotHistogramHovered = (UInt32)(39)
const ImGuiCol_TextSelectedBg = (UInt32)(40)
const ImGuiCol_TooltipBg = (UInt32)(41)
const ImGuiCol_ModalWindowDarkening = (UInt32)(42)
const ImGuiCol_COUNT = (UInt32)(43)
# end enum ImGuiCol_

# begin enum ImGuiStyleVar_
typealias ImGuiStyleVar_ UInt32
const ImGuiStyleVar_Alpha = (UInt32)(0)
const ImGuiStyleVar_WindowPadding = (UInt32)(1)
const ImGuiStyleVar_WindowRounding = (UInt32)(2)
const ImGuiStyleVar_WindowMinSize = (UInt32)(3)
const ImGuiStyleVar_ChildWindowRounding = (UInt32)(4)
const ImGuiStyleVar_FramePadding = (UInt32)(5)
const ImGuiStyleVar_FrameRounding = (UInt32)(6)
const ImGuiStyleVar_ItemSpacing = (UInt32)(7)
const ImGuiStyleVar_ItemInnerSpacing = (UInt32)(8)
const ImGuiStyleVar_IndentSpacing = (UInt32)(9)
const ImGuiStyleVar_GrabMinSize = (UInt32)(10)
# end enum ImGuiStyleVar_

# begin enum ImGuiAlign_
typealias ImGuiAlign_ UInt32
const ImGuiAlign_Left = (UInt32)(1)
const ImGuiAlign_Center = (UInt32)(2)
const ImGuiAlign_Right = (UInt32)(4)
const ImGuiAlign_Top = (UInt32)(8)
const ImGuiAlign_VCenter = (UInt32)(16)
const ImGuiAlign_Default = (UInt32)(9)
# end enum ImGuiAlign_

# begin enum ImGuiColorEditMode_
typealias ImGuiColorEditMode_ Cint
const ImGuiColorEditMode_UserSelect = (Int32)(-2)
const ImGuiColorEditMode_UserSelectShowButton = (Int32)(-1)
const ImGuiColorEditMode_RGB = (Int32)(0)
const ImGuiColorEditMode_HSV = (Int32)(1)
const ImGuiColorEditMode_HEX = (Int32)(2)
# end enum ImGuiColorEditMode_

# begin enum ImGuiMouseCursor_
typealias ImGuiMouseCursor_ UInt32
const ImGuiMouseCursor_Arrow = (UInt32)(0)
const ImGuiMouseCursor_TextInput = (UInt32)(1)
const ImGuiMouseCursor_Move = (UInt32)(2)
const ImGuiMouseCursor_ResizeNS = (UInt32)(3)
const ImGuiMouseCursor_ResizeEW = (UInt32)(4)
const ImGuiMouseCursor_ResizeNESW = (UInt32)(5)
const ImGuiMouseCursor_ResizeNWSE = (UInt32)(6)
const ImGuiMouseCursor_Count_ = (UInt32)(7)
# end enum ImGuiMouseCursor_

# begin enum ImGuiSetCond_
typealias ImGuiSetCond_ UInt32
const ImGuiSetCond_Always = (UInt32)(1)
const ImGuiSetCond_Once = (UInt32)(2)
const ImGuiSetCond_FirstUseEver = (UInt32)(4)
const ImGuiSetCond_Appearing = (UInt32)(8)
# end enum ImGuiSetCond_

type ImGuiOnceUponAFrame
    RefFrame::Cint
end

type ImGuiTextFilter
end

type ImGuiTextBuffer
end

type ImGuiListClipper
    ItemsHeight::Cfloat
    ItemsCount::Cint
    DisplayStart::Cint
    DisplayEnd::Cint
end

typealias ImDrawIdx UInt16

type ImDrawVert
    pos::ImVec2
    uv::ImVec2
    col::ImU32
end

type ImDrawChannel
end
