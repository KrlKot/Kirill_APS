namespace Homework3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClubsButton = new Button();
            PlayersButton = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ClubsButton
            // 
            ClubsButton.Location = new Point(70, 60);
            ClubsButton.Name = "ClubsButton";
            ClubsButton.Size = new Size(150, 40);
            ClubsButton.TabIndex = 0;
            ClubsButton.Text = "Клубы";
            ClubsButton.UseVisualStyleBackColor = true;
            ClubsButton.Click += ClubsButton_Click;
            // 
            // PlayersButton
            // 
            PlayersButton.Location = new Point(70, 140);
            PlayersButton.Name = "PlayersButton";
            PlayersButton.Size = new Size(150, 40);
            PlayersButton.TabIndex = 1;
            PlayersButton.Text = "Игроки";
            PlayersButton.UseVisualStyleBackColor = true;
            PlayersButton.Click += PlayersButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(70, 220);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 2;
            button3.Text = "Отчёт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 27);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 3;
            label1.Text = "Футбольная Статистика";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(PlayersButton);
            Controls.Add(ClubsButton);
            Name = "MainForm";
            Text = "Футбольная статистика";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClubsButton;
        private Button PlayersButton;
        private Button button3;
        private Label label1;
    }
}
