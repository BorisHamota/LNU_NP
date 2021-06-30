using MyPharmacy.DAL.Modules.Abstract;
using MyPharmacy.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyPharmacy.DAL.Repositories.Impl.FileImpl
{
    public abstract class BaseFileRepository<T> : IBaseRepository<T> where T : IEntity
    {
        public List<T> entities;

        public void Create(T product)
        {
            entities.Add(product);
            Save();
        }
        public void Delete(int id)
        {
            var itemToRemove = entities.Single(r => r.Id == id);
            entities.Remove(itemToRemove);
            Save();
        }
        public List<T> GetAll()
        {
            return entities;
        }
        public T GetById(int id)
        {
            return entities.Single(r => r.Id == id);
        }
        public void Update(T product)
        {
            //var itemToReplace = entities.Single(r => r.Id == product.Id);
            var index = entities.FindIndex(0, r => r.Id == product.Id);
            entities.RemoveAt(index);
            entities.Insert(index, product);
            Save();
        }
        protected void Init()
        {
            entities = new List<T>();
        }

        public abstract void Save();
        protected abstract void ReadItemsFromFile();
        protected abstract void ReadItemsFromStream(StreamReader streamReader);
        public abstract T ConvertToObject(string [] strObjItems);
    }
}
