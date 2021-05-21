
using BinanceExchange.API.Client;
using Binancian.Framework;
using CryptoExchange.Net.ExchangeInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Binancian.Trading;

namespace Binancian.Bots
{
    public class GridTrading : BotBase
    {
        public BotTypes type;
        public string pair;
        public decimal investmentAmnt;
        public int nGrids;
        public decimal lowest;
        public decimal highest;
        private Thread botTrd;

        public GridTrading(BotTypes bType, string symbolPair, decimal AmountToInvest, int DesiredGrids, decimal PriceLowest, decimal PriceHighest)
        {
            type = bType;
            pair = symbolPair;
            investmentAmnt = AmountToInvest;
            nGrids = DesiredGrids;
            lowest = PriceLowest;
            highest = PriceHighest;
            
        }

        public async void InitializeGrids(BinanceClient client, string symbol)
        {
            //Get current asset price
            var priceData = await client.GetDailyTicker(symbol);
            decimal currentPrice = priceData.LastPrice;
            this.pair = symbol;
        
            Console.WriteLine("Init Grids... Starting Price: {0}", priceData.LastPrice);

            switch (this.type)
            {
                case BotTypes.GRID:
                    
                    decimal lastPriceDec = Convert.ToDecimal(priceData.LastPrice);
                    GridContainer = new Grids();
                    GridContainer.GridList = GridContainer.FillGridList(50, 700.00M, 500.00M, pair, lastPriceDec, 400, BinanceExchange.API.Enums.OrderSide.Buy);

                    //create new thread for cycling
                    botTrd = new Thread(new ThreadStart(this.CycleAsync));
                    botTrd.IsBackground = true;
                    botTrd.Start();
                    break;

                case BotTypes.REVERSE_GRID:
                    break;

            };
        }
    
        

        public async void CycleAsync() //!remember concurrency issues!
        {
            Console.WriteLine("Starting bot for {0}", pair);
            this.IsBotting = true;
            decimal currentPrice;

            while (IsBotting)
            {
                var priceData = await client.GetDailyTicker(this.pair);
                currentPrice = priceData.LastPrice; //Get Price
                Console.WriteLine("Current Price: {0}", currentPrice);

                this.OrderList = new Orders();
                this.OrderList.GetOpenOrders("BNBUSDT", client);
                this.OrderList.UpdateFilledOrders(client, "BNBUSDT");

                foreach (Orders.Order ord in this.OrderList)
                {
                    Console.WriteLine("Found order: {0}, {1}, {2}, {3}", ord.id, ord.Symbol, ord.price, ord.isMarket);
           
                    if((currentPrice >= ord.price) && (ord.Symbol == this.pair)) //this will hit for all orders existing under our price
                    {
                          if (OrderList.WasOrderFilled(client, this.pair, ord.id))
                          {
                            Console.WriteLine("Order {0} was filled: {1} units.", ord.id, ord.amount);

                              if(ord.Side == BinanceExchange.API.Enums.OrderSide.Sell) //sell tx
                              {

                              }
                              else //buy tx
                              {

                              }
                           }
                    }
                }

                Thread.Sleep(1500);
            }

        }
    
    }
}
