using System;
using System.Collections.Generic;
using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Service
{
    public class HallServiceImpl : IHallService
    {
        private HallRepositoryImpl _hallRepository;

        public HallServiceImpl() 
        {
            _hallRepository = new HallRepositoryImpl();
        }

        public void Create(Hall hall)
        {
            _hallRepository.Create(hall);
        }

        public void Delete(int id)
        {
            _hallRepository.Delete(id);
        }

        public int FindCountComputerById(int id)
        {
            return _hallRepository.FindCountComputerById(id);
        }

        public int FindHallIdByName(string name)
        {
            return _hallRepository.FindHallIdByName(name);
        }

        public int FindMaxCountComputerById(int id)
        {
            return _hallRepository.FindMaxCountComputerById(id);
        }

        public List<Hall> GetAll()
        {
            return _hallRepository.GetAll();
        }

        public Hall GetById(int id)
        {
            return _hallRepository.GetById(id);
        }

        public void Update(int id, Hall hall)
        {
            _hallRepository.Update(id, hall);
        }
    }
}
