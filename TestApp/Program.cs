using System;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = new NCalc2.Expression("2 + 2");
            var result = expression.Evaluate();
            int i = Convert.ToInt32(result);
            Console.WriteLine(result);

            //TestStrings();
            //TestStringBuilder();

            Console.ReadLine();
        }

        static string TestStrings()
        {
            string s = string.Empty;
            for (int i = 0; i < 100000; ++i)
            {
                s += "S";
            }

            return s;
        }

        static string TestStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; ++i)
            {
                sb.Append("S");
            }

            return sb.ToString();
        }
    }
}
