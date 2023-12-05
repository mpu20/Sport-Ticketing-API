namespace SportTicketingAPI.Models
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        public int? CustomerId { get; set; }
        public int? MatchId { get; set; }
        public DateTime? Timestamp { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
