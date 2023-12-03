using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportTicketingAPI.Data
{
    [Table("Sport")]
    public class Sport
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SportId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
