using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string UrlImgCatego { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        private ICollection<Product> Products { get; set; }
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
