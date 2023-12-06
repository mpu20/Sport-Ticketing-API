using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportTicketingAPI.Models
{
    public class TeamModel
    {
        [Required]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        public int? SportId { get; set; }
    }
}
