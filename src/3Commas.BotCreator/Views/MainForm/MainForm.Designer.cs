namespace _3Commas.BotCreator.Views.MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.cmbStrategy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numBaseOrderVolume = new System.Windows.Forms.NumericUpDown();
            this.numSafetyOrderVolume = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuoteCurrency = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblBuyTitle = new System.Windows.Forms.Label();
            this.numAmountToBuy = new System.Windows.Forms.NumericUpDown();
            this.txtBotname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStartOrderType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numSafetyOrderVolumeScale = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numPriceDeviationToOpenSafetyOrders = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.chkTrailing = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTrailing = new System.Windows.Forms.Label();
            this.numTrailingDeviation = new System.Windows.Forms.NumericUpDown();
            this.numMaxSafetyTradesCount = new System.Windows.Forms.NumericUpDown();
            this.lblMaxSafetyTradesCount = new System.Windows.Forms.Label();
            this.numMaxActiveSafetyTradesCount = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numSafetyOrderStepScale = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numTargetProfit = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.lblQuoteCurrency = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTrailingUnit = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewStartConditions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.numCooldownBetweenDeals = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBotNamePreview = new System.Windows.Forms.Label();
            this.cmbExchange = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.linkLabelHuobi = new System.Windows.Forms.LinkLabel();
            this.linkLabelBinance = new System.Windows.Forms.LinkLabel();
            this.linkLabel3Commas = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbBinance = new System.Windows.Forms.RadioButton();
            this.rbHuobi = new System.Windows.Forms.RadioButton();
            this.panelBotSettings = new System.Windows.Forms.Panel();
            this.lblLeverageCustomValue = new System.Windows.Forms.Label();
            this.numCustomLeverageValue = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbLeverageType = new System.Windows.Forms.ComboBox();
            this.panelStopLoss = new System.Windows.Forms.Panel();
            this.numStopLossPercentage = new System.Windows.Forms.NumericUpDown();
            this.lblStopLossTimeoutUnit = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbStopLossType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.chkStopLossTimeoutEnabled = new System.Windows.Forms.CheckBox();
            this.numStopLossTimeout = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.chkStopLossEnabled = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.chkBuyBase = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddStartCondition = new System.Windows.Forms.Button();
            this.chkLogCheckForBaseStablecoin = new System.Windows.Forms.CheckBox();
            this.chkLogCheckForExistingBots = new System.Windows.Forms.CheckBox();
            this.chkLogCheckForExistingPairWithSameBaseCurrency = new System.Windows.Forms.CheckBox();
            this.chkCheckForExistingPairWithSameBaseCurrency = new System.Windows.Forms.CheckBox();
            this.chkCheckForExistingBots = new System.Windows.Forms.CheckBox();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLogSkipUpDownPairs = new System.Windows.Forms.CheckBox();
            this.chkSkipUpDownPairs = new System.Windows.Forms.CheckBox();
            this.logSkipFirstTradeXDaysAgo = new System.Windows.Forms.CheckBox();
            this.chkLogSkipMinVolume = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.numMinVolume = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCheckForBaseStablecoin = new System.Windows.Forms.CheckBox();
            this.chkLogSkipBlacklistedPairs = new System.Windows.Forms.CheckBox();
            this.chkSkipBlacklistedPairs = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.numFirstTradeXDaysAgo = new System.Windows.Forms.NumericUpDown();
            this.toolTipBlacklist = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStablecoins = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseOrderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSafetyOrderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSafetyOrderVolumeScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceDeviationToOpenSafetyOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrailingDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSafetyTradesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxActiveSafetyTradesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSafetyOrderStepScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldownBetweenDeals)).BeginInit();
            this.groupBoxCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBotSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomLeverageValue)).BeginInit();
            this.panelStopLoss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStopLossPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopLossTimeout)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstTradeXDaysAgo)).BeginInit();
            this.SuspendLayout();
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(171, 25);
            this.numAmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(51, 20);
            this.numAmount.TabIndex = 0;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Bots to create:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Strategy";
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Checked = true;
            this.chkEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnable.Location = new System.Drawing.Point(228, 27);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(59, 17);
            this.chkEnable.TabIndex = 1;
            this.chkEnable.Text = "Enable";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // cmbStrategy
            // 
            this.cmbStrategy.FormattingEnabled = true;
            this.cmbStrategy.Location = new System.Drawing.Point(222, 56);
            this.cmbStrategy.Name = "cmbStrategy";
            this.cmbStrategy.Size = new System.Drawing.Size(121, 21);
            this.cmbStrategy.TabIndex = 5;
            this.cmbStrategy.SelectedIndexChanged += new System.EventHandler(this.cmbStrategy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base order size";
            // 
            // numBaseOrderVolume
            // 
            this.numBaseOrderVolume.DecimalPlaces = 8;
            this.numBaseOrderVolume.Location = new System.Drawing.Point(222, 243);
            this.numBaseOrderVolume.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBaseOrderVolume.Name = "numBaseOrderVolume";
            this.numBaseOrderVolume.Size = new System.Drawing.Size(121, 20);
            this.numBaseOrderVolume.TabIndex = 13;
            this.numBaseOrderVolume.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numSafetyOrderVolume
            // 
            this.numSafetyOrderVolume.DecimalPlaces = 8;
            this.numSafetyOrderVolume.Location = new System.Drawing.Point(222, 269);
            this.numSafetyOrderVolume.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSafetyOrderVolume.Name = "numSafetyOrderVolume";
            this.numSafetyOrderVolume.Size = new System.Drawing.Size(121, 20);
            this.numSafetyOrderVolume.TabIndex = 14;
            this.numSafetyOrderVolume.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Safety order size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quote Currency";
            // 
            // txtQuoteCurrency
            // 
            this.txtQuoteCurrency.Location = new System.Drawing.Point(222, 30);
            this.txtQuoteCurrency.Name = "txtQuoteCurrency";
            this.txtQuoteCurrency.Size = new System.Drawing.Size(120, 20);
            this.txtQuoteCurrency.TabIndex = 4;
            this.txtQuoteCurrency.Text = "USDT";
            this.txtQuoteCurrency.TextChanged += new System.EventHandler(this.txtQuoteCurrency_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(540, 42);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(480, 611);
            this.txtOutput.TabIndex = 0;
            // 
            // lblBuyTitle
            // 
            this.lblBuyTitle.AutoSize = true;
            this.lblBuyTitle.Enabled = false;
            this.lblBuyTitle.Location = new System.Drawing.Point(51, 710);
            this.lblBuyTitle.Name = "lblBuyTitle";
            this.lblBuyTitle.Size = new System.Drawing.Size(166, 13);
            this.lblBuyTitle.TabIndex = 13;
            this.lblBuyTitle.Text = "Amount to buy (in quote currency)";
            // 
            // numAmountToBuy
            // 
            this.numAmountToBuy.DecimalPlaces = 6;
            this.numAmountToBuy.Enabled = false;
            this.numAmountToBuy.Location = new System.Drawing.Point(222, 707);
            this.numAmountToBuy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmountToBuy.Name = "numAmountToBuy";
            this.numAmountToBuy.Size = new System.Drawing.Size(121, 20);
            this.numAmountToBuy.TabIndex = 28;
            // 
            // txtBotname
            // 
            this.txtBotname.Location = new System.Drawing.Point(222, 83);
            this.txtBotname.Name = "txtBotname";
            this.txtBotname.Size = new System.Drawing.Size(120, 20);
            this.txtBotname.TabIndex = 6;
            this.txtBotname.Text = "{strategy} {pair} Bot";
            this.txtBotname.TextChanged += new System.EventHandler(this.txtBotname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bot Name";
            // 
            // cmbStartOrderType
            // 
            this.cmbStartOrderType.FormattingEnabled = true;
            this.cmbStartOrderType.Location = new System.Drawing.Point(222, 148);
            this.cmbStartOrderType.Name = "cmbStartOrderType";
            this.cmbStartOrderType.Size = new System.Drawing.Size(121, 21);
            this.cmbStartOrderType.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Start Order Type";
            // 
            // numSafetyOrderVolumeScale
            // 
            this.numSafetyOrderVolumeScale.DecimalPlaces = 2;
            this.numSafetyOrderVolumeScale.Location = new System.Drawing.Point(222, 553);
            this.numSafetyOrderVolumeScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSafetyOrderVolumeScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSafetyOrderVolumeScale.Name = "numSafetyOrderVolumeScale";
            this.numSafetyOrderVolumeScale.Size = new System.Drawing.Size(121, 20);
            this.numSafetyOrderVolumeScale.TabIndex = 22;
            this.numSafetyOrderVolumeScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(90, 555);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Safety order volume scale";
            // 
            // numPriceDeviationToOpenSafetyOrders
            // 
            this.numPriceDeviationToOpenSafetyOrders.DecimalPlaces = 2;
            this.numPriceDeviationToOpenSafetyOrders.Location = new System.Drawing.Point(222, 527);
            this.numPriceDeviationToOpenSafetyOrders.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPriceDeviationToOpenSafetyOrders.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numPriceDeviationToOpenSafetyOrders.Name = "numPriceDeviationToOpenSafetyOrders";
            this.numPriceDeviationToOpenSafetyOrders.Size = new System.Drawing.Size(121, 20);
            this.numPriceDeviationToOpenSafetyOrders.TabIndex = 21;
            this.numPriceDeviationToOpenSafetyOrders.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Price deviation to open safety orders";
            // 
            // chkTrailing
            // 
            this.chkTrailing.AutoSize = true;
            this.chkTrailing.Location = new System.Drawing.Point(222, 322);
            this.chkTrailing.Name = "chkTrailing";
            this.chkTrailing.Size = new System.Drawing.Size(15, 14);
            this.chkTrailing.TabIndex = 16;
            this.chkTrailing.UseVisualStyleBackColor = true;
            this.chkTrailing.CheckedChanged += new System.EventHandler(this.chkTrailing_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(146, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "TTP Enabled";
            // 
            // lblTrailing
            // 
            this.lblTrailing.AutoSize = true;
            this.lblTrailing.Enabled = false;
            this.lblTrailing.Location = new System.Drawing.Point(128, 347);
            this.lblTrailing.Name = "lblTrailing";
            this.lblTrailing.Size = new System.Drawing.Size(89, 13);
            this.lblTrailing.TabIndex = 31;
            this.lblTrailing.Text = "Trailing Deviation";
            // 
            // numTrailingDeviation
            // 
            this.numTrailingDeviation.DecimalPlaces = 2;
            this.numTrailingDeviation.Enabled = false;
            this.numTrailingDeviation.Location = new System.Drawing.Point(222, 343);
            this.numTrailingDeviation.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numTrailingDeviation.Name = "numTrailingDeviation";
            this.numTrailingDeviation.Size = new System.Drawing.Size(121, 20);
            this.numTrailingDeviation.TabIndex = 17;
            // 
            // numMaxSafetyTradesCount
            // 
            this.numMaxSafetyTradesCount.Location = new System.Drawing.Point(222, 475);
            this.numMaxSafetyTradesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSafetyTradesCount.Name = "numMaxSafetyTradesCount";
            this.numMaxSafetyTradesCount.Size = new System.Drawing.Size(51, 20);
            this.numMaxSafetyTradesCount.TabIndex = 19;
            this.numMaxSafetyTradesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxSafetyTradesCount
            // 
            this.lblMaxSafetyTradesCount.AutoSize = true;
            this.lblMaxSafetyTradesCount.Location = new System.Drawing.Point(97, 477);
            this.lblMaxSafetyTradesCount.Name = "lblMaxSafetyTradesCount";
            this.lblMaxSafetyTradesCount.Size = new System.Drawing.Size(120, 13);
            this.lblMaxSafetyTradesCount.TabIndex = 34;
            this.lblMaxSafetyTradesCount.Text = "Max safety trades count";
            // 
            // numMaxActiveSafetyTradesCount
            // 
            this.numMaxActiveSafetyTradesCount.Location = new System.Drawing.Point(222, 501);
            this.numMaxActiveSafetyTradesCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxActiveSafetyTradesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxActiveSafetyTradesCount.Name = "numMaxActiveSafetyTradesCount";
            this.numMaxActiveSafetyTradesCount.Size = new System.Drawing.Size(51, 20);
            this.numMaxActiveSafetyTradesCount.TabIndex = 20;
            this.numMaxActiveSafetyTradesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(66, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Max active safety trades count";
            // 
            // numSafetyOrderStepScale
            // 
            this.numSafetyOrderStepScale.DecimalPlaces = 2;
            this.numSafetyOrderStepScale.Location = new System.Drawing.Point(222, 579);
            this.numSafetyOrderStepScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSafetyOrderStepScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSafetyOrderStepScale.Name = "numSafetyOrderStepScale";
            this.numSafetyOrderStepScale.Size = new System.Drawing.Size(121, 20);
            this.numSafetyOrderStepScale.TabIndex = 23;
            this.numSafetyOrderStepScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 581);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Safety order step scale";
            // 
            // numTargetProfit
            // 
            this.numTargetProfit.DecimalPlaces = 2;
            this.numTargetProfit.Location = new System.Drawing.Point(222, 295);
            this.numTargetProfit.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numTargetProfit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numTargetProfit.Name = "numTargetProfit";
            this.numTargetProfit.Size = new System.Drawing.Size(121, 20);
            this.numTargetProfit.TabIndex = 15;
            this.numTargetProfit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(152, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Target Profit";
            // 
            // lblQuoteCurrency
            // 
            this.lblQuoteCurrency.AutoSize = true;
            this.lblQuoteCurrency.Enabled = false;
            this.lblQuoteCurrency.Location = new System.Drawing.Point(350, 710);
            this.lblQuoteCurrency.Name = "lblQuoteCurrency";
            this.lblQuoteCurrency.Size = new System.Drawing.Size(37, 13);
            this.lblQuoteCurrency.TabIndex = 41;
            this.lblQuoteCurrency.Text = "USDT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "%";
            // 
            // lblTrailingUnit
            // 
            this.lblTrailingUnit.AutoSize = true;
            this.lblTrailingUnit.Enabled = false;
            this.lblTrailingUnit.Location = new System.Drawing.Point(350, 347);
            this.lblTrailingUnit.Name = "lblTrailingUnit";
            this.lblTrailingUnit.Size = new System.Drawing.Size(15, 13);
            this.lblTrailingUnit.TabIndex = 43;
            this.lblTrailingUnit.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(350, 531);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Deal start conditions";
            // 
            // listViewStartConditions
            // 
            this.listViewStartConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewStartConditions.HideSelection = false;
            this.listViewStartConditions.Location = new System.Drawing.Point(222, 174);
            this.listViewStartConditions.Name = "listViewStartConditions";
            this.listViewStartConditions.Size = new System.Drawing.Size(120, 63);
            this.listViewStartConditions.TabIndex = 10;
            this.listViewStartConditions.UseCompatibleStateImageBehavior = false;
            this.listViewStartConditions.View = System.Windows.Forms.View.List;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cooldown between deals";
            // 
            // numCooldownBetweenDeals
            // 
            this.numCooldownBetweenDeals.Location = new System.Drawing.Point(222, 605);
            this.numCooldownBetweenDeals.Maximum = new decimal(new int[] {
            2591999,
            0,
            0,
            0});
            this.numCooldownBetweenDeals.Name = "numCooldownBetweenDeals";
            this.numCooldownBetweenDeals.Size = new System.Drawing.Size(121, 20);
            this.numCooldownBetweenDeals.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "seconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "placeholders: {strategy} {pair}";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(121, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Bot Name Preview:";
            // 
            // lblBotNamePreview
            // 
            this.lblBotNamePreview.AutoSize = true;
            this.lblBotNamePreview.Location = new System.Drawing.Point(219, 127);
            this.lblBotNamePreview.Name = "lblBotNamePreview";
            this.lblBotNamePreview.Size = new System.Drawing.Size(83, 13);
            this.lblBotNamePreview.TabIndex = 8;
            this.lblBotNamePreview.Text = "USDT_XXX Bot";
            // 
            // cmbExchange
            // 
            this.cmbExchange.FormattingEnabled = true;
            this.cmbExchange.Location = new System.Drawing.Point(222, 3);
            this.cmbExchange.Name = "cmbExchange";
            this.cmbExchange.Size = new System.Drawing.Size(121, 21);
            this.cmbExchange.TabIndex = 3;
            this.cmbExchange.SelectedIndexChanged += new System.EventHandler(this.cmbExchange_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(70, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "3Commas Exchange Account";
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.linkLabelHuobi);
            this.groupBoxCredentials.Controls.Add(this.linkLabelBinance);
            this.groupBoxCredentials.Controls.Add(this.linkLabel3Commas);
            this.groupBoxCredentials.Controls.Add(this.pictureBox1);
            this.groupBoxCredentials.Controls.Add(this.rbBinance);
            this.groupBoxCredentials.Controls.Add(this.rbHuobi);
            this.groupBoxCredentials.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(522, 89);
            this.groupBoxCredentials.TabIndex = 64;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "API Credentials";
            // 
            // linkLabelHuobi
            // 
            this.linkLabelHuobi.AutoSize = true;
            this.linkLabelHuobi.Location = new System.Drawing.Point(368, 64);
            this.linkLabelHuobi.Name = "linkLabelHuobi";
            this.linkLabelHuobi.Size = new System.Drawing.Size(64, 13);
            this.linkLabelHuobi.TabIndex = 4;
            this.linkLabelHuobi.TabStop = true;
            this.linkLabelHuobi.Text = "Set API Key";
            this.linkLabelHuobi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHuobi_LinkClicked);
            // 
            // linkLabelBinance
            // 
            this.linkLabelBinance.AutoSize = true;
            this.linkLabelBinance.Location = new System.Drawing.Point(205, 64);
            this.linkLabelBinance.Name = "linkLabelBinance";
            this.linkLabelBinance.Size = new System.Drawing.Size(64, 13);
            this.linkLabelBinance.TabIndex = 2;
            this.linkLabelBinance.TabStop = true;
            this.linkLabelBinance.Text = "Set API Key";
            this.linkLabelBinance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBinance_LinkClicked);
            // 
            // linkLabel3Commas
            // 
            this.linkLabel3Commas.AutoSize = true;
            this.linkLabel3Commas.Location = new System.Drawing.Point(15, 64);
            this.linkLabel3Commas.Name = "linkLabel3Commas";
            this.linkLabel3Commas.Size = new System.Drawing.Size(64, 13);
            this.linkLabel3Commas.TabIndex = 0;
            this.linkLabel3Commas.TabStop = true;
            this.linkLabel3Commas.Text = "Set API Key";
            this.linkLabel3Commas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3Commas_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3Commas.BotCreator.Properties.Resources._3Commas;
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // rbBinance
            // 
            this.rbBinance.Image = global::_3Commas.BotCreator.Properties.Resources.Binance;
            this.rbBinance.Location = new System.Drawing.Point(186, 19);
            this.rbBinance.Name = "rbBinance";
            this.rbBinance.Size = new System.Drawing.Size(158, 47);
            this.rbBinance.TabIndex = 1;
            this.rbBinance.TabStop = true;
            this.rbBinance.UseVisualStyleBackColor = true;
            // 
            // rbHuobi
            // 
            this.rbHuobi.Image = global::_3Commas.BotCreator.Properties.Resources.Huobi;
            this.rbHuobi.Location = new System.Drawing.Point(350, 19);
            this.rbHuobi.Name = "rbHuobi";
            this.rbHuobi.Size = new System.Drawing.Size(128, 47);
            this.rbHuobi.TabIndex = 3;
            this.rbHuobi.TabStop = true;
            this.rbHuobi.UseVisualStyleBackColor = true;
            // 
            // panelBotSettings
            // 
            this.panelBotSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotSettings.AutoScroll = true;
            this.panelBotSettings.Controls.Add(this.lblLeverageCustomValue);
            this.panelBotSettings.Controls.Add(this.numCustomLeverageValue);
            this.panelBotSettings.Controls.Add(this.label27);
            this.panelBotSettings.Controls.Add(this.cmbLeverageType);
            this.panelBotSettings.Controls.Add(this.panelStopLoss);
            this.panelBotSettings.Controls.Add(this.chkStopLossEnabled);
            this.panelBotSettings.Controls.Add(this.label30);
            this.panelBotSettings.Controls.Add(this.chkBuyBase);
            this.panelBotSettings.Controls.Add(this.label23);
            this.panelBotSettings.Controls.Add(this.txtQuoteCurrency);
            this.panelBotSettings.Controls.Add(this.label2);
            this.panelBotSettings.Controls.Add(this.numAmountToBuy);
            this.panelBotSettings.Controls.Add(this.lblQuoteCurrency);
            this.panelBotSettings.Controls.Add(this.cmbExchange);
            this.panelBotSettings.Controls.Add(this.lblBuyTitle);
            this.panelBotSettings.Controls.Add(this.label22);
            this.panelBotSettings.Controls.Add(this.cmbStrategy);
            this.panelBotSettings.Controls.Add(this.label3);
            this.panelBotSettings.Controls.Add(this.lblBotNamePreview);
            this.panelBotSettings.Controls.Add(this.numBaseOrderVolume);
            this.panelBotSettings.Controls.Add(this.label20);
            this.panelBotSettings.Controls.Add(this.label4);
            this.panelBotSettings.Controls.Add(this.label10);
            this.panelBotSettings.Controls.Add(this.numSafetyOrderVolume);
            this.panelBotSettings.Controls.Add(this.label9);
            this.panelBotSettings.Controls.Add(this.label5);
            this.panelBotSettings.Controls.Add(this.numCooldownBetweenDeals);
            this.panelBotSettings.Controls.Add(this.label8);
            this.panelBotSettings.Controls.Add(this.btnRemove);
            this.panelBotSettings.Controls.Add(this.btnAddStartCondition);
            this.panelBotSettings.Controls.Add(this.label11);
            this.panelBotSettings.Controls.Add(this.listViewStartConditions);
            this.panelBotSettings.Controls.Add(this.label7);
            this.panelBotSettings.Controls.Add(this.label12);
            this.panelBotSettings.Controls.Add(this.cmbStartOrderType);
            this.panelBotSettings.Controls.Add(this.label21);
            this.panelBotSettings.Controls.Add(this.label14);
            this.panelBotSettings.Controls.Add(this.lblTrailingUnit);
            this.panelBotSettings.Controls.Add(this.numPriceDeviationToOpenSafetyOrders);
            this.panelBotSettings.Controls.Add(this.label16);
            this.panelBotSettings.Controls.Add(this.label13);
            this.panelBotSettings.Controls.Add(this.numSafetyOrderVolumeScale);
            this.panelBotSettings.Controls.Add(this.numTargetProfit);
            this.panelBotSettings.Controls.Add(this.chkTrailing);
            this.panelBotSettings.Controls.Add(this.label19);
            this.panelBotSettings.Controls.Add(this.label15);
            this.panelBotSettings.Controls.Add(this.numSafetyOrderStepScale);
            this.panelBotSettings.Controls.Add(this.lblTrailing);
            this.panelBotSettings.Controls.Add(this.label17);
            this.panelBotSettings.Controls.Add(this.numTrailingDeviation);
            this.panelBotSettings.Controls.Add(this.label18);
            this.panelBotSettings.Controls.Add(this.numMaxSafetyTradesCount);
            this.panelBotSettings.Controls.Add(this.numMaxActiveSafetyTradesCount);
            this.panelBotSettings.Controls.Add(this.lblMaxSafetyTradesCount);
            this.panelBotSettings.Controls.Add(this.txtBotname);
            this.panelBotSettings.Location = new System.Drawing.Point(6, 64);
            this.panelBotSettings.Name = "panelBotSettings";
            this.panelBotSettings.Size = new System.Drawing.Size(510, 269);
            this.panelBotSettings.TabIndex = 65;
            // 
            // lblLeverageCustomValue
            // 
            this.lblLeverageCustomValue.AutoSize = true;
            this.lblLeverageCustomValue.Location = new System.Drawing.Point(96, 660);
            this.lblLeverageCustomValue.Name = "lblLeverageCustomValue";
            this.lblLeverageCustomValue.Size = new System.Drawing.Size(120, 13);
            this.lblLeverageCustomValue.TabIndex = 203;
            this.lblLeverageCustomValue.Text = "Custom Leverage Value";
            // 
            // numCustomLeverageValue
            // 
            this.numCustomLeverageValue.Location = new System.Drawing.Point(222, 658);
            this.numCustomLeverageValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCustomLeverageValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCustomLeverageValue.Name = "numCustomLeverageValue";
            this.numCustomLeverageValue.Size = new System.Drawing.Size(51, 20);
            this.numCustomLeverageValue.TabIndex = 26;
            this.numCustomLeverageValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(137, 634);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 201;
            this.label27.Text = "Leverage Type";
            // 
            // cmbLeverageType
            // 
            this.cmbLeverageType.FormattingEnabled = true;
            this.cmbLeverageType.Location = new System.Drawing.Point(222, 631);
            this.cmbLeverageType.Name = "cmbLeverageType";
            this.cmbLeverageType.Size = new System.Drawing.Size(121, 21);
            this.cmbLeverageType.TabIndex = 25;
            this.cmbLeverageType.SelectedIndexChanged += new System.EventHandler(this.cmbLeverageType_SelectedIndexChanged);
            // 
            // panelStopLoss
            // 
            this.panelStopLoss.Controls.Add(this.numStopLossPercentage);
            this.panelStopLoss.Controls.Add(this.lblStopLossTimeoutUnit);
            this.panelStopLoss.Controls.Add(this.label29);
            this.panelStopLoss.Controls.Add(this.cmbStopLossType);
            this.panelStopLoss.Controls.Add(this.label28);
            this.panelStopLoss.Controls.Add(this.chkStopLossTimeoutEnabled);
            this.panelStopLoss.Controls.Add(this.numStopLossTimeout);
            this.panelStopLoss.Controls.Add(this.label26);
            this.panelStopLoss.Location = new System.Drawing.Point(73, 390);
            this.panelStopLoss.Name = "panelStopLoss";
            this.panelStopLoss.Size = new System.Drawing.Size(323, 81);
            this.panelStopLoss.TabIndex = 199;
            // 
            // numStopLossPercentage
            // 
            this.numStopLossPercentage.DecimalPlaces = 2;
            this.numStopLossPercentage.Location = new System.Drawing.Point(149, 5);
            this.numStopLossPercentage.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numStopLossPercentage.Name = "numStopLossPercentage";
            this.numStopLossPercentage.Size = new System.Drawing.Size(121, 20);
            this.numStopLossPercentage.TabIndex = 0;
            this.numStopLossPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStopLossTimeoutUnit
            // 
            this.lblStopLossTimeoutUnit.AutoSize = true;
            this.lblStopLossTimeoutUnit.Location = new System.Drawing.Point(225, 61);
            this.lblStopLossTimeoutUnit.Name = "lblStopLossTimeoutUnit";
            this.lblStopLossTimeoutUnit.Size = new System.Drawing.Size(47, 13);
            this.lblStopLossTimeoutUnit.TabIndex = 3;
            this.lblStopLossTimeoutUnit.Text = "seconds";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(48, 61);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 13);
            this.label29.TabIndex = 191;
            this.label29.Text = "Stop Loss Timeout";
            // 
            // cmbStopLossType
            // 
            this.cmbStopLossType.FormattingEnabled = true;
            this.cmbStopLossType.Location = new System.Drawing.Point(149, 31);
            this.cmbStopLossType.Name = "cmbStopLossType";
            this.cmbStopLossType.Size = new System.Drawing.Size(121, 21);
            this.cmbStopLossType.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(62, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 13);
            this.label28.TabIndex = 188;
            this.label28.Text = "Stop Loss Type";
            // 
            // chkStopLossTimeoutEnabled
            // 
            this.chkStopLossTimeoutEnabled.AutoSize = true;
            this.chkStopLossTimeoutEnabled.Location = new System.Drawing.Point(149, 61);
            this.chkStopLossTimeoutEnabled.Name = "chkStopLossTimeoutEnabled";
            this.chkStopLossTimeoutEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkStopLossTimeoutEnabled.TabIndex = 2;
            this.chkStopLossTimeoutEnabled.UseVisualStyleBackColor = true;
            this.chkStopLossTimeoutEnabled.CheckedChanged += new System.EventHandler(this.chkStopLossTimeoutEnabled_CheckedChanged);
            // 
            // numStopLossTimeout
            // 
            this.numStopLossTimeout.Enabled = false;
            this.numStopLossTimeout.Location = new System.Drawing.Point(170, 58);
            this.numStopLossTimeout.Maximum = new decimal(new int[] {
            2591999,
            0,
            0,
            0});
            this.numStopLossTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStopLossTimeout.Name = "numStopLossTimeout";
            this.numStopLossTimeout.Size = new System.Drawing.Size(50, 20);
            this.numStopLossTimeout.TabIndex = 193;
            this.numStopLossTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 185;
            this.label26.Text = "Stop Loss Percentage";
            // 
            // chkStopLossEnabled
            // 
            this.chkStopLossEnabled.AutoSize = true;
            this.chkStopLossEnabled.Location = new System.Drawing.Point(222, 372);
            this.chkStopLossEnabled.Name = "chkStopLossEnabled";
            this.chkStopLossEnabled.Size = new System.Drawing.Size(15, 14);
            this.chkStopLossEnabled.TabIndex = 18;
            this.chkStopLossEnabled.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(162, 372);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 196;
            this.label30.Text = "Stop Loss";
            // 
            // chkBuyBase
            // 
            this.chkBuyBase.AutoSize = true;
            this.chkBuyBase.Location = new System.Drawing.Point(222, 687);
            this.chkBuyBase.Name = "chkBuyBase";
            this.chkBuyBase.Size = new System.Drawing.Size(15, 14);
            this.chkBuyBase.TabIndex = 27;
            this.chkBuyBase.UseVisualStyleBackColor = true;
            this.chkBuyBase.CheckedChanged += new System.EventHandler(this.chkBuyBase_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(122, 686);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "Buy Base currency";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::_3Commas.BotCreator.Properties.Resources.Cancel_16x16;
            this.btnRemove.Location = new System.Drawing.Point(348, 201);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(29, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddStartCondition
            // 
            this.btnAddStartCondition.Image = global::_3Commas.BotCreator.Properties.Resources.Add_16x16;
            this.btnAddStartCondition.Location = new System.Drawing.Point(348, 174);
            this.btnAddStartCondition.Name = "btnAddStartCondition";
            this.btnAddStartCondition.Size = new System.Drawing.Size(29, 23);
            this.btnAddStartCondition.TabIndex = 11;
            this.btnAddStartCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStartCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStartCondition.UseVisualStyleBackColor = true;
            this.btnAddStartCondition.Click += new System.EventHandler(this.btnAddStartCondition_Click);
            // 
            // chkLogCheckForBaseStablecoin
            // 
            this.chkLogCheckForBaseStablecoin.AutoSize = true;
            this.chkLogCheckForBaseStablecoin.Checked = true;
            this.chkLogCheckForBaseStablecoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogCheckForBaseStablecoin.Location = new System.Drawing.Point(292, 117);
            this.chkLogCheckForBaseStablecoin.Name = "chkLogCheckForBaseStablecoin";
            this.chkLogCheckForBaseStablecoin.Size = new System.Drawing.Size(83, 17);
            this.chkLogCheckForBaseStablecoin.TabIndex = 212;
            this.chkLogCheckForBaseStablecoin.Text = "show in Log";
            this.chkLogCheckForBaseStablecoin.UseVisualStyleBackColor = true;
            // 
            // chkLogCheckForExistingBots
            // 
            this.chkLogCheckForExistingBots.AutoSize = true;
            this.chkLogCheckForExistingBots.Checked = true;
            this.chkLogCheckForExistingBots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogCheckForExistingBots.Location = new System.Drawing.Point(292, 96);
            this.chkLogCheckForExistingBots.Name = "chkLogCheckForExistingBots";
            this.chkLogCheckForExistingBots.Size = new System.Drawing.Size(83, 17);
            this.chkLogCheckForExistingBots.TabIndex = 208;
            this.chkLogCheckForExistingBots.Text = "show in Log";
            this.chkLogCheckForExistingBots.UseVisualStyleBackColor = true;
            // 
            // chkLogCheckForExistingPairWithSameBaseCurrency
            // 
            this.chkLogCheckForExistingPairWithSameBaseCurrency.AutoSize = true;
            this.chkLogCheckForExistingPairWithSameBaseCurrency.Checked = true;
            this.chkLogCheckForExistingPairWithSameBaseCurrency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogCheckForExistingPairWithSameBaseCurrency.Location = new System.Drawing.Point(292, 73);
            this.chkLogCheckForExistingPairWithSameBaseCurrency.Name = "chkLogCheckForExistingPairWithSameBaseCurrency";
            this.chkLogCheckForExistingPairWithSameBaseCurrency.Size = new System.Drawing.Size(83, 17);
            this.chkLogCheckForExistingPairWithSameBaseCurrency.TabIndex = 206;
            this.chkLogCheckForExistingPairWithSameBaseCurrency.Text = "show in Log";
            this.chkLogCheckForExistingPairWithSameBaseCurrency.UseVisualStyleBackColor = true;
            // 
            // chkCheckForExistingPairWithSameBaseCurrency
            // 
            this.chkCheckForExistingPairWithSameBaseCurrency.AutoSize = true;
            this.chkCheckForExistingPairWithSameBaseCurrency.Checked = true;
            this.chkCheckForExistingPairWithSameBaseCurrency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckForExistingPairWithSameBaseCurrency.Location = new System.Drawing.Point(9, 73);
            this.chkCheckForExistingPairWithSameBaseCurrency.Name = "chkCheckForExistingPairWithSameBaseCurrency";
            this.chkCheckForExistingPairWithSameBaseCurrency.Size = new System.Drawing.Size(275, 17);
            this.chkCheckForExistingPairWithSameBaseCurrency.TabIndex = 204;
            this.chkCheckForExistingPairWithSameBaseCurrency.Text = "Skip if Strategy and any Pair with base currency exist";
            this.chkCheckForExistingPairWithSameBaseCurrency.UseVisualStyleBackColor = true;
            // 
            // chkCheckForExistingBots
            // 
            this.chkCheckForExistingBots.AutoSize = true;
            this.chkCheckForExistingBots.Checked = true;
            this.chkCheckForExistingBots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckForExistingBots.Location = new System.Drawing.Point(9, 94);
            this.chkCheckForExistingBots.Name = "chkCheckForExistingBots";
            this.chkCheckForExistingBots.Size = new System.Drawing.Size(233, 17);
            this.chkCheckForExistingBots.TabIndex = 0;
            this.chkCheckForExistingBots.Text = "Skip Bot Creation for existing Pair && Strategy";
            this.chkCheckForExistingBots.UseVisualStyleBackColor = true;
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(71, 28);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(109, 21);
            this.cmbTemplates.TabIndex = 0;
            this.cmbTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbTemplates_SelectedIndexChanged);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSettings.Controls.Add(this.label31);
            this.groupBoxSettings.Controls.Add(this.panelBotSettings);
            this.groupBoxSettings.Controls.Add(this.cmbTemplates);
            this.groupBoxSettings.Controls.Add(this.btnSave);
            this.groupBoxSettings.Controls.Add(this.btnDeleteTemplate);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 345);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(522, 339);
            this.groupBoxSettings.TabIndex = 67;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Bot Settings";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 13);
            this.label31.TabIndex = 204;
            this.label31.Text = "Templates:";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::_3Commas.BotCreator.Properties.Resources.Save_16x16;
            this.btnSave.Location = new System.Drawing.Point(311, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Current Settings as Template";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Enabled = false;
            this.btnDeleteTemplate.Image = global::_3Commas.BotCreator.Properties.Resources.Cancel_16x16;
            this.btnDeleteTemplate.Location = new System.Drawing.Point(186, 26);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteTemplate.TabIndex = 1;
            this.btnDeleteTemplate.Text = "Delete Template";
            this.btnDeleteTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTemplate.UseVisualStyleBackColor = true;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnCreate);
            this.panelMain.Controls.Add(this.btnPreview);
            this.panelMain.Controls.Add(this.chkEnable);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.numAmount);
            this.panelMain.Location = new System.Drawing.Point(12, 107);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(522, 70);
            this.panelMain.TabIndex = 69;
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::_3Commas.BotCreator.Properties.Resources.Play_16x16;
            this.btnCreate.Location = new System.Drawing.Point(385, 16);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 36);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Image = global::_3Commas.BotCreator.Properties.Resources.ShowTestReport_16x16;
            this.btnPreview.Location = new System.Drawing.Point(289, 16);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 36);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(540, 783);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 71;
            this.progressBar.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::_3Commas.BotCreator.Properties.Resources.Close_16x16;
            this.btnCancel.Location = new System.Drawing.Point(540, 659);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = global::_3Commas.BotCreator.Properties.Resources.Info_16x16;
            this.btnAbout.Location = new System.Drawing.Point(936, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(84, 25);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::_3Commas.BotCreator.Properties.Resources.Clear_16x16;
            this.button1.Location = new System.Drawing.Point(921, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear Output";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLogSkipUpDownPairs);
            this.groupBox1.Controls.Add(this.chkSkipUpDownPairs);
            this.groupBox1.Controls.Add(this.logSkipFirstTradeXDaysAgo);
            this.groupBox1.Controls.Add(this.chkLogSkipMinVolume);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.numMinVolume);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkCheckForBaseStablecoin);
            this.groupBox1.Controls.Add(this.chkLogSkipBlacklistedPairs);
            this.groupBox1.Controls.Add(this.chkSkipBlacklistedPairs);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.numFirstTradeXDaysAgo);
            this.groupBox1.Controls.Add(this.chkLogCheckForBaseStablecoin);
            this.groupBox1.Controls.Add(this.chkCheckForExistingBots);
            this.groupBox1.Controls.Add(this.chkCheckForExistingPairWithSameBaseCurrency);
            this.groupBox1.Controls.Add(this.chkLogCheckForExistingBots);
            this.groupBox1.Controls.Add(this.chkLogCheckForExistingPairWithSameBaseCurrency);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 155);
            this.groupBox1.TabIndex = 214;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pair selection";
            // 
            // chkLogSkipUpDownPairs
            // 
            this.chkLogSkipUpDownPairs.AutoSize = true;
            this.chkLogSkipUpDownPairs.Checked = true;
            this.chkLogSkipUpDownPairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogSkipUpDownPairs.Location = new System.Drawing.Point(292, 51);
            this.chkLogSkipUpDownPairs.Name = "chkLogSkipUpDownPairs";
            this.chkLogSkipUpDownPairs.Size = new System.Drawing.Size(83, 17);
            this.chkLogSkipUpDownPairs.TabIndex = 224;
            this.chkLogSkipUpDownPairs.Text = "show in Log";
            this.chkLogSkipUpDownPairs.UseVisualStyleBackColor = true;
            // 
            // chkSkipUpDownPairs
            // 
            this.chkSkipUpDownPairs.AutoSize = true;
            this.chkSkipUpDownPairs.Checked = true;
            this.chkSkipUpDownPairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipUpDownPairs.Location = new System.Drawing.Point(9, 51);
            this.chkSkipUpDownPairs.Name = "chkSkipUpDownPairs";
            this.chkSkipUpDownPairs.Size = new System.Drawing.Size(131, 17);
            this.chkSkipUpDownPairs.TabIndex = 223;
            this.chkSkipUpDownPairs.Text = "Skip UP/DOWN Pairs";
            this.chkSkipUpDownPairs.UseVisualStyleBackColor = true;
            // 
            // logSkipFirstTradeXDaysAgo
            // 
            this.logSkipFirstTradeXDaysAgo.AutoSize = true;
            this.logSkipFirstTradeXDaysAgo.Checked = true;
            this.logSkipFirstTradeXDaysAgo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logSkipFirstTradeXDaysAgo.Location = new System.Drawing.Point(289, 16);
            this.logSkipFirstTradeXDaysAgo.Name = "logSkipFirstTradeXDaysAgo";
            this.logSkipFirstTradeXDaysAgo.Size = new System.Drawing.Size(83, 17);
            this.logSkipFirstTradeXDaysAgo.TabIndex = 222;
            this.logSkipFirstTradeXDaysAgo.Text = "show in Log";
            this.logSkipFirstTradeXDaysAgo.UseVisualStyleBackColor = true;
            // 
            // chkLogSkipMinVolume
            // 
            this.chkLogSkipMinVolume.AutoSize = true;
            this.chkLogSkipMinVolume.Checked = true;
            this.chkLogSkipMinVolume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogSkipMinVolume.Location = new System.Drawing.Point(289, 34);
            this.chkLogSkipMinVolume.Name = "chkLogSkipMinVolume";
            this.chkLogSkipMinVolume.Size = new System.Drawing.Size(83, 17);
            this.chkLogSkipMinVolume.TabIndex = 221;
            this.chkLogSkipMinVolume.Text = "show in Log";
            this.chkLogSkipMinVolume.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(153, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 220;
            this.label24.Text = "USDT";
            // 
            // numMinVolume
            // 
            this.numMinVolume.Location = new System.Drawing.Point(79, 33);
            this.numMinVolume.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMinVolume.Name = "numMinVolume";
            this.numMinVolume.Size = new System.Drawing.Size(69, 20);
            this.numMinVolume.TabIndex = 219;
            this.numMinVolume.ThousandsSeparator = true;
            this.numMinVolume.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 218;
            this.label6.Text = "Min Volume";
            // 
            // chkCheckForBaseStablecoin
            // 
            this.chkCheckForBaseStablecoin.AutoSize = true;
            this.chkCheckForBaseStablecoin.Checked = true;
            this.chkCheckForBaseStablecoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckForBaseStablecoin.Location = new System.Drawing.Point(9, 114);
            this.chkCheckForBaseStablecoin.Name = "chkCheckForBaseStablecoin";
            this.chkCheckForBaseStablecoin.Size = new System.Drawing.Size(105, 17);
            this.chkCheckForBaseStablecoin.TabIndex = 217;
            this.chkCheckForBaseStablecoin.Text = "Skip Stablecoins";
            this.chkCheckForBaseStablecoin.UseVisualStyleBackColor = true;
            // 
            // chkLogSkipBlacklistedPairs
            // 
            this.chkLogSkipBlacklistedPairs.AutoSize = true;
            this.chkLogSkipBlacklistedPairs.Checked = true;
            this.chkLogSkipBlacklistedPairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogSkipBlacklistedPairs.Location = new System.Drawing.Point(292, 138);
            this.chkLogSkipBlacklistedPairs.Name = "chkLogSkipBlacklistedPairs";
            this.chkLogSkipBlacklistedPairs.Size = new System.Drawing.Size(83, 17);
            this.chkLogSkipBlacklistedPairs.TabIndex = 216;
            this.chkLogSkipBlacklistedPairs.Text = "show in Log";
            this.chkLogSkipBlacklistedPairs.UseVisualStyleBackColor = true;
            // 
            // chkSkipBlacklistedPairs
            // 
            this.chkSkipBlacklistedPairs.AutoSize = true;
            this.chkSkipBlacklistedPairs.Checked = true;
            this.chkSkipBlacklistedPairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipBlacklistedPairs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkSkipBlacklistedPairs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkSkipBlacklistedPairs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.chkSkipBlacklistedPairs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.chkSkipBlacklistedPairs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkSkipBlacklistedPairs.Location = new System.Drawing.Point(9, 133);
            this.chkSkipBlacklistedPairs.Name = "chkSkipBlacklistedPairs";
            this.chkSkipBlacklistedPairs.Size = new System.Drawing.Size(101, 17);
            this.chkSkipBlacklistedPairs.TabIndex = 215;
            this.chkSkipBlacklistedPairs.Text = "Skip Blacklisted";
            this.chkSkipBlacklistedPairs.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(231, 17);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 13);
            this.label38.TabIndex = 214;
            this.label38.Text = "days";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 17);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(160, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "Only if first trade is not older than";
            // 
            // numFirstTradeXDaysAgo
            // 
            this.numFirstTradeXDaysAgo.Location = new System.Drawing.Point(177, 14);
            this.numFirstTradeXDaysAgo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numFirstTradeXDaysAgo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFirstTradeXDaysAgo.Name = "numFirstTradeXDaysAgo";
            this.numFirstTradeXDaysAgo.Size = new System.Drawing.Size(51, 20);
            this.numFirstTradeXDaysAgo.TabIndex = 4;
            this.numFirstTradeXDaysAgo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // toolTipBlacklist
            // 
            this.toolTipBlacklist.ToolTipTitle = "Skip Bot Creation for blacklisted Pairs";
            // 
            // toolTipStablecoins
            // 
            this.toolTipStablecoins.ToolTipTitle = "Skip if base coin is a stablecoin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxCredentials);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1046, 584);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bot Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseOrderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSafetyOrderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSafetyOrderVolumeScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceDeviationToOpenSafetyOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrailingDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxSafetyTradesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxActiveSafetyTradesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSafetyOrderStepScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCooldownBetweenDeals)).EndInit();
            this.groupBoxCredentials.ResumeLayout(false);
            this.groupBoxCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBotSettings.ResumeLayout(false);
            this.panelBotSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCustomLeverageValue)).EndInit();
            this.panelStopLoss.ResumeLayout(false);
            this.panelStopLoss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStopLossPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopLossTimeout)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstTradeXDaysAgo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.ComboBox cmbStrategy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBaseOrderVolume;
        private System.Windows.Forms.NumericUpDown numSafetyOrderVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuoteCurrency;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblBuyTitle;
        private System.Windows.Forms.NumericUpDown numAmountToBuy;
        private System.Windows.Forms.TextBox txtBotname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbStartOrderType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSafetyOrderVolumeScale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numPriceDeviationToOpenSafetyOrders;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkTrailing;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTrailing;
        private System.Windows.Forms.NumericUpDown numTrailingDeviation;
        private System.Windows.Forms.NumericUpDown numMaxSafetyTradesCount;
        private System.Windows.Forms.Label lblMaxSafetyTradesCount;
        private System.Windows.Forms.NumericUpDown numMaxActiveSafetyTradesCount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numSafetyOrderStepScale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numTargetProfit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblQuoteCurrency;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTrailingUnit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewStartConditions;
        private System.Windows.Forms.Button btnAddStartCondition;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numCooldownBetweenDeals;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBotNamePreview;
        private System.Windows.Forms.ComboBox cmbExchange;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rbHuobi;
        private System.Windows.Forms.RadioButton rbBinance;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelHuobi;
        private System.Windows.Forms.LinkLabel linkLabelBinance;
        private System.Windows.Forms.LinkLabel linkLabel3Commas;
        private System.Windows.Forms.Panel panelBotSettings;
        private System.Windows.Forms.CheckBox chkBuyBase;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chkCheckForExistingBots;
        private System.Windows.Forms.NumericUpDown numStopLossPercentage;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numStopLossTimeout;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbStopLossType;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblStopLossTimeoutUnit;
        private System.Windows.Forms.CheckBox chkStopLossEnabled;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox chkStopLossTimeoutEnabled;
        private System.Windows.Forms.Panel panelStopLoss;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label lblLeverageCustomValue;
        private System.Windows.Forms.NumericUpDown numCustomLeverageValue;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbLeverageType;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkLogCheckForBaseStablecoin;
        private System.Windows.Forms.CheckBox chkLogCheckForExistingBots;
        private System.Windows.Forms.CheckBox chkLogCheckForExistingPairWithSameBaseCurrency;
        private System.Windows.Forms.CheckBox chkCheckForExistingPairWithSameBaseCurrency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown numFirstTradeXDaysAgo;
        private System.Windows.Forms.ToolTip toolTipBlacklist;
        private System.Windows.Forms.CheckBox chkLogSkipBlacklistedPairs;
        private System.Windows.Forms.CheckBox chkSkipBlacklistedPairs;
        private System.Windows.Forms.CheckBox chkCheckForBaseStablecoin;
        private System.Windows.Forms.ToolTip toolTipStablecoins;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown numMinVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkLogSkipMinVolume;
        private System.Windows.Forms.CheckBox logSkipFirstTradeXDaysAgo;
        private System.Windows.Forms.CheckBox chkLogSkipUpDownPairs;
        private System.Windows.Forms.CheckBox chkSkipUpDownPairs;
    }
}

