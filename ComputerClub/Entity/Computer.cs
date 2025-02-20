namespace ComputerClub.Entity
{
    public class Computer
    {
        public int Id { get; private set; }

        public int HallId { get; set; }

        public bool IsBusy { get; set; }

        public Computer(int id, int hallId, bool isBusy) 
        {
            Id = id;
            HallId = hallId;
            IsBusy = isBusy;
        }

        public Computer(int hallId, bool isBusy) 
        {
            HallId = hallId;
            IsBusy = isBusy;
        }
    }
}
