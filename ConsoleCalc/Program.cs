﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CStackClass;

namespace ConsoleCalc
{
    class Program
    {//C:\Users\allop\source\ReposMolk\ConsoleCalc\kommandoList.txt
        static void Main(string[] args)
        {
            CStack cs = new CStack();
            bool stop = false;
            Console.WriteLine("Welcome to ConsoleCalc");
            string input;
            string[] commands;
            // ParseCommand(cs, stop, commands);

            do
            {

                Console.Write("> ");
                input = Console.ReadLine();
                commands = input.Split(' ');

                stop = ParseCommand(cs, stop, commands);
              
               
            } while (!stop);
            Console.ReadKey();
        }
        static void Show(CStack cs)
        {
            Console.WriteLine("T: {0}\nZ: {1}\nY: {2}\nX: {3}",
                              cs.T.ToString(), cs.Z.ToString(),
                              cs.Y.ToString(), cs.X.ToString());
        }



        private static bool ParseCommand(CStack cs, bool stop, string[] commands)
        {

            if (commands[0] == "enter" && commands.Length == 2)
            {
                cs.entry = commands[1];
                cs.Enter();
            }
            else if (commands[0] == "show")
            {
                Show(cs);
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
            else if (commands[0] == "/")
            {
                cs.BinOp("÷");
            }
            else if (commands[0] == "^")
            {
                cs.BinOp("yˣ");
            }
            else if (commands[0] == @"\")
            {
                cs.BinOp("ˣ√y");
            }
            else if (commands[0] == "sqr")
            {
                cs.Unop("x²");
            }
            else if (commands[0] == "sqrt")
            {
                cs.Unop("√x");
            }
            else if (commands[0] == "log")
            {
                cs.Unop("log x");
            }
            else if (commands[0] == "ln")
            {
                cs.Unop("ln x");
            }
            else if (commands[0] == "10^")
            {
                cs.Unop("10ˣ");
            }
            else if (commands[0] == "e^")
            {
                cs.Unop("eˣ");
            }
            else if (commands[0] == "sin")
            {
                cs.Unop("sin");
            }
            else if (commands[0] == "cos")
            {
                cs.Unop("cos");
            }
            else if (commands[0] == "tan")
            {
                cs.Unop("tan");
            }
            else if (commands[0] == "asin")
            {
                cs.Unop("sin⁻¹");
            }
            else if (commands[0] == "acos")
            {
                cs.Unop("cos⁻¹");
            }
            else if (commands[0] == "atan")
            {
                cs.Unop("tan⁻¹");
            }
            else if (commands[0] == "pi")
            {
                cs.Nilop("π");
            }
            else if (commands[0] == "e")
            {
                cs.Nilop("e");
            }
            else if (commands[0] == "quit")
            {
                Console.WriteLine("Bye! Press any key to continue ...");
                stop = true;
            }
            else if (commands[0] == "parse")
            {
                using (StreamReader readFile = new StreamReader(commands[1]))
                {
                    string line;
                    line = readFile.ReadLine();
                    while (line != null)
                    {
                        string[] words = line.Split(' ');
                        ParseCommand(cs, false, words);
                        line = readFile.ReadLine();
                    }
                }

            }

            else
            {
                Console.WriteLine("Unknown command: {0}", commands[0]);
            }
            return stop;
        }
            
    }
}
 

