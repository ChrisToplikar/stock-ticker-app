using System;
using System.Collections.Generic;
using System.Text;

namespace StockTickerApp
{
    public class BotTests
    {
        public static void runTests()
        {
            int testCount = 0;
            double a= 24800;
            double b= 25500;
            double c= 25750;
            double d= 26000;
            double e= 26250;
            double f= 26500;
            double g = 26750;
            Console.WriteLine($"Testing {a}, expected value: TRUE, Actual value: {sendMail(a)}");
            Console.WriteLine($"Testing {b}, expected value: TRUE, Actual value: {sendMail(b)}");
            Console.WriteLine($"Testing {c}, expected value: TRUE, Actual value: {sendMail(c)}");
            Console.WriteLine($"Testing {d}, expected value: FALSE, Actual value: {sendMail(d)}");
            Console.WriteLine($"Testing {e}, expected value: FALSE, Actual value: {sendMail(e)}");
            Console.WriteLine($"Testing {f}, expected value: FALSE, Actual value: {sendMail(f)}");
            Console.WriteLine($"Testing {g}, expected value: FALSE, Actual value: {sendMail(g)}");
        }

        public static Boolean sendMail(double price)
        {
            DateTime start = new DateTime(2019, 01, 01);
            DateTime today = DateTime.Today;
            TimeSpan difference = today - start; //create TimeSpan object
            int days = difference.Days;
            double y = 5.819178 * days + 16500;//y=5.819178x +16500
            double A = (y - price) / price;
            double B = (y - 26000) / 26000;
            if (A > B)
            {
                return true;
            }

            return false;
        }
    }
}
