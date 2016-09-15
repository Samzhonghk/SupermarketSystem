using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSystem
{
    class ProductRepository
    {
        List<List<GeneralProduct>> repository = new List<List<GeneralProduct>>();
        public ProductRepository()
        {
            repository.Add(new List<GeneralProduct>());//car
            repository.Add(new List<GeneralProduct>());//computer
            repository.Add(new List<GeneralProduct>());//furniture
            repository.Add(new List<GeneralProduct>());//sportequipment
            repository.Add(new List<GeneralProduct>());//lawmower
        }

        public void SaveGoods(string strType, double quantity, double price, string name)
        {
            for (int i = 0; i < quantity; i++)
            {
                switch (strType)
                {
                    case "Car": repository[0].Add(new Car(i,price, quantity, name, Guid.NewGuid().ToString()));
                        break;

                    case "Computer": repository[1].Add(new Computer(i, price,quantity, name, Guid.NewGuid().ToString()));
                        break;

                    case "Furniture": repository[2].Add(new Furniture(i, price, quantity, name, Guid.NewGuid().ToString()));
                        break;


                }
            }
        }

        public GeneralProduct[] GetGoods(string strType, double quantity)
        {
            GeneralProduct[] GetGoodsList = new GeneralProduct[(int)quantity];
            for (int i = 0; i < quantity; i++)
            {
                switch (strType)
                {
                    case "Car": GetGoodsList[i] = repository[0][0];
                        repository[0].RemoveAt(0);
                        break;
                    case "Computer": GetGoodsList[i] = repository[1][0];
                        repository[1].RemoveAt(0);
                        break;
                    case "Furniture": GetGoodsList[i] = repository[2][0];
                        repository[2].RemoveAt(0);
                        break;
                }
            }
            return GetGoodsList;
        }

        public void displayProducts()
        {
            foreach (var item in repository)
            {
                Console.WriteLine("List of our products");
                Console.WriteLine("Product ID: {0}", item[0].ID + "\n Product Guid: {0}", item[0].Guid + "\n Product Name: {0}", item[0].Name + "\n Product Price: {1}", item[0].Price + "\n Product Quantity: {0}", item[0].Quantity);
                
            }
        }
    }
}
