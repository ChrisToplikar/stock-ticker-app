using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StockTickerApp.Daily_Info;

namespace StockTickerApp
{
    class Program
    {
        static void Main(string[] args)
        {


            MarketScanner.dowIndex();

            //DateTime FutureDate = DateTime.ParseExact("08/21/2016", "mm/dd/yyyy", CultureInfo.InvariantCulture);
            //DateTime TodayDate = DateTime.Now;

            //int days = (FutureDate - TodayDate).Days;
           // DateTime start = new DateTime(2015, 01, 01);
            
           // DateTime today = DateTime.Today;
            

            //TimeSpan difference = today - start; //create TimeSpan object
            //int days = difference.Days;
            //Console.WriteLine("Difference in days: " + days); //Extract days, write to Console.
            //BotTests.runTests();
           


        }

        
    }
}
