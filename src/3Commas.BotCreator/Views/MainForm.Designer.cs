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
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddStartCondition = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numCooldownBetweenDeals = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBotNamePreview = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(215, 78);
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
            this.label1.Location = new System.Drawing.Point(129, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Bots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Strategy";
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(272, 80);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(59, 17);
            this.chkEnable.TabIndex = 1;
            this.chkEnable.Text = "Enable";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // cmbStrategy
            // 
            this.cmbStrategy.FormattingEnabled = true;
            this.cmbStrategy.Location = new System.Drawing.Point(215, 130);
            this.cmbStrategy.Name = "cmbStrategy";
            this.cmbStrategy.Size = new System.Drawing.Size(121, 21);
            this.cmbStrategy.TabIndex = 3;
            this.cmbStrategy.SelectedIndexChanged += new System.EventHandler(this.cmbStrategy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base order size";
            // 
            // numBaseOrderVolume
            // 
            this.numBaseOrderVolume.DecimalPlaces = 8;
            this.numBaseOrderVolume.Location = new System.Drawing.Point(215, 344);
            this.numBaseOrderVolume.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBaseOrderVolume.Name = "numBaseOrderVolume";
            this.numBaseOrderVolume.Size = new System.Drawing.Size(121, 20);
            this.numBaseOrderVolume.TabIndex = 10;
            this.numBaseOrderVolume.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numSafetyOrderVolume
            // 
            this.numSafetyOrderVolume.DecimalPlaces = 8;
            this.numSafetyOrderVolume.Location = new System.Drawing.Point(215, 370);
            this.numSafetyOrderVolume.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSafetyOrderVolume.Name = "numSafetyOrderVolume";
            this.numSafetyOrderVolume.Size = new System.Drawing.Size(121, 20);
            this.numSafetyOrderVolume.TabIndex = 11;
            this.numSafetyOrderVolume.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Safety order size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quote Currency";
            // 
            // txtQuoteCurrency
            // 
            this.txtQuoteCurrency.Location = new System.Drawing.Point(215, 104);
            this.txtQuoteCurrency.Name = "txtQuoteCurrency";
            this.txtQuoteCurrency.Size = new System.Drawing.Size(120, 20);
            this.txtQuoteCurrency.TabIndex = 2;
            this.txtQuoteCurrency.Text = "USDT";
            this.txtQuoteCurrency.TextChanged += new System.EventHandler(this.txtQuoteCurrency_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(415, 43);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(605, 601);
            this.txtOutput.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Base currency to buy";
            // 
            // numAmountToBuy
            // 
            this.numAmountToBuy.DecimalPlaces = 8;
            this.numAmountToBuy.Location = new System.Drawing.Point(215, 318);
            this.numAmountToBuy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmountToBuy.Name = "numAmountToBuy";
            this.numAmountToBuy.Size = new System.Drawing.Size(121, 20);
            this.numAmountToBuy.TabIndex = 9;
            // 
            // txtBotname
            // 
            this.txtBotname.Location = new System.Drawing.Point(215, 157);
            this.txtBotname.Name = "txtBotname";
            this.txtBotname.Size = new System.Drawing.Size(120, 20);
            this.txtBotname.TabIndex = 4;
            this.txtBotname.Text = "{strategy} {pair} Bot";
            this.txtBotname.TextChanged += new System.EventHandler(this.txtBotname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bot Name";
            // 
            // cmbStartOrderType
            // 
            this.cmbStartOrderType.FormattingEnabled = true;
            this.cmbStartOrderType.Location = new System.Drawing.Point(215, 222);
            this.cmbStartOrderType.Name = "cmbStartOrderType";
            this.cmbStartOrderType.Size = new System.Drawing.Size(121, 21);
            this.cmbStartOrderType.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Start Order Type";
            // 
            // numSafetyOrderVolumeScale
            // 
            this.numSafetyOrderVolumeScale.DecimalPlaces = 2;
            this.numSafetyOrderVolumeScale.Location = new System.Drawing.Point(215, 548);
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
            this.numSafetyOrderVolumeScale.TabIndex = 18;
            this.numSafetyOrderVolumeScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 550);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Safety order volume scale";
            // 
            // numPriceDeviationToOpenSafetyOrders
            // 
            this.numPriceDeviationToOpenSafetyOrders.DecimalPlaces = 2;
            this.numPriceDeviationToOpenSafetyOrders.Location = new System.Drawing.Point(215, 522);
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
            this.numPriceDeviationToOpenSafetyOrders.TabIndex = 17;
            this.numPriceDeviationToOpenSafetyOrders.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 524);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Price deviation to open safety orders";
            // 
            // chkTrailing
            // 
            this.chkTrailing.AutoSize = true;
            this.chkTrailing.Location = new System.Drawing.Point(216, 424);
            this.chkTrailing.Name = "chkTrailing";
            this.chkTrailing.Size = new System.Drawing.Size(15, 14);
            this.chkTrailing.TabIndex = 13;
            this.chkTrailing.UseVisualStyleBackColor = true;
            this.chkTrailing.CheckedChanged += new System.EventHandler(this.chkTrailing_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "TTP Enabled";
            // 
            // lblTrailing
            // 
            this.lblTrailing.AutoSize = true;
            this.lblTrailing.Location = new System.Drawing.Point(122, 448);
            this.lblTrailing.Name = "lblTrailing";
            this.lblTrailing.Size = new System.Drawing.Size(89, 13);
            this.lblTrailing.TabIndex = 31;
            this.lblTrailing.Text = "Trailing Deviation";
            this.lblTrailing.Visible = false;
            // 
            // numTrailingDeviation
            // 
            this.numTrailingDeviation.DecimalPlaces = 1;
            this.numTrailingDeviation.Location = new System.Drawing.Point(215, 444);
            this.numTrailingDeviation.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numTrailingDeviation.Name = "numTrailingDeviation";
            this.numTrailingDeviation.Size = new System.Drawing.Size(121, 20);
            this.numTrailingDeviation.TabIndex = 14;
            this.numTrailingDeviation.Visible = false;
            // 
            // numMaxSafetyTradesCount
            // 
            this.numMaxSafetyTradesCount.Location = new System.Drawing.Point(215, 470);
            this.numMaxSafetyTradesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxSafetyTradesCount.Name = "numMaxSafetyTradesCount";
            this.numMaxSafetyTradesCount.Size = new System.Drawing.Size(51, 20);
            this.numMaxSafetyTradesCount.TabIndex = 15;
            this.numMaxSafetyTradesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaxSafetyTradesCount
            // 
            this.lblMaxSafetyTradesCount.AutoSize = true;
            this.lblMaxSafetyTradesCount.Location = new System.Drawing.Point(90, 472);
            this.lblMaxSafetyTradesCount.Name = "lblMaxSafetyTradesCount";
            this.lblMaxSafetyTradesCount.Size = new System.Drawing.Size(120, 13);
            this.lblMaxSafetyTradesCount.TabIndex = 34;
            this.lblMaxSafetyTradesCount.Text = "Max safety trades count";
            // 
            // numMaxActiveSafetyTradesCount
            // 
            this.numMaxActiveSafetyTradesCount.Location = new System.Drawing.Point(215, 496);
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
            this.numMaxActiveSafetyTradesCount.TabIndex = 16;
            this.numMaxActiveSafetyTradesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 498);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Max active safety trades count";
            // 
            // numSafetyOrderStepScale
            // 
            this.numSafetyOrderStepScale.DecimalPlaces = 2;
            this.numSafetyOrderStepScale.Location = new System.Drawing.Point(215, 574);
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
            this.numSafetyOrderStepScale.TabIndex = 19;
            this.numSafetyOrderStepScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 576);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Safety order step scale";
            // 
            // numTargetProfit
            // 
            this.numTargetProfit.DecimalPlaces = 2;
            this.numTargetProfit.Location = new System.Drawing.Point(215, 396);
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
            this.numTargetProfit.TabIndex = 12;
            this.numTargetProfit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(145, 398);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Target Profit";
            // 
            // lblQuoteCurrency
            // 
            this.lblQuoteCurrency.AutoSize = true;
            this.lblQuoteCurrency.Location = new System.Drawing.Point(343, 321);
            this.lblQuoteCurrency.Name = "lblQuoteCurrency";
            this.lblQuoteCurrency.Size = new System.Drawing.Size(37, 13);
            this.lblQuoteCurrency.TabIndex = 41;
            this.lblQuoteCurrency.Text = "USDT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(343, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "%";
            // 
            // lblTrailingUnit
            // 
            this.lblTrailingUnit.AutoSize = true;
            this.lblTrailingUnit.Location = new System.Drawing.Point(343, 448);
            this.lblTrailingUnit.Name = "lblTrailingUnit";
            this.lblTrailingUnit.Size = new System.Drawing.Size(15, 13);
            this.lblTrailingUnit.TabIndex = 43;
            this.lblTrailingUnit.Text = "%";
            this.lblTrailingUnit.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(343, 526);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 251);
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
            this.listViewStartConditions.Location = new System.Drawing.Point(215, 249);
            this.listViewStartConditions.Name = "listViewStartConditions";
            this.listViewStartConditions.Size = new System.Drawing.Size(120, 63);
            this.listViewStartConditions.TabIndex = 6;
            this.listViewStartConditions.UseCompatibleStateImageBehavior = false;
            this.listViewStartConditions.View = System.Windows.Forms.View.List;
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::_3Commas.BotCreator.Properties.Resources.Cancel_16x16;
            this.btnRemove.Location = new System.Drawing.Point(341, 276);
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
            this.btnAddStartCondition.Location = new System.Drawing.Point(341, 249);
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
            this.btnAbout.TabIndex = 25;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.Image = global::_3Commas.BotCreator.Properties.Resources.Properties_32x32;
            this.btnEditSettings.Location = new System.Drawing.Point(12, 12);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(60, 45);
            this.btnEditSettings.TabIndex = 24;
            this.btnEditSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSettings.UseVisualStyleBackColor = true;
            this.btnEditSettings.Click += new System.EventHandler(this.btnEditSettings_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::_3Commas.BotCreator.Properties.Resources.Clear_16x16;
            this.button1.Location = new System.Drawing.Point(921, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear Output";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::_3Commas.BotCreator.Properties.Resources.Play_16x16;
            this.btnCreate.Location = new System.Drawing.Point(214, 639);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Cooldown between deals";
            // 
            // numCooldownBetweenDeals
            // 
            this.numCooldownBetweenDeals.Location = new System.Drawing.Point(215, 600);
            this.numCooldownBetweenDeals.Maximum = new decimal(new int[] {
            2591999,
            0,
            0,
            0});
            this.numCooldownBetweenDeals.Name = "numCooldownBetweenDeals";
            this.numCooldownBetweenDeals.Size = new System.Drawing.Size(121, 20);
            this.numCooldownBetweenDeals.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "seconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "placeholders: {strategy} {pair}";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(114, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Bot Name Preview:";
            // 
            // lblBotNamePreview
            // 
            this.lblBotNamePreview.AutoSize = true;
            this.lblBotNamePreview.Location = new System.Drawing.Point(212, 201);
            this.lblBotNamePreview.Name = "lblBotNamePreview";
            this.lblBotNamePreview.Size = new System.Drawing.Size(83, 13);
            this.lblBotNamePreview.TabIndex = 58;
            this.lblBotNamePreview.Text = "USDT_XXX Bot";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 687);
            this.Controls.Add(this.lblBotNamePreview);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numCooldownBetweenDeals);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddStartCondition);
            this.Controls.Add(this.listViewStartConditions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnEditSettings);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblTrailingUnit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblQuoteCurrency);
            this.Controls.Add(this.numTargetProfit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.numSafetyOrderStepScale);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numMaxActiveSafetyTradesCount);
            this.Controls.Add(this.lblMaxSafetyTradesCount);
            this.Controls.Add(this.numMaxSafetyTradesCount);
            this.Controls.Add(this.numTrailingDeviation);
            this.Controls.Add(this.lblTrailing);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chkTrailing);
            this.Controls.Add(this.numSafetyOrderVolumeScale);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numPriceDeviationToOpenSafetyOrders);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbStartOrderType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBotname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numAmountToBuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtQuoteCurrency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSafetyOrderVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBaseOrderVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStrategy);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1048, 590);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bot Creator";
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
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Button btnEditSettings;
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
    }
}

