namespace SportTicketingAPI.Models
{
    public class TicketModel
    {
        public int TicketId { get; set; }
        public int? MatchId { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Price { get; set; }
        public string? SeatNumber { get; set; }
        public string Status { get; set; }
    }
}
