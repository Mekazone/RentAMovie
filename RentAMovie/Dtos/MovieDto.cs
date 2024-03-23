using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentAMovie.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }
        public GenreDto Genre { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}