using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = "";
            int solution;
            int firstNumber = 0;
            int secondNumber = 0;
            

            Console.WriteLine("Hello Welcome to the Calculator.");
            Console.WriteLine("Here are the choices you can do.");
            Console.WriteLine("Use the the Numbers or Words to select");
            Console.WriteLine("1.) Addition    2.) Subtraction   3.) Mulitplication    4.) Division   5.) Quit");
            action = Console.ReadLine();

        
            if (action == "1" || action == "Add" || action == "Addition" || action == "add" || action == "addition")
            {
                    Add();


            }
            else if (action == "2" || action == "Sub" || action == "Subtraction" || action == "sub" || action == "subtraction")
            {
                    Subtract();

            }
            else if (action == "3" || action == "Multiply" || action == "multiply" || action == "Mulitplication" || action == "multiplication")
            {

                    Multiply();


            }
            else if (action == "4" || action == "Divide" || action == "divide" || action == "Division" || action == "division")
            {

                    Divide();


            }
            else if(action == "5" || action == "Quit" || action == "quit")
            {




            }
          

         bool Add()
            {
                Console.WriteLine("Enter your first number.");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number.");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                firstNumber += solution;
                secondNumber += solution;

                Console.WriteLine("Your Problem is " + firstNumber + " + " + secondNumber + " = " + solution);
                Console.ReadKey();
                return true;
            }


            bool Subtract()
            {
                Console.WriteLine("Enter your first number.");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number.");
                secondNumber = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Your Problem is " + firstNumber + " - " + secondNumber + " = " + solution);
                Console.ReadKey();
                return true;
            }

            bool Multiply()
            {
                Console.WriteLine("Enter your first number.");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number.");
                secondNumber = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Your Problem is " + firstNumber + " * " + secondNumber + " = " + solution);
                Console.ReadKey();
                return true;
            }

            bool Divide()
            {
                Console.WriteLine("Enter your first number.");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number.");
                secondNumber = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Your Problem is " + firstNumber + " / " + secondNumber + " = " + solution);
                Console.ReadKey();
                return true;
            }
        }
    }
}
