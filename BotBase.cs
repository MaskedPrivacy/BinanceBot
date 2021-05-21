using BinanceExchange.API.Client;
using BinanceExchange.API.Market;
using BinanceExchange.API.Models.Response;
using Binancian.Framework;
using Binancian.Trading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binancian.Bots
{
    public enum BotTypes
    {
        GRID,
        LEVERAGE_GRID,
        INFINITE_GRIDS,
        REVERSE_GRID,
        REVERSE_LEVERAGE_GRID 
    };

    public class BotBase
    {
        //Provide your configuration and keys here, this allows the client to function as expected.
        string apiKey = "xxx";
        string secretKey = "yyy";

        public BotBase()
        {
            //set up vars later
            //Initialise the general client client with config
            this.client = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = apiKey,
                SecretKey = secretKey,
            });
        }

        public BotBase(BotTypes bType, string symbolPair,  double AmountToInvest, int DesiredGrids, double PriceLowest, double PriceHighest)
        {
            this.Type = bType;
            this.BotPair = symbolPair;
            this.InvestmentTotal = AmountToInvest;
            this.nGridlines = DesiredGrids;
            this.PriceLowest = PriceLowest;
            this.PriceHighest = PriceHighest;

            //Initialise the general client client with config
            this.client = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = apiKey,
                SecretKey = secretKey,
            });
        }

        public async void GetTickerPrice(string Symbol)
        {
            //Initialise the general client client with config
            this.client = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = apiKey,
                SecretKey = secretKey,
            });

            SymbolPriceChangeTickerResponse a = await client.GetDailyTicker(Symbol);

            Console.WriteLine(a.LastPrice);
        }

        public bool DoesPriceHaveOrder(decimal price, string symbol)
        {
            for(int i = 0; i < OrderList.OrderList.Count; i++)
            {
                if (OrderList.OrderList[i].Symbol == symbol && OrderList.OrderList[i].price == price)
                    return true;
            }

            return false;
        }

        virtual public BotTypes Type { get; set; }
        
        public string BotPair;
        
        public int nGridlines { get; set; } //we must calculate whether user can afford n Grids when starting bot

        public double InvestmentTotal { get; set; } //used for calculations for grid lines based on higher + lower price

        public double ProfitTaken { get; set; } //PNL

        public double ProfitToTake { get; set; } //UPNL

        public double PriceLowest { get; set; }
        public double PriceMidrange { get; set; }
        public double PriceHighest { get; set; }

        public double StopLoss { get; set; }
        public double EndAtPrice { get; set; }

        public double AnnualizedEstimate { get; set; }

        public BinanceClient client { get; set; }

        public Wallet UserWallet { get; set; }

        public Grids GridContainer { get; set; }

        public Dictionary<string, decimal> TickerPrices { get; set; }

        public Orders OrderList { get; set; }

        public static string APIKey;
        public static string SecretKey;

        public bool IsBotting { get; set; }
    }
}
