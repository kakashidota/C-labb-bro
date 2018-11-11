using System;
namespace Calculatooooooor
{
    public class Calculator
    {
       
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        float numberInMemory;

        public Calculator()
        {
            clear();
        }


        public void clear()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            numberInMemory = 0;
        }

        public string printToString()
        {

            string message = @"
                First number: {0}
                Second number: {1}
                In memory: {2}";
            return string.Format(message, FirstNumber, SecondNumber, numberInMemory);
        }

        public float multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public float sum()
        {
            return FirstNumber + SecondNumber;
        }

        public void setNumbers(int first, int second)
        {
            FirstNumber = first;
            SecondNumber = second;
        }

        public float sumInbetween()
        {
            int first = FirstNumber;
            int second = SecondNumber;
            if (FirstNumber > SecondNumber)
            {
                first = SecondNumber;
                second = FirstNumber;
            }

            int sum = 0;
            for (int i = first; i < second + 1; i++)
            {
                sum += i;
            }
            return sum;
        }


        public void storeNumber(int val)
        {
            numberInMemory = val;
        }

        public void removeFromMemory()
        {
            numberInMemory = 0;
            FirstNumber = 0;
            SecondNumber = 0;
        }
    }
    }
