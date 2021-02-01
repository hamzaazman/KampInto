namespace LinqProject
{
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantitiyPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
