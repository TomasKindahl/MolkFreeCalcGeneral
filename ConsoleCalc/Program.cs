using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStackClass;
using System.IO;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack cs;
            cs = new CStack();
            bool stop = false;
            Console.WriteLine("welcome to calc");
            string input;
            string[] commands;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                commands = input.Split(' ');

                stop = ParseCommand(commands, cs);


            } while (!stop);



            Console.ReadKey();

        }

        static public bool ParseCommand(string[] commands, CStack cs)
        {
            if (commands[0] == "quit")
            {
                Console.WriteLine("hej då");
                return true;
            }
            else if ( commands[0] == "parse")
            {
                string file_name = @"C:\Users\samka\progmet\freecalc.lis";
                //string[] stringLines = new string[] { };
                if (File.Exists(file_name))
                {
                    string[] stringLines = File.ReadAllLines(file_name);
                    foreach (string line in stringLines)
                    {
                        string[] lineCommands = line.Split(' ');
                        ParseCommand(lineCommands, cs);
                    }
                }
                
            }
            else if (commands[0] == "enter" && commands.Length == 2)
            {
                cs.entry = commands[1];
                cs.Enter();

            }
            else if (commands[0] == "+")
            {
                cs.BinOp("+");
            }
            else if (commands[0] == "*")
            {
                cs.BinOp("×");
            }
            else if (commands[0] == "-")
            {
                cs.BinOp("−");
            }
            else if (commands[0] == "/")
            {
                cs.BinOp("÷");
            }
            else if (commands[0] == "show")
            {
                Console.WriteLine($"T: {cs.T}");
                Console.WriteLine($"Z: {cs.Z}");
                Console.WriteLine($"Y: {cs.Y}");
                Console.WriteLine($"X: {cs.X}");
            }
            else if (commands[0] == "clear")
            {
                cs.Reset();
                Console.WriteLine("Done...");
            }
            else
            {
                Console.WriteLine("wrong input, try again");
            }
            return false;
        }


    }
}
