namespace Homework3
{
    partial class PlayersForm
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
            dataGridViewPlayers = new DataGridView();
            AddPlayerButton = new Button();
            EditPlayerButton = new Button();
            DeletePlayerButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(396, 46);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.RowHeadersWidth = 51;
            dataGridViewPlayers.Size = new Size(365, 368);
            dataGridViewPlayers.TabIndex = 0;
            dataGridViewPlayers.CellContentClick += dataGridViewPlayers_CellContentClick;
            // 
            // AddPlayerButton
            // 
            AddPlayerButton.Location = new Point(111, 69);
            AddPlayerButton.Name = "AddPlayerButton";
            AddPlayerButton.Size = new Size(140, 40);
            AddPlayerButton.TabIndex = 1;
            AddPlayerButton.Text = "Добавить игрока";
            AddPlayerButton.UseVisualStyleBackColor = true;
            AddPlayerButton.Click += AddPlayer;
            // 
            // EditPlayerButton
            // 
            EditPlayerButton.Location = new Point(111, 145);
            EditPlayerButton.Name = "EditPlayerButton";
            EditPlayerButton.Size = new Size(140, 40);
            EditPlayerButton.TabIndex = 2;
            EditPlayerButton.Text = "Изменить игрока";
            EditPlayerButton.UseVisualStyleBackColor = true;
            EditPlayerButton.Click += EditPlayerButton_Click;
            // 
            // DeletePlayerButton
            // 
            DeletePlayerButton.Location = new Point(111, 234);
            DeletePlayerButton.Name = "DeletePlayerButton";
            DeletePlayerButton.Size = new Size(140, 40);
            DeletePlayerButton.TabIndex = 3;
            DeletePlayerButton.Text = "Удалить игрока";
            DeletePlayerButton.UseVisualStyleBackColor = true;
            DeletePlayerButton.Click += DeletePlayerButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(111, 318);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(140, 40);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Закрыть форму";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(DeletePlayerButton);
            Controls.Add(EditPlayerButton);
            Controls.Add(AddPlayerButton);
            Controls.Add(dataGridViewPlayers);
            Name = "PlayersForm";
            Text = "Футбольная Статистика - Игроки";
            Load += LoadPlayers;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPlayers;
        private Button EditPlayerButton;
        private Button DeletePlayerButton;
        private Button CloseButton;
        private Button AddPlayerButton;
    }
}