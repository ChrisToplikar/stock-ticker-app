using System;
using System.Collections.Generic;
using System.Text;

namespace StockTickerApp
{
    public class Algorithm
    {

        public static void purchaseIndex(double price)
        {
            //52 week low of Dow Index was 21712.55 on 12/23/2018
            //26000
            //24800
            if (price < 24800)
            {
                MailService m1 = new MailService();
                m1.tradingBotBuyEmail();
                //Ends Program
                Environment.Exit(0);
                
            }
        }
        public static void algorithm1(double price)
        {




            DateTime start = new DateTime(2019, 01, 01);
            DateTime today = DateTime.Today;
            TimeSpan difference = today - start; //create TimeSpan object
            int days = difference.Days;
            double y = 5.819178 * days + 16500;//y=5.819178x +16500
            double A = (y - price) / price;
            double B = (y - 26000) / 26000;
            double predictedBenefit = (A - B) * 100;
            if (A > B& A>0&B>0)
            {
                MailService m1 = new MailService();
                //Console.WriteLine($"A: Dollar gained returning to standard growth line: {A}");
                //Console.WriteLine($"B:percent growth of dollar today {B}");
                m1.tradingBotBuyEmail2(predictedBenefit);
                Environment.Exit(0);
               
            }

            //stock market growth
            // y= 177x + 16500
            //y = expected price of dow jones
            // x = current month since january 2015.  january 15 = month 0.  
            // current month August is 56.

            /*
             * Dollar gained returning to standard growth line(called A) = (y - actual stock price)/ actual stock price.
             * 
             * b= percent growth of dollar today(y-26000)/26000
             * 
             * if A is > B: send email.
             * 
             */

            /*days functions
             *  8/22/2019 = day 1694
             *  y=5.819178x +16500
             *  
             * */

        }

    }
}
