using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportTicketingAPI.Data;
using SportTicketingAPI.Models;

namespace SportTicketingAPI.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SportTicketingContext context;
        private readonly IMapper mapper;

        public TeamRepository(SportTicketingContext context, IMapper mapper) {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<int> CreateTeam(TeamModel teamModel)
        {
            var newTeam = mapper.Map<Team>(teamModel);
            context.Teams!.Add(newTeam);
            await context.SaveChangesAsync();

            return newTeam.TeamId;
        }

        public async Task DeleteTeam(int id)
        {
            var team = await context.Teams!.FindAsync(id);

            if (team != null)
            {
                context.Teams.Remove(team);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TeamModel>> GetAllTeams()
        {
            var teams = await context.Teams!.ToListAsync();

            return mapper.Map<List<TeamModel>>(teams);
        }

        public async Task<TeamModel> GetTeamById(int id)
        {
            var team = await context.Teams!.FindAsync(id);

            return mapper.Map<TeamModel>(team);
        }

        public async Task UpdateTeam(int id, TeamModel teamModel)
        {
            var team = mapper.Map<Team>(teamModel);
            context.Teams!.Update(team);
            await context.SaveChangesAsync();
        }
    }
}
