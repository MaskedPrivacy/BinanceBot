
using BinanceExchange.API.Client;
using Binancian.Framework;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Binancian.Bots;

namespace Binancian
{
    public partial class MainForm : Form
    {
        BotBase b = new BotBase();
        GridTrading GT;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //do bnb gridlines
            b.UserWallet = new Wallet(b.client);
            b.UserWallet.GetAssetBalances(b.client);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.GetTickerPrice("ETHUSDT");
        }

        private void button_SelectBotFile_Click(object sender, EventArgs e)
        {
            GT = new GridTrading(BotTypes.GRID, "BNBUSDT", 400.00M, 40, 600.00M, 700.00M);
            GT.InitializeGrids(GT.client, "BNBUSDT");
        }
    }
}
