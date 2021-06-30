using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.DAL.Modules.Impl;

namespace MyPharmacy.DAL.Repositories.Impl.MemoryImpl
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        public MedicineRepository()
        {
            this.entities = InitialDataLoader.InitializeMedicineRepository();
        }

        public void Save()
        {
            
        }
    }
}
