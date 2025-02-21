using System.Collections.Generic;
using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Service
{
    internal class SessionServiceImpl : ISessionService
    {
        private SessionRepositoryImpl _sessionRepository;

        public SessionServiceImpl()
        {
            _sessionRepository = new SessionRepositoryImpl();
        }

        public void Create(Session session)
        {
            _sessionRepository.Create(session);
        }

        public void Delete(int id)
        {
            _sessionRepository.Delete(id);
        }

        public List<Session> GetAll()
        {
            return _sessionRepository.GetAll();
        }

        public Session GetById(int id)
        {
            return _sessionRepository.GetById(id);
        }

        public void Update(int id, Session session)
        {
            _sessionRepository.Update(id, session);
        }
    }
}
