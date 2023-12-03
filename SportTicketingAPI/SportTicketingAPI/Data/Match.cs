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

        [ForeignKey("Venue")]
        public int? VenueId { get; set; }
        [ForeignKey("HomeTeam")]
        public int? HomeTeamId { get; set; }
        [ForeignKey("AwayTeam")]
        public int? AwayTeamId { get; set; }
        public string? description { get; set; }
        public int? Capacity { get; set; }
        public virtual Venue Venue { get; set; }
        [InverseProperty("HomeMatches")]
        public virtual Team HomeTeam { get; set; }
        [InverseProperty("AwayMatches")]
        public virtual Team AwayTeam { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
