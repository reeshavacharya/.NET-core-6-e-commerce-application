﻿namespace eTickets.Models
{
    public class Actor_Movie
    {
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
