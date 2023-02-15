using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureSim
{
    internal class Utility
    {
        public delegate void PrintPlatform(string message);
        public static PrintPlatform Print = PrintConsole;

        //usage example for later in the semester
        //public static PrintPlatform Print = PrintWPF;
        public static void PrintConsole(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintWPF(string message)
        {

            //statements for WPF/ GUI
        }
    }
}
