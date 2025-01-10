using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class MenuItem
    {
        private double _price;

        public String Title, Description;
        public double Price
        {
            get { return _price; }
            set {
                if (value > 0) _price = value;
                else throw new ArgumentOutOfRangeException("Menu items can not have a negative price.");
            }
        }
        
       

    }
}
