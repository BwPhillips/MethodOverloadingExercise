using System;

namespace MethodOverloadingConsol
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 0;
            var b = 1;
            var number = Sum(a, b);

            var c = 4.90m;
            var d = 3.85m;
            var decimalSum = Sum(c, d);

            var thirdAnswer = Sum(a, b, true);

            Console.WriteLine($"int add: {number} decimal add: {decimalSum}");
            Console.WriteLine(thirdAnswer);

        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static Decimal Sum(Decimal a, Decimal b)
        {
            return a + b;
        }

        public static String Sum(int a, int b, bool c)
        {
            var sum = a + b;

            if (c == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (c == true && sum <= 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
