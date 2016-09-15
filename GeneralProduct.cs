using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem
{
    class GeneralProduct
    {

        public GeneralProduct(int id, double price, double quantity, string name, string guid)
        {
            this.ID = id;
            this.Price = price;
            this.Quantity = quantity;
            this.Name = name;
            this.Guid = guid;
        }
        public int ID
        {
            get;
            set;
        }

        public string Guid
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public double Quantity
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

    }
}
