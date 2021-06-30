using MyPharmacy.DAL.Modules.Abstract;

namespace MyPharmacy.DAL.Modules.Impl
{
    public class CartEntity : IEntity
    {
        public CartEntity() { }
        public CartEntity(int Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }
        public int Id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return $"{Id} | {name}";
        }

        public override bool Equals(object obj)
        {
            var other = obj as Flyweight;
            return this.Id == other?.Id
                && this.name == other.name
                ;
        }
    }
}
