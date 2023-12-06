using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportTicketingAPI.Data
{
    [Table("Match")]
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatchId { get; set; }
        public DateTime? Date { get; set; }        
        public int? VenueId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? AwayTeamId { get; set; }
        public string? description { get; set; }
        public int? Capacity { get; set; }
        [ForeignKey("VenueId")]
        public virtual Venue Venue { get; set; }
        [ForeignKey("HomeTeamId")]
        [InverseProperty("HomeMatches")]
        public virtual Team HomeTeam { get; set; }
        [ForeignKey("AwayTeamId")]
        [InverseProperty("AwayMatches")]
        public virtual Team AwayTeam { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
