using System.ComponentModel.DataAnnotations.Schema;

namespace HealthApp.Models
{
    public class LabTest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
