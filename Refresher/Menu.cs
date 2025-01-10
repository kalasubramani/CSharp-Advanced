using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class Menu
    {
        public Menu() {
            items = new List<MenuItem>();
        }

        public void AddMenuItem(string Title, string Desc,double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Desc;
            item.Price = Price;
            items.Add(item);
        }
        public string name;
        public List<MenuItem> items;
    }
}
