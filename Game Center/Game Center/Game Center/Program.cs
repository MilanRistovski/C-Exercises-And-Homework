using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace Game_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            // Find all TEAMS with names starting with LA

            var teamsStartingWithLA = teams.Where(team => team.Name.StartsWith("LA")).ToList();

            //teamsStartingWithLA.ForEach(team => Console.WriteLine(team.Name));

            //Find all team NAMES playing in Staples Center

            var allTeamsNameStaplesCenter = teams.Where(team => team.Arena.Contains("Staples Center")).ToList();
            //allTeamsNameStaplesCenter.ForEach(team => Console.WriteLine(team.Name));

            var allTeamsNameStaplesCenter1 = teams.Where(team => team.Arena == "Staples Center").Select(team => team.Name).ToList();

            //allTeamsNameStaplesCenter1.ForEach(team => Console.WriteLine(team));

            var allCoaches = teams.Select(team => team.Coach).ToList();
            //allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));

            var oldest3CoachesNamesAndAge = allCoaches.OrderByDescending(coach => coach.Age)
                                                                                            .Take(3).Select(coach => coach.FullName).ToList();

            //oldest3CoachesNamesAndAge.ForEach(trainerName => Console.WriteLine(trainerName));

            // Group all teams by their arenas

            var groupTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();
            //foreach (var group in groupTeamsByArenas)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"------------- {team.Name}");
            //    }
            //}

            // Find all players in one List

            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            //allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            // Find a Player With Highest PPG

            //var bestPtsPerGame = allPlayers.Max(player => player.PlayerStatistic);
            //Console.WriteLine(bestPtsPerGame.Keys);

            var BestPPG = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).ToList()[0];
                                                                                                      // Moze i FirstOrDefault();                                              
            //Console.WriteLine(BestPPG.FullName);
                                                                   
            //BestPPG.ForEach(player => Console.WriteLine(player.FullName));
            //Console.WriteLine(BestPPG.FullName);


            // HOMEWORK HOMEWORK HOMEWORK HOMEWORK HOMEWORK

            // Find all coaches NAMES with Age > 50

            var coachesNamesAbove50 = allCoaches.Where
                                                      (coach => coach.Age > 50).ToList();
            //coachesNamesAbove50.ForEach(coach => Console.WriteLine(coach.FullName));

            // Order players by AGE - DESC

            var allPlayersByAge = allPlayers.OrderByDescending
                                                        (player => player.Age).ToList();
            //allPlayersByAge.ForEach(player => Console.WriteLine(player.FullName));

            // Find player with highest RebPerGame

            var bestRPG = allPlayers.OrderByDescending
                                                    (player => player.PlayerStatistic["RebPerGame"]).ToList()[0];
            //Console.WriteLine(bestRPG.FullName);

            // Find all players with PtsPerGame > 20

            var ptsPGAbove20 = allPlayers.Where
                                            (player => player.PlayerStatistic["PtsPerGame"] > 20).ToList();
            //ptsPGAbove20.ForEach(player => Console.WriteLine(player.FullName));

            // Find all players NAMES older then 30 years

            var playersOlderThan30 = allPlayers.Where
                                                    (player => player.Age > 30).ToList();
            //playersOlderThan30.ForEach(player => Console.WriteLine(player.FullName));

            // Group players by age 
            
            var groupPlayersByAge = allPlayers.GroupBy(player => player.Age).ToList();
            foreach (var group in groupPlayersByAge)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var player in group)
                {
                    Console.WriteLine($"------------- {player.FullName}");
                }
            }

            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
            var playersWithRPG7OrBigger = allPlayers.Where
                                                        (player => player.PlayerStatistic["RebPerGame"] > 7).ToList();
            //playersWithRPG7OrBigger.ForEach(player => Console.WriteLine(player.FullName));
            //playersWithRPG7OrBigger.ForEach(player => Console.WriteLine(player.PlayerStatistic["PtsPerGame"]));

            // Find first 3 players with highest PtsPerGame

            var playersWithMostPPG = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                                            .Take(3).Select(player => player.FullName).ToList();
            //playersWithMostPPG.ForEach(player => Console.WriteLine(player));

            // Find the team which has the player with highest PtsPerGame

            var teamWithBestPPGPlayer = teams.First
                                                   (team => team.Players.Contains(BestPPG));
            Console.WriteLine(teamWithBestPPGPlayer.Name);

            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC

            var playerswithBestRPG1 = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                                            .Take(4).OrderBy
                                                            (player => player.PlayerStatistic["PtsPerGame"])
                                                            .ToList();
            //playerswithBestRPG1.ForEach(player => Console.WriteLine(player.FullName));

        }
    }
}
