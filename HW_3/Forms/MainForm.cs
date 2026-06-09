using Homework3.Properties.DataSources;

namespace Homework3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var init = new DatabaseInitializer();
            init.Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ClubsButton_Click(object sender, EventArgs e)
        {
            using var ClubsInfo = new ClubsForm();
            ClubsInfo.ShowDialog();
        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            using var PlayersInfo = new PlayersForm();
            PlayersInfo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using var Reports = new ReportForm();
            Reports.ShowDialog();
        }
    }
}
