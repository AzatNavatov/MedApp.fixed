using System.ComponentModel.DataAnnotations;

namespace MedApp.Models;

public class Patient
{
    [Key]
    public int Id { get; set; }
    public string? Image { get; set; }
    public Person Person { get; set; }
    public MedicalCard Card { get; set; }

}