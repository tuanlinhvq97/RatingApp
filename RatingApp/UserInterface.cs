using System;
using System.IO;
using System.Windows.Forms;

namespace RatingApp
{
    public partial class UserInterface : Form
    {
        private AppController appController = new AppController();
        public bool resetApp = false;

        public UserInterface()
        {
            InitializeComponent();

            if (File.Exists(appController.path))
            {
                appController.ReadData();
                UpdateData();
            }

            appController.Top = 0;
            appController.Left = 0;

            ratingPanel.Controls.Add(appController);
        }

        public void UpdateData()
        {
            if (appController.appData.TotalVote == 0)
            {
                fiveStarBar.Value = 0;
                fourStarBar.Value = 0;
                threeStarBar.Value = 0;
                twoStarBar.Value = 0;
                oneStarBar.Value = 0;
            }
            else
            {
                fiveStarBar.Value = 100 * appController.appData.FiveStarVote / appController.appData.TotalVote;
                fourStarBar.Value = 100 * appController.appData.FourStarVote / appController.appData.TotalVote;
                threeStarBar.Value = 100 * appController.appData.ThreeStarVote / appController.appData.TotalVote;
                twoStarBar.Value = 100 * appController.appData.TwoStarVote / appController.appData.TotalVote;
                oneStarBar.Value = 100 * appController.appData.OneStarVote / appController.appData.TotalVote;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            appController.SelectedStar = 0;
            appController.appData = new AppData();
            UpdateData();
            appController.SaveData();
        }
    }
}
