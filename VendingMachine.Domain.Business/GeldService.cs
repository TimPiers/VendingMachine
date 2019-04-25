using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Business;
using VendingMachine.Domain.Models;
using VendingMachine.Repository.Repositories;

namespace VendingMachine.Domain.Business
{
    public class GeldService : IGeldService
    {
        private GeldRepository geldRepository;

        public GeldService()
        {
            geldRepository = new GeldRepository();
        }

        public List<Geld> GetChange(float price, float insert)
        {
            List<Geld> voorraad = geldRepository.GetVoorraadGeld();
            List<Geld> change = new List<Geld>();
            double remainingPrice = insert - price;
            int slot = 0;
            while (remainingPrice >= 0.001)
            {
                double x = remainingPrice / ((double)voorraad[slot].Valuta);
                if (voorraad[slot].Kwantiteit - x <= 0)
                {
                    slot++;
                }
                else
                {
                    double z = Math.Floor(x) * voorraad[slot].Valuta;
                    if(z > 0)
                    {
                        remainingPrice = ((remainingPrice * 100) - Math.Floor((z * 100))) / 100;
                        Geld g = voorraad[slot];
                        g.Kwantiteit = (int)Math.Floor(x);
                        change.Add(g);
                    }
                    slot++;
                }
               
            }

            foreach(Geld g in change)
            {
                RemoveGeld(g.Valuta, -g.Kwantiteit);
            }
            return change;
        }

        public List<Geld> GetVoorraadGeld()
        {
            return geldRepository.GetVoorraadGeld();
        }

        public void RemoveGeld(double hoeveelheid, int amount)
        {
            geldRepository.ChangeGeld(hoeveelheid, amount);
        }
    }
}
