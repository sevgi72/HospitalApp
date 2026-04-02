namespace HospitalApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<Doctor> Doctors { get; set; }=new List<Doctor>();
    }
}
