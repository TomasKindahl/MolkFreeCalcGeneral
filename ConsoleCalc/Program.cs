using System;
using System.IO;
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
                ParseInput(cs, command, commandWord);

            }
        }

        private static void ParseInput(CStack cs, string command, string[] commandWord)
        {
            if (command.Length == 1)
            {
                cs.BinOp(command);
            }
            else if (commandWord[0] == "enter")
            {
                cs.RollSetX(double.Parse(commandWord[1]));
            }
            else if (command == "show")
            {
                Console.WriteLine(cs.StackString());
            }
            else if (commandWord[0] == "execute")
            {
                try
                {
                    using (StreamReader sr = new StreamReader("TestFile.txt"))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] lineWord = line.Split(' ');
                            ParseInput(cs, line, lineWord);

                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }

            else if (commandWord[0] == "load")
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@commandWord[1]))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] lineWord = line.Split(':');
                            cs.X = double.Parse(lineWord[0]);
                            cs.Y = double.Parse(lineWord[1]);
                            cs.Z = double.Parse(lineWord[2]);
                            cs.T = double.Parse(lineWord[3]);


                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
            else if (commandWord[0] == "save")
            {
                try
                {
                    using (StreamWriter sr = new StreamWriter(@commandWord[1]))
                    {


                        sr.WriteLine("{0}:{1}:{2}:{3}", cs.X, cs.Y, cs.Z, cs.T);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
