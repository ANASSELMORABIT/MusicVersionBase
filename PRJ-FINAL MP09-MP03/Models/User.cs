using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using PRJ_FINAL_MP09_MP03.Models; 
public class User
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Role { get; set; } // "user" o "admin"

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public string VerificationCode { get; set; }

    public List<Playlist> Playlists { get; set; }
}
