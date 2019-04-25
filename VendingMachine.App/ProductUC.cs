using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VendingMachine.Domain.Models;

namespace VendingMachine.App
{
    public partial class ProductUC : UserControl
    {

        public int tag;
        public double prijs;
        public Product p;

        public ProductUC(Product product)
        {
            InitializeComponent();
            p = product;
            tag = product.Id;
            prijs = product.Prijs;
            if (tag < 10)
            {
                lblTag.Text = "0" + Convert.ToString(tag);
            }
            else
            {
                lblTag.Text = Convert.ToString(tag);
            }
            pbProduct.Image = byteArrayToImage(product.Afbeelding);
            lblPrijs.Text = String.Format("{0:0.00}", prijs);
        }

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
    }
}
