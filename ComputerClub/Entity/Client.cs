namespace ComputerClub.Entity
{
    public class Client
    {
        public int Id { get; private set; }

        public string Login { get; set; }

        public double Discount { get; set; }

        public string Phone {  get; set; }

        public int Balance { get; set; }

        public Client(int id, string login, double discount, string phone, int balance) 
        {
            Id = id;
            Login = login;
            Discount = discount;
            Phone = phone;
            Balance = balance;
        }

        public Client(string login, double discount, string phone, int balance) 
        {
            Login = login;
            Discount = discount;
            Phone = phone;
            Balance = balance;
        }
    }
}
