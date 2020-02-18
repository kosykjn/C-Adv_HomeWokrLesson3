using System;

namespace homeWorkLesson3_1
{
    public delegate int MyDelagate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelagate myDelagate = delegate (int a, int b, int c) { return (a + b + c) / 3; };

            int summ = myDelagate.Invoke(5, 10, 3);

            Console.WriteLine($"Среднее арифметическое: {summ}");

            Console.ReadKey();
        }
    }
}
