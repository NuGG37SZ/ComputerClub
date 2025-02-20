namespace ComputerClub.Entity
{
    public class Hall
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public int PricePerHour { get; set; }

        public int MaxCountComputers { get; set; }

        public Hall(int id, string name, int pricePerHour, int maxCountComputers)
        {
            Id = id;
            Name = name;
            PricePerHour = pricePerHour;
            MaxCountComputers = maxCountComputers;
        }

        public Hall(string name, int pricePerHour, int maxCountComputers)
        {
            Name = name;
            PricePerHour = pricePerHour;
            MaxCountComputers = maxCountComputers;
        }
    }
}
