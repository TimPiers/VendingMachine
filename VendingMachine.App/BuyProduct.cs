using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Domain.Business;
using VendingMachine.Domain.Models;

namespace VendingMachine.App
{
    public partial class BuyProduct : Form
    {
        public BuyProduct(ProductUC product)
        {
            InitializeComponent();
            productUc = product;
        }

        private ProductUC productUc;
        private double inworp = 0;

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            inworp += Double.Parse(button.Text);
            label1.Text = "Huidige inworp: " + inworp.ToString("0.00") + " euro";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(inworp >= productUc.prijs)
            {
                GeldService gs = new GeldService();
                List<Geld> change = gs.GetChange((float)productUc.prijs, (float)inworp);
                string geld = "Uw wisselgeld: \n";
                foreach(Geld g in change)
                {
                    geld += g.Kwantiteit + "x " + g.Valuta.ToString("0.00") + "\n";
                }
                MessageBox.Show(geld);
                ReturnProductApp rpa = new ReturnProductApp(productUc.p);
                rpa.Show();
            }
            else
            {
                MessageBox.Show("Helaas je komt nog wat muntjes te kort");
            }
        }
    }
}
