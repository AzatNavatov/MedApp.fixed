using System.ComponentModel.DataAnnotations;
using MedApp.Data.Enums;

namespace MedApp.Models;

public class Person
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public int? Age { get; set; }
    public Address? Address { get; set; }
}