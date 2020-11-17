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
                    case "x²":
                    case "√x":
                    case "log x":
                    case "ln x":
                    case "10ˣ":
                    case "eˣ":
                    case "sin":
                    case "cos":
                    case "tan":
                    case "sin⁻¹":
                    case "cos⁻¹":
                    case "tan⁻¹":
                        cs.Unop(command[0]);
                        break;
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

            Console.ReadKey();

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
