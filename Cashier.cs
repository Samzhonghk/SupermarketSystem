using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem
{
    public class Cashier
    {
        public Cashier()
        {
            //rep.SaveGoods();
        }

        public void AskForBuying()
        {
            Console.WriteLine("Hi, welcome! \n We have car, computer, furniture, lawmower and sport equipment");
            string strType = Console.ReadLine(); 

        }

        ProductRepository rep = new ProductRepository();
    }
}
