using System.ComponentModel.DataAnnotations;
using MedApp.Data.Enums;

namespace MedApp.Models;

public class Doctor
{
    [Key]
    public int Id { get; set; }
    public string? Image { get; set; }
    public Person Person { get; set; }
    public SpecialityType Speciality { get; set; }

}