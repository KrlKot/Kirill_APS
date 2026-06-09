using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework3
{
    public partial class InputPlayerForm : Form
    {
        public int ChosenClubId { get; private set; }
        public string PlayerName { get; private set; }
        public int PlayerGoals { get; private set; }
        public InputPlayerForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputPlayerForm_Load(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            var AvailableClubs = context.Clubs.ToList();
            comboBoxClub.DisplayMember = "Name";
            comboBoxClub.ValueMember = "Id";
            comboBoxClub.DataSource = AvailableClubs;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (comboBoxClub.SelectedValue != null && textBoxName.Text.Length > 0)
            {
                ChosenClubId = (int)comboBoxClub.SelectedValue;
                PlayerName = textBoxName.Text;
                PlayerGoals = (int)numericUpDownGoals.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
            else { MessageBox.Show("Заполните все поля"); return; }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
