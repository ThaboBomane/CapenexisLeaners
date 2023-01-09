using System.ComponentModel.DataAnnotations;

namespace CapenexisLeaners.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Surname { get; set; }
    
    public string Firstname { get; set; }
    public string? NationalIdentityNumber { get; set; }
    public string Course { get; set; }
    public decimal Price { get; set; }
    public string Duration { get; set; }
}
