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
            //
            CStack cs;
            string command;
            cs = new CStack();          
            
            do{
                Console.Write("> ");
                command = Console.ReadLine();
                string[] commandWord = command.Split(' ');

                if (command == "show")
                {
                    Console.WriteLine("T: "+(cs.T));
                    Console.WriteLine("Z: "+(cs.Z));
                    Console.WriteLine("Y: "+(cs.Y));
                    Console.WriteLine("X: "+(cs.X));
                }
                else if (commandWord[0] == "enter")
	            {
                    double num;
                    double.TryParse(commandWord[1], out num);                      
                    cs.T = cs.Z; 
                    cs.Z = cs.Y; 
                    cs.Y = cs.X; 
                    cs.X = num;
	            }
                else if (command == "+")
	            {
                    double result = cs.Y + cs.X;            
                    cs.X = result;
	            } 
                else if (command == "-")
	            {
                    double result = cs.Y - cs.X;            
                    cs.X = result;
	            } 
                else if (command == "/")
	            {
                    double result = cs.Y / cs.X;            
                    cs.X = result;
	            } 
                else if (command == "*")
	            {
                    double result = cs.Y * cs.X;            
                    cs.X = result;
	            }
	
	        } while (command != "quit");

        }

    }
}
