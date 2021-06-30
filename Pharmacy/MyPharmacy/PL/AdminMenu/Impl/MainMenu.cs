using MyPharmacy.PL.AdminMenu.Abstract;
using System;

namespace MyPharmacy.PL.AdminMenu.Impl
{
    public class MainMenu : IMainMenu
    {
        public MainMenu()
        {
            m = new MedicineMenu();
            c = new CosmeticMenu();
        }
        public enum MainMenuCommands
        {
            Quit,
            ShowMedicinesTable,
            ShowCosmeticsTable,
            MainMenuWaiting,
        };
        private MainMenuCommands mState;
        private MedicineMenu m;
        private CosmeticMenu c;
        public void SetState(MainMenuCommands state)
        {
            this.mState = state;
        }
        public void ShowMainMenu()
        {
            PrintMenuForm();
            MainMenuCommands command;
            do
            {
                command = (MainMenuCommands)((int)(Console.ReadKey(true).KeyChar) - 48);
                switch (command)
                {
                    case MainMenuCommands.ShowMedicinesTable:
                        {
                            m.ShowTableMenu();
                            break;
                        }
                    case MainMenuCommands.ShowCosmeticsTable:
                        {
                            c.ShowTableMenu();
                            break;
                        }
                    case MainMenuCommands.Quit:
                        {
                            Console.WriteLine("Quit Pharmacy? | 1 : Yes | 0 : No");
                            if (Console.ReadKey(true).KeyChar == '1')
                            {
                                command = MainMenuCommands.Quit;
                                break;
                            }
                            else
                            {
                                command = MainMenuCommands.MainMenuWaiting;
                            }
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
                PrintMenuForm();
            } while (command != MainMenuCommands.Quit);
            Console.Clear();
            PrintPharmacyGetWellSoon();
        }
        public void PrintPharmacyWellcome()
        {
            Console.WriteLine(@"
______________________________________________________



		Pharmacy +	 Admin


______________________________________________________

			");
        }
        public void PrintPharmacyGetWellSoon()
        {
            Console.WriteLine(@"
______________________________________________________



		GetWellSoon	  Admin


______________________________________________________

			");
        }
        public void PrintMenuForm()
        {
            Console.Clear();
            Console.WriteLine($"{(int)MainMenuCommands.Quit } : Quit | " +
                $"{(int)MainMenuCommands.ShowMedicinesTable} : Choose Medicines Table | " +
                $"{(int)MainMenuCommands.ShowCosmeticsTable} : Choose Cosmetics Table");
            PrintPharmacyWellcome();
            SetState(MainMenuCommands.MainMenuWaiting);
        }
    }
}