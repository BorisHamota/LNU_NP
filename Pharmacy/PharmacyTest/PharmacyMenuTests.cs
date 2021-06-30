using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.PL.AdminMenu.Impl;
using System;
using static MyPharmacy.PL.AdminMenu.Impl.BaseMenu<MyPharmacy.DAL.Repositories.Abstract.IMedicineRepository, MyPharmacy.DAL.Modules.Impl.Medicine>;

namespace PharmacyTest
{
    [TestClass]
    public class PharmacyMenuTests
    {
        [TestMethod]
        public void TestCheckTableMenuSetState()
        {
            //arrange
            TableMenuCommands expectedState = TableMenuCommands.CreateNewProduct;
            //act
            BaseMenu<IMedicineRepository, Medicine> menu = new MedicineMenu();
            menu.SetState(BaseMenu<IMedicineRepository, Medicine>.TableMenuCommands.CreateNewProduct);//TableMenuCommands.CreateNewProduct
            var actualState = menu.tState;
            //assert
            Assert.AreEqual(expectedState, actualState);
        }
        [TestMethod]
        public void TestCheckProductDate()
        {
            //arrange
            //bool expectedState1 = true, expectedState2 = false;
            //act
            BaseMenu<IMedicineRepository, Medicine> menu = new MedicineMenu();
            bool actualState1, actualState2;
            try
            {
                menu.CheckProductDate("12.12.2020");
                actualState1 = true;
            }
            catch (Exception ex)
            {
                actualState1 = false;
            }
            try
            {
                menu.CheckProductDate("somedate");
                actualState2 = true;
            }
            catch (Exception ex)
            {
                actualState2 = false;
            }
            //assert
            Assert.IsTrue(actualState1);
            Assert.IsFalse(actualState2);
        }
        [TestMethod]
        public void TestCheckProductInt()
        {
            //arrange
            //bool expectedState1 = true, expectedState2 = false;
            //act
            BaseMenu<IMedicineRepository, Medicine> menu = new MedicineMenu();
            bool actualState1, actualState2;
            try
            {
                menu.CheckProductInt("123");
                actualState1 = true;
            }
            catch (Exception ex)
            {
                actualState1 = false;
            }
            try
            {
                menu.CheckProductInt("someint");
                actualState2 = true;
            }
            catch (Exception ex)
            {
                actualState2 = false;
            }
            //assert
            Assert.IsTrue(actualState1);
            Assert.IsFalse(actualState2);
        }
    }
}
