using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using StockTickerApp.Daily_Info;

namespace StockTickerApp
{
    public static class MarketScanner
    {
        public static void dowIndex(int x = 500)
        {
            AppMessages.Greeting();
            WebClient client = new WebClient();

            for (int i = 0; i < x; i++)
            {
                string myBase = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=dji&apikey=BZSLO6FXM3RZSX72";

                string data = client.DownloadString(myBase);
                data = cleanData(data);
                DailyQuoteHolder d1 = new DailyQuoteHolder();
                d1 = JsonConvert.DeserializeObject<DailyQuoteHolder>(data);
                //System.Threading.Thread.Sleep(172800);//2.88 min
                //api limit is 5 calls per min, 500 calls per day
                double dowPrice = double.Parse(d1.dailyQuote.price);
                string dowP = dowPrice.ToString("C");
                Console.WriteLine("Dow Jones Index  " + dowP + " " + DateTime.Now);
                Algorithm.purchaseIndex(dowPrice);
                Algorithm.algorithm1(dowPrice);
                System.Threading.Thread.Sleep(54000);

            }



        }
        public static double dowCurrentPrice()
        {
            WebClient client = new WebClient();
            string myBase = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=dji&apikey=BZSLO6FXM3RZSX72";
            string data = client.DownloadString(myBase);
            data = cleanData(data);
            DailyQuoteHolder d1 = new DailyQuoteHolder();
            d1 = JsonConvert.DeserializeObject<DailyQuoteHolder>(data);
            double dowPrice = double.Parse(d1.dailyQuote.price);
            return dowPrice;
        }
        public static string cleanData(string data)
        {
            data = data.Replace("Global Quote", "DailyQuote");
            data = data.Replace("01. symbol", "symbol");
            data = data.Replace("02. open", "open");
            data = data.Replace("03. high", "high");
            data = data.Replace("04. low", "low");
            data = data.Replace("05. price", "price");
            data = data.Replace("06. volume", "volume");
            data = data.Replace("07. latest trading day", "latestTradingDay");
            data = data.Replace("08. previous close", "previousClose");
            data = data.Replace("09. change", "change");
            data = data.Replace("10. change percent", "changePercent");
            return data;

        }
    }
}
