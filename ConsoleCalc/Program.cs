using System;
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

                if (words[0] == "quit")
                {
                    quit = true;
                    Console.WriteLine("Hejdå!");
                }
                else if (words[0] == "enter")
                {
                    cs.entry = words[1];
                    cs.Enter();
                }
                else if (words[0] == "show")
                {
                    Console.WriteLine($"X = {cs.X}");
                    Console.WriteLine($"Y = {cs.Y}");
                    Console.WriteLine($"Z = {cs.Z}");
                    Console.WriteLine($"T = {cs.T}");
                }
                switch (words[0])
                {
                    case "+": cs.BinOp("+"); break;
                    case "-": cs.BinOp("-"); break;
                    case "x": cs.BinOp("×"); break;
                    case "÷": cs.BinOp("÷"); break;
                    default: break;
                }
            } while (!quit);

        }
    }
}
