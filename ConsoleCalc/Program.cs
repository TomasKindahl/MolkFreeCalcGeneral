using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CStackClass;
using System.IO;

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
                    case "load":
                        string filepath = commandWord[1];
                        string[] tmp = File.ReadAllLines(filepath);
                        for(int i = 0; i < tmp.Length; i++)
                        {
                            commandWord = tmp[i].Split(' ');
                            switch (commandWord[0]){
                                case "enter":
                                    double newXLoad = double.Parse(commandWord[1]);
                                    cs.RollSetX(newXLoad);
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
                                case "quit":
                                    check = true;
                                    break;
                            }
                        }
                        break;
                    case "show":
                        Console.WriteLine(cs.StackString());
                        break;
                    case "quit":
                        check = true;
                        break;
                }

            } while(!check);
        }
    }
}
