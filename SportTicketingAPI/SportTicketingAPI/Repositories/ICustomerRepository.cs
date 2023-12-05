using SportTicketingAPI.Models;

namespace SportTicketingAPI.Repositories
{
    public interface ICustomerRepository
    {
        public Task<int> Register(CustomerModel customer);
    }
}
