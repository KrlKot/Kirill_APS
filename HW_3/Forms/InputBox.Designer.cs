namespace Homework3
{
    partial class InputBox
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBoxInput = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 92);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClose_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 92);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Ок";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите название клуба";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 48);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(331, 27);
            textBoxInput.TabIndex = 4;
            // 
            // InputBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 153);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "InputBox";
            Text = "Form1";
            Load += InputBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBoxInput;
    }
}