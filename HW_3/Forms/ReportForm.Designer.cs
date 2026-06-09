namespace Homework3.Properties.DataSources
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewReport = new DataGridView();
            PlayersList = new Button();
            PlayersPerClubs = new Button();
            AvgGoalsPerClub = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(408, 35);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(355, 369);
            dataGridViewReport.TabIndex = 0;
            // 
            // PlayersList
            // 
            PlayersList.Location = new Point(127, 67);
            PlayersList.Name = "PlayersList";
            PlayersList.Size = new Size(157, 75);
            PlayersList.TabIndex = 1;
            PlayersList.Text = "Полный список игроков";
            PlayersList.UseVisualStyleBackColor = true;
            PlayersList.Click += PlayersList_Click;
            // 
            // PlayersPerClubs
            // 
            PlayersPerClubs.Location = new Point(127, 164);
            PlayersPerClubs.Name = "PlayersPerClubs";
            PlayersPerClubs.Size = new Size(157, 79);
            PlayersPerClubs.TabIndex = 2;
            PlayersPerClubs.Text = "Число игроков по клубам";
            PlayersPerClubs.UseVisualStyleBackColor = true;
            PlayersPerClubs.Click += PlayersPerClubs_Click;
            // 
            // AvgGoalsPerClub
            // 
            AvgGoalsPerClub.Location = new Point(127, 275);
            AvgGoalsPerClub.Name = "AvgGoalsPerClub";
            AvgGoalsPerClub.Size = new Size(157, 80);
            AvgGoalsPerClub.TabIndex = 3;
            AvgGoalsPerClub.Text = "Среднее число голов по клубам";
            AvgGoalsPerClub.UseVisualStyleBackColor = true;
            AvgGoalsPerClub.Click += AvgGoalsPerClub_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AvgGoalsPerClub);
            Controls.Add(PlayersPerClubs);
            Controls.Add(PlayersList);
            Controls.Add(dataGridViewReport);
            Name = "ReportForm";
            Text = "Отчет";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewReport;
        private Button PlayersList;
        private Button PlayersPerClubs;
        private Button AvgGoalsPerClub;
    }
}