using System.Collections.Generic;
using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Service
{
    public class UserServiceImpl : IUserService
    {
        private IUserRepository _userRepository;

        public UserServiceImpl()
        {
            _userRepository = new UserRepositoryImpl();
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetUserByLogin(string login)
        {
            return _userRepository.GetUserByLogin(login);
        }
    }
}
