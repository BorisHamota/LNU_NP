using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.DAL.Modules.Impl;


namespace MyPharmacy.DAL.Repositories.Impl.MemoryImpl
{
    public class CosmeticRepository : BaseRepository<Cosmetic>, ICosmeticRepository
    {
        public CosmeticRepository()//-----
        {
            this.entities = InitialDataLoader.InitializeCosmeticRepository();
        }//

        public void Save()
        {

        }
    }
}
