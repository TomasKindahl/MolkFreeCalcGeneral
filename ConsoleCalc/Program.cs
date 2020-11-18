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
            CStack cs;
            cs = new CStack();
            cs.X = 0;
            string[] command = { "" };
            do
            {
                Console.Write(">");
               
                command = Console.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "enter":
                        cs.RollSetX(double.Parse(command[1]));
                        break;
                    case "show":
                        Console.WriteLine("T: {0} ", cs.T);
                        Console.WriteLine("Z: {0} ", cs.Z);
                        Console.WriteLine("Y: {0} ", cs.Y);
                        Console.WriteLine("X: {0} ", cs.X);
                        break;
                    case "sqrt": cs.Unop("√x"); break;
                    case "10^": cs.Unop("10ˣ"); break;
                    case "x^2": cs.Unop("x²"); break;
                    case "e^": cs.Unop("eˣ"); break;
                    case "log x":
                    case "ln x":
                    case "sin":
                    case "tan": cs.Unop(command[0]);break;
                    case "arcsin": cs.Unop("sin⁻¹"); break;
                    case "arccos": cs.Unop("cos⁻¹"); break;
                    case "arctan": cs.Unop("tan⁻¹"); break;  
                    case "+":
                    case "-":
                    case "×":
                    case "*":
                    case "/":
                        cs.BinOp(command[0]);
                        break;
                    case "pi":
                        cs.Nilop("π");
                        break;
                    case "e":
                        cs.Nilop(command[0]);
                        break;
                }

            } while (command[0] != "quit");
        }

    }
}
//do
//{
//    if (Console.ReadKey().Key == ConsoleKey.Enter)
//    {
//        Console.WriteLine("enter pressed");
//    }
//}
//while(Console.ReadKey().Key != ConsoleKey.Escape);
//Console.WriteLine("escape pressed");
