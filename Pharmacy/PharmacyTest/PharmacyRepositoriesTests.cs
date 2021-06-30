using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Impl.FileImpl;
using MyPharmacy.DAL.Repositories.Impl.MemoryImpl;

namespace PharmacyTest
{
    [TestClass]
    public class PharmacyRepositoriesTests
    {
        [TestMethod]
        public void TestGetByIdCosmeticEntity()
        {
            //arrange
            CosmeticFileRepository repos = new CosmeticFileRepository();
            //64350,14.03.2025,Caudalie,1,20,345
            Cosmetic expectedEntitty = (new Cosmetic()
            {
                Id = 64350,
                name = "Caudalie",
                amount = 345,
                capacity = 20,
                expirationDate = "14.03.2025",
                storageTemperature = 1
            });
            //act
            var actualEntity = repos.GetById(64350);
            //assert
            Assert.AreEqual(expectedEntitty, actualEntity);
        }
        [TestMethod]
        public void TestConvertToCosmetic()
        {
            //arrange
            CosmeticFileRepository repos = new CosmeticFileRepository();
            //64350,14.03.2025,Caudalie,1,20,345
            Cosmetic expectedEntitty = (new Cosmetic()
            {
                Id = 64350,
                name = "Caudalie",
                amount = 345,
                capacity = 20,
                expirationDate = "14.03.2025",
                storageTemperature = 1
            });
            //actint Id, string expirationDate, string name, int storageTemperature, int capacity, int amount
            string[] arr = { "64350", "14.03.2025", "Caudalie", "1", "20", "345" };
            var actualEntity = repos.ConvertToObject(arr);
            //assert
            Assert.AreEqual(expectedEntitty, actualEntity);
        }
        [TestMethod]
        public void TestIsFlyweightExist()
        {
            //arrange
            CartFileRepository repos = new CartFileRepository();
            bool expectedState1 = true, expectedState2 = false;
            //act
            Flyweight entity = new Flyweight(new CartEntity(12345, "Exist"), 10);
            repos.entities.Add(entity);
            //assert
            Assert.AreEqual(repos.IsProductExist(entity), expectedState1);
            Assert.AreEqual(repos.IsProductExist(new Flyweight(new CartEntity(54321, "NotExist"), 10)), expectedState2);
            repos.DeleteAll();
        }
        [TestMethod]
        public void TestMemoryCosmeticRepositoryDeleteTable()
        {
            //arrange
            int expectedNumber = 3;
            //act
            CosmeticRepository repos = new CosmeticRepository();
            repos.Delete(13356);
            var actualNumber = repos.entities.Count;
            //assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }
    }
}
