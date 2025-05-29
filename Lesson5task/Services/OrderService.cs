using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson5task.Database;
using Lesson5task.Model;
using Lesson5task.Services;

namespace Lesson5task.Services
{
    public class OrderService : BaseService<Order>
    {
        public OrderService(StoreAppDataBase database) : base(database)
        {
        }

        public override void Add(Order item)
        {
           foreach(var product in item.Products)
            {
                item.TotalPrice += product.Price;
            }
        }

        public override void DeleteById(Guid id)
        {var product=GetById(id);
            if (product != null) {
                _database.Orders.Remove(product);

            }
        }

        public override List<Order> GetAll()
        {
            return _database.Orders.ToList();
        }

        public override Order GetById(Guid id)
        {
            return _database.Orders.FirstOrDefault(p => p.Id == id);
        }

        public override void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
