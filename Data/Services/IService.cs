using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public interface IService
    {
        Task<List<Team>> GetTeams();

        Task<List<MatchResult>> GetMatchResults();

        Task<List<TeamInformation>> GetTeamsInformation();
    }
}
