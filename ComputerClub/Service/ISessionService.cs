using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Service
{
    public interface ISessionService 
    {
        List<Session> GetAll();

        Session GetById(int id);

        void Create(Session session);

        void Update(int id, Session session);

        void Delete(int id);
    }
}
