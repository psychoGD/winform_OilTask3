namespace WindowsFormsApp1
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
            this.petrolGB = new System.Windows.Forms.GroupBox();
            this.oilPriceGB = new System.Windows.Forms.GroupBox();
            this.oilTotalLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.oilPriceTB = new System.Windows.Forms.TextBox();
            this.oilPriceLbl = new System.Windows.Forms.Label();
            this.oilTypesCB = new System.Windows.Forms.ComboBox();
            this.oilTypeLbl = new System.Windows.Forms.Label();
            this.marketGB = new System.Windows.Forms.GroupBox();
            this.marketPriceGB = new System.Windows.Forms.GroupBox();
            this.marketTotalLbl = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hamburgerCount = new System.Windows.Forms.NumericUpDown();
            this.hamburgerPrice = new System.Windows.Forms.TextBox();
            this.hamburgerLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.hotdogCount = new System.Windows.Forms.NumericUpDown();
            this.priceLbl = new System.Windows.Forms.Label();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hotdogLbl = new System.Windows.Forms.Label();
            this.totalGB = new System.Windows.Forms.GroupBox();
            this.payButton = new System.Windows.Forms.Button();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumofHotdogLbl = new System.Windows.Forms.Label();
            this.sumofHamburgerLbl = new System.Windows.Forms.Label();
            this.sumofPeraskiLbl = new System.Windows.Forms.Label();
            this.sumofQaynarLbl = new System.Windows.Forms.Label();
            this.petrolGB.SuspendLayout();
            this.oilPriceGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.marketGB.SuspendLayout();
            this.marketPriceGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotdogCount)).BeginInit();
            this.totalGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // petrolGB
            // 
            this.petrolGB.Controls.Add(this.oilPriceGB);
            this.petrolGB.Controls.Add(this.numericUpDown1);
            this.petrolGB.Controls.Add(this.label1);
            this.petrolGB.Controls.Add(this.oilPriceTB);
            this.petrolGB.Controls.Add(this.oilPriceLbl);
            this.petrolGB.Controls.Add(this.oilTypesCB);
            this.petrolGB.Controls.Add(this.oilTypeLbl);
            this.petrolGB.Location = new System.Drawing.Point(12, 12);
            this.petrolGB.Name = "petrolGB";
            this.petrolGB.Size = new System.Drawing.Size(440, 420);
            this.petrolGB.TabIndex = 0;
            this.petrolGB.TabStop = false;
            this.petrolGB.Text = "Petrol";
            // 
            // oilPriceGB
            // 
            this.oilPriceGB.Controls.Add(this.oilTotalLbl);
            this.oilPriceGB.Location = new System.Drawing.Point(24, 263);
            this.oilPriceGB.Name = "oilPriceGB";
            this.oilPriceGB.Size = new System.Drawing.Size(397, 137);
            this.oilPriceGB.TabIndex = 7;
            this.oilPriceGB.TabStop = false;
            this.oilPriceGB.Text = "Mebleg";
            // 
            // oilTotalLbl
            // 
            this.oilTotalLbl.AutoSize = true;
            this.oilTotalLbl.Location = new System.Drawing.Point(6, 48);
            this.oilTotalLbl.Name = "oilTotalLbl";
            this.oilTotalLbl.Size = new System.Drawing.Size(21, 23);
            this.oilTotalLbl.TabIndex = 0;
            this.oilTotalLbl.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 196);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Litr";
            // 
            // oilPriceTB
            // 
            this.oilPriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.oilPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oilPriceTB.Location = new System.Drawing.Point(158, 104);
            this.oilPriceTB.Name = "oilPriceTB";
            this.oilPriceTB.ReadOnly = true;
            this.oilPriceTB.Size = new System.Drawing.Size(121, 25);
            this.oilPriceTB.TabIndex = 3;
            // 
            // oilPriceLbl
            // 
            this.oilPriceLbl.AutoSize = true;
            this.oilPriceLbl.Location = new System.Drawing.Point(7, 107);
            this.oilPriceLbl.Name = "oilPriceLbl";
            this.oilPriceLbl.Size = new System.Drawing.Size(145, 23);
            this.oilPriceLbl.TabIndex = 2;
            this.oilPriceLbl.Text = "Petrol Qiymeti";
            // 
            // oilTypesCB
            // 
            this.oilTypesCB.FormattingEnabled = true;
            this.oilTypesCB.Location = new System.Drawing.Point(137, 43);
            this.oilTypesCB.Name = "oilTypesCB";
            this.oilTypesCB.Size = new System.Drawing.Size(121, 31);
            this.oilTypesCB.TabIndex = 1;
            this.oilTypesCB.SelectedIndexChanged += new System.EventHandler(this.oilTypesCB_SelectedIndexChanged);
            // 
            // oilTypeLbl
            // 
            this.oilTypeLbl.AutoSize = true;
            this.oilTypeLbl.Location = new System.Drawing.Point(6, 46);
            this.oilTypeLbl.Name = "oilTypeLbl";
            this.oilTypeLbl.Size = new System.Drawing.Size(125, 23);
            this.oilTypeLbl.TabIndex = 0;
            this.oilTypeLbl.Text = "Petrol Novu";
            // 
            // marketGB
            // 
            this.marketGB.Controls.Add(this.sumofQaynarLbl);
            this.marketGB.Controls.Add(this.sumofPeraskiLbl);
            this.marketGB.Controls.Add(this.sumofHamburgerLbl);
            this.marketGB.Controls.Add(this.sumofHotdogLbl);
            this.marketGB.Controls.Add(this.label4);
            this.marketGB.Controls.Add(this.marketPriceGB);
            this.marketGB.Controls.Add(this.numericUpDown2);
            this.marketGB.Controls.Add(this.textBox3);
            this.marketGB.Controls.Add(this.label2);
            this.marketGB.Controls.Add(this.numericUpDown3);
            this.marketGB.Controls.Add(this.textBox4);
            this.marketGB.Controls.Add(this.label3);
            this.marketGB.Controls.Add(this.hamburgerCount);
            this.marketGB.Controls.Add(this.hamburgerPrice);
            this.marketGB.Controls.Add(this.hamburgerLbl);
            this.marketGB.Controls.Add(this.countLbl);
            this.marketGB.Controls.Add(this.hotdogCount);
            this.marketGB.Controls.Add(this.priceLbl);
            this.marketGB.Controls.Add(this.productNameLbl);
            this.marketGB.Controls.Add(this.textBox2);
            this.marketGB.Controls.Add(this.hotdogLbl);
            this.marketGB.Location = new System.Drawing.Point(557, 12);
            this.marketGB.Name = "marketGB";
            this.marketGB.Size = new System.Drawing.Size(511, 420);
            this.marketGB.TabIndex = 1;
            this.marketGB.TabStop = false;
            this.marketGB.Text = "Mini Market";
            // 
            // marketPriceGB
            // 
            this.marketPriceGB.Controls.Add(this.marketTotalLbl);
            this.marketPriceGB.Location = new System.Drawing.Point(14, 263);
            this.marketPriceGB.Name = "marketPriceGB";
            this.marketPriceGB.Size = new System.Drawing.Size(397, 151);
            this.marketPriceGB.TabIndex = 19;
            this.marketPriceGB.TabStop = false;
            this.marketPriceGB.Text = "Mebleg";
            // 
            // marketTotalLbl
            // 
            this.marketTotalLbl.AutoSize = true;
            this.marketTotalLbl.Location = new System.Drawing.Point(6, 48);
            this.marketTotalLbl.Name = "marketTotalLbl";
            this.marketTotalLbl.Size = new System.Drawing.Size(21, 23);
            this.marketTotalLbl.TabIndex = 0;
            this.marketTotalLbl.Text = "0";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(296, 221);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 32);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Qaynar Peraski";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(296, 167);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown3.TabIndex = 15;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 32);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Peraski";
            // 
            // hamburgerCount
            // 
            this.hamburgerCount.Location = new System.Drawing.Point(296, 118);
            this.hamburgerCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hamburgerCount.Name = "hamburgerCount";
            this.hamburgerCount.Size = new System.Drawing.Size(120, 32);
            this.hamburgerCount.TabIndex = 12;
            this.hamburgerCount.ValueChanged += new System.EventHandler(this.hamburgerCount_ValueChanged);
            // 
            // hamburgerPrice
            // 
            this.hamburgerPrice.Location = new System.Drawing.Point(172, 118);
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.ReadOnly = true;
            this.hamburgerPrice.Size = new System.Drawing.Size(100, 32);
            this.hamburgerPrice.TabIndex = 11;
            this.hamburgerPrice.Text = "7";
            // 
            // hamburgerLbl
            // 
            this.hamburgerLbl.AutoSize = true;
            this.hamburgerLbl.Location = new System.Drawing.Point(10, 121);
            this.hamburgerLbl.Name = "hamburgerLbl";
            this.hamburgerLbl.Size = new System.Drawing.Size(121, 23);
            this.hamburgerLbl.TabIndex = 10;
            this.hamburgerLbl.Text = "Hamburger";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(292, 28);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(70, 23);
            this.countLbl.TabIndex = 9;
            this.countLbl.Text = "Count";
            // 
            // hotdogCount
            // 
            this.hotdogCount.Location = new System.Drawing.Point(296, 62);
            this.hotdogCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hotdogCount.Name = "hotdogCount";
            this.hotdogCount.Size = new System.Drawing.Size(120, 32);
            this.hotdogCount.TabIndex = 8;
            this.hotdogCount.ValueChanged += new System.EventHandler(this.hotdogCount_ValueChanged);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(168, 28);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(57, 23);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "Price";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLbl.Location = new System.Drawing.Point(6, 34);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(132, 21);
            this.productNameLbl.TabIndex = 2;
            this.productNameLbl.Text = "Product Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 32);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "4";
            // 
            // hotdogLbl
            // 
            this.hotdogLbl.AutoSize = true;
            this.hotdogLbl.Location = new System.Drawing.Point(10, 67);
            this.hotdogLbl.Name = "hotdogLbl";
            this.hotdogLbl.Size = new System.Drawing.Size(91, 23);
            this.hotdogLbl.TabIndex = 0;
            this.hotdogLbl.Text = "Hot Dog";
            // 
            // totalGB
            // 
            this.totalGB.Controls.Add(this.payButton);
            this.totalGB.Controls.Add(this.TotalPriceLbl);
            this.totalGB.Location = new System.Drawing.Point(12, 438);
            this.totalGB.Name = "totalGB";
            this.totalGB.Size = new System.Drawing.Size(1056, 160);
            this.totalGB.TabIndex = 1;
            this.totalGB.TabStop = false;
            this.totalGB.Text = "Umumi Hesab";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(545, 74);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(146, 44);
            this.payButton.TabIndex = 1;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLbl.Location = new System.Drawing.Point(24, 74);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(40, 44);
            this.TotalPriceLbl.TabIndex = 0;
            this.TotalPriceLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sum";
            // 
            // sumofHotdogLbl
            // 
            this.sumofHotdogLbl.AutoSize = true;
            this.sumofHotdogLbl.Location = new System.Drawing.Point(439, 71);
            this.sumofHotdogLbl.Name = "sumofHotdogLbl";
            this.sumofHotdogLbl.Size = new System.Drawing.Size(21, 23);
            this.sumofHotdogLbl.TabIndex = 21;
            this.sumofHotdogLbl.Text = "0";
            // 
            // sumofHamburgerLbl
            // 
            this.sumofHamburgerLbl.AutoSize = true;
            this.sumofHamburgerLbl.Location = new System.Drawing.Point(439, 127);
            this.sumofHamburgerLbl.Name = "sumofHamburgerLbl";
            this.sumofHamburgerLbl.Size = new System.Drawing.Size(21, 23);
            this.sumofHamburgerLbl.TabIndex = 22;
            this.sumofHamburgerLbl.Text = "0";
            // 
            // sumofPeraskiLbl
            // 
            this.sumofPeraskiLbl.AutoSize = true;
            this.sumofPeraskiLbl.Location = new System.Drawing.Point(439, 179);
            this.sumofPeraskiLbl.Name = "sumofPeraskiLbl";
            this.sumofPeraskiLbl.Size = new System.Drawing.Size(21, 23);
            this.sumofPeraskiLbl.TabIndex = 23;
            this.sumofPeraskiLbl.Text = "0";
            // 
            // sumofQaynarLbl
            // 
            this.sumofQaynarLbl.AutoSize = true;
            this.sumofQaynarLbl.Location = new System.Drawing.Point(439, 230);
            this.sumofQaynarLbl.Name = "sumofQaynarLbl";
            this.sumofQaynarLbl.Size = new System.Drawing.Size(21, 23);
            this.sumofQaynarLbl.TabIndex = 24;
            this.sumofQaynarLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 619);
            this.Controls.Add(this.totalGB);
            this.Controls.Add(this.marketGB);
            this.Controls.Add(this.petrolGB);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.petrolGB.ResumeLayout(false);
            this.petrolGB.PerformLayout();
            this.oilPriceGB.ResumeLayout(false);
            this.oilPriceGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.marketGB.ResumeLayout(false);
            this.marketGB.PerformLayout();
            this.marketPriceGB.ResumeLayout(false);
            this.marketPriceGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotdogCount)).EndInit();
            this.totalGB.ResumeLayout(false);
            this.totalGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox petrolGB;
        private System.Windows.Forms.GroupBox oilPriceGB;
        private System.Windows.Forms.Label oilTotalLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oilPriceTB;
        private System.Windows.Forms.Label oilPriceLbl;
        private System.Windows.Forms.ComboBox oilTypesCB;
        private System.Windows.Forms.Label oilTypeLbl;
        private System.Windows.Forms.GroupBox marketGB;
        private System.Windows.Forms.GroupBox marketPriceGB;
        private System.Windows.Forms.Label marketTotalLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hamburgerCount;
        private System.Windows.Forms.TextBox hamburgerPrice;
        private System.Windows.Forms.Label hamburgerLbl;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.NumericUpDown hotdogCount;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label hotdogLbl;
        private System.Windows.Forms.GroupBox totalGB;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Label sumofQaynarLbl;
        private System.Windows.Forms.Label sumofPeraskiLbl;
        private System.Windows.Forms.Label sumofHamburgerLbl;
        private System.Windows.Forms.Label sumofHotdogLbl;
        private System.Windows.Forms.Label label4;
    }
}

