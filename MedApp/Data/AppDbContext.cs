using MedApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MedApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Doctor> Doctors { get; set; }  
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Admin> Admin { get; set; }
    public DbSet<Registrator> Registrators { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<MedicalCard> MedicalCards { get; set; }




}