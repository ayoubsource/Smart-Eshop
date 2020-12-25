using System.Collections.Generic;
using MyEshop.Models.Entities;

namespace MyEshop.Models.DAO
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client Get(int id);
        void Add(Client entity);
        void Update(Client dbEntity, Client entity);
        void Delete(Client entity);
    }
}
