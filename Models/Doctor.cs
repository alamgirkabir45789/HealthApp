using System.ComponentModel.DataAnnotations.Schema;

namespace HealthApp.Models
{
    public class Doctor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool IsActive { get; set; }
        public Doctor()
        {
            List<Doctor> list = new List<Doctor>()
            {
                new Doctor() {Id=5, Name = "Alamgir", Email = "alamgir@gmail.com", ContactNo = "434324", IsActive = true },
                new Doctor() { Id=4,Name = "Kabir", Email = "kabir@gmail.com", ContactNo = "434324", IsActive = true },
                new Doctor() { Id=6,Name = "Asif", Email = "asif@gmail.com", ContactNo = "434324", IsActive = true },
            };
        }
    }
    
}
