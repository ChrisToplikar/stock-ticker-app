using System;
using System.Collections.Generic;
using System.Text;

namespace StockTickerApp.Daily_Info
{
    public class DailyQuote
    {
        public string symbol { get; set; }
        public string open { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string price { get; set; }
        public string volume { get; set; }
        public string latestTradingDay { get; set; }
        public string previousClose { get; set; }
        public string change { get; set; }
        public string changePercent { get; set; }
    }
}
