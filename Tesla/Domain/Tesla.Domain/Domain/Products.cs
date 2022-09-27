namespace Tesla.Domain.Domain
{
    public class Products
    {
        public int Id { get; set; }
        public Categories CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int StockReserved { get; set; }
        public string Photo { get; set; }
        public string Descroption { get; set; }
        public int Sales { get; set; }
    }
}
