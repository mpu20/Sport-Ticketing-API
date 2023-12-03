using Microsoft.EntityFrameworkCore;

namespace SportTicketingAPI.Data
{
    public class SportTicketingContext : DbContext
    {
        public SportTicketingContext(DbContextOptions<SportTicketingContext> options) : base(options) { }

        #region DbSet
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Match>? Matches { get; set; }
        public DbSet<Sport>? Sports { get; set; }
        public DbSet<Team>? Teams { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<Transaction>? Transactions { get; set; }
        public DbSet<Venue>? Venues { get; set; }
        #endregion
    }
}
