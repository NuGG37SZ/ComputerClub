using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Service
{
    public interface IHallService
    {
        List<Hall> GetAll();
        
        Hall GetById(int id);

        void Create(Hall hall);

        void Update(int id, Hall hall);

        void Delete(int id);

        int FindMaxCountComputerById(int id);

        int FindHallIdByName(string name);

        int FindCountComputerById(int id);
    }
}
