include("cimgui_h.jl")
include("cimgui.jl")

function render()
	x::Array{Bool,1} = [true]
	size::ImVec2 = ImVec2(0,0)
	igBegin("window", pointer(x), 0)
	igButton("BUTTON2", ImVec2(100,100))
	igButton("BUTTON", ImVec2(0,0))
	igEnd()
end



setupAll()
setRenderCallback(render)
mainLoop()
destroyAll()
