using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Models;

namespace VendingMachine.Domain.Business.Contracts.Business
{
    public interface IGeldService
    {

        List<Geld> GetVoorraadGeld();
        List<Geld> GetChange(float price, float insert);
        void RemoveGeld(double hoeveelheid, int amount);
    }
}
