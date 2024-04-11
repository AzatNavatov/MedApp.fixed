using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MedApp.Data.Enums;

namespace MedApp.Models;

public class MedicalCard
{
    [Key]
    public int Id { get; set; }
    public Diagnosys? Diagnosis { get; set; }
    public bool? Allergy { get; set; }
    public DateTime? VisitDate { get; set; }
    [ForeignKey("PatientId")]
    public int PatientId { get; set; }
    
}