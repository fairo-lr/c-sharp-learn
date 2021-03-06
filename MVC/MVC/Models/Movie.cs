﻿using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace MVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
