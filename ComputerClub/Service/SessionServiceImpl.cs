using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Service
{
    internal class SessionServiceImpl : ISessionService
    {
        private SessionRepositoryImpl _sessionRepository;

        private ClientRepositoryImpl _clientRepositoryImpl;

        private ComputerRepositoryImpl _computerRepositoryImpl;

        public SessionServiceImpl()
        {
            _sessionRepository = new SessionRepositoryImpl();
            _clientRepositoryImpl = new ClientRepositoryImpl();
            _computerRepositoryImpl = new ComputerRepositoryImpl();
        }

        public void Create(Session session)
        {
            Client client = _clientRepositoryImpl.GetById(session.ClientId);
            int pricePerHour = _computerRepositoryImpl.GetPricePerHouseByComputerId(
                session.ComputerId
            );
            int hourDifference = (session.EndPlay - session.StartPlay).Hours;
            int sessionAmount = (pricePerHour * hourDifference);
            int discount = Convert.ToInt32(Math.Round(sessionAmount * client.Discount));
            sessionAmount -= discount;
            if(client.Balance >= sessionAmount)
            {
                client.Balance -= sessionAmount;
            }
            _clientRepositoryImpl.Update(session.ClientId, client);

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

        public void CheckEndSession()
        {
            List<Session> sessions = _sessionRepository.GetAll();

            foreach (var session in sessions)
            {
                Computer currentComputer = _computerRepositoryImpl.GetById(session.ComputerId);
                
                if(currentComputer.IsBusy && session.EndPlay >= DateTime.Now) 
                {
                    currentComputer.IsBusy = false;
                    session.EndPlay = DateTime.MaxValue;
                }
            }
        }
    }
}
