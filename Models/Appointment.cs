using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthApp.Models
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Email{ get; set; }
        public string PhoneNumber { get; set; }
        public double Age { get; set; }
        public string Address { get; set; }
        public DateTime VisitingDate { get; set; }
        public int DoctorId { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }

        [DefaultValue(true)]
        public bool IsConfirm { get; set; }
        [DefaultValue(false)]
        public bool IsVisited { get; set; }
        [DefaultValue(false)]
        public bool IsPaymentCompleted { get; set; }
    }
}
