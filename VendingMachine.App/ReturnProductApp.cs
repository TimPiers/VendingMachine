using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Domain.Models;

namespace VendingMachine.App
{
    public partial class ReturnProductApp : Form
    {

        private Product product;

        public ReturnProductApp(Product product)
        {
            InitializeComponent();
            this.product = product;
            SetupApp();
        }

        public void SetupApp()
        {
            productImage.BackgroundImage = byteArrayToImage(product.Afbeelding);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("../../Resources/product.wav");
            simpleSound.Play();
            productImage.Hide();
            button1.Hide();
        }
    }
}
