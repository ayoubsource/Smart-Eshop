using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyEshop.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LasttName { get; set; }
        public DateTime BirthDay { get; set; }
        public Account Account { get; set; }
    }
}
