using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEshop.Models.Data
{
    public class Account 
    {
        public  int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public  string Compte { get; set; }

    }
}
