#Pkg.add("Clang")
using Clang.wrap_c
context = wrap_c.init(; output_file="cimgui.jl", header_library=x->"cimgui", common_file="cimgui_h.jl", clang_diagnostics=true, clang_includes=["/home/oleksandr/ath/julia/usr/lib/clang/3.7.1/include"])
context.headers = ["/home/oleksandr/ath/julia/_cimgui.h"]
context.options.wrap_structs = true
wrap_c.run(context)
#Clang.wrap_c.debug_cursors