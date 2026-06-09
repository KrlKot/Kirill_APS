using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Homework3.HW_3
{
    internal static class Program
    {
        static void Main(string[] args) 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
