using MedApp.Data.Enums;
using MedApp.Models;

namespace MedApp.Interfaces;

public interface IDoctorRepository
{ 
    Task<IEnumerable<Doctor>> GetAll();
    Task<Doctor> GetById(int id);
    Task<IEnumerable<Doctor>> GetBySpecialityty(SpecialityType speciality);
    bool Add(Doctor patient);
    bool Update(Doctor patient);
    bool Delete(Doctor patient);
    bool Save();

}