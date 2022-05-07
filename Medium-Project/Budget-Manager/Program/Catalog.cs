using System;
using System.Collections.Generic;
using System.Linq;

namespace Budget_Manager
{
    abstract class Catalog
    {
        public Dictionary<string, double> Product = new Dictionary<string, double>();
        public virtual void AddPurchase(string product, double price)
        {
            this.Product.Add(product, price);
        }

        public virtual void showList()
        {

            if (this.Product.Count == 0)
            {
                Console.WriteLine("Your list is empty");
            }
            else
            {
                for (int i = 0; i < Product.Count; i++)
                {
                    Console.WriteLine("{0} ${1:N}",
                                                            Product.ElementAt(i).Key,
                                                            Product.ElementAt(i).Value);
                }
            }
        }




    }
}
