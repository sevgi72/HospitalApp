namespace HospitalApp.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Specialty { get; set; }=null!;
        public string Description { get; set; } = null!;
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

    }
}
