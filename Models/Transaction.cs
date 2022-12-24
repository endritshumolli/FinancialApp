using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancialApp.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        [Required]
        [MaxLength(11, ErrorMessage="Maximum 11 characters only.")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [Required]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string SWIFTCode { get; set; }
        [Required]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
