using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5task.Model
{
    public class Customer:BaseModel
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        public List<Order> Orders { get; set; }
    }
}
