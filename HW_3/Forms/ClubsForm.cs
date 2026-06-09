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
    public partial class ClubsForm : Form
    {
        public ClubsForm()
        {
            InitializeComponent();
        }

        private void ClubsForm_Load(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var clubs = context.Clubs.ToList();
            dataGridViewClubs.DataSource = clubs;
        }

        private void EditClub(object sender, EventArgs e)
        {
            if (dataGridViewClubs.CurrentRow != null) 
            {
                var CurrentClub = (Club)dataGridViewClubs.CurrentRow.DataBoundItem;
                using var inputForm = new InputBox();
                if (inputForm.ShowDialog() == DialogResult.OK && inputForm.InputText.Length > 0) 
                {
                    CurrentClub.Name = inputForm.InputText;

                    using var context = new AppDbContext();
                    context.Clubs.Update(CurrentClub);
                    context.SaveChanges();

                    ClubsForm_Load(sender, e);
                }
            }
        }

        private void DeleteClub(object sender, EventArgs e)
        {
            if (dataGridViewClubs.CurrentRow != null) 
            {
                var CurrentClub = (Club)dataGridViewClubs.CurrentRow.DataBoundItem;
                using var context = new AppDbContext();
                if (context.Players.Any(x => x.ClubId == CurrentClub.Id)) { MessageBox.Show("Удаление невозможно: в клубе есть игроки"); return; }
                else
                {
                    var result = MessageBox.Show("Вы точно хотите удалить этот клуб?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) 
                    {
                        context.Clubs.Remove(CurrentClub);
                        context.SaveChanges();
                        ClubsForm_Load(sender, e);
                    }
                }
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClub(object sender, EventArgs e)
        {
            using var input = new InputBox();
            if (input.ShowDialog() == DialogResult.OK && input.InputText.Length > 0) 
            {
                using var context = new AppDbContext();
                var newClub = new Club(input.InputText);
                context.Clubs.Add(newClub);
                context.SaveChanges();

                ClubsForm_Load(sender, e);
            }
        }
    }
}
