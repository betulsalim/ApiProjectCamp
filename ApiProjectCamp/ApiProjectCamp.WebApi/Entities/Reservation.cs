﻿namespace ApiProjectCamp.WebApi.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public int NumberOfPeople { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
      

    }
}
