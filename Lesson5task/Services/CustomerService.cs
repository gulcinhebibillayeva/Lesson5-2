using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson5task.Database;
using Lesson5task.Model;

namespace Lesson5task.Services
{
    public class CustomerService : BaseService<Customer>
    {
        public CustomerService(StoreAppDataBase database) : base(database)
        {
        }

        public override void Add(Customer item) => _database.Customers.Add(item);
        public override Customer GetById(Guid id)
        {
            var customer = _database.Customers.FirstOrDefault(c => c.Id == id);
            return customer;


        }
        public override void DeleteById(Guid id)
        {
            var customer=GetById(id);
            if (customer != null)
            {
                _database.Customers.Remove(customer);
            }
        }

        public override List<Customer> GetAll()
        {
            return _database.Customers;
        }

        

        public override void Update(Customer item)
        {if (item != null)
            {
                var customer = GetById(item.Id);
                if (customer != null)
                {

                    customer.Name = item.Name;
                    customer.Surname = item.Surname;
                }
                
            }
            
        }

        
    }
}
