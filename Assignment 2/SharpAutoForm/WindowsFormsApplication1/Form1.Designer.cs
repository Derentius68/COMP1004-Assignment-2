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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.ComputerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(132, 134);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(111, 20);
            this.BasePriceTextBox.TabIndex = 0;
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(12, 137);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(61, 13);
            this.BasePriceLabel.TabIndex = 1;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(12, 160);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(98, 13);
            this.AdditionalOptionsLabel.TabIndex = 2;
            this.AdditionalOptionsLabel.Text = "Additional Options: ";
            // 
            // AddionalOptionsTextBox
            // 
            this.AddionalOptionsTextBox.Location = new System.Drawing.Point(132, 157);
            this.AddionalOptionsTextBox.Name = "AddionalOptionsTextBox";
            this.AddionalOptionsTextBox.ReadOnly = true;
            this.AddionalOptionsTextBox.Size = new System.Drawing.Size(111, 20);
            this.AddionalOptionsTextBox.TabIndex = 3;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(12, 182);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 4;
            this.SubTotalLabel.Text = "SubTotal: ";
            this.SubTotalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(12, 207);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(89, 13);
            this.SalesTaxLabel.TabIndex = 5;
            this.SalesTaxLabel.Text = "Sales Tax (13%): ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 233);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total: ";
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(12, 268);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(99, 13);
            this.TradeInAllowanceLabel.TabIndex = 7;
            this.TradeInAllowanceLabel.Text = "Trade-In Allowance";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(12, 293);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(69, 13);
            this.AmountDueLabel.TabIndex = 8;
            this.AmountDueLabel.Text = "Amount Due:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(132, 179);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(111, 20);
            this.SubTotalTextBox.TabIndex = 11;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(132, 204);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(111, 20);
            this.SalesTaxTextBox.TabIndex = 12;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(132, 230);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(111, 20);
            this.TotalTextBox.TabIndex = 13;
            // 
            // TradeInAllowanceTextBox
            // 
            this.TradeInAllowanceTextBox.Location = new System.Drawing.Point(132, 267);
            this.TradeInAllowanceTextBox.Name = "TradeInAllowanceTextBox";
            this.TradeInAllowanceTextBox.Size = new System.Drawing.Size(111, 20);
            this.TradeInAllowanceTextBox.TabIndex = 14;
            this.TradeInAllowanceTextBox.Text = "0";
            this.TradeInAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(132, 293);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(111, 20);
            this.AmountDueTextBox.TabIndex = 15;
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(6, 23);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.StereoSystemCheckBox.TabIndex = 17;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(6, 47);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.LeatherInteriorCheckBox.TabIndex = 18;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputerNavigationCheckBox
            // 
            this.ComputerNavigationCheckBox.AutoSize = true;
            this.ComputerNavigationCheckBox.Location = new System.Drawing.Point(6, 71);
            this.ComputerNavigationCheckBox.Name = "ComputerNavigationCheckBox";
            this.ComputerNavigationCheckBox.Size = new System.Drawing.Size(125, 17);
            this.ComputerNavigationCheckBox.TabIndex = 19;
            this.ComputerNavigationCheckBox.Text = "Computer Navigation";
            this.ComputerNavigationCheckBox.UseVisualStyleBackColor = true;
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(6, 19);
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
            this.PearlizedRadioButton.Location = new System.Drawing.Point(6, 43);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.PearlizedRadioButton.TabIndex = 22;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomizedDetailingRadioButton
            // 
            this.CustomizedDetailingRadioButton.AutoSize = true;
            this.CustomizedDetailingRadioButton.Location = new System.Drawing.Point(6, 67);
            this.CustomizedDetailingRadioButton.Name = "CustomizedDetailingRadioButton";
            this.CustomizedDetailingRadioButton.Size = new System.Drawing.Size(123, 17);
            this.CustomizedDetailingRadioButton.TabIndex = 23;
            this.CustomizedDetailingRadioButton.Text = "Customized Detailing";
            this.CustomizedDetailingRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(31, 386);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(80, 35);
            this.CalculateButton.TabIndex = 24;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(166, 386);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 35);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(291, 386);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 35);
            this.ExitButton.TabIndex = 26;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.colourToolStripMenuItem.Text = "C&olour";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StereoSystemCheckBox);
            this.groupBox1.Controls.Add(this.LeatherInteriorCheckBox);
            this.groupBox1.Controls.Add(this.ComputerNavigationCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(266, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 113);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Items:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StandardRadioButton);
            this.groupBox2.Controls.Add(this.PearlizedRadioButton);
            this.groupBox2.Controls.Add(this.CustomizedDetailingRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(266, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 101);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Auto Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox ComputerNavigationCheckBox;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton CustomizedDetailingRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

