﻿using MyPharmacy.DAL.Modules.Impl;

namespace MyPharmacy.PL.AdminMenu.Abstract
{
    interface IMedicineMenu : IBaseMenu
    {
		public void ShowTableMenu();
		public void PrintTable();
		public void PrintTableForm();
		public void SortTable();
		public void MoveCursorByProductId(int n);
		public void CreateNewProductForm();
		public void ShowProductMenu(int Id);
		public void PrintProduct();
		public Medicine ChangeCurrentFieldById(int Id);

		public void DeleteCurrentProduct();
		public void CreateNewProduct();
	}
}
