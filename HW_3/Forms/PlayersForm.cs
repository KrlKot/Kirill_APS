using Homework3.HW_3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework3
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        private void LoadPlayers(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var players = context.Players.Include(x => x.Club).ToList();
            dataGridViewPlayers.DataSource = players;
            dataGridViewPlayers.Columns["PlayerId"].Visible = false;
            dataGridViewPlayers.Columns["ClubId"].Visible = false;
            dataGridViewPlayers.Columns["Club"].Visible = false;

            DataGridViewTextBoxColumn clubColumn = new DataGridViewTextBoxColumn();
            clubColumn.Name = "ClubName";
            clubColumn.ReadOnly = true;
            dataGridViewPlayers.Columns.Add(clubColumn);

            foreach (DataGridViewRow row in dataGridViewPlayers.Rows)
            {
                var player = (Player)row.DataBoundItem;
                row.Cells["ClubName"].Value = player.Club.Name;
            }
        }

        private void AddPlayer(object sender, EventArgs e)
        {
            using var input = new InputPlayerForm();
            if (input.ShowDialog() == DialogResult.OK)
            {
                using var context = new AppDbContext();
                var newPlayer = new Player(input.ChosenClubId, input.PlayerName, input.PlayerGoals);
                context.Players.Add(newPlayer);
                context.SaveChanges();

                LoadPlayers(sender, e);
            }
        }

        private void EditPlayerButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.CurrentRow != null)
            {
                var CurrentPlayer = (Player)dataGridViewPlayers.CurrentRow.DataBoundItem;
                using var input = new InputPlayerForm();
                if (input.ShowDialog() == DialogResult.OK)
                {
                    CurrentPlayer.ClubId = input.ChosenClubId;
                    CurrentPlayer.Name = input.PlayerName;
                    CurrentPlayer.Goals = input.PlayerGoals;

                    using var context = new AppDbContext();
                    context.Players.Update(CurrentPlayer);
                    context.SaveChanges();

                    LoadPlayers(sender, e);
                }
            }
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.CurrentRow != null)
            {
                var CurrentPlayer = (Player)dataGridViewPlayers.CurrentRow.DataBoundItem;
                using var context = new AppDbContext();
                var result = MessageBox.Show("Вы точно хотите удалить этого игрока?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.Players.Remove(CurrentPlayer);
                    context.SaveChanges();
                    LoadPlayers(sender, e);
                }
            }
        }

        private void dataGridViewPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
