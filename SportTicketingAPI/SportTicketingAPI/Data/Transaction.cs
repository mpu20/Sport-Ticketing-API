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
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        [ForeignKey("Match")]
        public int? MatchId { get; set; }
        public DateTime? Timestamp { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? TotalAmount { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Match Match { get; set; }
    }
}
