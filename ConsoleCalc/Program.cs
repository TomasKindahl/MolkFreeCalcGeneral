using System;
using System.IO;
using CStackClass;
using System.Collections.Generic;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            CStack cs;
            cs = new CStack();
            bool stop = false;
            string input;
            string[] commands = { };
            List<string> lineList = new List<string>();

            Console.WriteLine("welcome to calc");
            while (!stop)
            {
                if (lineList.Count == 0)
                {
                    Console.Write("> ");
                    input = Console.ReadLine();
                    commands = input.Split(' ');
                }
                if (lineList.Count > 0)
                {
                    commands = lineList[0].Split(' ');
                    //Console.WriteLine(commands[0]);
                    lineList.RemoveAt(0);
                }

                if (commands[0] == "quit" )
                {
                    Console.WriteLine("hej då");
                    stop = true;
                }
                else if (commands[0] == "enter" && commands.Length == 2)
                {
                    cs.entry = commands[1];
                    cs.Enter();

                }
                else if (commands[0] == "load")
                {
                    string file_name = @"C:\Users\samka\progmet\freecalc.lis";

                    if (File.Exists(file_name))
                    {
                        string[] stringLines = File.ReadAllLines(file_name);
                        foreach (string line in stringLines)
                        {
                            lineList.Add(line);
                        }
                    }
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
            }


            Console.ReadKey();

        }
    }
}