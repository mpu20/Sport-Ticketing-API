namespace SportTicketingAPI.Models
{
    public class MatchModel
    {
        public int MatchId { get; set; }
        public DateTime? Date { get; set; }
        public int? VenueId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? AwayTeamId { get; set; }
        public string? description { get; set; }
        public int? Capacity { get; set; }
    }
}
