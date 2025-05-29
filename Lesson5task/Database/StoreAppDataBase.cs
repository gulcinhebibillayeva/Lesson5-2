using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson5task.Model;

namespace Lesson5task.Database
{
    public  class StoreAppDataBase
    {
        public List <Customer>Customers { get; set; }
        public List<Order>Orders { get; set; }
        public List<Product>Products { get; set; }


        public StoreAppDataBase()
        {
            Customers=new List<Model.Customer>();
            Products=new List<Model.Product>();
            Orders=new List<Model.Order>();
        }
    }
}
