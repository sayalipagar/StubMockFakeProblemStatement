using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubMockFakeDemo
{
    public class StarBuckNew
    {
        private readonly ICoffee service;
        public StarBuckNew(ICoffee service)
        {
            this.service = service;
        }
        public string OrderCoffee(int suggerPerSpone, int CoffeeCount)
        {
            if (service.CheckIngridentAvalability())
            {
                return service.CoffeeMaking(suggerPerSpone, CoffeeCount);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }
        }
    }
}
