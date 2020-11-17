﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStackClass;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack cs = new CStack();
            bool stop = false;
            Console.WriteLine("welcome to calc");
            string input;
            string[] commands;
            //string currentFile = @".\kommandoFile.txt";



            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                commands = input.Split(' ');

                if ( commands[0] == "quit")
                {//
                    Console.WriteLine("hej då");
                    stop = true;
                }
                else if ( commands[0] == "enter" && commands.Length == 2 )
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
                else
                {
                    Console.WriteLine("wrong input, try again");
                }

            } while (!stop);


            Console.ReadKey();

        }
    }
}
