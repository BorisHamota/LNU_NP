using MyPharmacy.DAL.Factories.Abstract;
using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.DAL.Repositories.Impl.MemoryImpl;

namespace MyPharmacy.DAL.Factories.Impl.MemoryImpl
{
    public class MemoryFactory : IFactory
    {
        public ICartRepositoty GetCartRepository()
        {
            return new CartRepository();
        }

        public ICosmeticRepository GetCosmeticRepository()
        {
            return new CosmeticRepository();
        }

        public IMedicineRepository GetMedicineRepository()
        {
            return new MedicineRepository();
        }
    }
}
