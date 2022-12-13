using System;

namespace DivideAndRound
{
    class Program
    {
        /// <summary>
        /// Հաշվում է արգումենտների կլորացված գործակիցը
        /// </summary>
        /// <param name="a">բաժանելի</param>
        /// <param name="b">բաժանարար</param>
        /// <returns>Կլորացված մաս</returns>
        public static int DivideAndRound(double a, double b)
        {
            return (int)Math.Round(a / b);
        }
        static void Main(string[] args)
        {
            DivideAndRound(34, 56);
            double num1 = +5.5e-2;
            float num2 = 7.8f;
            int num3 = 0;
            long num4 = 2000000000000L;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            double pi = Math.PI;
            float tenThousand = 10000L;
            double tenThousandPi = pi * tenThousand;
            double roundedTenThousandPi = tenThousandPi;
            double integerPartOfTenThousandPi = tenThousandPi;

            Console.WriteLine(Math.Truncate(integerPartOfTenThousandPi));
            Console.WriteLine(Math.Round(roundedTenThousandPi));

            double amount = 1.11;
            int peopleCount = 60;
            int totalMoney = (int)Math.Round(amount * peopleCount);

            Console.WriteLine(totalMoney);
            string str = Console.ReadLine();
            double number = double.Parse(str);

            Console.WriteLine(number + 1);
            string doubleNumber = "894376.243643";
            double number1 = Convert.ToDouble(doubleNumber);

            Console.WriteLine(number + 1);
            string st1 = "Test 1 ";
            string st2 = "Test 2";
            var result = st1 + st2;

            Console.WriteLine(result);
            double a = 5;
            a = a + 0.5;

            Console.WriteLine(a);
        }
    }
}
