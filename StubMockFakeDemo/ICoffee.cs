using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubMockFakeDemo
{
    public interface ICoffee
    {
        bool CheckIngridentAvalability();
        string CoffeeMaking(int suggerPerSpone, int CoffeePack);
    }
}
