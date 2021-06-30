using MyPharmacy.DAL.Modules.Impl;

namespace MyPharmacy.DAL.Repositories.Abstract
{
    public interface ICosmeticRepository : IBaseRepository<Cosmetic>
    {
        public void Save();
    }
}
