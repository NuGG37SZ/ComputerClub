using ComputerClub.Entity;

namespace ComputerClub.Repository
{
    public interface IHallRepository : ICRUDRepository<Hall>
    {
        int FindHallIdByName(string name);

        int FindMaxCountComputerById(int id);

        int FindCountComputerById(int id);
    }
}
