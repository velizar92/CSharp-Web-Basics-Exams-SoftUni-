﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SharedTrip.Data.Models
{
    public class Trip
    {
        public Trip()
        {
            this.UserTrips = new HashSet<UserTrip>();
        }


        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string StartPoint { get; set; }

        [Required]
        public string EndPoint { get; set; }


        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        [Range(2,6)]
        public int Seats { get; set; }

        [Required]
        [MaxLength(80)]
        public string Description { get; set; }
     
        public string ImagePath { get; set; }


        public ICollection<UserTrip> UserTrips { get; set; }
    }
}
