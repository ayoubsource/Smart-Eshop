using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Models.Entities;

namespace MyEshop.ModelsViews
{
    public class Registration
    {
        public Client Client { get; set; }
        public  Account Account { get; set; }

        public Registration(Client client, Account account)
        {
            this.Client = client;
            Account = account;
        }
    }
}
