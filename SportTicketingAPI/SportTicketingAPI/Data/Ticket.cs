using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportTicketingAPI.Data
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        [ForeignKey("Match")]
        public int? MatchId { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }
        [MaxLength(20)]
        public string? SeatNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        public virtual Match Match { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
