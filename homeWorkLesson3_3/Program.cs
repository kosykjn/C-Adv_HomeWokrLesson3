using System;
using System.Threading;

namespace homeWorkLesson3_3
{
    class Program
    {
        public delegate int MyDelegate();
        public delegate double AvgDelegate(MyDelegate[] delegates);

        static void Main(string[] args)
        {
            Random random = new Random();

            MyDelegate myDelegate1 = () => random.Next(0, 20);
            MyDelegate myDelegate2 = () => random.Next(0, 20);
            MyDelegate myDelegate3 = () => random.Next(0, 20);

            AvgDelegate avg = delegate(MyDelegate[] delegates)
            {
                var sum = 0;

                foreach (var @delegate in delegates)
                {
                    sum += @delegate();
                }

                return sum / Convert.ToDouble(delegates.Length);
            };

            var result = avg(new MyDelegate[] { myDelegate1, myDelegate2, myDelegate3 });

            Console.WriteLine($"Result => {result:#.00}");

            Console.ReadKey();
        }
    }
}
