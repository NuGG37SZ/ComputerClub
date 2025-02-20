namespace ComputerClub.Entity
{
    public class ComputerDisplay
    {
        public int Id { get; set; }
        
        public string HallName { get; set; }

        public int PricePerHour { get; set; }

        public bool IsBusy { get; set; }

        public ComputerDisplay(int id, string hallName, int pricePerHour, bool isBusy)
        {
            Id = id;
            HallName = hallName;
            PricePerHour = pricePerHour;
            IsBusy = isBusy;
        }

        public ComputerDisplay(string hallName, int pricePerHour, bool isBusy)
        {
            HallName = hallName;
            PricePerHour = pricePerHour;
            IsBusy = isBusy;
        }

        public ComputerDisplay() { }
    }
}
