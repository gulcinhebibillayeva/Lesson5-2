using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson5task.Database;
using Lesson5task.Model;
namespace Lesson5task.Services
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(StoreAppDataBase database) : base(database)
        {
        }
        public override void Add(Product item)
        {
            _database.Products.Add(item);
        }

        public override void DeleteById(Guid id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _database.Products.Remove(product);
            }
        }

        public override List<Product> GetAll()
        {
            return _database.Products;
        }

        public override Product GetById(Guid id)
        {
           return _database.Products.FirstOrDefault(p => p.Id == id);
        }

        public override void Update(Product item)
        {
            var product=GetById(item.Id);
            if (product != null) {
                product.Name = item.Name;
                product.Description = item.Description;
                product.Price = item.Price;
                        
            }
        }
    }
}
