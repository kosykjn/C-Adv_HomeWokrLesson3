using System;

namespace homeWorkLesson3_2
{
    class Program
    {
        public delegate int SimpleOperation(int a, int b);
        public delegate bool SimpleOperationEx(int a, int b, out int result);
        static void Main(string[] args)
        {
            SimpleOperation addOperation = (a,  b) => a + b;

            SimpleOperation substractOperation = (a, b) => a - b;

            SimpleOperation multiplyOperation = (a, b) => a * b;

            SimpleOperationEx divideOperation = (int a, int b, out int result) =>
            {
                try
                {
                    result = a / b;
                    return true;
                }
                catch (DivideByZeroException)
                {
                    result = -1;
                    return false;
                }
            };

            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(addOperation(number1, number2));
                    }
                    break;
                case "-":
                    {
                        Console.WriteLine(substractOperation(number1, number2));
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine(multiplyOperation(number1, number2));
                    }
                    break;
                case "/":
                    {
                        if (divideOperation(number1, number2, out int divideResult))
                        {
                            Console.WriteLine(divideResult);
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на 0!!!");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Нет такого знака!");
                    break;
            }


            Console.ReadKey();
        }
    }
}
