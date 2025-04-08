using System.ComponentModel.DataAnnotations;

namespace Receipt_Reimbursement_App.Models
{
    public class Reimbursement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Please select a date")]
        public DateOnly DatePurchased { get; set; }

        public string? FileName { get; set; }

        public string? ContentType { get; set; }

        public byte[]? FileData { get; set; }
    }
}
