using System;

namespace Calculatooooooor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Welcome to yet another fucking calculator..");
            while (true)
            {
                int choice = startMenu();
                decisions(calc, choice);

            }

        }


        private static int startMenu()
        {

            string start = @"
            ---------------------------------------------
                1. Add two numbers
                2. Multiply two numbers
                3. Sum the numbers between two numbers.
                4. Add number to memory
                5. Clear memory
                6. Print calculator contents.
                7. Quit
            ---------------------------------------------
                ";

            Console.WriteLine(start);
            var input = Convert.ToInt32(Console.ReadLine());
            return input;

        }

        private static void decisions(Calculator calc, int input)
        {
            switch (input)
            {
                case 1:
                    inputTwoNumbers(calc);
                    Console.WriteLine("The sum is: " + calc.sum());
                    break;
                case 2:
                    inputTwoNumbers(calc);
                    Console.WriteLine("The product is: " + calc.multiply());
                    break;
                case 3:
                    inputTwoNumbers(calc);
                    Console.WriteLine("The sum is : " + calc.sumInbetween());
                    break;
                case 4:
                    string s = Console.ReadLine();
                    calc.storeNumber(Convert.ToInt32(s));
                    Console.WriteLine("Successfully added to memory");
                    break;
                case 5:
                    calc.removeFromMemory();
                    Console.WriteLine("Successfully removed from memory");

                    break;
                case 6:
                    Console.WriteLine(calc.printToString());
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }


        private static void inputTwoNumbers(Calculator calc)
        {
            string input1 = null;
            string input2 = null;
            do
            {
                Console.WriteLine("Input two numbers");
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
                //Console.WriteLine(input1.GetType() + input1);
            } while (input1 == "" || input2 == "");

            calc.setNumbers(Convert.ToInt32(input1), Convert.ToInt32(input2));
        }
    }
}
