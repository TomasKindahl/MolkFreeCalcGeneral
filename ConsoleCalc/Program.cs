using System;
using System.Collections.Generic;
using System.IO;
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

            string[] fileInfo;
            string[] commandWord;
            Console.WriteLine("Free calc input comand: ");
            do
            {
                
                Console.Write("> ");
                string command = Console.ReadLine();
                commandWord = command.Split(' ');
               
                if (commandWord[0] == "load")
                {

                    fileInfo = LoadFile(commandWord[1]);
                    Console.WriteLine(fileInfo.Length);
                    for (int i = 0; i < fileInfo.Length; i++)
                    {
                       CommandSort(cs,fileInfo[i]);
                    }
                }
                else 
                {
                   CommandSort(cs, command);
                }
            } while (commandWord[0] != "quit");
        }

        private static void CommandSort(CStack cs , string command)
        {
            string[] commandWord = command.Split(' ');
            switch (commandWord[0])
            {
                case "enter":
                    try
                    {
                        cs.entry = commandWord[1];
                        cs.Enter();
                    }
                    catch { };
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
                    cs.Show();
                    break;
                
                default: break;

            }

            
        }

        static string[] LoadFile(string path)// Load the specified file
        {
            string[] fileInfo;
            
            using (StreamReader sr = new StreamReader(path))
            {
                
                int lineCount = File.ReadLines(path).Count();
                fileInfo = new string[lineCount];
                for (int i = 0; i < lineCount; i++)
                {
                    string line = sr.ReadLine();
                    //string[] lineword = line.Split('\n');
                    fileInfo[i] = line;

                   
                }
            }

            Console.WriteLine("Loaded the file");
            return fileInfo;
        }
        
    }
}
