﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 1000)]
        public decimal Price { get; set; }
        [RegularExpression(@"[a-zA-Z]*")]
        public string Genre { get; set; }
        [RegularExpression(@"[a-zA-Z""']*")]
        public string Rating { get; set; }
    }
}
