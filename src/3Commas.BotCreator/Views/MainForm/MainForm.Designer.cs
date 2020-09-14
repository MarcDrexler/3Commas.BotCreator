namespace _3Commas.BotCreator.Views
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddStartCondition = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelBotSettings = new System.Windows.Forms.Panel();
            this.chkBuyBase = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(197, 19);
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
            this.label1.Location = new System.Drawing.Point(111, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Bots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Strategy";
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(254, 21);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(59, 17);
            this.chkEnable.TabIndex = 1;
            this.chkEnable.Text = "Enable";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // cmbStrategy
            // 
            this.cmbStrategy.FormattingEnabled = true;
            this.cmbStrategy.Location = new System.Drawing.Point(198, 98);
            this.cmbStrategy.Name = "cmbStrategy";
            this.cmbStrategy.Size = new System.Drawing.Size(121, 21);
            this.cmbStrategy.TabIndex = 4;
            this.cmbStrategy.SelectedIndexChanged += new System.EventHandler(this.cmbStrategy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base order size";
            // 
            // numBaseOrderVolume
            // 
            this.numBaseOrderVolume.DecimalPlaces = 8;
            this.numBaseOrderVolume.Location = new System.Drawing.Point(197, 286);
            this.numBaseOrderVolume.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBaseOrderVolume.Name = "numBaseOrderVolume";
            this.numBaseOrderVolume.Size = new System.Drawing.Size(121, 20);
            this.numBaseOrderVolume.TabIndex = 8;
            this.numBaseOrderVolume.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numSafetyOrderVolume
            // 
            this.numSafetyOrderVolume.DecimalPlaces = 8;
            this.numSafetyOrderVolume.Location = new System.Drawing.Point(197, 312);
            this.numSafetyOrderVolume.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSafetyOrderVolume.Name = "numSafetyOrderVolume";
            this.numSafetyOrderVolume.Size = new System.Drawing.Size(121, 20);
            this.numSafetyOrderVolume.TabIndex = 9;
            this.numSafetyOrderVolume.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Safety order size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quote Currency";
            // 
            // txtQuoteCurrency
            // 
            this.txtQuoteCurrency.Location = new System.Drawing.Point(198, 72);
            this.txtQuoteCurrency.Name = "txtQuoteCurrency";
            this.txtQuoteCurrency.Size = new System.Drawing.Size(120, 20);
            this.txtQuoteCurrency.TabIndex = 3;
            this.txtQuoteCurrency.Text = "USDT";
            this.txtQuoteCurrency.TextChanged += new System.EventHandler(this.txtQuoteCurrency_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(528, 42);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(492, 692);
            this.txtOutput.TabIndex = 0;
            // 
            // lblBuyTitle
            // 
            this.lblBuyTitle.AutoSize = true;
            this.lblBuyTitle.Enabled = false;
            this.lblBuyTitle.Location = new System.Drawing.Point(26, 593);
            this.lblBuyTitle.Name = "lblBuyTitle";
            this.lblBuyTitle.Size = new System.Drawing.Size(166, 13);
            this.lblBuyTitle.TabIndex = 13;
            this.lblBuyTitle.Text = "Amount to buy (in quote currency)";
            // 
            // numAmountToBuy
            // 
            this.numAmountToBuy.DecimalPlaces = 8;
            this.numAmountToBuy.Enabled = false;
            this.numAmountToBuy.Location = new System.Drawing.Point(197, 590);
            this.numAmountToBuy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmountToBuy.Name = "numAmountToBuy";
            this.numAmountToBuy.Size = new System.Drawing.Size(121, 20);
            this.numAmountToBuy.TabIndex = 20;
            // 
            // txtBotname
            // 
            this.txtBotname.Location = new System.Drawing.Point(198, 125);
            this.txtBotname.Name = "txtBotname";
            this.txtBotname.Size = new System.Drawing.Size(120, 20);
            this.txtBotname.TabIndex = 5;
            this.txtBotname.Text = "{strategy} {pair} Bot";
            this.txtBotname.TextChanged += new System.EventHandler(this.txtBotname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bot Name";
            // 
            // cmbStartOrderType
            // 
            this.cmbStartOrderType.FormattingEnabled = true;
            this.cmbStartOrderType.Location = new System.Drawing.Point(198, 190);
            this.cmbStartOrderType.Name = "cmbStartOrderType";
            this.cmbStartOrderType.Size = new System.Drawing.Size(121, 21);
            this.cmbStartOrderType.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Start Order Type";
            // 
            // numSafetyOrderVolumeScale
            // 
            this.numSafetyOrderVolumeScale.DecimalPlaces = 2;
            this.numSafetyOrderVolumeScale.Location = new System.Drawing.Point(197, 490);
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
            this.numSafetyOrderVolumeScale.TabIndex = 16;
            this.numSafetyOrderVolumeScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Safety order volume scale";
            // 
            // numPriceDeviationToOpenSafetyOrders
            // 
            this.numPriceDeviationToOpenSafetyOrders.DecimalPlaces = 2;
            this.numPriceDeviationToOpenSafetyOrders.Location = new System.Drawing.Point(197, 464);
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
            this.numPriceDeviationToOpenSafetyOrders.TabIndex = 15;
            this.numPriceDeviationToOpenSafetyOrders.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Price deviation to open safety orders";
            // 
            // chkTrailing
            // 
            this.chkTrailing.AutoSize = true;
            this.chkTrailing.Location = new System.Drawing.Point(198, 366);
            this.chkTrailing.Name = "chkTrailing";
            this.chkTrailing.Size = new System.Drawing.Size(15, 14);
            this.chkTrailing.TabIndex = 11;
            this.chkTrailing.UseVisualStyleBackColor = true;
            this.chkTrailing.CheckedChanged += new System.EventHandler(this.chkTrailing_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(122, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "TTP Enabled";
            // 
            // lblTrailing
            // 
            this.lblTrailing.AutoSize = true;
            this.lblTrailing.Enabled = false;
            this.lblTrailing.Location = new System.Drawing.Point(104, 390);
            this.lblTrailing.Name = "lblTrailing";
            this.lblTrailing.Size = new System.Drawing.Size(89, 13);
            this.lblTrailing.TabIndex = 31;
            this.lblTrailing.Text = "Trailing Deviation";
            // 
            // numTrailingDeviation
            // 
            this.numTrailingDeviation.DecimalPlaces = 1;
            this.numTrailingDeviation.Enabled = false;
            this.numTrailingDeviation.Location = new System.Drawing.Point(197, 386);
            this.numTrailingDeviation.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numTrailingDeviation.Name = "numTrailingDeviation";
            this.numTrailingDeviation.Size = new System.Drawing.Size(121, 20);
            this.numTrailingDeviation.TabIndex = 12;
            // 
            // numMaxSafetyTradesCount
            // 
            this.numMaxSafetyTradesCount.Location = new System.Drawing.Point(197, 412);
            this.numMaxSafetyTradesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSafetyTradesCount.Name = "numMaxSafetyTradesCount";
            this.numMaxSafetyTradesCount.Size = new System.Drawing.Size(51, 20);
            this.numMaxSafetyTradesCount.TabIndex = 13;
            this.numMaxSafetyTradesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxSafetyTradesCount
            // 
            this.lblMaxSafetyTradesCount.AutoSize = true;
            this.lblMaxSafetyTradesCount.Location = new System.Drawing.Point(72, 414);
            this.lblMaxSafetyTradesCount.Name = "lblMaxSafetyTradesCount";
            this.lblMaxSafetyTradesCount.Size = new System.Drawing.Size(120, 13);
            this.lblMaxSafetyTradesCount.TabIndex = 34;
            this.lblMaxSafetyTradesCount.Text = "Max safety trades count";
            // 
            // numMaxActiveSafetyTradesCount
            // 
            this.numMaxActiveSafetyTradesCount.Location = new System.Drawing.Point(197, 438);
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
            this.numMaxActiveSafetyTradesCount.TabIndex = 14;
            this.numMaxActiveSafetyTradesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 440);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Max active safety trades count";
            // 
            // numSafetyOrderStepScale
            // 
            this.numSafetyOrderStepScale.DecimalPlaces = 2;
            this.numSafetyOrderStepScale.Location = new System.Drawing.Point(197, 516);
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
            this.numSafetyOrderStepScale.TabIndex = 17;
            this.numSafetyOrderStepScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(79, 518);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Safety order step scale";
            // 
            // numTargetProfit
            // 
            this.numTargetProfit.DecimalPlaces = 2;
            this.numTargetProfit.Location = new System.Drawing.Point(197, 338);
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
            this.numTargetProfit.TabIndex = 10;
            this.numTargetProfit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(127, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Target Profit";
            // 
            // lblQuoteCurrency
            // 
            this.lblQuoteCurrency.AutoSize = true;
            this.lblQuoteCurrency.Enabled = false;
            this.lblQuoteCurrency.Location = new System.Drawing.Point(325, 593);
            this.lblQuoteCurrency.Name = "lblQuoteCurrency";
            this.lblQuoteCurrency.Size = new System.Drawing.Size(37, 13);
            this.lblQuoteCurrency.TabIndex = 41;
            this.lblQuoteCurrency.Text = "USDT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(325, 341);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "%";
            // 
            // lblTrailingUnit
            // 
            this.lblTrailingUnit.AutoSize = true;
            this.lblTrailingUnit.Enabled = false;
            this.lblTrailingUnit.Location = new System.Drawing.Point(325, 390);
            this.lblTrailingUnit.Name = "lblTrailingUnit";
            this.lblTrailingUnit.Size = new System.Drawing.Size(15, 13);
            this.lblTrailingUnit.TabIndex = 43;
            this.lblTrailingUnit.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(325, 468);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 219);
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
            this.listViewStartConditions.Location = new System.Drawing.Point(198, 217);
            this.listViewStartConditions.Name = "listViewStartConditions";
            this.listViewStartConditions.Size = new System.Drawing.Size(120, 63);
            this.listViewStartConditions.TabIndex = 7;
            this.listViewStartConditions.UseCompatibleStateImageBehavior = false;
            this.listViewStartConditions.View = System.Windows.Forms.View.List;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cooldown between deals";
            // 
            // numCooldownBetweenDeals
            // 
            this.numCooldownBetweenDeals.Location = new System.Drawing.Point(197, 542);
            this.numCooldownBetweenDeals.Maximum = new decimal(new int[] {
            2591999,
            0,
            0,
            0});
            this.numCooldownBetweenDeals.Name = "numCooldownBetweenDeals";
            this.numCooldownBetweenDeals.Size = new System.Drawing.Size(121, 20);
            this.numCooldownBetweenDeals.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "seconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "placeholders: {strategy} {pair}";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(97, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Bot Name Preview:";
            // 
            // lblBotNamePreview
            // 
            this.lblBotNamePreview.AutoSize = true;
            this.lblBotNamePreview.Location = new System.Drawing.Point(195, 169);
            this.lblBotNamePreview.Name = "lblBotNamePreview";
            this.lblBotNamePreview.Size = new System.Drawing.Size(83, 13);
            this.lblBotNamePreview.TabIndex = 58;
            this.lblBotNamePreview.Text = "USDT_XXX Bot";
            // 
            // cmbExchange
            // 
            this.cmbExchange.FormattingEnabled = true;
            this.cmbExchange.Location = new System.Drawing.Point(198, 45);
            this.cmbExchange.Name = "cmbExchange";
            this.cmbExchange.Size = new System.Drawing.Size(121, 21);
            this.cmbExchange.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(46, 49);
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
            this.groupBoxCredentials.Size = new System.Drawing.Size(489, 89);
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
            this.linkLabelHuobi.TabIndex = 66;
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
            this.linkLabelBinance.TabIndex = 65;
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
            this.linkLabel3Commas.TabIndex = 64;
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
            this.rbBinance.TabIndex = 0;
            this.rbBinance.TabStop = true;
            this.rbBinance.UseVisualStyleBackColor = true;
            // 
            // rbHuobi
            // 
            this.rbHuobi.Image = global::_3Commas.BotCreator.Properties.Resources.Huobi;
            this.rbHuobi.Location = new System.Drawing.Point(350, 19);
            this.rbHuobi.Name = "rbHuobi";
            this.rbHuobi.Size = new System.Drawing.Size(128, 47);
            this.rbHuobi.TabIndex = 1;
            this.rbHuobi.TabStop = true;
            this.rbHuobi.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::_3Commas.BotCreator.Properties.Resources.Cancel_16x16;
            this.btnRemove.Location = new System.Drawing.Point(324, 244);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(29, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddStartCondition
            // 
            this.btnAddStartCondition.Image = global::_3Commas.BotCreator.Properties.Resources.Add_16x16;
            this.btnAddStartCondition.Location = new System.Drawing.Point(324, 217);
            this.btnAddStartCondition.Name = "btnAddStartCondition";
            this.btnAddStartCondition.Size = new System.Drawing.Size(29, 23);
            this.btnAddStartCondition.TabIndex = 7;
            this.btnAddStartCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStartCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStartCondition.UseVisualStyleBackColor = true;
            this.btnAddStartCondition.Click += new System.EventHandler(this.btnAddStartCondition_Click);
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
            this.button1.Location = new System.Drawing.Point(921, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear Output";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::_3Commas.BotCreator.Properties.Resources.Play_16x16;
            this.btnCreate.Location = new System.Drawing.Point(197, 619);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelBotSettings
            // 
            this.panelBotSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotSettings.AutoScroll = true;
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
            this.panelBotSettings.Controls.Add(this.chkEnable);
            this.panelBotSettings.Controls.Add(this.label20);
            this.panelBotSettings.Controls.Add(this.label1);
            this.panelBotSettings.Controls.Add(this.label4);
            this.panelBotSettings.Controls.Add(this.numAmount);
            this.panelBotSettings.Controls.Add(this.label10);
            this.panelBotSettings.Controls.Add(this.numSafetyOrderVolume);
            this.panelBotSettings.Controls.Add(this.label9);
            this.panelBotSettings.Controls.Add(this.label5);
            this.panelBotSettings.Controls.Add(this.numCooldownBetweenDeals);
            this.panelBotSettings.Controls.Add(this.btnCreate);
            this.panelBotSettings.Controls.Add(this.label8);
            this.panelBotSettings.Controls.Add(this.btnRemove);
            this.panelBotSettings.Controls.Add(this.btnAddStartCondition);
            this.panelBotSettings.Controls.Add(this.label11);
            this.panelBotSettings.Controls.Add(this.listViewStartConditions);
            this.panelBotSettings.Controls.Add(this.txtBotname);
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
            this.panelBotSettings.Location = new System.Drawing.Point(12, 107);
            this.panelBotSettings.Name = "panelBotSettings";
            this.panelBotSettings.Size = new System.Drawing.Size(489, 647);
            this.panelBotSettings.TabIndex = 65;
            // 
            // chkBuyBase
            // 
            this.chkBuyBase.AutoSize = true;
            this.chkBuyBase.Location = new System.Drawing.Point(197, 570);
            this.chkBuyBase.Name = "chkBuyBase";
            this.chkBuyBase.Size = new System.Drawing.Size(15, 14);
            this.chkBuyBase.TabIndex = 19;
            this.chkBuyBase.UseVisualStyleBackColor = true;
            this.chkBuyBase.CheckedChanged += new System.EventHandler(this.chkBuyBase_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(97, 569);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "Buy Base currency";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 777);
            this.Controls.Add(this.panelBotSettings);
            this.Controls.Add(this.groupBoxCredentials);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1048, 590);
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
    }
}

