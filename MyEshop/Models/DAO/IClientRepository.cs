using System;
using System.Collections.Generic;
using MyEshop.Models.Entities;

namespace MyEshop.Models.DAO
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients();
        Client GetClient(int id);
        void Register(Client client);
        void Update(Client oldClientInfo, Client newClientInfo);
        void Delete(Client client);
    }

    public class ClientManager : IClientRepository
    {
        private readonly SmartEshopDbContext _smartEshopDbContext;

        public ClientManager()
        {

        }
        public ClientManager(SmartEshopDbContext smartEshopDbContext)
        {
            this._smartEshopDbContext = smartEshopDbContext;
        }
        public IEnumerable<Client> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public Client GetClient(int id)
        {
            throw new NotImplementedException();
        }

        public void Register(Client client)
        {
            _smartEshopDbContext.Client.Add(client);
            _smartEshopDbContext.SaveChanges();
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
