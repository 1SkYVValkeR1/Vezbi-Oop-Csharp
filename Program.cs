using System;

namespace HomeWork.Class02.Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SwapNumbers");

            int firstNumber = 8;
            int secondNumber = 5;
            int temp;

            Console.WriteLine("please enter the firstNumber");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the secondNumber");
            secondNumber = Convert.ToInt32(Console.ReadLine());


            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("Values are swapping are:" );
            Console.WriteLine("firstNumber="+firstNumber);
            Console.WriteLine("secondNumber="+secondNumber);
            
        }
    }
}
