using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loader
{

    class Program
    {
     

        static void Main(string[] args)
        {
            bool usedx10 = true;
            if (!ImguiRender.setupAll_dx10())
            {
                usedx10 = false;
                ImguiRender.setupAll();
            }
            bool woo = true;
            ImguiRender.setRenderCallback(() =>
            {
                NativeMethods.igBegin("window", ref woo, 0);
                NativeMethods.igButton("BUTTON", new ImVec2 { x = 100, y = 100 });
                NativeMethods.igButton("BUTTON2", new ImVec2 { });
                NativeMethods.igEnd();            
            });
            if (usedx10)
            {
                ImguiRender.mainLoop_dx10();
                ImguiRender.destroyAll_dx10();
            }else
            {
                ImguiRender.mainLoop();
                ImguiRender.destroyAll();
            }
        }
    }
}
