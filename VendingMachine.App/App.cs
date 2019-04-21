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
        public App()
        {
            InitializeComponent();
            //Comment out function to avoid database issue
            //GetProducts();
            //GeldService gs = new GeldService();

            //Prijs product, inworp geld
            //gs.GetChange(1.75F, 2.0F);
        }
        
        public void GetProducts()
        {
            // Producten service voor ophalen producten
            ProductService ps = new ProductService();
            // Door alle producten heen gaan
            foreach (Product p in ps.GetProducts())
            {
                // Afbeelding byte array omzetten naar image's
                Image i = byteArrayToImage(p.Afbeelding);
                this.BackgroundImage = i;
            }
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

        private void testProductBtn_Click(object sender, EventArgs e)
        {
            ProductService ps = new ProductService();
            //Maak product scherm aan met eerste product in db
            ReturnProductApp rpa = new ReturnProductApp(ps.GetProducts()[0]);
            //Toon scherm
            rpa.Show();
        }
    }
}
