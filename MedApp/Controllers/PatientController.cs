using MedApp.Data;
using MedApp.Interfaces;
using MedApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedApp.Controllers
{
    public class PatientController : Controller
    {
       
        private readonly IPatientRepository _patientRepository;

        public PatientController(AppDbContext context,IPatientRepository patientRepository)
        {
            
            _patientRepository = patientRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Patient> patients = await _patientRepository.GetAll();
            return View(patients);
        }
        
        public async Task<IActionResult> Detail(int id)
        {
            Patient patient = await _patientRepository.GetById(id);
            return View(patient);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
