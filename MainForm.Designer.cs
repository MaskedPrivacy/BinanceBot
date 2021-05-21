namespace Binancian
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button_SelectBotFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_Swap = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_SwapSpotPrice = new System.Windows.Forms.NumericUpDown();
            this.button_SwapAllSpot = new System.Windows.Forms.Button();
            this.button_SwapAll = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_ToSwap = new System.Windows.Forms.Label();
            this.label_FromAsset = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_BalanceResult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_GetBalance = new System.Windows.Forms.Button();
            this.comboBox_Balance = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_EndProfit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_StopLoss = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_SellAssetsAfterBotting = new System.Windows.Forms.CheckBox();
            this.button_StopBot = new System.Windows.Forms.Button();
            this.comboBox_Pair = new System.Windows.Forms.ComboBox();
            this.label_BotPair = new System.Windows.Forms.Label();
            this.button_StartBot = new System.Windows.Forms.Button();
            this.numericUpDown_USDTInvest = new System.Windows.Forms.NumericUpDown();
            this.label_USDTInvest = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label_HighPrice = new System.Windows.Forms.Label();
            this.label_LowestPrice = new System.Windows.Forms.Label();
            this.numericUpDown_PriceLowest = new System.Windows.Forms.NumericUpDown();
            this.label_BotType = new System.Windows.Forms.Label();
            this.comboBox_BotType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Grids = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Server = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Account = new System.Windows.Forms.Label();
            this.tabPage_Bots = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_Txs = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_Swap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SwapSpotPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BalanceResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EndProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StopLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_USDTInvest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceLowest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Grids)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage_Bots.SuspendLayout();
            this.groupBox_Txs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage_Bots);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox_Swap);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button_SelectBotFile);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(6, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 127);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Testing";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_SelectBotFile
            // 
            this.button_SelectBotFile.Location = new System.Drawing.Point(11, 70);
            this.button_SelectBotFile.Name = "button_SelectBotFile";
            this.button_SelectBotFile.Size = new System.Drawing.Size(178, 23);
            this.button_SelectBotFile.TabIndex = 3;
            this.button_SelectBotFile.Text = "Example BNBUSDT Grid Lines";
            this.button_SelectBotFile.UseVisualStyleBackColor = true;
            this.button_SelectBotFile.Click += new System.EventHandler(this.button_SelectBotFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Place BNB Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox_Swap
            // 
            this.groupBox_Swap.Controls.Add(this.label5);
            this.groupBox_Swap.Controls.Add(this.numericUpDown1);
            this.groupBox_Swap.Controls.Add(this.label4);
            this.groupBox_Swap.Controls.Add(this.numericUpDown_SwapSpotPrice);
            this.groupBox_Swap.Controls.Add(this.button_SwapAllSpot);
            this.groupBox_Swap.Controls.Add(this.button_SwapAll);
            this.groupBox_Swap.Controls.Add(this.comboBox2);
            this.groupBox_Swap.Controls.Add(this.comboBox1);
            this.groupBox_Swap.Controls.Add(this.label_ToSwap);
            this.groupBox_Swap.Controls.Add(this.label_FromAsset);
            this.groupBox_Swap.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox_Swap.Location = new System.Drawing.Point(216, 14);
            this.groupBox_Swap.Name = "groupBox_Swap";
            this.groupBox_Swap.Size = new System.Drawing.Size(179, 209);
            this.groupBox_Swap.TabIndex = 3;
            this.groupBox_Swap.TabStop = false;
            this.groupBox_Swap.Text = "Swap Assets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 8;
            this.numericUpDown1.Location = new System.Drawing.Point(58, 79);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // numericUpDown_SwapSpotPrice
            // 
            this.numericUpDown_SwapSpotPrice.DecimalPlaces = 8;
            this.numericUpDown_SwapSpotPrice.Location = new System.Drawing.Point(58, 105);
            this.numericUpDown_SwapSpotPrice.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown_SwapSpotPrice.Name = "numericUpDown_SwapSpotPrice";
            this.numericUpDown_SwapSpotPrice.Size = new System.Drawing.Size(115, 22);
            this.numericUpDown_SwapSpotPrice.TabIndex = 6;
            // 
            // button_SwapAllSpot
            // 
            this.button_SwapAllSpot.Location = new System.Drawing.Point(6, 147);
            this.button_SwapAllSpot.Name = "button_SwapAllSpot";
            this.button_SwapAllSpot.Size = new System.Drawing.Size(167, 23);
            this.button_SwapAllSpot.TabIndex = 5;
            this.button_SwapAllSpot.Text = "Swap All Assets (Spot)";
            this.button_SwapAllSpot.UseVisualStyleBackColor = true;
            // 
            // button_SwapAll
            // 
            this.button_SwapAll.Location = new System.Drawing.Point(6, 177);
            this.button_SwapAll.Name = "button_SwapAll";
            this.button_SwapAll.Size = new System.Drawing.Size(167, 23);
            this.button_SwapAll.TabIndex = 4;
            this.button_SwapAll.Text = "Swap All Assets (Market)";
            this.button_SwapAll.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NULS",
            "ETH",
            "TFUEL",
            "BNB",
            "ETH",
            "LINK",
            "COS",
            "EOS",
            "BCH",
            "THETA",
            "XRP",
            "ETC",
            "COS",
            "LTC",
            "OMG",
            "BNB",
            "ADA",
            "XTZ",
            "LINK",
            "MATIC",
            "OMG",
            "TRX",
            "IOTX",
            "XRP",
            "FUEL",
            "VET",
            "BCH",
            "IOTX",
            "EOS",
            "LTC",
            "ONT",
            "NEO",
            "RVN",
            "XTZ",
            "XMR",
            "ICX",
            "ZIL",
            "BNT",
            "KNC",
            "QTUM",
            "ZIL",
            "ADA",
            "DASH",
            "XMR",
            "XLM",
            "ERD",
            "ETC",
            "TUSD",
            "ENJ",
            "TUSD",
            "IOST",
            "ZEC",
            "PAX",
            "ALGO",
            "PAX",
            "POLY",
            "ICX",
            "AMB",
            "RVN",
            "ALGO",
            "BNT",
            "HOT",
            "COTI",
            "BAT",
            "PHB",
            "ENJ",
            "ZRX",
            "OGN",
            "TNT",
            "ZRX",
            "TRX",
            "TCT",
            "KAVA",
            "BTT",
            "NKN",
            "OGN",
            "HOT",
            "VET",
            "BAT",
            "AION",
            "CHR",
            "KAVA",
            "ZEC",
            "NEO",
            "FET",
            "XLM",
            "XVG",
            "ONT",
            "NANO",
            "ATOM",
            "REN",
            "LTO",
            "BAND",
            "FTM",
            "WRX",
            "DASH",
            "HBAR",
            "IOTA",
            "NANO",
            "WTC",
            "CND",
            "WRX",
            "NPXS",
            "IOST",
            "AION",
            "QTUM",
            "DUSK",
            "NAS",
            "CHZ",
            "HC",
            "POA",
            "WAVES",
            "ARDR",
            "XEM",
            "FTM",
            "CTSI",
            "VIB",
            "GAS",
            "COTI",
            "HBAR",
            "WABI",
            "CHR",
            "DATA",
            "NKN",
            "GTO",
            "SOL",
            "HC",
            "BAND",
            "TOMO",
            "NGN",
            "TROY",
            "WAVES",
            "EUR",
            "IOTA",
            "HIVE",
            "CELR",
            "SC",
            "WIN",
            "ARK",
            "ERD",
            "SNT",
            "BEAM",
            "BEAM",
            "STEEM",
            "SNGLS",
            "MANA",
            "HIVE",
            "PERL",
            "CELR",
            "STX",
            "ENG",
            "BCD",
            "MTL",
            "ONE",
            "STX",
            "ARDR",
            "REN",
            "DREP",
            "ATOM",
            "LSK",
            "CHZ",
            "ARN",
            "QKC",
            "ZEN",
            "ONE",
            "COSBNB",
            "CDT",
            "DUSK",
            "BCHPAX",
            "TOMO",
            "FET",
            "ETHTUSD",
            "STRAT",
            "FUN",
            "MITH",
            "DOCK",
            "PERL",
            "KMD",
            "MBL",
            "MCO",
            "BTG",
            "STPT",
            "WAN",
            "TRY",
            "GO",
            "AE",
            "ARPA",
            "CTSI",
            "POWR",
            "DATA",
            "TROY",
            "SKY",
            "BCHTUSD",
            "RLC",
            "POE",
            "VITE",
            "WTC",
            "DENT",
            "FTT",
            "WAN",
            "MITH",
            "TCT",
            "LEND",
            "XZC",
            "QLC",
            "ANKR",
            "LOOM",
            "PPT",
            "STORM",
            "DOGE",
            "ELF",
            "AGI",
            "OST",
            "REP",
            "ANKR",
            "KEY",
            "GNT",
            "MDA",
            "TNB",
            "STORJ",
            "CVC",
            "STPT",
            "APPC",
            "MBL",
            "EVX",
            "ONG",
            "LSK",
            "VITE",
            "ARPA",
            "GTO",
            "BTS",
            "MCO",
            "ONG",
            "SNM",
            "MTL",
            "CMT",
            "LUN",
            "STRAT",
            "PIVX",
            "MTH",
            "LTO",
            "VIBE",
            "EDO",
            "XZC",
            "VIA",
            "BQX",
            "DCR",
            "COCOS",
            "BTS",
            "DNT",
            "QSP",
            "CVC",
            "BCPT",
            "FUN",
            "ADX",
            "RCN",
            "LRC",
            "DOCK",
            "STORM",
            "RLC",
            "GRS",
            "DOGE",
            "NAV",
            "DREP",
            "LEND",
            "FTT",
            "CTXC",
            "NULS",
            "SYS",
            "AST",
            "MFT"});
            this.comboBox2.Location = new System.Drawing.Point(58, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "USDT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NULS",
            "ETH",
            "TFUEL",
            "BNB",
            "ETH",
            "LINK",
            "COS",
            "EOS",
            "BCH",
            "THETA",
            "XRP",
            "ETC",
            "COS",
            "LTC",
            "OMG",
            "BNB",
            "ADA",
            "XTZ",
            "LINK",
            "MATIC",
            "OMG",
            "TRX",
            "IOTX",
            "XRP",
            "FUEL",
            "VET",
            "BCH",
            "IOTX",
            "EOS",
            "LTC",
            "ONT",
            "NEO",
            "RVN",
            "XTZ",
            "XMR",
            "ICX",
            "ZIL",
            "BNT",
            "KNC",
            "QTUM",
            "ZIL",
            "ADA",
            "DASH",
            "XMR",
            "XLM",
            "ERD",
            "ETC",
            "TUSD",
            "ENJ",
            "TUSD",
            "IOST",
            "ZEC",
            "PAX",
            "ALGO",
            "PAX",
            "POLY",
            "ICX",
            "AMB",
            "RVN",
            "ALGO",
            "BNT",
            "HOT",
            "COTI",
            "BAT",
            "PHB",
            "ENJ",
            "ZRX",
            "OGN",
            "TNT",
            "ZRX",
            "TRX",
            "TCT",
            "KAVA",
            "BTT",
            "NKN",
            "OGN",
            "HOT",
            "VET",
            "BAT",
            "AION",
            "CHR",
            "KAVA",
            "ZEC",
            "NEO",
            "FET",
            "XLM",
            "XVG",
            "ONT",
            "NANO",
            "ATOM",
            "REN",
            "LTO",
            "BAND",
            "FTM",
            "WRX",
            "DASH",
            "HBAR",
            "IOTA",
            "NANO",
            "WTC",
            "CND",
            "WRX",
            "NPXS",
            "IOST",
            "AION",
            "QTUM",
            "DUSK",
            "NAS",
            "CHZ",
            "HC",
            "POA",
            "WAVES",
            "ARDR",
            "XEM",
            "FTM",
            "CTSI",
            "VIB",
            "GAS",
            "COTI",
            "HBAR",
            "WABI",
            "CHR",
            "DATA",
            "NKN",
            "GTO",
            "SOL",
            "HC",
            "BAND",
            "TOMO",
            "NGN",
            "TROY",
            "WAVES",
            "EUR",
            "IOTA",
            "HIVE",
            "CELR",
            "SC",
            "WIN",
            "ARK",
            "ERD",
            "SNT",
            "BEAM",
            "BEAM",
            "STEEM",
            "SNGLS",
            "MANA",
            "HIVE",
            "PERL",
            "CELR",
            "STX",
            "ENG",
            "BCD",
            "MTL",
            "ONE",
            "STX",
            "ARDR",
            "REN",
            "DREP",
            "ATOM",
            "LSK",
            "CHZ",
            "ARN",
            "QKC",
            "ZEN",
            "ONE",
            "COSBNB",
            "CDT",
            "DUSK",
            "BCHPAX",
            "TOMO",
            "FET",
            "ETHTUSD",
            "STRAT",
            "FUN",
            "MITH",
            "DOCK",
            "PERL",
            "KMD",
            "MBL",
            "MCO",
            "BTG",
            "STPT",
            "WAN",
            "TRY",
            "GO",
            "AE",
            "ARPA",
            "CTSI",
            "POWR",
            "DATA",
            "TROY",
            "SKY",
            "BCHTUSD",
            "RLC",
            "POE",
            "VITE",
            "WTC",
            "DENT",
            "FTT",
            "WAN",
            "MITH",
            "TCT",
            "LEND",
            "XZC",
            "QLC",
            "ANKR",
            "LOOM",
            "PPT",
            "STORM",
            "DOGE",
            "ELF",
            "AGI",
            "OST",
            "REP",
            "ANKR",
            "KEY",
            "GNT",
            "MDA",
            "TNB",
            "STORJ",
            "CVC",
            "STPT",
            "APPC",
            "MBL",
            "EVX",
            "ONG",
            "LSK",
            "VITE",
            "ARPA",
            "GTO",
            "BTS",
            "MCO",
            "ONG",
            "SNM",
            "MTL",
            "CMT",
            "LUN",
            "STRAT",
            "PIVX",
            "MTH",
            "LTO",
            "VIBE",
            "EDO",
            "XZC",
            "VIA",
            "BQX",
            "DCR",
            "COCOS",
            "BTS",
            "DNT",
            "QSP",
            "CVC",
            "BCPT",
            "FUN",
            "ADX",
            "RCN",
            "LRC",
            "DOCK",
            "STORM",
            "RLC",
            "GRS",
            "DOGE",
            "NAV",
            "DREP",
            "LEND",
            "FTT",
            "CTXC",
            "NULS",
            "SYS",
            "AST",
            "MFT"});
            this.comboBox1.Location = new System.Drawing.Point(58, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "BTC";
            // 
            // label_ToSwap
            // 
            this.label_ToSwap.AutoSize = true;
            this.label_ToSwap.Location = new System.Drawing.Point(5, 57);
            this.label_ToSwap.Name = "label_ToSwap";
            this.label_ToSwap.Size = new System.Drawing.Size(25, 13);
            this.label_ToSwap.TabIndex = 1;
            this.label_ToSwap.Text = "To: ";
            // 
            // label_FromAsset
            // 
            this.label_FromAsset.AutoSize = true;
            this.label_FromAsset.Location = new System.Drawing.Point(5, 28);
            this.label_FromAsset.Name = "label_FromAsset";
            this.label_FromAsset.Size = new System.Drawing.Size(36, 13);
            this.label_FromAsset.TabIndex = 0;
            this.label_FromAsset.Text = "From:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_BalanceResult);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button_GetBalance);
            this.groupBox3.Controls.Add(this.comboBox_Balance);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Location = new System.Drawing.Point(6, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 92);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wallet";
            // 
            // numericUpDown_BalanceResult
            // 
            this.numericUpDown_BalanceResult.DecimalPlaces = 8;
            this.numericUpDown_BalanceResult.Location = new System.Drawing.Point(55, 58);
            this.numericUpDown_BalanceResult.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown_BalanceResult.Name = "numericUpDown_BalanceResult";
            this.numericUpDown_BalanceResult.ReadOnly = true;
            this.numericUpDown_BalanceResult.Size = new System.Drawing.Size(134, 22);
            this.numericUpDown_BalanceResult.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result: ";
            // 
            // button_GetBalance
            // 
            this.button_GetBalance.Location = new System.Drawing.Point(6, 20);
            this.button_GetBalance.Name = "button_GetBalance";
            this.button_GetBalance.Size = new System.Drawing.Size(90, 23);
            this.button_GetBalance.TabIndex = 1;
            this.button_GetBalance.Text = "Get Balance:";
            this.button_GetBalance.UseVisualStyleBackColor = true;
            this.button_GetBalance.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_Balance
            // 
            this.comboBox_Balance.FormattingEnabled = true;
            this.comboBox_Balance.Items.AddRange(new object[] {
            "NULS",
            "ETH",
            "TFUEL",
            "BNB",
            "ETH",
            "LINK",
            "COS",
            "EOS",
            "BCH",
            "THETA",
            "XRP",
            "ETC",
            "COS",
            "LTC",
            "OMG",
            "BNB",
            "ADA",
            "XTZ",
            "LINK",
            "MATIC",
            "OMG",
            "TRX",
            "IOTX",
            "XRP",
            "FUEL",
            "VET",
            "BCH",
            "IOTX",
            "EOS",
            "LTC",
            "ONT",
            "NEO",
            "RVN",
            "XTZ",
            "XMR",
            "ICX",
            "ZIL",
            "BNT",
            "KNC",
            "QTUM",
            "ZIL",
            "ADA",
            "DASH",
            "XMR",
            "XLM",
            "ERD",
            "ETC",
            "TUSD",
            "ENJ",
            "TUSD",
            "IOST",
            "ZEC",
            "PAX",
            "ALGO",
            "PAX",
            "POLY",
            "ICX",
            "AMB",
            "RVN",
            "ALGO",
            "BNT",
            "HOT",
            "COTI",
            "BAT",
            "PHB",
            "ENJ",
            "ZRX",
            "OGN",
            "TNT",
            "ZRX",
            "TRX",
            "TCT",
            "KAVA",
            "BTT",
            "NKN",
            "OGN",
            "HOT",
            "VET",
            "BAT",
            "AION",
            "CHR",
            "KAVA",
            "ZEC",
            "NEO",
            "FET",
            "XLM",
            "XVG",
            "ONT",
            "NANO",
            "ATOM",
            "REN",
            "LTO",
            "BAND",
            "FTM",
            "WRX",
            "DASH",
            "HBAR",
            "IOTA",
            "NANO",
            "WTC",
            "CND",
            "WRX",
            "NPXS",
            "IOST",
            "AION",
            "QTUM",
            "DUSK",
            "NAS",
            "CHZ",
            "HC",
            "POA",
            "WAVES",
            "ARDR",
            "XEM",
            "FTM",
            "CTSI",
            "VIB",
            "GAS",
            "COTI",
            "HBAR",
            "WABI",
            "CHR",
            "DATA",
            "NKN",
            "GTO",
            "SOL",
            "HC",
            "BAND",
            "TOMO",
            "NGN",
            "TROY",
            "WAVES",
            "EUR",
            "IOTA",
            "HIVE",
            "CELR",
            "SC",
            "WIN",
            "ARK",
            "ERD",
            "SNT",
            "BEAM",
            "BEAM",
            "STEEM",
            "SNGLS",
            "MANA",
            "HIVE",
            "PERL",
            "CELR",
            "STX",
            "ENG",
            "BCD",
            "MTL",
            "ONE",
            "STX",
            "ARDR",
            "REN",
            "DREP",
            "ATOM",
            "LSK",
            "CHZ",
            "ARN",
            "QKC",
            "ZEN",
            "ONE",
            "COSBNB",
            "CDT",
            "DUSK",
            "BCHPAX",
            "TOMO",
            "FET",
            "ETHTUSD",
            "STRAT",
            "FUN",
            "MITH",
            "DOCK",
            "PERL",
            "KMD",
            "MBL",
            "MCO",
            "BTG",
            "STPT",
            "WAN",
            "TRY",
            "GO",
            "AE",
            "ARPA",
            "CTSI",
            "POWR",
            "DATA",
            "TROY",
            "SKY",
            "BCHTUSD",
            "RLC",
            "POE",
            "VITE",
            "WTC",
            "DENT",
            "FTT",
            "WAN",
            "MITH",
            "TCT",
            "LEND",
            "XZC",
            "QLC",
            "ANKR",
            "LOOM",
            "PPT",
            "STORM",
            "DOGE",
            "ELF",
            "AGI",
            "OST",
            "REP",
            "ANKR",
            "KEY",
            "GNT",
            "MDA",
            "TNB",
            "STORJ",
            "CVC",
            "STPT",
            "APPC",
            "MBL",
            "EVX",
            "ONG",
            "LSK",
            "VITE",
            "ARPA",
            "GTO",
            "BTS",
            "MCO",
            "ONG",
            "SNM",
            "MTL",
            "CMT",
            "LUN",
            "STRAT",
            "PIVX",
            "MTH",
            "LTO",
            "VIBE",
            "EDO",
            "XZC",
            "VIA",
            "BQX",
            "DCR",
            "COCOS",
            "BTS",
            "DNT",
            "QSP",
            "CVC",
            "BCPT",
            "FUN",
            "ADX",
            "RCN",
            "LRC",
            "DOCK",
            "STORM",
            "RLC",
            "GRS",
            "DOGE",
            "NAV",
            "DREP",
            "LEND",
            "FTT",
            "CTXC",
            "NULS",
            "SYS",
            "AST",
            "MFT"});
            this.comboBox_Balance.Location = new System.Drawing.Point(102, 21);
            this.comboBox_Balance.Name = "comboBox_Balance";
            this.comboBox_Balance.Size = new System.Drawing.Size(87, 21);
            this.comboBox_Balance.TabIndex = 0;
            this.comboBox_Balance.Text = "BTC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_EndProfit);
            this.groupBox2.Controls.Add(this.numericUpDown_StopLoss);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBox_SellAssetsAfterBotting);
            this.groupBox2.Controls.Add(this.button_StopBot);
            this.groupBox2.Controls.Add(this.comboBox_Pair);
            this.groupBox2.Controls.Add(this.label_BotPair);
            this.groupBox2.Controls.Add(this.button_StartBot);
            this.groupBox2.Controls.Add(this.numericUpDown_USDTInvest);
            this.groupBox2.Controls.Add(this.label_USDTInvest);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label_HighPrice);
            this.groupBox2.Controls.Add(this.label_LowestPrice);
            this.groupBox2.Controls.Add(this.numericUpDown_PriceLowest);
            this.groupBox2.Controls.Add(this.label_BotType);
            this.groupBox2.Controls.Add(this.comboBox_BotType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown_Grids);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(401, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bots";
            // 
            // numericUpDown_EndProfit
            // 
            this.numericUpDown_EndProfit.DecimalPlaces = 4;
            this.numericUpDown_EndProfit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown_EndProfit.Location = new System.Drawing.Point(90, 212);
            this.numericUpDown_EndProfit.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown_EndProfit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_EndProfit.Name = "numericUpDown_EndProfit";
            this.numericUpDown_EndProfit.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown_EndProfit.TabIndex = 18;
            this.numericUpDown_EndProfit.Tag = "";
            this.numericUpDown_EndProfit.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numericUpDown_StopLoss
            // 
            this.numericUpDown_StopLoss.DecimalPlaces = 4;
            this.numericUpDown_StopLoss.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown_StopLoss.Location = new System.Drawing.Point(90, 183);
            this.numericUpDown_StopLoss.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown_StopLoss.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_StopLoss.Name = "numericUpDown_StopLoss";
            this.numericUpDown_StopLoss.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown_StopLoss.TabIndex = 17;
            this.numericUpDown_StopLoss.Tag = "";
            this.numericUpDown_StopLoss.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Take Profits at:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stop Loss Price:";
            // 
            // checkBox_SellAssetsAfterBotting
            // 
            this.checkBox_SellAssetsAfterBotting.AutoSize = true;
            this.checkBox_SellAssetsAfterBotting.Location = new System.Drawing.Point(9, 302);
            this.checkBox_SellAssetsAfterBotting.Name = "checkBox_SellAssetsAfterBotting";
            this.checkBox_SellAssetsAfterBotting.Size = new System.Drawing.Size(175, 17);
            this.checkBox_SellAssetsAfterBotting.TabIndex = 14;
            this.checkBox_SellAssetsAfterBotting.Text = "Sell Assets for USDT Post-bot";
            this.checkBox_SellAssetsAfterBotting.UseVisualStyleBackColor = true;
            // 
            // button_StopBot
            // 
            this.button_StopBot.Location = new System.Drawing.Point(7, 354);
            this.button_StopBot.Name = "button_StopBot";
            this.button_StopBot.Size = new System.Drawing.Size(205, 23);
            this.button_StopBot.TabIndex = 13;
            this.button_StopBot.Text = "Stop Bot";
            this.button_StopBot.UseVisualStyleBackColor = true;
            // 
            // comboBox_Pair
            // 
            this.comboBox_Pair.FormattingEnabled = true;
            this.comboBox_Pair.Items.AddRange(new object[] {
            "NULSUSDT",
            "BTCUSDT",
            "ETHUSDT",
            "TFUELBTC",
            "TFUELUSDT",
            "BNBUSDT",
            "ETHBTC",
            "LINKUSDT",
            "COSBTC",
            "EOSUSDT",
            "BCHUSDT",
            "THETABTC",
            "XRPUSDT",
            "THETAUSDT",
            "ETCUSDT",
            "COSUSDT",
            "LTCUSDT",
            "OMGUSDT",
            "BNBBTC",
            "ADAUSDT",
            "MATICUSDT",
            "XTZUSDT",
            "LINKBTC",
            "MATICBTC",
            "OMGBTC",
            "TRXUSDT",
            "IOTXBTC",
            "XRPBTC",
            "FUELBTC",
            "VETUSDT",
            "BCHBTC",
            "IOTXUSDT",
            "EOSBTC",
            "LTCBTC",
            "ONTUSDT",
            "NEOUSDT",
            "RVNBTC",
            "XTZBTC",
            "XMRBTC",
            "ICXUSDT",
            "ZILUSDT",
            "BNTBTC",
            "KNCBTC",
            "QTUMUSDT",
            "ZILBTC",
            "ADABTC",
            "DASHUSDT",
            "XMRUSDT",
            "XLMUSDT",
            "ERDUSDT",
            "ETCBTC",
            "TUSDUSDT",
            "ENJBTC",
            "BTCTUSD",
            "IOSTUSDT",
            "ZECUSDT",
            "PAXUSDT",
            "ALGOUSDT",
            "BTCPAX",
            "POLYBTC",
            "ICXBTC",
            "AMBBTC",
            "RVNUSDT",
            "ALGOBTC",
            "BNTUSDT",
            "HOTUSDT",
            "COTIBTC",
            "BATUSDT",
            "PHBBTC",
            "ENJUSDT",
            "ZRXBTC",
            "OGNBTC",
            "TNTBTC",
            "ZRXUSDT",
            "TRXBTC",
            "TCTBTC",
            "KAVAUSDT",
            "BTTUSDT",
            "NKNBTC",
            "OGNUSDT",
            "HOTBTC",
            "VETBTC",
            "BATBTC",
            "AIONBTC",
            "CHRBTC",
            "KAVABTC",
            "ZECBTC",
            "NEOBTC",
            "FETUSDT",
            "XLMBTC",
            "XVGBTC",
            "ONTBTC",
            "NANOUSDT",
            "ATOMUSDT",
            "RENBTC",
            "LTOBTC",
            "BANDUSDT",
            "FTMBTC",
            "WRXBTC",
            "DASHBTC",
            "HBARBTC",
            "IOTAUSDT",
            "NANOBTC",
            "WTCBTC",
            "CNDBTC",
            "WRXUSDT",
            "NPXSUSDT",
            "IOSTBTC",
            "AIONUSDT",
            "QTUMBTC",
            "DUSKBTC",
            "NASBTC",
            "CHZBTC",
            "HCUSDT",
            "POABTC",
            "WAVESBTC",
            "ARDRBTC",
            "XEMBTC",
            "FTMUSDT",
            "CTSIBTC",
            "VIBBTC",
            "GASBTC",
            "COTIUSDT",
            "HBARUSDT",
            "WABIBTC",
            "CHRUSDT",
            "DATABTC",
            "NKNUSDT",
            "GTOBTC",
            "SOLBTC",
            "HCBTC",
            "BANDBTC",
            "TOMOBTC",
            "BTCNGN",
            "TROYBTC",
            "WAVESUSDT",
            "BTCEUR",
            "IOTABTC",
            "HIVEBTC",
            "CELRBTC",
            "SCBTC",
            "WINUSDT",
            "ARKBTC",
            "ERDBTC",
            "SNTBTC",
            "BEAMUSDT",
            "BEAMBTC",
            "STEEMBTC",
            "SNGLSBTC",
            "MANABTC",
            "HIVEUSDT",
            "PERLBTC",
            "CELRUSDT",
            "STXUSDT",
            "ENGBTC",
            "BCDBTC",
            "MTLBTC",
            "ONEBTC",
            "STXBTC",
            "ARDRUSDT",
            "RENUSDT",
            "DREPBTC",
            "ATOMBTC",
            "LSKBTC",
            "CHZUSDT",
            "ARNBTC",
            "QKCBTC",
            "ZENBTC",
            "ONEUSDT",
            "COSBNB",
            "CDTBTC",
            "DUSKUSDT",
            "BCHPAX",
            "TOMOUSDT",
            "FETBTC",
            "ETHTUSD",
            "STRATBTC",
            "FUNBTC",
            "MITHUSDT",
            "DOCKBTC",
            "PERLUSDT",
            "KMDBTC",
            "MBLUSDT",
            "MCOBTC",
            "BTGBTC",
            "STPTBTC",
            "WANBTC",
            "USDTTRY",
            "GOBTC",
            "AEBTC",
            "ARPABTC",
            "CTSIUSDT",
            "POWRBTC",
            "DATAUSDT",
            "TROYUSDT",
            "SKYBTC",
            "BCHTUSD",
            "RLCBTC",
            "POEBTC",
            "VITEBTC",
            "WTCUSDT",
            "DENTUSDT",
            "FTTBTC",
            "WANUSDT",
            "MITHBTC",
            "TCTUSDT",
            "LENDBTC",
            "XZCBTC",
            "QLCBTC",
            "ANKRUSDT",
            "LOOMBTC",
            "PPTBTC",
            "STORMUSDT",
            "DOGEUSDT",
            "ELFBTC",
            "AGIBTC",
            "OSTBTC",
            "REPBTC",
            "ANKRBTC",
            "KEYUSDT",
            "GNTBTC",
            "MDABTC",
            "TNBBTC",
            "STORJBTC",
            "CVCBTC",
            "STPTUSDT",
            "APPCBTC",
            "MBLBTC",
            "EVXBTC",
            "ONGBTC",
            "LSKUSDT",
            "VITEUSDT",
            "ARPAUSDT",
            "GTOUSDT",
            "BTSBTC",
            "MCOUSDT",
            "ONGUSDT",
            "SNMBTC",
            "MTLUSDT",
            "CMTBTC",
            "LUNBTC",
            "STRATUSDT",
            "PIVXBTC",
            "MTHBTC",
            "LTOUSDT",
            "VIBEBTC",
            "EDOBTC",
            "XZCUSDT",
            "VIABTC",
            "BQXBTC",
            "DCRBTC",
            "COCOSUSDT",
            "BTSUSDT",
            "DNTBTC",
            "QSPBTC",
            "CVCUSDT",
            "BCPTBTC",
            "FUNUSDT",
            "ADXBTC",
            "RCNBTC",
            "LRCBTC",
            "DOCKUSDT",
            "STORMBTC",
            "RLCUSDT",
            "GRSBTC",
            "DOGEBTC",
            "NAVBTC",
            "DREPUSDT",
            "LENDUSDT",
            "FTTUSDT",
            "CTXCUSDT",
            "NULSBTC",
            "SYSBTC",
            "ASTBTC",
            "MFTUSDT"});
            this.comboBox_Pair.Location = new System.Drawing.Point(90, 155);
            this.comboBox_Pair.Name = "comboBox_Pair";
            this.comboBox_Pair.Size = new System.Drawing.Size(114, 21);
            this.comboBox_Pair.TabIndex = 12;
            this.comboBox_Pair.Text = "BNBUSDT";
            // 
            // label_BotPair
            // 
            this.label_BotPair.AutoSize = true;
            this.label_BotPair.Location = new System.Drawing.Point(6, 158);
            this.label_BotPair.Name = "label_BotPair";
            this.label_BotPair.Size = new System.Drawing.Size(29, 13);
            this.label_BotPair.TabIndex = 11;
            this.label_BotPair.Text = "Pair:";
            // 
            // button_StartBot
            // 
            this.button_StartBot.Location = new System.Drawing.Point(7, 326);
            this.button_StartBot.Name = "button_StartBot";
            this.button_StartBot.Size = new System.Drawing.Size(205, 23);
            this.button_StartBot.TabIndex = 10;
            this.button_StartBot.Text = "Start Bot";
            this.button_StartBot.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_USDTInvest
            // 
            this.numericUpDown_USDTInvest.DecimalPlaces = 4;
            this.numericUpDown_USDTInvest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown_USDTInvest.Location = new System.Drawing.Point(90, 129);
            this.numericUpDown_USDTInvest.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown_USDTInvest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_USDTInvest.Name = "numericUpDown_USDTInvest";
            this.numericUpDown_USDTInvest.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown_USDTInvest.TabIndex = 9;
            this.numericUpDown_USDTInvest.Tag = "";
            this.numericUpDown_USDTInvest.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label_USDTInvest
            // 
            this.label_USDTInvest.AutoSize = true;
            this.label_USDTInvest.Location = new System.Drawing.Point(3, 131);
            this.label_USDTInvest.Name = "label_USDTInvest";
            this.label_USDTInvest.Size = new System.Drawing.Size(89, 13);
            this.label_USDTInvest.TabIndex = 8;
            this.label_USDTInvest.Text = "USDT To Invest: ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 4;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown2.Location = new System.Drawing.Point(90, 102);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label_HighPrice
            // 
            this.label_HighPrice.AutoSize = true;
            this.label_HighPrice.Location = new System.Drawing.Point(6, 104);
            this.label_HighPrice.Name = "label_HighPrice";
            this.label_HighPrice.Size = new System.Drawing.Size(62, 13);
            this.label_HighPrice.TabIndex = 6;
            this.label_HighPrice.Text = "High Price:";
            // 
            // label_LowestPrice
            // 
            this.label_LowestPrice.AutoSize = true;
            this.label_LowestPrice.Location = new System.Drawing.Point(6, 77);
            this.label_LowestPrice.Name = "label_LowestPrice";
            this.label_LowestPrice.Size = new System.Drawing.Size(58, 13);
            this.label_LowestPrice.TabIndex = 5;
            this.label_LowestPrice.Text = "Low Price:";
            // 
            // numericUpDown_PriceLowest
            // 
            this.numericUpDown_PriceLowest.DecimalPlaces = 4;
            this.numericUpDown_PriceLowest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown_PriceLowest.Location = new System.Drawing.Point(90, 75);
            this.numericUpDown_PriceLowest.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown_PriceLowest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PriceLowest.Name = "numericUpDown_PriceLowest";
            this.numericUpDown_PriceLowest.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown_PriceLowest.TabIndex = 4;
            this.numericUpDown_PriceLowest.Tag = "";
            this.numericUpDown_PriceLowest.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label_BotType
            // 
            this.label_BotType.AutoSize = true;
            this.label_BotType.Location = new System.Drawing.Point(6, 25);
            this.label_BotType.Name = "label_BotType";
            this.label_BotType.Size = new System.Drawing.Size(36, 13);
            this.label_BotType.TabIndex = 3;
            this.label_BotType.Text = "Type: ";
            // 
            // comboBox_BotType
            // 
            this.comboBox_BotType.FormattingEnabled = true;
            this.comboBox_BotType.Items.AddRange(new object[] {
            "Grid Trading",
            "Leveraged Grid",
            "Infinite Grid",
            "Reverse Grid",
            "Leveraged Reverse Grid"});
            this.comboBox_BotType.Location = new System.Drawing.Point(90, 22);
            this.comboBox_BotType.Name = "comboBox_BotType";
            this.comboBox_BotType.Size = new System.Drawing.Size(114, 21);
            this.comboBox_BotType.TabIndex = 2;
            this.comboBox_BotType.Text = "Grid Trading";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grids:";
            // 
            // numericUpDown_Grids
            // 
            this.numericUpDown_Grids.Location = new System.Drawing.Point(90, 49);
            this.numericUpDown_Grids.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_Grids.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_Grids.Name = "numericUpDown_Grids";
            this.numericUpDown_Grids.Size = new System.Drawing.Size(114, 22);
            this.numericUpDown_Grids.TabIndex = 0;
            this.numericUpDown_Grids.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Server);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Account);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Location = new System.Drawing.Point(8, 75);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(153, 13);
            this.label_Server.TabIndex = 2;
            this.label_Server.Text = "API Server: api4.binance.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Time: ";
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Location = new System.Drawing.Point(8, 25);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(61, 13);
            this.label_Account.TabIndex = 0;
            this.label_Account.Text = "Username:";
            // 
            // tabPage_Bots
            // 
            this.tabPage_Bots.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Bots.Controls.Add(this.label9);
            this.tabPage_Bots.Controls.Add(this.label8);
            this.tabPage_Bots.Controls.Add(this.groupBox_Txs);
            this.tabPage_Bots.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Bots.Name = "tabPage_Bots";
            this.tabPage_Bots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Bots.Size = new System.Drawing.Size(624, 395);
            this.tabPage_Bots.TabIndex = 1;
            this.tabPage_Bots.Text = "Bots";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Profit Holding:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Profit Taken:";
            // 
            // groupBox_Txs
            // 
            this.groupBox_Txs.Controls.Add(this.progressBar1);
            this.groupBox_Txs.Location = new System.Drawing.Point(166, 9);
            this.groupBox_Txs.Name = "groupBox_Txs";
            this.groupBox_Txs.Size = new System.Drawing.Size(452, 380);
            this.groupBox_Txs.TabIndex = 0;
            this.groupBox_Txs.TabStop = false;
            this.groupBox_Txs.Text = "Transactions";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(656, 445);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Anti-China Bot";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox_Swap.ResumeLayout(false);
            this.groupBox_Swap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SwapSpotPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BalanceResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EndProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StopLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_USDTInvest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PriceLowest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Grids)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Bots.ResumeLayout(false);
            this.tabPage_Bots.PerformLayout();
            this.groupBox_Txs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_Bots;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox_Swap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_SwapSpotPrice;
        private System.Windows.Forms.Button button_SwapAllSpot;
        private System.Windows.Forms.Button button_SwapAll;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_ToSwap;
        private System.Windows.Forms.Label label_FromAsset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown_BalanceResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_GetBalance;
        private System.Windows.Forms.ComboBox comboBox_Balance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Pair;
        private System.Windows.Forms.Label label_BotPair;
        private System.Windows.Forms.Button button_StartBot;
        private System.Windows.Forms.NumericUpDown numericUpDown_USDTInvest;
        private System.Windows.Forms.Label label_USDTInvest;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label_HighPrice;
        private System.Windows.Forms.Label label_LowestPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_PriceLowest;
        private System.Windows.Forms.Label label_BotType;
        private System.Windows.Forms.ComboBox comboBox_BotType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Grids;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.GroupBox groupBox_Txs;
        private System.Windows.Forms.NumericUpDown numericUpDown_EndProfit;
        private System.Windows.Forms.NumericUpDown numericUpDown_StopLoss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_SellAssetsAfterBotting;
        private System.Windows.Forms.Button button_StopBot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_SelectBotFile;
        private System.Windows.Forms.Button button3;
    }
}