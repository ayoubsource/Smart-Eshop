namespace MyEshop.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string UrlImgProd { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public double UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Product(int id, string urlImgProd, string name, string shortDescription, string longDescription, double unitPrice, int availableQuantity, int categorId)
        {
            Id = id;
            UrlImgProd = urlImgProd;
            Name = name;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            UnitPrice = unitPrice;
            AvailableQuantity = availableQuantity;
            CategoryId = categorId;
        }


        public Product()
        {

        }
    }
}
