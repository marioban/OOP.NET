using Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{

    public class DataService
    {
        private IService Service;
        public static List<MatchResult> MatchResults { get; set; }
        private static string malePlayersFile = @"Resources\FavoriteMalePlayers.txt";
        private static string femalePlayersFile = @"Resources\FavoriteFemalePlayers.txt";
        private static string femaleTeamFile = @"Resources\FavoriteFemaleTeam.txt";
        private static string maleTeamFile = @"Resources\FavoriteMaleTeam.txt";
        private string dataSourceFile = @"C:\Users\MarioB\Desktop\Faks\2.godina\OOP.NET 2nd try\MarioBanOOP.NET\Data\Settings\Settings.txt";
        public string dataSource;
        public string selectedTeam;
        public static string fifaCode;
        public string teamResult;

        public DataService()
        {
            var storageType = ResolveStorageType();

            if (storageType == Storage.File)
            {
                Service = new FileService();
            }
            else
            {
                Service = new ApiService();
            }
        }

        private Storage ResolveStorageType()
        {
            StreamReader r = new StreamReader(dataSourceFile);
            dataSource = r.ReadToEnd();

            if (dataSource == "File")
            {
                return Storage.File;
            }
            else
            {
                return Storage.Api;
            }
        }

        public async Task<List<Team>> GetTeams()
        {
            return await Service.GetTeams();
        }

        public async Task<List<MatchResult>> GetAllMatchResults()
        {
            return await Service.GetMatchResults();
        }
        public async Task<List<Team>> GetOpponents(string fifaCode)
        {
            List<Team> teams = new List<Team>();
            MatchResults = await Service.GetMatchResults();
            List<MatchResult> sortedMatchResults =
                MatchResults.Where(x => x.HomeTeamCountry == fifaCode
            || x.AwayTeamCountry == fifaCode).ToList();
            foreach (MatchResult item in sortedMatchResults)
            {
                if (item.HomeTeamCountry == fifaCode)
                {
                    teams.Add(item.AwayTeam);
                }
                else
                {
                    teams.Add(item.HomeTeam);
                }
            }

            return teams;

        }

        public async Task<List<TeamEvent>> GetEvents(string firstTeam, string secondTeam)
        {
            List<MatchResult> matchResults = await Service.GetMatchResults();

            List<TeamEvent> events = new List<TeamEvent>();
            foreach (var matchResult in matchResults)
            {
                if (matchResult.HomeTeam.Country == firstTeam && matchResult.AwayTeam.Country == secondTeam)
                {
                    matchResult.HomeTeamEvents.ForEach(e => events.Add(e));
                }
                else if (matchResult.AwayTeam.Country == firstTeam && matchResult.HomeTeam.Country == secondTeam)
                {
                    matchResult.AwayTeamEvents.ForEach(e => events.Add(e));
                }
            }
            return events;

        }


        public async Task<string> GetScore(string firstTeam, string secondTeam)
        {
            int homeGoals = 0;
            int awayGoals = 0;
            MatchResults = await Service.GetMatchResults();
            List<MatchResult> sortedMatchResults =
                MatchResults.Where(x => x.HomeTeamCountry == firstTeam
            || x.AwayTeamCountry == firstTeam).ToList();
            foreach (MatchResult match in sortedMatchResults)
            {
                if (match.HomeTeamCountry == firstTeam && match.AwayTeamCountry == secondTeam)
                {
                    foreach (var teamEvent in match.HomeTeamEvents)
                    {
                        if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                        {
                            homeGoals++;
                        }
                    }
                    foreach (var teamEvent in match.AwayTeamEvents)
                    {
                        if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                        {
                            awayGoals++;

                        }
                    }
                }
                else if (match.HomeTeamCountry == secondTeam && match.AwayTeamCountry == firstTeam)
                {
                    foreach (var teamEvent in match.HomeTeamEvents)
                    {
                        if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                        {
                            awayGoals++;

                        }
                    }
                    foreach (var teamEvent in match.AwayTeamEvents)
                    {
                        if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                        {
                            homeGoals++;

                        }
                    }
                }

            }
            string result = "Rezultat " + homeGoals + " : " + awayGoals;
            return result;
        }
        public async Task<TeamInformation> GetTeamInformation(string fifaCode)
        {
            List<TeamInformation> teamsInformations = await Service.GetTeamsInformation();
            TeamInformation teamInformation = new TeamInformation();
            for (int i = 0; i < teamsInformations.Count; i++)
            {
                if (teamsInformations[i].Country == fifaCode)
                {
                    teamInformation = teamsInformations[i];
                }
            }
            return teamInformation;
        }


      
        public async Task<List<Player>> GetPlayers(string fifaCode)
        {
            MatchResults = await Service.GetMatchResults();
            var matchResult = MatchResults
                .Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode).OrderBy(x => x.Datetime)
                .FirstOrDefault();
            List<Player> players = new List<Player>();
            if (matchResult.HomeTeamCountry == fifaCode)
            {
                players.AddRange(matchResult.HomeTeamStatistics.StartingEleven);
                players.AddRange(matchResult.HomeTeamStatistics.Substitutes);
            }
            else
            {
                players.AddRange(matchResult.AwayTeamStatistics.StartingEleven);
                players.AddRange(matchResult.AwayTeamStatistics.Substitutes);
            }
            return players;
        }

        public async Task<List<Player>> GetStartingEleven(string firstTeam, string secondTeam)
        {
            MatchResults = await Service.GetMatchResults();
            List<MatchResult> sortedMatchResults =
                MatchResults.Where(x => x.HomeTeamCountry == firstTeam
            || x.AwayTeamCountry == firstTeam).ToList();
            List<Player> players = new List<Player>();

            foreach (MatchResult match in sortedMatchResults)
            {
                if (match.HomeTeamCountry == firstTeam && match.AwayTeamCountry == secondTeam)
                {
                    players.AddRange(match.HomeTeamStatistics.StartingEleven);

                }
                else if (match.HomeTeamCountry == secondTeam && match.AwayTeamCountry == firstTeam)
                {
                    players.AddRange(match.AwayTeamStatistics.StartingEleven);

                }
            }
            return players;
        }

        public void WriteFavoriteTeam(string fifaCode)
        {
            if (GetGender() == Gender.Male)
            {
                File.WriteAllText(maleTeamFile, fifaCode);
            }
            else
            {
                File.WriteAllText(femaleTeamFile, fifaCode);
            }


        }
        public string GetFavoriteTeam()
        {
            string fifaCode;
            Gender gender = GetGender();
            if (GetGender() == Gender.Male)
            {
                if (File.Exists(maleTeamFile))
                {
                    fifaCode = File.ReadAllText(maleTeamFile);

                }
                else
                {
                    fifaCode = null;
                }
            }
            else
            {
                if (File.Exists(femaleTeamFile))
                {
                    fifaCode = File.ReadAllText(femaleTeamFile);
                }
                else
                {
                    fifaCode = null;
                }
            }

            return fifaCode;
        }
        public Language GetLanguage()
        {

            AppService appSettingsService = new AppService();
            AppSettings appSettings = appSettingsService.GetAplicationSettings();
            return appSettings.Language;
        }

        public void WriteFavoritePlayers(List<Player> players)
        {
            if (GetGender() == Gender.Male)
            {
                string json = JsonConvert.SerializeObject(players);
                if (GetGender() == Gender.Male)
                {

                    System.IO.File.WriteAllText(malePlayersFile, json);
                }
            }
            else
            {
                string json = JsonConvert.SerializeObject(players);
                System.IO.File.WriteAllText(femalePlayersFile, json);
            }

        }
        public List<Player> ReadFavoritePlayers()
        {
            string path;
            List<Player> players = new List<Player>();
            if (GetGender() == Gender.Male)
            {
                path = malePlayersFile;
            }
            else
            {
                path = femalePlayersFile;
            }
            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    players = JsonConvert.DeserializeObject<List<Player>>(json);
                }
            }
            else
            {
                players = null;
            }

            return players;
        }

        public async Task<List<GameStats>> GetGamesInfo()
        {
            string fifaCode = GetSelectedTeam();
            List<MatchResult> matchResults = await Service.GetMatchResults();
            List<GameStats> gameStats = new List<GameStats>();
            List<MatchResult> matchResult = MatchResults
             .Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode).ToList();
            for (int i = 0; i < matchResult.Count; i++)
            {
                gameStats.Add(new Models.GameStats
                {
                    Location = matchResult[i].Location,
                    Visitors = matchResult[i].Attendance,
                    HomeTeam = matchResult[i].HomeTeamCountry,
                    AwayTeam = matchResult[i].AwayTeamCountry,
                });
            }
            return gameStats;
        }
        public Gender GetGender()
        {
            AppSettings appSettings = new AppSettings();
            AppService appService = new AppService();
            appSettings = appService.GetAplicationSettings();
            return appSettings.Gender;
        }
        public void SetSelectedTeam(string var)
        {
            fifaCode = var;
        }
        public string GetSelectedTeam()
        {
            return fifaCode;
        }
    }
}
