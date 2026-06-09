using Homework3.HW_3;

namespace Homework3
{
    partial class InputPlayerForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxClub = new ComboBox();
            clubBindingSource = new BindingSource(components);
            textBoxName = new TextBox();
            numericUpDownGoals = new NumericUpDown();
            OK = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)clubBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGoals).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 33);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя клуба";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 81);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя игрока";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 129);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Число голов";
            // 
            // comboBoxClub
            // 
            comboBoxClub.DataSource = clubBindingSource;
            comboBoxClub.FormattingEnabled = true;
            comboBoxClub.Location = new Point(254, 30);
            comboBoxClub.Name = "comboBoxClub";
            comboBoxClub.Size = new Size(151, 28);
            comboBoxClub.TabIndex = 3;
            comboBoxClub.SelectedIndexChanged += comboBoxClub_SelectedIndexChanged;
            // 
            // clubBindingSource
            // 
            clubBindingSource.DataSource = typeof(Club);
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(254, 81);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 4;
            // 
            // numericUpDownGoals
            // 
            numericUpDownGoals.Location = new Point(254, 127);
            numericUpDownGoals.Name = "numericUpDownGoals";
            numericUpDownGoals.Size = new Size(150, 27);
            numericUpDownGoals.TabIndex = 5;
            numericUpDownGoals.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // OK
            // 
            OK.Location = new Point(271, 183);
            OK.Name = "OK";
            OK.Size = new Size(94, 29);
            OK.TabIndex = 6;
            OK.Text = "ОК";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Close
            // 
            Close.Location = new Point(86, 183);
            Close.Name = "Close";
            Close.Size = new Size(94, 29);
            Close.TabIndex = 7;
            Close.Text = "Отмена";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // InputPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 241);
            Controls.Add(Close);
            Controls.Add(OK);
            Controls.Add(numericUpDownGoals);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxClub);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InputPlayerForm";
            Text = "Form1";
            Load += InputPlayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)clubBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGoals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxClub;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownGoals;
        private Button OK;
        private Button Close;
        private BindingSource clubBindingSource;
    }
}