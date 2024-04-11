using MedApp.Data;
using MedApp.Data.Enums;
using MedApp.Interfaces;
using MedApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MedApp.Repository;

public class DoctorRepository : IDoctorRepository
{
    private readonly AppDbContext _context;

    public DoctorRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Doctor>> GetAll()
    {
        return await _context.Doctors.Include(a=>a.Person).ToListAsync();
        
    }

    public async Task<Doctor> GetById(int id)
    {
        return await _context.Doctors.Include(a=>a.Person).ThenInclude(a=>a.Address).FirstOrDefaultAsync(a=>a.Id == id);
    }

    public async Task<IEnumerable<Doctor>> GetBySpecialityty(SpecialityType speciality)
    {
        return await _context.Doctors.Where(a=>a.Speciality == speciality).ToListAsync();
    }

    public bool Add(Doctor patient)
    {
        _context.Add(patient);
        return Save();
    }

    public bool Update(Doctor patient)
    {
        _context.Update(patient);
        return Save();
    }

    public bool Delete(Doctor patient)
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