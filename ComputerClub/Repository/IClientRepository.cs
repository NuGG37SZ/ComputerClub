using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Repository
{
    public interface IClientRepository : ICRUDRepository<Client>
    {
        List<Client> FindClientsByLoginOrPhone(string text);
    }
}
