namespace _3Commas.BotCreator.Views.SaveTemplateView
{
    partial class SaveTemplateView
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
            this.button1 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.txtNewTemplate = new System.Windows.Forms.TextBox();
            this.cmbExistingTemplate = new System.Windows.Forms.ComboBox();
            this.radioButtonCreateNew = new System.Windows.Forms.RadioButton();
            this.radioButtonOverwriteExisting = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(152, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Cancel";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(233, 123);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 27;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // txtNewTemplate
            // 
            this.txtNewTemplate.Location = new System.Drawing.Point(167, 31);
            this.txtNewTemplate.Name = "txtNewTemplate";
            this.txtNewTemplate.Size = new System.Drawing.Size(120, 20);
            this.txtNewTemplate.TabIndex = 30;
            this.txtNewTemplate.Visible = false;
            // 
            // cmbExistingTemplate
            // 
            this.cmbExistingTemplate.FormattingEnabled = true;
            this.cmbExistingTemplate.Location = new System.Drawing.Point(167, 69);
            this.cmbExistingTemplate.Name = "cmbExistingTemplate";
            this.cmbExistingTemplate.Size = new System.Drawing.Size(121, 21);
            this.cmbExistingTemplate.TabIndex = 31;
            this.cmbExistingTemplate.Visible = false;
            // 
            // radioButtonCreateNew
            // 
            this.radioButtonCreateNew.AutoSize = true;
            this.radioButtonCreateNew.Location = new System.Drawing.Point(28, 32);
            this.radioButtonCreateNew.Name = "radioButtonCreateNew";
            this.radioButtonCreateNew.Size = new System.Drawing.Size(122, 17);
            this.radioButtonCreateNew.TabIndex = 33;
            this.radioButtonCreateNew.TabStop = true;
            this.radioButtonCreateNew.Text = "Create new template";
            this.radioButtonCreateNew.UseVisualStyleBackColor = true;
            this.radioButtonCreateNew.CheckedChanged += new System.EventHandler(this.radioButtonCreateNew_CheckedChanged);
            // 
            // radioButtonOverwriteExisting
            // 
            this.radioButtonOverwriteExisting.AutoSize = true;
            this.radioButtonOverwriteExisting.Location = new System.Drawing.Point(28, 70);
            this.radioButtonOverwriteExisting.Name = "radioButtonOverwriteExisting";
            this.radioButtonOverwriteExisting.Size = new System.Drawing.Size(108, 17);
            this.radioButtonOverwriteExisting.TabIndex = 34;
            this.radioButtonOverwriteExisting.TabStop = true;
            this.radioButtonOverwriteExisting.Text = "Overwrite existing";
            this.radioButtonOverwriteExisting.UseVisualStyleBackColor = true;
            this.radioButtonOverwriteExisting.CheckedChanged += new System.EventHandler(this.radioButtonCreateNew_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "or";
            // 
            // SaveTemplateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonOverwriteExisting);
            this.Controls.Add(this.radioButtonCreateNew);
            this.Controls.Add(this.txtNewTemplate);
            this.Controls.Add(this.cmbExistingTemplate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveTemplateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox txtNewTemplate;
        private System.Windows.Forms.ComboBox cmbExistingTemplate;
        private System.Windows.Forms.RadioButton radioButtonCreateNew;
        private System.Windows.Forms.RadioButton radioButtonOverwriteExisting;
        private System.Windows.Forms.Label label1;
    }
}