using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystemConsole
{
    public class ConsoleLog
    {
        #region Neue Funct Hinzufügen
        public static string[] FunctNames = new string[] { "[ ERROR ]", "[WARNING]", "[PROCESS]" };  // Hier (1)
        public static ConsoleColor[] color = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Green }; // Hier (2)

        // Hier (3)
        public enum Funct
        {
            Error, // 0
            Warning, // 1
            Process  // 2
        }
        #endregion

        public static void Log(string text, Funct funct)
        {
            string Time = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            Console.Write("[" + Time + "] ");
            Console.Write(FunctNames[(int)funct] + " ", Console.ForegroundColor = color[(int)funct]);
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.White);
        }

        public static void LogWhiteArg(string text, string[] arg, Funct funct)
        {
            string Time = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
            Console.Write("[" + Time + "] ");
            Console.Write(FunctNames[(int)funct] + " ", Console.ForegroundColor = color[(int)funct]);
            Console.WriteLine(text, Console.ForegroundColor = ConsoleColor.White);
            Console.Write("[" + Time + "] ");
            Console.Write(FunctNames[(int)funct], Console.ForegroundColor = color[(int)funct]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ************************************************************************ ");
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write("[" + Time + "] ");
                Console.Write(FunctNames[(int)funct], Console.ForegroundColor = color[(int)funct]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" * " + arg[i]);
            }
            Console.Write("[" + Time + "] ");
            Console.Write(FunctNames[(int)funct], Console.ForegroundColor = color[(int)funct]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ************************************************************************ ");
        }

        public static void EmptyLine()
        {
            Console.WriteLine("");
        }
    }
}
