using MyPharmacy.DAL.Repositories.Abstract;

namespace MyPharmacy.DAL.Factories.Abstract
{
    public interface IFactory
    {
        ICartRepositoty GetCartRepository();
        ICosmeticRepository GetCosmeticRepository();
        IMedicineRepository GetMedicineRepository();
    }
}
