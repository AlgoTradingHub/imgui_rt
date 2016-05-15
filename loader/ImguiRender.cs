using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loader
{
    public class ImguiRender
    {
        [DllImport("imgui_rt.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool setRenderCallback(Action callback);

        [DllImport("imgui_rt.dll")]
        public static extern bool setupAll();
        [DllImport("imgui_rt.dll")]
        public static extern void mainLoop();
        [DllImport("imgui_rt.dll")]
        public static extern void destroyAll();

        [DllImport("imgui_rt.dll")]
        public static extern bool setupAll_dx10();
        [DllImport("imgui_rt.dll")]
        public static extern void mainLoop_dx10();
        [DllImport("imgui_rt.dll")]
        public static extern void destroyAll_dx10();
    }
}
