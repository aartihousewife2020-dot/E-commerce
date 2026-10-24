namespace E_commerce
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public bool InStock => Stock > 0;

        public decimal LineTotal(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity));
            }

            return Price * quantity;
        }
    }
}
