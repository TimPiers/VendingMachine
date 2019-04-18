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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Comment out function to avoid database issue
            //GetProducts();
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
    }
}
