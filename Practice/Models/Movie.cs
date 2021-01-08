using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Genre must be specified")]
        public string Genre { get; set; }
        [Range(1, 1000, ErrorMessage = "Price must be between $1 and $1000")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Price { get; set; }
    }
}