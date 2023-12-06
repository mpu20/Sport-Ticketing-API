using SportTicketingAPI.Models;

namespace SportTicketingAPI.Repositories
{
    public interface ITeamRepository
    {
        public Task<List<TeamModel>> GetAllTeams();
        public Task<TeamModel> GetTeamById(int id);
        public Task<int> CreateTeam(TeamModel teamModel);
        public Task UpdateTeam(int id, TeamModel teamModel);
        public Task DeleteTeam(int id);
    }
}
