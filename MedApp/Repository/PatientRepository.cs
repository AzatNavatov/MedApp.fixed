using MedApp.Data;
using MedApp.Data.Enums;
using MedApp.Interfaces;
using MedApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MedApp.Repository;

public class PatientRepository : IPatientRepository
{
    private readonly AppDbContext _context;

    public PatientRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Patient>> GetAll()
    {
        return await _context.Patients.Include(a=>a.Person).ToListAsync();
    }

    public async Task<Patient> GetById(int id)
    {

        return await _context.Patients.Include(a=>a.Person).ThenInclude(a=>a.Address).
            FirstOrDefaultAsync(i => i.Id == id);
    }

    public async Task<IEnumerable<Patient>> GetByDiagnosys(Diagnosys diagnosys)
    {
        return await _context.Patients.Where(a => a.Card.Diagnosis == diagnosys).ToListAsync();
    }

    public bool Add(Patient patient)
    {
        _context.Add(patient);
        return Save();
    }

    public bool Update(Patient patient)
    {
        _context.Update(patient);
        return Save();
    }

    public bool Delete(Patient patient)
    {
        _context.Remove(patient);
        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}