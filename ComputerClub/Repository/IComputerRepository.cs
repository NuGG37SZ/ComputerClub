using System.Collections.Generic;
using ComputerClub.Entity;

namespace ComputerClub.Repository
{
    public interface IComputerRepository : ICRUDRepository<Computer>
    {
        List<ComputerDisplay> FindComputerByBusyAndRoom(string text);

        List<int> FindAllIdByHallsId(int hallId);

        int GetPricePerHouseByComputerId(int id);
    }
}
