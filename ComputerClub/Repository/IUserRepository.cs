using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();

        void Create(User user); 

        void Delete(int id);

        User GetUserByLogin(string login);
    }
}
