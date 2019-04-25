using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Domain.Business;
using VendingMachine.Domain.Models;

namespace VendingMachine.App
{
    public partial class App : Form
    {
        int i = 0;
        int j = 0;
        public App()
        {
            InitializeComponent();
            //Comment out function to avoid database issue
            GetProducts();
            //GeldService gs = new GeldService();

            //Prijs product, inworp geld
            //gs.GetChange(1.75F, 2.0F);
            //ProductService ps = new ProductService();
            //ProductUC productUC = new ProductUC(ps.GetProducts()[0]);
            //this.Controls.Add(productUC);
        }
        
        public void GetProducts()
        {
            // Producten service voor ophalen producten
            ProductService ps = new ProductService();
            List<ProductUC> productList;
            productList = new List<ProductUC>();
            // Door alle producten heen gaan
            foreach (Product p in ps.GetProducts())
            {
                if (i <= 3)
                {
                    ProductUC productUC = new ProductUC(p);
                    productUC.Location = new Point(i * productUC.Width, j * productUC.Height);
                    i++;
                    productList.Add(productUC);
                }
                if(i == 4)
                {
                    i = 0;
                    j++;
                }
            }
            pnlProducts.Controls.Clear();
            pnlProducts.Controls.AddRange(productList.ToArray());
        }

        // Functie voor het omzetten van byte array naar image class
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void length()
        {
            int labelLength = lblChoice.Text.Length;
            if (labelLength > 5)
            {
                lblChoice.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Italic);
            }
            if (labelLength > 8)
            {
                lblChoice.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Italic);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn1.Text;
            length();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn2.Text;
            length();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn3.Text;
            length();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn4.Text;
            length();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn5.Text;
            length();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn6.Text;
            length();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn7.Text;
            length();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn8.Text;
            length();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn9.Text;
            length();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblChoice.Text = lblChoice.Text + btn0.Text;
            length();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblChoice.Text = "";
            lblChoice.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Italic);
        }
    }
}
