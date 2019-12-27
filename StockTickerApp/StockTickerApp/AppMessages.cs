using System;
using System.Collections.Generic;
using System.Text;

namespace StockTickerApp
{
    public static class AppMessages
    {

        public static void Greeting()
        {
            Console.WriteLine("Automated Stock Market Bot");
            Console.WriteLine("Sends Email Alert in case of a price drop");
            Console.WriteLine("New data collected every 54 seconds");
            Console.WriteLine("collecting data...");
            Console.WriteLine("");
        }
    }
}
