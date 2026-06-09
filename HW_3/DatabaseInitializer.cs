using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Homework3.HW_3
{
    internal class DatabaseInitializer
    {
        public void Init() 
        {
            using var context = new AppDbContext();
            context.Database.EnsureCreated();

            if (!context.Clubs.Any())
            {
                LoadClubsFromCSV(Path.Combine
                    (AppContext.BaseDirectory, "Football_Clubs.csv"),
                    context);

                LoadPlayersFromCSV(Path.Combine
                    (AppContext.BaseDirectory, "Players.csv"),
                    context);
            }
        }

        private void LoadClubsFromCSV(string path, AppDbContext context) 
        {
            using var reader = new StreamReader(path);

            string header = reader.ReadLine();
            List<string> Clubs = reader.ReadToEnd().Split("\r\n").ToList();

            foreach (string club in Clubs) 
            {
                Club _club = new Club(club.Split(";")[1]);
                context.Clubs.Add(_club);
            }
            context.SaveChanges();
        }

        private void LoadPlayersFromCSV(string path, AppDbContext context) 
        {
            using var reader = new StreamReader(path);

            string header = reader.ReadLine();
            List<string> Players = reader.ReadToEnd().Split("\r\n").ToList();

            foreach (string player in Players)
            {
                var PlayersList = player.Split(";");
                Player _player = new Player(int.Parse(PlayersList[1]),
                    PlayersList[2],
                    int.Parse(PlayersList[3]));

                context.Players.Add(_player);
            }
            context.SaveChanges();
        }
    }
}
