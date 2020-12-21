using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyEshop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UrlImgCatego { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        List<Product> _listProducts = new List<Product>();
        public Category(string urlImgCatego, string name, string titre, string descrip)
        {
            UrlImgCatego = urlImgCatego;
            Name = name;
            Title = titre;
            Description = descrip;
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;

        }
    }
}
