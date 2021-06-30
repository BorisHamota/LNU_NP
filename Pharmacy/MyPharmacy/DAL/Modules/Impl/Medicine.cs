using MyPharmacy.DAL.Modules.Abstract;

namespace MyPharmacy.DAL.Modules.Impl
{
    public class Medicine : IEntity
    {
        public Medicine() { }
        public Medicine(int Id, string expirationDate, string name, int storageTemperature, int amount)
        {
            this.Id = Id;
            this.name = name;
            this.expirationDate = expirationDate;
            this.amount = amount;
            this.storageTemperature = storageTemperature;
        }
        public int Id { get; set; }
        public string name { get; set; }
        public string expirationDate { get; set; }
        public int amount { get; set; }
        public int storageTemperature { get; set; }

        public override string ToString()
        {
            return $"{Id} | {expirationDate} | {name} | {storageTemperature} | {amount}";
        }

        public override bool Equals(object obj)
        {
            var other = obj as Medicine;
            return this.Id == other?.Id
                && this.name == other.name
                && this.storageTemperature == other.storageTemperature
                && this.expirationDate == other.expirationDate
                && this.amount == other.amount
                ;
        }
    }
}
