# stock-ticker-app
This is a C# console application that I built to monitor stock prices.  The application also sends email alerts when price drops significantly.  Application receives JSON data and serializes it into C# objects.

## Description
This project involves using a publicly accessible API to retrieve real-time stock prices of the Dow Jones index.  This project consumes the Alpha Vantage API https://www.alphavantage.co/ to get JSON data of the stock market.  The project parses the JSON data and converts the data into C# objects.  The project uses a separate C# file to control the price analysis of the index.  This is done to decouple the algorithm from the JSON reading and parsing.  The price algorithm can be updated frequently without damaging the project.   

## Getting Started
Download or clone the repository. Run the file StockTickerApp.sln

## Description of Project Files
Program.cs- This is the main entry point of the program.  From here you can start the program.

MarketScanner.cs- This file controls the main work of fetching the JSON info from the public financial api.  

Algorithm.cs- This class controls algorithm that determines if the price drop was significant.  The most recent algorithm uses regression on the most recent historical prices.  The algorithm looks at the current price of the stock index and the predicted trendline.  If the price index drops below a certain threshold then it will trigger a message through email.

MailService.cs- this class controls email functionality of the application.  

AppMessages.cs- This class controls the messages to the user, and through emails.  This decouples the messages from the other classes.  Messages can be changed in one place.

BotTests.cs- this class was used for testing.  

## Testing
Tests were done using a variety of different price criteria.   

## Demonstration
Here is an example of the application running.
![alt text][logo]

[logo]: https://github.com/ChrisToplikar/stock-ticker-app/blob/master/stock-ticker-demo.JPG?raw=true
 "Application Demo"
 
 ## Contributions
 This project used the API available for free from Alpha Vantage https://www.alphavantage.co/ to collect JSON data of the stock market.
