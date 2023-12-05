using AutoMapper;
using SportTicketingAPI.Data;
using SportTicketingAPI.Models;

namespace SportTicketingAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Match, MatchModel>().ReverseMap();
            CreateMap<Sport, SportModel>().ReverseMap();
            CreateMap<Team, TeamModel>().ReverseMap();
            CreateMap<Ticket, TicketModel>().ReverseMap();
            CreateMap<Transaction, TransactionModel>().ReverseMap();
            CreateMap<Venue, VenueModel>().ReverseMap();
        }
    }
}
