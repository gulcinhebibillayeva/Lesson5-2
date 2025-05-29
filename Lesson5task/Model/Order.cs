using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5task.Model
{
    public class Order:BaseModel
    {
        public double TotalPrice {  get; set; }
        public List<Product> Products { get; set; }
    }
}
