using MyPharmacy.PL.AdminMenu.Impl;

namespace AdminConsole.Admin
{
    class AdminProgram
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.ShowMainMenu();
        }
    }

}
