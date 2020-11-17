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
            
            
            string[] commandWord;
            Console.WriteLine("Free calc input comand: ");
            do
            {
                Console.Write("> ");
                commandWord = Console.ReadLine().Split(' ');
                switch(commandWord[0])
                {
                    case "enter":
                        try
                        {
                            cs.entry = commandWord[1];
                            cs.Enter();
                        }
                        catch { };
                        break;
                    case "+": cs.BinOp(commandWord[0]);
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
                        cs.Show();
                        break;
                    default: break;
               
                }


            } while (commandWord[0] != "quit");
        }
    }
}
