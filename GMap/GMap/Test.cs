using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap
{
    public class Item
    {
        private int _id;
        private int _order;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static IList<Item> InitList1()
        {
            var list = new List<Item>
        {
            new Item { Id = 1, Order = 1, Name = "Alpha" },
            new Item { Id = 2, Order = 2, Name = "Bravo" },
            new Item { Id = 3, Order = 3, Name = "Charlie" },
            new Item { Id = 4, Order = 4, Name = "Delta" }
        };

            return list;
        }
    }
}