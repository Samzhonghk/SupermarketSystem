using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem
{
    class Car:GeneralProduct
    {
        public Car(int id, double price, double quantity, string name, string guid):base(id,price,quantity,name,guid)
        {

        }
    }
}
