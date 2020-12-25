using System;
using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models.Data
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public DateTime BirthDay { get; set; }
        public Account Account { get; set; }
    }
}
