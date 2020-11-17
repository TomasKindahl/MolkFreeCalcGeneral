using System;
using System.IO;
using System.Reflection;
using CStackClass;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            CStack cs;
            cs = new CStack();
            string input;
            string[] words;
            Console.WriteLine("ConsoleCalc Grupp 4");
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                words = input.Split(' ');
                switch (words[0])
                {
                    case "+": cs.BinOp("+"); break;
                    case "-": cs.BinOp("-"); break;
                    case "*": cs.BinOp("x"); break;
                    case "÷": cs.BinOp("÷"); break;
                    case "quit":
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    case "enter":
                        cs.entry = words[1]; 
                        cs.Enter();
                        break;
                    case "show":
                        Console.WriteLine($"X = {cs.X}");
                        Console.WriteLine($"Y = {cs.Y}");
                        Console.WriteLine($"Z = {cs.Z}");
                        Console.WriteLine($"T = {cs.T}");
                        break;
                    case "load":
                        string filePath = words[1];
                        cs.ReadFile(filePath);
                        break;
                    default: break;
                }
            } while (!quit);
        }
    }
}