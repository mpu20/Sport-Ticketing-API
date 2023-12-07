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
        public int? MatchId { get; set; }
        public int? CustomerId { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }
        [MaxLength(20)]
        public string? SeatNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        [ForeignKey("MatchId")]
        public virtual Match Match { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
