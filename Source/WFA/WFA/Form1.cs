using System.ComponentModel.DataAnnotations;
using BLL;
using Entities;

namespace WFA
{
    public partial class Form1 : Form
    {
        private TournamentManager tournamentManager;

        public Form1()
        {
            InitializeComponent();
            tournamentManager = new TournamentManager();
            lbTournamentUpdater();
            cbSportType.DataSource = Enum.GetValues(typeof(sportTypes));
            cbTournamentSystem.DataSource = Enum.GetValues(typeof(TournamentSystems));
        }

        public void lbTournamentUpdater()
        {
            lbTournaments.Items.Clear();
            lbTournaments.Items.Add("NEW");
            foreach (var t in tournamentManager.AllTournaments)
            {
                lbTournaments.Items.Add($"{t.SportType} - {t.StartDate.ToString(format: "d/M/yy hh:mm")}");
            }
        }





        private void lbTournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTournaments.SelectedIndex != -1)
            {
                if (lbTournaments.SelectedItem.ToString() == "NEW")
                {
                    btUpdate.Visible = false;
                    btDelete.Visible = false;
                    btCreate.Visible = true;

                    rtbAddress.Text = "";
                    rtbDescription.Text = "";
                    cbSportType.SelectedIndex = -1;
                    cbTournamentSystem.SelectedIndex = -1;
                    dtpStartDate.Value = DateTime.Now;
                    dtpEndDate.Value = DateTime.Now;
                    cbMaxPlayers.Value = 0;
                    cbMinPlayers.Value = 0;


                }
                else
                {
                    btCreate.Visible = false;
                    btUpdate.Visible = true;
                    btDelete.Visible = true;

                    cbSportType.SelectedItem =
                        tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].SportType.ToString();
                    rtbDescription.Text = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].Description;
                    dtpStartDate.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].StartDate;
                    dtpEndDate.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].EndDate;
                    cbMinPlayers.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].MinPlayers;
                    cbMaxPlayers.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].MaxPlayers;
                    rtbAddress.Text = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].Location;
                    cbTournamentSystem.SelectedItem = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1]
                        .TournamentSystem.ToString();
                }
            }



        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            int gendr = 0;
            
            if (rbFemale.Checked)
            {
                gendr = 1;
            }
            Tournament newT = new Tournament()
            {
                SportType = (sportTypes)cbSportType.SelectedItem,
                Description = rtbDescription.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                MinPlayers = Convert.ToInt32(cbMinPlayers.Value),
                MaxPlayers = Convert.ToInt32(cbMaxPlayers.Value),
                Location = rtbAddress.Text,
                TournamentSystem = (TournamentSystems)cbTournamentSystem.SelectedItem,
                Gender = gendr
                
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(newT, null, null);
            if (!Validator.TryValidateObject(newT, context, results))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                tournamentManager.AddTournament(newT);
                MessageBox.Show("Tournament created");
                lbTournamentUpdater();
            }
            
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbTournaments.SelectedIndex != -1 && lbTournaments.SelectedItem.ToString() == "NEW")
            {
                tournamentManager.DeleteTournament(tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1]);
                MessageBox.Show("Tournament Deleted");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int gendr = 0;

            if (rbFemale.Checked)
            {
                gendr = 1;
            }

            Tournament newT = new Tournament()
            {
                SportType = (sportTypes)cbSportType.SelectedItem,
                Description = rtbDescription.Text,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                MinPlayers = Convert.ToInt32(cbMinPlayers.Value),
                MaxPlayers = Convert.ToInt32(cbMaxPlayers.Value),
                Location = rtbAddress.Text,
                TournamentSystem = (TournamentSystems)cbTournamentSystem.SelectedItem,
                Tournamnet_id = tournamentManager.AllTournaments[lbTournaments.SelectedIndex-1].Tournamnet_id,
                Gender = gendr
                   
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(newT, null, null);
            if (!Validator.TryValidateObject(newT, context, results))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                tournamentManager.UpdateTournament(newT);
                MessageBox.Show("Tournament updated");
                lbTournamentUpdater();
            }


        }
    }
}