using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.DAL.Modules.Impl;
using System.Collections.Generic;

namespace MyPharmacy.DAL.Repositories.Impl.MemoryImpl
{
	public class CartRepository : BaseRepository<Flyweight>,ICartRepositoty
    {
        public CartRepository() { }
		public bool IsProductExist(Flyweight product)
		{
			var it = entities.Find(x => x.Id == product.Id);
			if (it == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public override List<Flyweight> GetAll()
        {
			return entities;
		}

        public void Save()
        {
        }

        public void DeleteAll()
        {
        }
    }
}
