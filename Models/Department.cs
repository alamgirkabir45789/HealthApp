using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthApp.Models
{
    public class Department
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
