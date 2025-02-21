using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Service
{
    internal interface IComputerService
    {
        List<Computer> GetAll();

        Computer GetById(int id);

        void Create(Computer computer);

        void Update(int id, Computer computer);

        void Delete(int id);

        List<ComputerDisplay> FindComputerByBusyAndRoom(string text);

        List<int> FindAllIdByHallsId(int hallId);
    }
}
