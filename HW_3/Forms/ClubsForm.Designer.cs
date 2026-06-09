namespace Homework3
{
    partial class ClubsForm
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
            dataGridViewClubs = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClubs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClubs
            // 
            dataGridViewClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClubs.Location = new Point(369, 39);
            dataGridViewClubs.Name = "dataGridViewClubs";
            dataGridViewClubs.ReadOnly = true;
            dataGridViewClubs.RowHeadersWidth = 51;
            dataGridViewClubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClubs.Size = new Size(365, 360);
            dataGridViewClubs.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(112, 151);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 2;
            button2.Text = "Изменить клуб";
            button2.UseVisualStyleBackColor = true;
            button2.Click += EditClub;
            // 
            // button3
            // 
            button3.Location = new Point(112, 236);
            button3.Name = "button3";
            button3.Size = new Size(140, 40);
            button3.TabIndex = 3;
            button3.Text = "Удалить клуб";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteClub;
            // 
            // button5
            // 
            button5.Location = new Point(112, 320);
            button5.Name = "button5";
            button5.Size = new Size(140, 40);
            button5.TabIndex = 5;
            button5.Text = "Закрыть форму";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CloseForm;
            // 
            // button1
            // 
            button1.Location = new Point(112, 63);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 6;
            button1.Text = "Добаввить клуб";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddClub;
            // 
            // ClubsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridViewClubs);
            Name = "ClubsForm";
            Text = "Футбольная статистика - Клубы";
            Load += ClubsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClubs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClubs;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button1;
    }
}