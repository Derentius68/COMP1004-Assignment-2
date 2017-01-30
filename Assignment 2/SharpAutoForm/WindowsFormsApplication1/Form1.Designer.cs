namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.AddionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalItemsLabel = new System.Windows.Forms.Label();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.ComputerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishLabel = new System.Windows.Forms.Label();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(132, 29);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(111, 20);
            this.BasePriceTextBox.TabIndex = 0;
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(12, 32);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(61, 13);
            this.BasePriceLabel.TabIndex = 1;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(12, 55);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(98, 13);
            this.AdditionalOptionsLabel.TabIndex = 2;
            this.AdditionalOptionsLabel.Text = "Additional Options: ";
            // 
            // AddionalOptionsTextBox
            // 
            this.AddionalOptionsTextBox.Location = new System.Drawing.Point(132, 52);
            this.AddionalOptionsTextBox.Name = "AddionalOptionsTextBox";
            this.AddionalOptionsTextBox.ReadOnly = true;
            this.AddionalOptionsTextBox.Size = new System.Drawing.Size(111, 20);
            this.AddionalOptionsTextBox.TabIndex = 3;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(12, 77);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 4;
            this.SubTotalLabel.Text = "SubTotal: ";
            this.SubTotalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(12, 102);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(89, 13);
            this.SalesTaxLabel.TabIndex = 5;
            this.SalesTaxLabel.Text = "Sales Tax (13%): ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 128);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total: ";
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(12, 163);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(99, 13);
            this.TradeInAllowanceLabel.TabIndex = 7;
            this.TradeInAllowanceLabel.Text = "Trade-In Allowance";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(12, 188);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(69, 13);
            this.AmountDueLabel.TabIndex = 8;
            this.AmountDueLabel.Text = "Amount Due:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(132, 74);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(111, 20);
            this.SubTotalTextBox.TabIndex = 11;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(132, 99);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(111, 20);
            this.SalesTaxTextBox.TabIndex = 12;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(132, 125);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(111, 20);
            this.TotalTextBox.TabIndex = 13;
            // 
            // TradeInAllowanceTextBox
            // 
            this.TradeInAllowanceTextBox.Location = new System.Drawing.Point(132, 162);
            this.TradeInAllowanceTextBox.Name = "TradeInAllowanceTextBox";
            this.TradeInAllowanceTextBox.Size = new System.Drawing.Size(111, 20);
            this.TradeInAllowanceTextBox.TabIndex = 14;
            this.TradeInAllowanceTextBox.Text = "0";
            this.TradeInAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(132, 188);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(111, 20);
            this.AmountDueTextBox.TabIndex = 15;
            // 
            // AdditionalItemsLabel
            // 
            this.AdditionalItemsLabel.AutoSize = true;
            this.AdditionalItemsLabel.Location = new System.Drawing.Point(272, 31);
            this.AdditionalItemsLabel.Name = "AdditionalItemsLabel";
            this.AdditionalItemsLabel.Size = new System.Drawing.Size(87, 13);
            this.AdditionalItemsLabel.TabIndex = 16;
            this.AdditionalItemsLabel.Text = "Additional Items: ";
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(275, 50);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.StereoSystemCheckBox.TabIndex = 17;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(275, 74);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.LeatherInteriorCheckBox.TabIndex = 18;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputerNavigationCheckBox
            // 
            this.ComputerNavigationCheckBox.AutoSize = true;
            this.ComputerNavigationCheckBox.Location = new System.Drawing.Point(275, 98);
            this.ComputerNavigationCheckBox.Name = "ComputerNavigationCheckBox";
            this.ComputerNavigationCheckBox.Size = new System.Drawing.Size(125, 17);
            this.ComputerNavigationCheckBox.TabIndex = 19;
            this.ComputerNavigationCheckBox.Text = "Computer Navigation";
            this.ComputerNavigationCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExteriorFinishLabel
            // 
            this.ExteriorFinishLabel.AutoSize = true;
            this.ExteriorFinishLabel.Location = new System.Drawing.Point(272, 153);
            this.ExteriorFinishLabel.Name = "ExteriorFinishLabel";
            this.ExteriorFinishLabel.Size = new System.Drawing.Size(72, 13);
            this.ExteriorFinishLabel.TabIndex = 20;
            this.ExteriorFinishLabel.Text = "Exterior Finish";
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(275, 174);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.StandardRadioButton.TabIndex = 21;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(275, 198);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.PearlizedRadioButton.TabIndex = 22;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomizedDetailingRadioButton
            // 
            this.CustomizedDetailingRadioButton.AutoSize = true;
            this.CustomizedDetailingRadioButton.Location = new System.Drawing.Point(275, 222);
            this.CustomizedDetailingRadioButton.Name = "CustomizedDetailingRadioButton";
            this.CustomizedDetailingRadioButton.Size = new System.Drawing.Size(123, 17);
            this.CustomizedDetailingRadioButton.TabIndex = 23;
            this.CustomizedDetailingRadioButton.Text = "Customized Detailing";
            this.CustomizedDetailingRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(31, 281);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(80, 35);
            this.CalculateButton.TabIndex = 24;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(166, 281);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 35);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(291, 281);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 35);
            this.ExitButton.TabIndex = 26;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 340);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CustomizedDetailingRadioButton);
            this.Controls.Add(this.PearlizedRadioButton);
            this.Controls.Add(this.StandardRadioButton);
            this.Controls.Add(this.ExteriorFinishLabel);
            this.Controls.Add(this.ComputerNavigationCheckBox);
            this.Controls.Add(this.LeatherInteriorCheckBox);
            this.Controls.Add(this.StereoSystemCheckBox);
            this.Controls.Add(this.AdditionalItemsLabel);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.TradeInAllowanceTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AddionalOptionsTextBox);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.BasePriceTextBox);
            this.Name = "Form1";
            this.Text = "Auto Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.TextBox AddionalOptionsTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TradeInAllowanceTextBox;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.Label AdditionalItemsLabel;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox ComputerNavigationCheckBox;
        private System.Windows.Forms.Label ExteriorFinishLabel;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton CustomizedDetailingRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

