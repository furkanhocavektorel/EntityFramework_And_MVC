namespace Mvc.Models.dtos
{
    public class NewProductRequest
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public short Stock { get; set; }
        public int CategoryId { get; set; }
        public bool Discontinued { get; set; }
    }
}
