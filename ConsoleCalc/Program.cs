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
            // cs.X = 12;
            
            string[] com;
            do
	        {
                Console.Write("> ");
                com = Console.ReadLine().Split(' ');
                switch (com[0])
                {
                    case"enter": 
                        cs.RollSetX(double.Parse(com[1]));
                        Console.WriteLine($"T:{cs.T}\nZ:{cs.Z}\nY:{cs.Y}\nX:{cs.X}");
                        break;
                    case"*": cs.BinOp("×");
                        Console.WriteLine($"T:{cs.T}\nZ:{cs.Z}\nY:{cs.Y}\nX:{cs.X}");
                        break;
                    case "+":
                        cs.BinOp("+");
                        Console.WriteLine($"T:{cs.T}\nZ:{cs.Z}\nY:{cs.Y}\nX:{cs.X}");
                        break;
                    case "-":
                        cs.BinOp("−");
                        Console.WriteLine($"T:{cs.T}\nZ:{cs.Z}\nY:{cs.Y}\nX:{cs.X}");
                        break;
                    case "/":
                        cs.BinOp("÷");
                        Console.WriteLine($"T:{cs.T}\nZ:{cs.Z}\nY:{cs.Y}\nX:{cs.X}");
                        break;
                    case "show":
                        Console.WriteLine($"T:{cs.T}\nZ:{cs.Z}\nY:{cs.Y}\nX:{cs.X}");
                        Console.WriteLine(cs.StackString());
                        break;

                }
            } while (com[0] != "quit");

        }
    }
}
