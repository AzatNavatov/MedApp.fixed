using System.ComponentModel.DataAnnotations;

namespace MedApp.Models;

public class Admin
{
    [Key]
    public int Id { get; set; }
    public Person Person { get; set; }
}