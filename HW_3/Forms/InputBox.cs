using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Homework3
{
    public partial class InputBox : Form
    {
        public string InputText { get; private set; }
        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            InputText = textBoxInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
