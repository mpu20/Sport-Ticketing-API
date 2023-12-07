using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportTicketingAPI.Data
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public int? CustomerId { get; set; }
        public int? MatchId { get; set; }
        public DateTime? Timestamp { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? TotalAmount { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("MatchId")]
        public virtual Match Match { get; set; }
    }
}
