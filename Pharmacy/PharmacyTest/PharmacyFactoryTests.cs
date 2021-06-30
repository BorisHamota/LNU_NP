using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPharmacy.DAL.Factories.Impl;
using MyPharmacy.DAL.Factories.Impl.FileImpl;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories;

namespace PharmacyTest
{
    [TestClass]
    public class PharmacyFactoryTests
    {
        [TestMethod]
        public void TestFactoryProviderGetFactory()
        {
            //arrange
            FileFactory expectedFacory = new FileFactory();
            string expectedString = expectedFacory.GetType().Name;
            //act
            FactoryProvider prov = new FactoryProvider();
            var actualFactory = prov.GetFactory();
            var actualString = actualFactory.GetType().Name;
            //assert
            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void TestFactoryCartFlyweight()
        {
            //arrange
            CartEntity expectedEntity = new CartEntity()
            {
                Id = 22222,
                name = "name"
            };
            //act
            FlyweightFactory factory = new FlyweightFactory();
            var result1 = factory.flyweightsArr.Exists(r => r.Id == expectedEntity.Id);
            factory.GetCartFlyweight(expectedEntity,2);
            var result2 = factory.flyweightsArr.Exists(r => r.Id == expectedEntity.Id);
            //assert
            Assert.IsFalse(result1);
            Assert.IsTrue(result2);
        }
        //GetCartFlyweight
    }
}
