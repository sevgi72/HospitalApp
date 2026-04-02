using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    public class DoctorController : Controller
    {
        private List<Doctor> doctors = new List<Doctor>()
        {
            new Doctor
            {
                Id=1,
                Name="Dr. Smith",
                Specialty="Cardiologist",
                DepartmentId=1
            },
            new Doctor
            {
                Id=2,
                Name="Dr. Johnson",
                Specialty="Neurologist",
                DepartmentId=2
            },
            new Doctor
            {
                Id=3,
                Name="Dr. Williams",
                Specialty="Pediatrician",
                DepartmentId=3
            }
        };
        public IActionResult Index(int departmentId)
        {

            if (doctors.Any(m => m.DepartmentId == departmentId))
            {
                var doctorsInMyDepart = doctors.FindAll
                    (d => d.DepartmentId == departmentId)
                    .ToList();
                return View(doctorsInMyDepart);
            }
            return View(new List<Doctor>());
        }
    }
}
