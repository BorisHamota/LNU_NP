using MyPharmacy.DAL.Factories.Impl;
using MyPharmacy.DAL.Modules.Impl;
using MyPharmacy.DAL.Repositories;
using MyPharmacy.DAL.Repositories.Abstract;
using MyPharmacy.PL.UserMenu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPharmacy.PL.UserMenu.Impl
{
    public class CosmeticMenu : BaseMenu<ICosmeticRepository, Cosmetic>, ICosmeticMenu
    {
        public CosmeticMenu()
        {
            FactoryProvider prov = new FactoryProvider();
            cosRepos = prov.GetFactory().GetCosmeticRepository();
            cart = prov.GetFactory().GetCartRepository();
            //cart.
            //cart = new CartFileRepository();
            factory = new FlyweightFactory();
        }
        ICartRepositoty cart;
        ICosmeticRepository cosRepos;
        FlyweightFactory factory;
        public void ShowTableMenu()
        {
            products = cosRepos.GetAll() ?? new List<Cosmetic>();
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
                            PrintTableForm();
                            break;
                        }
                    case TableMenuCommands.Down:
                        {
                            MoveCursorByProductId(1);
                            PrintTableForm();
                            break;
                        }
                    case TableMenuCommands.SelectCurrentProduct:
                        {
                            ShowProductMenu(this.currentId);
                            PrintTableForm();
                            break;
                        }
                    case TableMenuCommands.SortTableById:
                        {
                            SortTable();
                            PrintTableForm();
                            break;
                        }
                    case TableMenuCommands.OrderCurrentProduct:
                        {
                            OrderProduct();
                            PrintTableForm();
                            break;
                        }
                    case TableMenuCommands.TableOpenCard:
                        {
                            OpenCard();
                            PrintTableForm();
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
            } while (catcher != TableMenuCommands.TableMenuBack);
        }
        public void PrintTable()
        {
            Console.WriteLine("\nID | expirationDate | Name | storageFormType | Capacity | Amount\n");
            foreach (var it in products)
            {
                Cosmetic p = it;
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
                $"\t\t\t Cosmetic Table \t\t\t \n\n" +
                $"{(int)TableMenuCommands.TableMenuBack} : Back |" +
                $"{(int)TableMenuCommands.Up}" + $" : Up |" +
                $"{(int)TableMenuCommands.Down} : Down |" +
                $"{(int)TableMenuCommands.SelectCurrentProduct} : Select Current Product \n" +
                $"{(int)TableMenuCommands.SortTableById}: Sort Table By Id | " +
                $"{(int)TableMenuCommands.OrderCurrentProduct} : Order current product | " +
                $"{(int)TableMenuCommands.TableOpenCard} : Table open card"
                );
            SetState(TableMenuCommands.TableMenuWaiting);
            PrintTable();
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
                            PrintProductForm();
                            break;
                        }
                    case ProductMenuCommands.ProductFieldDown:
                        {
                            if (currentProductFieldId != 5) { currentProductFieldId++; }
                            PrintProductForm();
                            break;
                        }
                    case ProductMenuCommands.ChangeCurrentField:
                        {
                            //
                            Console.WriteLine("Change this field ? | 1 : Yes | 0 : No");
                            if (Console.ReadKey().KeyChar == '1')
                            {
                                cosRepos.Update(ChangeCurrentFieldById(currentProductFieldId));
                                products = cosRepos.GetAll();
                            }
                            //
                            currentProductFieldId = 1;
                            PrintProductForm();
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
            } while (command != ProductMenuCommands.ProductMenuBack);
        }
        public void PrintProduct()
        {
            products = cosRepos.GetAll();
            Cosmetic product = new Cosmetic();
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
            Console.WriteLine($"Capacity : {product.capacity}");

            if (currentProductFieldId == 5) { Console.Write(" ->  "); }
            Console.WriteLine($"Amount : {product.amount}\n\n");
        }
        public void PrintProductForm()
        {
            Console.Clear();
            Console.WriteLine
                (
                $"\t\t\t Cosmetic Product \t\t\t \n\n" +
                $"{(int)ProductMenuCommands.ProductMenuBack} : Back | " +
                $"{(int)ProductMenuCommands.ProductFieldUp} : Move Up | " +
                $"{(int)ProductMenuCommands.ProductFieldDown} : Move Down | " +
                $"{(int)ProductMenuCommands.ChangeCurrentField}  : ChangeCurrentField"
                );
            SetState(ProductMenuCommands.ProductMenuWaiting);
            PrintProduct();
        }
        public void CreateNewProductForm()
        {
            Cosmetic product = new Cosmetic();
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

            Console.Write("Capacity (Example : 44) ");
            k = int.Parse(Console.ReadLine());
            product.capacity = k;
            Console.WriteLine();

            Console.Write("Amount (Example : 44) : ");
            k = int.Parse(Console.ReadLine());
            product.amount = k;
            Console.WriteLine();

            cosRepos.Create(product);
            products = cosRepos.GetAll();
        }
        public Cosmetic ChangeCurrentFieldById(int Id)
        {
            Cosmetic product = cosRepos.GetById(currentId);
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
                        product.capacity = Convert.ToInt32(CreateNewInt());
                        break;
                    }
                case 5:
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

        public void OrderProduct()
        {
            Console.WriteLine("\n\nChoose amount: ");
            int amount = int.Parse(Console.ReadLine());
            CartEntity cartProduct = TakeAmountFromCurrentProduct(amount);

            cart.Save();//

            if (cart.IsProductExist(factory.GetCartFlyweight(cartProduct, amount)))///////////////////////////////////
            {
                factory.GetCartFlyweight(cartProduct, amount).amount += amount;/////
                cart.Update(factory.GetCartFlyweight(cartProduct, amount));
            }
            else if ((factory.GetCartFlyweight(cartProduct, amount)).amount == 0)
            {
                factory.GetCartFlyweight(cartProduct, amount).amount += amount;
                cart.Create(factory.GetCartFlyweight(cartProduct, amount));
            }
            else
            {
                cart.Create(factory.GetCartFlyweight(cartProduct, amount));
            }

            Console.WriteLine("\nProduct successfully added to cart!\n" +
                "1 : Back to table | 2 : Open cart"
                );
            bool w = true;
            while (w)
            {
                int k = ((int)Console.ReadKey().KeyChar) - 48;
                if (k == 1)
                {
                    w = false;
                }
                else if (k == 2)
                {
                    PrintTableForm();
                    OpenCard();
                    w = false;
                }
            }

        }

        public void OpenCard()
        {
            bool w = true;
            while (w)
            {
                PrintTableForm();
                Console.WriteLine("\t\t\tMy Cart\n" +
                    "Product Id | Name | Amount\n\n"
                    );
                if (cart.GetAll() == null)
                {
                    Console.WriteLine("\tCart is emply!\n" +
                        "1 : Back"
                        );
                }
                else
                {
                    bool empty = false;
                    foreach (var it in cart.GetAll()/*entities*/)
                    {
                        if (it.amount != 0)
                        {
                            empty = true;
                            Console.WriteLine(it.ToString());
                        }
                    }
                    if (empty)
                    {
                        Console.WriteLine("\n\n1 : Back | 2 : Clear cart");
                    }
                    else
                    {
                        Console.WriteLine("\tCart is emply\n" +
                            "1 : Back"
                            );
                    }
                }
                int g = ((int)(Console.ReadKey().KeyChar)) - 48;
                if (g == 1)
                {
                    w = false;
                }
                else if (g == 2)
                {
                    foreach (var it in cart.GetAll()/*entities*/)
                    {
                        ReturnProductAmount(it.Id, it.name, it.amount);
                        //
                        CartEntity c = new CartEntity();
                        c.Id = it.Id;
                        c.name = it.name;
                        factory.GetCartFlyweight(c, 0).amount = 0;
                    }
                    ////clear
                    cart.DeleteAll();
                    PrintTableForm();
                    w = false;
                }
            }
        }

        public CartEntity TakeAmountFromCurrentProduct(int amount)
        {
            CartEntity p = new CartEntity();
            products = cosRepos.GetAll();
            foreach (var it in products)
            {
                if (it.Id == currentId)
                {
                    p.Id = it.Id;
                    p.name = it.name;
                    it.amount = it.amount - amount;
                }
            }
            return p;
        }

        public void ReturnProductAmount(int id, string name, int amount)
        {
            products = cosRepos.GetAll();
            foreach (var it in products)
            {
                if (it.Id == id)
                {
                    it.amount += amount;
                }
            }
        }

    }
}

