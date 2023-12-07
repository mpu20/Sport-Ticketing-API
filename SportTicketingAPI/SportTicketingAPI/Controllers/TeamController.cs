using Microsoft.AspNetCore.Mvc;
using SportTicketingAPI.Models;
using SportTicketingAPI.Repositories;

namespace SportTicketingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamRepository teamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> GetAllTeams()
        {
            return Ok(await teamRepository.GetAllTeams());
        }

        [HttpGet("Details/{id}")]
        public async Task<IActionResult> GetTeamById(int id)
        {
            var team = await teamRepository.GetTeamById(id);

            return team == null ? NotFound() : Ok(team);
        }

        [HttpGet("Create")]
        public async Task<IActionResult> CreateTeam()
        {
            return Ok();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateTeam(TeamModel teamModel)
        {
            if (ModelState.IsValid)
            {
                teamModel.TeamId = await teamRepository.CreateTeam(teamModel);

                return CreatedAtAction(nameof(GetTeamById), new { id = teamModel.TeamId }, teamModel);
            }

            return BadRequest();
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var team = await teamRepository.GetTeamById(id);

            return team == null ? NotFound() : Ok(team);
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> UpdateTeam(int id, TeamModel teamModel)
        {
            if (ModelState.IsValid && id == teamModel.TeamId)
            {
                await teamRepository.UpdateTeam(id, teamModel);

                return NoContent();
            }

            return BadRequest();
        }

        [HttpGet("Delete")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await teamRepository.GetTeamById(id);

            return team == null ? NotFound() : Ok(team);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            await teamRepository.DeleteTeam(id);

            return NoContent();
        }
    }
}
