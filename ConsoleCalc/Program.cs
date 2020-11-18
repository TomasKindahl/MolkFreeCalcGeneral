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
            bool check = false;
            string command;
            do
            {
                command = Console.ReadLine();
                string[] commandWord = command.Split(' ');

                switch (commandWord[0]){
                    case "enter":
                        double newX = double.Parse(commandWord[1]);
                        cs.RollSetX(newX);
                        break;
                    case "+":
                        cs.BinOp(commandWord[0]);
                        break;
                    case "-":
                        cs.BinOp(commandWord[0]);
                        break;
                    case "*":
                        cs.BinOp(commandWord[0]);
                        break;
                    case "/":
                        cs.BinOp(commandWord[0]);
                        break;
                    case "show":
                        Console.WriteLine(cs.StackString());
                        break;
                    case "save":
                        cs.Save(commandWord[1]);
                        break;
                    case "load":
                        cs.Load(commandWord[1]);
                        break;
                    case "quit":
                        check = true;
                        break;
                }

            } while(!check);
        }
    }
}
