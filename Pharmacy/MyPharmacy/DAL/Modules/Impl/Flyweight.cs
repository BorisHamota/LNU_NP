using MyPharmacy.DAL.Modules.Abstract;

namespace MyPharmacy.DAL.Modules.Impl
{
    public class Flyweight : IEntity
    {
		public int Id { get; set; }
		public string name { get; set; }
		public int amount { get; set; }

		public Flyweight(CartEntity flyw, int amount) 
		{
			this.amount = amount;
			this.Id = flyw.Id;
			this.name = flyw.name;
		}
		public Flyweight(Flyweight other)
        {
			this.Id = other.Id;
			this.amount = other.amount;
			this.name = other.name;
        }
		public override string ToString()
		{
			return $"{Id} | {name} | {amount}";
		}
		public override bool Equals(object obj)
		{
			var other = obj as Flyweight;
			return this.Id == other?.Id
				&& this.name == other.name
				&& this.amount == other.amount
				;
		}
	}
}
