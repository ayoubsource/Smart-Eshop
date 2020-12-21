using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyEshop.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int amount { get; set; }
    }
}
