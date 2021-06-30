using MyPharmacy.PL.UserMenu.Impl;

namespace UserConsole.User
{

    class UserProgram
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.ShowMainMenu();
        }
    }
}
