using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRJ_FINAL_MP09_MP03.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NombreCancion { get; set; }



        [Required]
        public string Artista { get; set; }

        public string Descripcion { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Nuevas columnas
        public string UrlMusica { get; set; }
        public string UrlDescarga { get; set; }
        public string UrlImg { get; set; }

        public string IdTrack { get; set; }

        // Relación con User
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }

}
