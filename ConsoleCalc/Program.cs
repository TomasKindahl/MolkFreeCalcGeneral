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

            Console.WriteLine("----CONSOLECALC----");

            string[] command = { "" };
            do
            {
                Console.Write(">");
                command = Console.ReadLine().Split(' ');

                if (command[0] == "enter")
                {
                    cs.RollSetX(double.Parse(command[1]));
                }
                else if (command[0] == "show")
                {
                    Console.WriteLine("T: {0} ", cs.T);
                    Console.WriteLine("Z: {0} ", cs.Z);
                    Console.WriteLine("Y: {0} ", cs.Y);
                    Console.WriteLine("X: {0} ", cs.X);
                }

                else
                    switch (command[0])
                    {
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
                            cs.BinOp("+");
                            break;
                        case "-":
                            cs.BinOp("−");
                            break;
                        case "*":
                            cs.BinOp("×");
                            break;
                        case "/":
                            cs.BinOp("÷");
                            break;

                        case "π":
                        case "e":
                            cs.Nilop(command[0]);
                            break;
                    }

            } while (command[0] != "quit");
        }
    }
}
