using System.Collections.Generic;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Repository;

namespace ComputerClub.Service
{
    public class ComputerServiceImpl : IComputerService
    {
        private IComputerRepository _computerRepository;

        private IHallRepository _hallRepository;
        
        public ComputerServiceImpl()
        {
            _computerRepository = new ComputerRepositoryImpl();
            _hallRepository = new HallRepositoryImpl();
        }

        public void Create(Computer computer)
        {
            int maxCountComputer = _hallRepository.FindMaxCountComputerById(computer.HallId);
            int currentCountComputerOnHall = _hallRepository.FindCountComputerById(computer.HallId);

            if (currentCountComputerOnHall < maxCountComputer)
                _computerRepository.Create(computer);
            else
                MessageBox.Show("Зал полностью заполнен!!!", "ERROR");
        }

        public void Delete(int id)
        {
            _computerRepository.Delete(id);
        }

        public List<int> FindAllIdByHallsId(int hallId)
        {
            return _computerRepository.FindAllIdByHallsId(hallId);
        }

        public List<ComputerDisplay> FindComputerByBusyAndRoom(string text)
        {
            return _computerRepository.FindComputerByBusyAndRoom(text);
        }

        public List<Computer> GetAll()
        {
            return _computerRepository.GetAll();
        }

        public Computer GetById(int id)
        {
            return _computerRepository.GetById(id);
        }

        public void Update(int id, Computer computer)
        {
            _computerRepository.Update(id, computer);
        }
    }
}
