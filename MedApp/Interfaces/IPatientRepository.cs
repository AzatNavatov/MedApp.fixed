using MedApp.Models;
using MedApp.Data.Enums;

namespace MedApp.Interfaces;

public interface IPatientRepository
{
    Task<IEnumerable<Patient>> GetAll();
    Task<Patient> GetById(int id);
    Task<IEnumerable<Patient>> GetByDiagnosys(Diagnosys diagnosys);
    bool Add(Patient patient);
    bool Update(Patient patient);
    bool Delete(Patient patient);
    bool Save();

}