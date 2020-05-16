using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    class ShippingService
    {
        private double unitPriceOfMass;
        public ShippingService(double unitPriceOfMass)
        {
            this.unitPriceOfMass = unitPriceOfMass;
        }
        public double Price(double weight)
        {
            return unitPriceOfMass * weight;
        }



    }



}
