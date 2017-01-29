﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyApproach.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public int MyProperty { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}