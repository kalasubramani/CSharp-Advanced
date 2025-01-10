using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();
        public double Total
        {
            get {
                double calculatedTotal = 0;
                foreach(MenuItem item in items)
                {
                    calculatedTotal += item.Price; 
                }
                return calculatedTotal;
            }
            set {  }
        }
    }
}
