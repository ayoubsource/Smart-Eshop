using System;
using System.Collections.Generic;
using MyEshop.Models.Entities;

namespace MyEshop.Models.DAO
{
    public class ClientManager : IClientRepository
    {
        private readonly SmartEshopDbContext smartEshopDbContext;

        public ClientManager()
        {
            
        }
        public ClientManager(SmartEshopDbContext smartEshopDbContext)
        {
            this.smartEshopDbContext = smartEshopDbContext;
        }
        public IEnumerable<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Client client)
        {
            smartEshopDbContext.Client.Add(client);
            smartEshopDbContext.SaveChanges();
        }

        public void Update(Client dbEntity, Client entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
