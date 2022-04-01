using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Newtonsoft.Json;

namespace Data.Services
{
    public class FileService : IService
    {
        AppService appService = new AppService();

        const string maleMatches =@"C:\Users\MarioB\Desktop\MarioBanOOP.NET\Data\Resources\MaleMatches.json";
        private string maleTeams = @"C:\Users\MarioB\Desktop\MarioBanOOP.NET\Data\Resources\MaleTeams.json";
        private string maleResults = @"C:\Users\MarioB\Desktop\MarioBanOOP.NET\Data\Resources\MaleResults.json";

        private string femaleMatches =@"C:\Users\MarioB\Desktop\MarioBanOOP.NET\Data\Resources\FemaleMatches.json";
        private string femaleResults =@"C:\Users\MarioB\Desktop\MarioBanOOP.NET\Data\Resources\FemaleResults.json";
        private string femaleTeams = @"C:\Users\MarioB\Desktop\MarioBanOOP.NET\Data\Resources\FemaleTeams.json";


        private string path;


        private AppSettings appSettings = new AppSettings();

        public async Task<List<MatchResult>> GetMatchResults()
        {
            if (GetGender() == Gender.Male)
            {
                path = maleMatches;
            }
            else
            {
                path = femaleMatches;
            }
            using (StreamReader r = new StreamReader(path))
            {
                string json = await r.ReadToEndAsync();
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }

        public async Task<List<Team>> GetTeams()
        {
            if (GetGender() == Gender.Male)
            {
                path = maleTeams;
            }
            else
            {
                path = femaleTeams;
            }
            using (StreamReader r = new StreamReader(path))
            {
                string json = await r.ReadToEndAsync();
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                return teams;
            }
        }

        public async Task<List<TeamInformation>> GetTeamsInformation()
        {
            if (GetGender() == Gender.Male)
            {
                path = maleResults;
            }
            else
            {
                path = femaleResults;
            }
            using (StreamReader r = new StreamReader(path))
            {
                string json = await r.ReadToEndAsync();
                List<TeamInformation> results = JsonConvert.DeserializeObject<List<TeamInformation>>(json);
                return results;
            }
        }

        private Gender GetGender()
        {
            appSettings = appService.GetAplicationSettings();
            if (appSettings.Gender == Gender.Male)
            {
                return Gender.Male;
            }
            else
            {
                return Gender.Female;
            }
        }
    }
}
