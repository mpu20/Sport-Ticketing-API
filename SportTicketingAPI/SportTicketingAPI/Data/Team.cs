using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportTicketingAPI.Data
{
    [Table("Team")]
    public class Team
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Sport")]
        public int? SportId { get; set; }
        public virtual Sport Sport { get; set; }
        [InverseProperty("HomeTeam")]
        public virtual ICollection<Match> HomeMatches { get; set; }

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Match> AwayMatches { get; set; }
    }
}
