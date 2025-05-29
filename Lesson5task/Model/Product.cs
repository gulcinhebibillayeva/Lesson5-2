using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5task.Model
{
    public class Product:BaseModel
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public double Price {  get; set; }
    }
}
