using Aspose.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        static public string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
            List<Oil> oils = new List<Oil>()
            {
                new Oil("Dizel",0.8),
                new Oil("AI-92",1),
                new Oil("AI-95",1.8),
            };
            oilTypesCB.DisplayMember = nameof(Oil.Name);
            oilTypesCB.Items.AddRange(oils.ToArray());
        }
        static public void CreatePDF(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                // Initialize document object
                Document document = new Document();

                // Add page
                Aspose.Pdf.Page page = document.Pages.Add();

                // Add text to new page
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(text));

                // Save PDF 
                
                document.Save($"{filePath}\\{Guid.NewGuid().ToString().Substring(0, 8)}.pdf");
            }
            
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            string paymentinfo = $@"
--------------------AzPetrol--------------------
Time: {DateTime.Now}
-----Market
    {marketTotalLbl.Text}
-----Oil
    {oilTotalLbl.Text}

Thank You For Choosing Us

";
            CreatePDF(paymentinfo);
            MessageBox.Show("Succesfully");
            Application.Restart();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(oilPriceTB.Text != "")
            {
                var oilprice = double.Parse(oilPriceTB.Text);
                if (oilprice != 0)
                {
                    oilTotalLbl.Text = (oilprice * ((double)numericUpDown1.Value)).ToString();
                    TotalPriceLbl.Text = (double.Parse(marketTotalLbl.Text) + double.Parse(oilTotalLbl.Text)).ToString();
                }
            }
            
        }
        
        private void oilTypesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var oil = oilTypesCB.SelectedItem as Oil;
            if(oil != null)
            {
                oilTotalLbl.Text = "0";

                oilPriceTB.Text = oil.Price.ToString();

            }

        }
        private void TotalPriceMarketUpdate()
        {
            marketTotalLbl.Text = (double.Parse(sumofHotdogLbl.Text) + double.Parse(sumofHamburgerLbl.Text) + double.Parse(sumofPeraskiLbl.Text) +
                double.Parse(sumofQaynarLbl.Text)).ToString();
            TotalPriceLbl.Text = (double.Parse(oilTotalLbl.Text) + double.Parse(marketTotalLbl.Text)).ToString();
        }
        private void hotdogCount_ValueChanged(object sender, EventArgs e)
        {
            sumofHotdogLbl.Text = (double.Parse(textBox2.Text) * (double)hotdogCount.Value).ToString();
            TotalPriceMarketUpdate();

        }

        private void hamburgerCount_ValueChanged(object sender, EventArgs e)
        {
            sumofHamburgerLbl.Text = (double.Parse(hamburgerPrice.Text) * (double)hamburgerCount.Value).ToString();
            TotalPriceMarketUpdate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            sumofPeraskiLbl.Text = (double.Parse(textBox4.Text) * (double)numericUpDown3.Value).ToString();
            TotalPriceMarketUpdate();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            sumofQaynarLbl.Text = (double.Parse(textBox3.Text) * (double)numericUpDown2.Value).ToString();
            TotalPriceMarketUpdate();

        }
    }
}
