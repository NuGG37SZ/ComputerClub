using System;

namespace ComputerClub.Entity
{
    public class Session
    {
        public int Id { get; private set; }
        public int ClientId { get; set; }
        
        public int ComputerId { get; set; }

        public DateTime StartPlay {  get; set; }

        public DateTime EndPlay { get; set; }

        public Session(int id, int clientId, int computerId, DateTime startPlay, DateTime endPlay)
        {
            Id = id;
            ClientId = clientId;
            ComputerId = computerId;
            StartPlay = startPlay;
            EndPlay = endPlay;
        }

        public Session(int clientId, int computerId, DateTime startPlay, DateTime endPlay) 
        {
            ClientId = clientId;
            ComputerId = computerId;
            StartPlay = startPlay;
            EndPlay = endPlay;
        }
    }
}
