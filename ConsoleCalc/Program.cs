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
            string command = "";
            string[] commandWord;
            while (command != "quit")
	        {
                command = Console.ReadLine();
                commandWord = command.Split(' ');
                if (command.Length == 1)
                {
                    cs.BinOp(command);
                }
                else if (commandWord[0] == "enter")
                {
                    cs.RollSetX(double.Parse(commandWord[1]));
                }
                else if(command == "show")
                {
                    Console.WriteLine(cs.StackString());
                }

            }
        }
    }
}
