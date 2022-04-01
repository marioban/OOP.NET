using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Newtonsoft.Json;

namespace Data.Services
{
    public class ApiService :IService
    {
        public string maleTeamPath = "https://world-cup-json-2018.herokuapp.com/teams";
        public string femaleTeamPath = "https://worldcup.sfg.io/teams/";
        public string maleMatchResults = "https://world-cup-json-2018.herokuapp.com/matches";
        public string femaleMatchResults = "https://worldcup.sfg.io/matches";
        public string maleResults = "https://world-cup-json-2018.herokuapp.com/teams/results";
        public string femaleResults = "https://worldcup.sfg.io/teams/results";
        string path;
        private AppSettings appSettings = new AppSettings();
        AppService appService = new AppService();

        public async Task<List<Team>> GetTeams()
        {
            try
            {

                if (GetGender() == Gender.Male)
                {
                    path = maleTeamPath;
                }
                else
                {
                    path = femaleTeamPath;
                }
                using (WebClient wc = new WebClient())
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                    var json = await wc.DownloadStringTaskAsync(path);
                    List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                    return teams;
                }
            }
            catch (Exception)
            {

                return null;
            }


        }

        public Gender GetGender()
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


        public async Task<List<MatchResult>> GetMatchResults()
        {
            try
            {
                if (GetGender() == Gender.Male)
                {
                    path = maleMatchResults;
                }
                else
                {
                    path = femaleMatchResults;
                }
                using (WebClient wc = new WebClient())
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                    var json = await wc.DownloadStringTaskAsync(path);
                    List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                    return results;
                }
            }
            catch (System.Exception )
            {
            
                return null;
            }
        }


        public async Task<List<TeamInformation>> GetTeamsInformation()
        {
            try
            {

                if (GetGender() == Gender.Male)
                {
                    path = maleResults;
                }
                else
                {
                    path = femaleResults;
                }
                using (WebClient wc = new WebClient())
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                    var json = await wc.DownloadStringTaskAsync(path);
                    List<TeamInformation> results = JsonConvert.DeserializeObject<List<TeamInformation>>(json);
                    return results;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }




}
