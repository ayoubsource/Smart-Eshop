using System;
using System.ComponentModel.DataAnnotations;

namespace MyEshop.Models.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public DateTime BirthDay { get; set; }
        public Account Account { get; set; }

        public Client(string firstName, string lasttName, DateTime birthDay)
        {
            FirstName = firstName;
            LasttName = lasttName;
            BirthDay = birthDay;
        }
    }
}
