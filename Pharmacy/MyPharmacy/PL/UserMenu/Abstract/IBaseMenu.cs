namespace MyPharmacy.PL.UserMenu.Abstract
{
    public interface IBaseMenu
    {
        public void CheckProductString(string str);
        public void CheckProductDate(string str);
        public void CheckProductInt(string str);
        public string CreateNewDate();
        public string CreateNewString();
        public string CreateNewInt();
    }
}
