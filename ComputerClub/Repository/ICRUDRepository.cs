using System.Collections.Generic;

namespace ComputerClub.Repository
{
    public interface ICRUDRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}
