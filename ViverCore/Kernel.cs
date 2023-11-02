using System;
using Sys = Cosmos.System;

namespace ViverCore
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Core.Startup();
        }

        protected override void Run()
        {
        }
    }
}
