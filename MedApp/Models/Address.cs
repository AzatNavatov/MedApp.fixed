using System.ComponentModel.DataAnnotations;

namespace MedApp.Models;

public class Address
{
    [Key] 
    public int AddressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
}