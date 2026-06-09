using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework3.Properties.DataSources
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void PlayersList_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var playersList = context.Players.Include(x => x.Club).Select(x => new
            {

                x.Name,
                x.ClubId,
                ClubName = x.Club.Name,
                x.Goals
            }).ToList();
            dataGridViewReport.DataSource = playersList;
        }

        private void PlayersPerClubs_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var playersPerClubsList = context.Clubs.Select(x => new
            {
                x.Name,
                PlayersNumber = x.Players.Count
            }).ToList();
            dataGridViewReport.DataSource = playersPerClubsList;
        }

        private void AvgGoalsPerClub_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var avgGoalsPerClubsList = context.Clubs.Select(x => new
            {
                x.Name,
                AverageGoals = Math.Round(x.Players.Average(y => y.Goals), 2)
            }).ToList();
            dataGridViewReport.DataSource= avgGoalsPerClubsList;
        }
    }
}
