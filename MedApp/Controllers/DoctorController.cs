using MedApp.Data;
using MedApp.Interfaces;
using MedApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedApp.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
    

        public DoctorController(AppDbContext context, IDoctorRepository doctorRepository)
        {
            
            _doctorRepository = doctorRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Doctor> doctors = await _doctorRepository.GetAll();
            return View(doctors);
        }

        
    }
}
