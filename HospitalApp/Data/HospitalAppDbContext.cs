using HospitalApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalApp.Data
{
    public class HospitalAppDbContext: DbContext
    {
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public HospitalAppDbContext(DbContextOptions<HospitalAppDbContext> options) : base(options)
        {
        }
       
    }
}
