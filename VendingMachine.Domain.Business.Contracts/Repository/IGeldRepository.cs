using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Models;

namespace VendingMachine.Domain.Business.Contracts.Repository
{
    public interface IGeldRepository
    {

        List<Geld> GetVoorraadGeld();
        Geld GetGeldByHoeveelheid(double hoeveelheid);
        void ChangeGeld(double hoeveelheid, int amount);

    }
}
