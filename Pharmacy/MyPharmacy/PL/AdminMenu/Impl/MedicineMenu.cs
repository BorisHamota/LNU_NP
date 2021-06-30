using MyPharmacy.DAL.Factories.Impl;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.PL.AdminMenu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPharmacy.PL.AdminMenu.Impl
{
    public class MedicineMenu : BaseMenu<IMedicineRepository, Medicine>, IMedicineMenu
    {
        public MedicineMenu()
        {
            FactoryProvider prov = new FactoryProvider();
            medRepos = prov.GetFactory().GetMedicineRepository();

        }
        IMedicineRepository medRepos;
        public void ShowTableMenu()
        {
            products = medRepos.GetAll() ?? new List<Medicine>();
            if (products.Count() != 0)
            {
                this.currentId = products[0].Id;
            }
            PrintTableForm();
            TableMenuCommands catcher;
            do
            {
                catcher = (TableMenuCommands)((int)(Console.ReadKey(true).KeyChar) - 48);
                switch (catcher)
                {
                    case TableMenuCommands.Up:
                        {
                            MoveCursorByProductId(-1);
                            break;
                        }
                    case TableMenuCommands.Down:
                        {
                            MoveCursorByProductId(1);
                            break;
                        }
                    case TableMenuCommands.SelectCurrentProduct:
                        {
                            ShowProductMenu(this.currentId);
                            break;
                        }
                    case TableMenuCommands.SortTableById:
                        {
                            SortTable();
                            break;
                        }
                    case TableMenuCommands.CreateNewProduct:
                        {
                            CreateNewProduct();
                            break;
                        }
                    case TableMenuCommands.DeleteCurrentProduct:
                        {
                            DeleteCurrentProduct();
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
                PrintTableForm();
            } while (catcher != TableMenuCommands.TableMenuBack);
        }
        public void PrintTable()
        {
            Console.WriteLine("\nID | Expiration Date | Name | Storage Temperature | Amount\n");
            foreach (var it in products)
            {
                Medicine p = it;
                if (p.Id == this.currentId)
                {
                    Console.Write(" ->  ");
                }
                Console.WriteLine(it.ToString());
            }
            Console.WriteLine("\n\n");
        }
        public void PrintTableForm()
        {
            Console.Clear();
            Console.WriteLine(
                $"\t\t\t Medicine Table \t\t\t \n\n" +
                $"{(int)TableMenuCommands.TableMenuBack} : Back | " +
                $"{(int)TableMenuCommands.Up}" + $" : Up | " +
                $"{(int)TableMenuCommands.Down} : Down | " +
                $"{(int)TableMenuCommands.SelectCurrentProduct} : Select Current Product \n" +
                $"{(int)TableMenuCommands.SortTableById}: Sort Table By Id | " +
                $"{(int)TableMenuCommands.CreateNewProduct} : Create new product | " +
                $"{(int)TableMenuCommands.DeleteCurrentProduct}  : Delete current product"
                );
            SetState(TableMenuCommands.TableMenuWaiting);
            PrintTable();
        }
        public void CreateNewProduct()
        {
            Console.WriteLine("Create new product? | 1 : Yes | 0 : No");
            if (Console.ReadKey().KeyChar == '1')
            {

                CreateNewProductForm();
                currentId = products[0].Id;
            }
        }
        public void DeleteCurrentProduct()
        {
            Console.WriteLine("Delete current product? | 1 : Yes | 0 : No");
            if (Console.ReadKey().KeyChar == '1')
            {
                medRepos.Delete(currentId);
                products = medRepos.GetAll();
                currentId = products[0].Id;
            }
        }
        public void SortTable()
        {
            Console.Clear();
            if (products[0].Id > products[1].Id)
            {
                products.Sort((x, y) => x.Id.CompareTo(y.Id));
            }
            else
            {
                products.Sort((y, x) => x.Id.CompareTo(y.Id));
            }
        }
        public void MoveCursorByProductId(int n)
        {
            if (n == 1)
            {
                if (currentId == products[products.Count - 1].Id)
                {
                    return;
                }
            }
            else
            {
                if (currentId == products[0].Id)
                {
                    return;
                }
            }
            int i = 0;
            while (products[i].Id != currentId)
            {
                i++;
            }
            currentId = products[i + n].Id;
        }

        public void ShowProductMenu(int Id)
        {
            this.currentId = Id;
            PrintProductForm();
            ProductMenuCommands command;
            do
            {
                command = (ProductMenuCommands)((int)(Console.ReadKey(true).KeyChar) - 48);
                switch (command)
                {
                    case ProductMenuCommands.ProductFieldUp:
                        {
                            if (currentProductFieldId != 1) { currentProductFieldId--; }
                            break;
                        }
                    case ProductMenuCommands.ProductFieldDown:
                        {
                            if (currentProductFieldId != 4) { currentProductFieldId++; }
                            break;
                        }
                    case ProductMenuCommands.ChangeCurrentField:
                        {
                            //
                            Console.WriteLine("Change this field ? | 1 : Yes | 0 : No");
                            if (Console.ReadKey().KeyChar == '1')
                            {
                                medRepos.Update(ChangeCurrentFieldById(currentProductFieldId));
                                products = medRepos.GetAll();
                            }
                            //
                            currentProductFieldId = 1;
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
                PrintProductForm();
            } while (command != ProductMenuCommands.ProductMenuBack);
        }
        public void PrintProduct()
        {
            products = medRepos.GetAll();
            Medicine product = new Medicine();
            foreach (var it in products)
            {
                if (it.Id == currentId)
                {
                    product = it;
                }
            }
            Console.WriteLine($"\nId : { product.Id}\n");

            if (currentProductFieldId == 1) { Console.Write(" ->  "); }
            Console.WriteLine($"Expiration Date : {product.expirationDate}");

            if (currentProductFieldId == 2) { Console.Write(" ->  "); }
            Console.WriteLine($"Name :  {product.name}");

            if (currentProductFieldId == 3) { Console.Write(" ->  "); }
            Console.WriteLine($"Storage Form Type : {product.storageTemperature}");

            if (currentProductFieldId == 4) { Console.Write(" ->  "); }
            Console.WriteLine($"Amount : {product.amount}\n\n");
        }
        public void PrintProductForm()
        {
            Console.Clear();
            Console.WriteLine
                (
                $"\t\t\t Medicine Product \t\t\t \n\n" +
                $"{(int)ProductMenuCommands.ProductMenuBack} : Back | " +
                $"{(int)ProductMenuCommands.ProductFieldUp} : Move Up | " +
                $"{(int)ProductMenuCommands.ProductFieldDown} : Move Down | " +
                $"{(int)ProductMenuCommands.ChangeCurrentField} : ChangeCurrentField "
                );
            SetState(ProductMenuCommands.ProductMenuWaiting);
            PrintProduct();
        }
        public void CreateNewProductForm()
        {
            Medicine product = new Medicine();
            string str; int k;

            Console.Write("Id (Example : 99999) : ");
            k = int.Parse(Console.ReadLine());
            product.Id = k;
            Console.WriteLine();

            Console.Write("Expiration Date (Example : 12.12.2012) : ");
            str = Console.ReadLine();
            product.expirationDate = str;
            Console.WriteLine();

            Console.Write("Name (Example : Kfehjvre) : ");
            str = Console.ReadLine();
            product.name = str;
            Console.WriteLine();

            Console.Write("Storage Temperature (Example : 23) : ");
            k = int.Parse(Console.ReadLine());
            product.storageTemperature = k;
            Console.WriteLine();

            Console.Write("Amount (Example : 44) : ");
            k = int.Parse(Console.ReadLine());
            product.amount = k;
            Console.WriteLine();

            medRepos.Create(product);
            products = medRepos.GetAll();
        }
        public Medicine ChangeCurrentFieldById(int Id)
        {
            Medicine product = medRepos.GetById(currentId);
            switch (Id)
            {
                case 1:
                    {
                        product.expirationDate = CreateNewDate();
                        break;
                    }
                case 2:
                    {
                        product.name = CreateNewString();
                        break;
                    }
                case 3:
                    {
                        product.storageTemperature = Convert.ToInt32(CreateNewInt());
                        break;
                    }
                case 4:
                    {
                        product.amount = Convert.ToInt32(CreateNewInt());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return product;
        }
    }
}

