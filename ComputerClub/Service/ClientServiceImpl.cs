using System.Collections.Generic;
using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Service
{
    public class ClientServiceImpl : IClientService
    {
        private ClientRepositoryImpl _clientRepository;

        public ClientServiceImpl()
        {
            _clientRepository = new ClientRepositoryImpl();
        }

        public void Create(Client client)
        {
            _clientRepository.Create(client);
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }

        public List<Client> FindClientsByLoginOrPhone(string text)
        {
            return _clientRepository.FindClientsByLoginOrPhone(text);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void Update(int id, Client client)
        {
            _clientRepository.Update(id, client);
        }
    }
}
