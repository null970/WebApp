using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class User
{
    #pragma warning disable CS8618 // Required by Entity Framework
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    #pragma warning restore CS8618 // Required by Entity Framework
}