using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubMockFakeDemo
{
    public class StarBucks : ICoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }
        string ICoffee.CoffeeMaking(int suggerPerSpone, int CoffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarbucks : ICoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }
        public string CoffeeMaking(int suggerPerSpone, int CoffeePack)
        {
            return "Your Order is received.";
        }
    }
}
