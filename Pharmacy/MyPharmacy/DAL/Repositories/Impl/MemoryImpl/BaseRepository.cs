using MyPharmacy.DAL.Modules.Abstract;
using MyPharmacy.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MyPharmacy.DAL.Repositories.Impl.MemoryImpl
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : IEntity
    {
        public List<T> entities = new List<T>();
        public virtual void Create(T product) 
        {
            entities.Add(product);
        }
        public virtual void Update(T product) 
        {
        }
        public virtual void Delete(int id)
        {
            var itemToRemove = entities.Single(r => r.Id == id);
            entities.Remove(itemToRemove);
        }
        public virtual T GetById(int id)
        {
            return entities.Single(r => r.Id == id);
        }
        public virtual List<T> GetAll()
        {
            return entities;
        }
    }
}
