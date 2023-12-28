using System.ComponentModel.DataAnnotations.Schema;

namespace HealthApp.Models
{
    public class BillInvoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime MyProperty { get; set; }
        public bool IsDueAmount { get; set; }
        public double Total { get; set; }

    }
}
