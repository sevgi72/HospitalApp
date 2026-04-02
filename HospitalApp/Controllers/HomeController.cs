using System.Diagnostics;
using HospitalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApp.Controllers
{
    public class HomeController : Controller
    {
        private List<Department> departments = new List<Department>()
        {
            new Department
            {
                Id=1,
                Name="Cardiology",
                Description="The cardiology department specializes in the diagnosis and treatment of heart-related conditions and diseases."
            },
            new Department
            {
                Id=2,
                Name="Neurology",
                Description="The neurology department focuses on the diagnosis and treatment of disorders related to the nervous system, including the brain, spinal cord, and nerves."
            },
            new Department
            {
                Id=3,
                Name="Pediatrics",
                Description="The pediatrics department provides medical care for infants, children, and adolescents, addressing a wide range of health issues specific to this age group."
            }
        };
        public IActionResult Index()
        {
            return View(departments);
        }
    }
}
