using MyPharmacy.DAL.Modules.Impl;

namespace MyPharmacy.DAL.Repositories.Abstract
{
    public interface IMedicineRepository : IBaseRepository<Medicine>
    {
        public void Save();
    }
}
