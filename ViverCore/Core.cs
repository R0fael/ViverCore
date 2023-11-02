using Cosmos.HAL.BlockDevice.Registers;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Sys = Cosmos.System;

namespace ViverCore
{
    public class Core
    {
        public string processes = "Desktop;";
        private int counter;
        public static void Startup()
        {
            Console.Clear();
            Console.WriteLine("Running Viver Core");
        }
        public void Input(string input)
        {
            foreach(string proc in processes.Split(';'))
            {

            }
        }

        private string Desktop(string input, int counter) 
        {
            if(counter == 0)
            {
                switch (input)
                {
                    default: break;
                }
                return "";
            }
            return "";
        }
    }
}
