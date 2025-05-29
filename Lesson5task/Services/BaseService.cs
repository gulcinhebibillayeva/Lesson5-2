using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson5task.Database;
using Lesson5task.Model;

namespace Lesson5task.Services
{
    public abstract class BaseService<T>where T : BaseModel
    {
        protected StoreAppDataBase _database;
        public BaseService(StoreAppDataBase database) {
            _database = database;
        }      
        public abstract List<T> GetAll();
        public abstract T GetById(Guid id);
        public abstract void DeleteById(Guid id);
        public abstract void Add(T item);
        public abstract void Update(T item);
    }
}
