using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportTicketingAPI.Data
{
    [Table("Team")]
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; } = null!;        
        public int? SportId { get; set; }
        [ForeignKey("SportId")]
        public virtual Sport Sport { get; set; } = null!;
        [InverseProperty("HomeTeam")]
        public virtual ICollection<Match> HomeMatches { get; set; } = null!;

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Match> AwayMatches { get; set; } = null!;
    }
}
