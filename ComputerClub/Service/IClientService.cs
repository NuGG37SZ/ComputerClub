using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Service
{
    public interface IClientService
    {
        List<Client> GetAll();

        Client GetById(int id);

        void Create(Client client);

        void Update(int id, Client client);

        void Delete(int id);

        List<Client> FindClientsByLoginOrPhone(string text);

        Client GetClientByLogin(string login);
    }
}
