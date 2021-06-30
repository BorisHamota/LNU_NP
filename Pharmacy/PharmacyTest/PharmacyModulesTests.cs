using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPharmacy.DAL.Modules.Impl;

namespace PharmacyTest
{
    [TestClass]
    public class PharmacyModulesTests
    {
        [TestMethod]
        public void TestMedicineToString()
        {
            //arrange
            Medicine expectedEntity = new Medicine()
            {
                Id = 36544,
                name = "Ciprofloxacin",
                amount = 3,
                expirationDate = "30.03.2150",
                storageTemperature = 12
            };
            string expectedString = "36544 | 30.03.2150 | Ciprofloxacin | 12 | 3";
            //act
            var artualString = expectedEntity.ToString();
            //assert
            Assert.AreEqual(expectedString, artualString);
        }

        [TestMethod]
        public void TestFlyweightToString()
        {
            //arrange
            Flyweight expectedEntity = new Flyweight(
            new CartEntity()
            {
                Id = 12345,
                name = "erge"
            },
            amount: 3);
            string expectedString = "12345 | erge | 3";
            //act
            var artualString = expectedEntity.ToString();
            //assert
            Assert.AreEqual(expectedString, artualString);
        }
    }
}
