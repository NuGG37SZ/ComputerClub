using ComputerClub.Entity;
using System.Collections.Generic;

namespace ComputerClub.Service
{
    public interface IUserService
    {
        List<User> GetAll();

        void Create(User user);

        void Delete(int id);

        User GetUserByLogin(string login);
    }
}
