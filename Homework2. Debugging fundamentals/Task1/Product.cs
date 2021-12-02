namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }
        public override bool Equals(object obj)
        {
            var other = obj as Product;

            if (other == null)
                return false;

            if (Name != other.Name || Price != other.Price)
                return false;

            return true;
        }
    }
}
