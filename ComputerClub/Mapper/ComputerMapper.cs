using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Mapper
{
    public class ComputerMapper
    {
        private static HallRepositoryImpl _repository = new HallRepositoryImpl();

        public static ComputerDisplay MapComputerToComputerDisplay(Computer computer)
        {
            ComputerDisplay computerDisplay = new ComputerDisplay();
            computerDisplay.Id = computer.Id;
            computerDisplay.HallName = _repository.GetById(computer.HallId).Name;
            computerDisplay.PricePerHour = _repository.GetById(computer.HallId).PricePerHour;
            computerDisplay.IsBusy = computer.IsBusy;
            return computerDisplay;
        }
    }
}
