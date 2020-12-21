using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyEshop.Models
{
    public class Product 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UrlImgProd { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string ShortDescription { get; set; }
        [Required]

        public string LongDescription { get; set; }

        [Required]

        public int Price { get; set; }

        private Category _categorie;



        public Product(int id, string urlImgProd, string name, string shortDescription, string longDescription,int price)
        {
            Id = id;
            UrlImgProd = urlImgProd;
            Name = name;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            Price = price;

        }
        public Product()
        {

        }
        public void GetAllProducts(List<Product> _listProducts)
        {
            foreach (var p in _listProducts)
            {
                Console.WriteLine(p.UrlImgProd);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.ShortDescription);
                Console.WriteLine(p.LongDescription);
                Console.WriteLine(p.Price);
            }
        }

       
    }
}
