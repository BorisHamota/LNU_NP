using MyPharmacy.DAL.Factories.Abstract;
using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.DAL.Repositories.Impl.FileImpl;

namespace MyPharmacy.DAL.Factories.Impl.FileImpl
{
    public class FileFactory : IFactory
    {
        public ICartRepositoty GetCartRepository()
        {
            return new CartFileRepository();
        }

        public ICosmeticRepository GetCosmeticRepository()
        {
            return new CosmeticFileRepository();
        }

        public IMedicineRepository GetMedicineRepository()
        {
            return new MedicineFileRepository();
        }
    }
}
