using System.ComponentModel.DataAnnotations;
using BLL;
using DAL;
using Entities;

namespace WFA;

public partial class Form1 : Form
{
    private readonly TournamentManager tournamentManager;
    private int _previoslbFightsIndx;
    private int _previouslbRoundIndx;

    private bool _rChangedBFN;


    //just for easy of use
    private TournamentInPlay _selectedTournamentInPlay;

    private bool enoughPlayers;
    private IGameDB gameDB;

    public Form1(IUserDB userDB, IGameDB gameDB, ITournamentDB tournamentDB)
    {
        InitializeComponent();
        tournamentManager = new TournamentManager(tournamentDB, gameDB);
        lbTournamentUpdater();
        cbSportType.DataSource = Enum.GetValues(typeof(sportTypes));
        cbTournamentSystem.DataSource = Enum.GetValues(typeof(TournamentSystems));
        this.gameDB = gameDB;
    }

    public void lbTournamentUpdater()
    {
        lbTournaments.Items.Clear();
        lbTournaments.Items.Add("NEW");
        foreach (var t in tournamentManager.AllTournaments)
            lbTournaments.Items.Add($"{t.SportType} - {t.StartDate.ToString("d/M/yy hh:mm")}");
    }


    private void lbTournaments_SelectedIndexChanged(object sender, EventArgs e)
    {
        //CRUD Tournament
        if (lbTournaments.SelectedIndex != -1)
        {
            if (lbTournaments.SelectedItem.ToString() == "NEW")
            {
                btUpdate.Visible = false;
                btDelete.Visible = false;
                btCreate.Visible = true;

                rtbAddress.Text = "";
                rtbDescription.Text = "";
                cbSportType.SelectedIndex = 0;
                cbTournamentSystem.SelectedIndex = 0;
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
                cbMaxPlayers.Value = 2;
                cbMinPlayers.Value = 2;
            }
            else
            {
                btCreate.Visible = false;
                btUpdate.Visible = true;
                btDelete.Visible = true;

                cbSportType.SelectedItem = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].SportType
                    .ToString();
                rtbDescription.Text = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].Description;
                dtpStartDate.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].StartDate;
                dtpEndDate.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].EndDate;
                cbMinPlayers.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].MinPlayers;
                cbMaxPlayers.Value = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].MaxPlayers;
                rtbAddress.Text = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].Location;
                cbTournamentSystem.SelectedItem = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1]
                    .TournamentSystem.ToString();
                _previoslbFightsIndx = -1;
                _previouslbRoundIndx = -1;
            }
        }

        //Play tournament
        if (tabControl1.SelectedIndex == 1 && lbTournaments.SelectedIndex != 0)
        {
            if (tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].isGameStartable())
            {
                _selectedTournamentInPlay =
                    (TournamentInPlay)tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1];
                lbRound.Items.Clear();


                foreach (var r in _selectedTournamentInPlay.AllRounds) lbRound.Items.Add(r.RoundNumber);


                if (_selectedTournamentInPlay.AllRounds[0].Errmsg is not null)
                    MessageBox.Show(_selectedTournamentInPlay.AllRounds[0].Errmsg);


                enoughPlayers = true;
            }
            else
            {
                MessageBox.Show("non enough players to start the match");
                enoughPlayers = false;
                lbRound.Items.Clear();
                lbFight.Items.Clear();
            }
        }
    }

    private void btCreate_Click(object sender, EventArgs e)
    {
        var gendr = 0;

        if (rbFemale.Checked) gendr = 1;
        try
        {
            var newT = new Tournament
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
                foreach (var error in results) MessageBox.Show(error.ErrorMessage);
            }
            else
            {
                tournamentManager.AddTournament(newT);
                MessageBox.Show("Tournament created");
                lbTournamentUpdater();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btDelete_Click(object sender, EventArgs e)
    {
        if (lbTournaments.SelectedIndex != -1 && lbTournaments.SelectedItem.ToString() == "NEW")
        {
            tournamentManager.DeleteTournament(tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1]);
            MessageBox.Show("Tournament Deleted");
        }
    }

    private void btUpdate_Click(object sender, EventArgs e)
    {
        if (lbTournaments.SelectedIndex != -1)
        {
            var gendr = 0;

            if (rbFemale.Checked) gendr = 1;
            try
            {
                var newT = new Tournament
                {
                    SportType = (sportTypes)cbSportType.SelectedItem,
                    Description = rtbDescription.Text,
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    MinPlayers = Convert.ToInt32(cbMinPlayers.Value),
                    MaxPlayers = Convert.ToInt32(cbMaxPlayers.Value),
                    Location = rtbAddress.Text,
                    TournamentSystem = (TournamentSystems)cbTournamentSystem.SelectedItem,
                    Tournamnet_id = tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].Tournamnet_id,
                    Gender = gendr
                };
                var results = new List<ValidationResult>();
                var context = new ValidationContext(newT, null, null);
                if (!Validator.TryValidateObject(newT, context, results))
                {
                    foreach (var error in results) MessageBox.Show(error.ErrorMessage);
                }
                else
                {
                    tournamentManager.UpdateTournament(newT);
                    MessageBox.Show("Tournament updated");
                    lbTournamentUpdater();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void lbRound_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbFight.Items.Clear();
        if (lbRound.Items.Count >= 1 && lbRound.SelectedIndex != -1 && enoughPlayers)
        {
            foreach (var f in _selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex].Fights)
                if (f.Player1.Player is not null && f.Player2.Player is not null)
                    lbFight.Items.Add(
                        $"{f.Player1.Player.firstName},{f.Player1.Player.lastName} vs {f.Player2.Player.firstName},{f.Player2.Player.lastName}");
                else
                    lbFight.Items.Add(" . ");

            if (_previouslbRoundIndx != -1 && _previoslbFightsIndx != -1)
                _selectedTournamentInPlay.UpdatePlayerScore(_selectedTournamentInPlay.AllRounds[_previouslbRoundIndx],
                    _selectedTournamentInPlay.AllRounds[_previouslbRoundIndx].Fights[_previoslbFightsIndx],
                    Convert.ToInt32(cbPlayer1Score.Value), Convert.ToInt32(cbPlayer2Score.Value));

            _previouslbRoundIndx = lbRound.SelectedIndex;
            _rChangedBFN = true;
        }
    }

    private void lbFight_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbFight.SelectedItem != " . " && lbFight.SelectedIndex != -1 && lbRound.SelectedIndex != -1)
        {
            labContestant1.Text = _selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex]
                .Fights[lbFight.SelectedIndex].Player1.Player.firstName;
            cbPlayer1Score.Value = _selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex]
                .Fights[lbFight.SelectedIndex].Player1.Score;

            labContestant2.Text = _selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex]
                .Fights[lbFight.SelectedIndex].Player2.Player.firstName;
            cbPlayer2Score.Value = _selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex]
                .Fights[lbFight.SelectedIndex].Player2.Score;
            _previoslbFightsIndx = lbFight.SelectedIndex;
        }
        else
        {
            lbFight.SelectedIndex = -1;
        }

        if (!_rChangedBFN)
            // _gameManager.UpdatePlayerScore(_gameManager.AllRounds[_previouslbRoundIndx], _gameManager.AllRounds[_previouslbRoundIndx].Fights[_previoslbFightsIndx], Convert.ToInt32(cbPlayer1Score.Value), Convert.ToInt32(cbPlayer2Score.Value));


            _rChangedBFN = false;
    }

    //btSaveGame
    private void button1_Click(object sender, EventArgs e)
    {
        var trownEX = false;
        if (lbRound.SelectedIndex != -1 && lbFight.SelectedIndex != -1)
        {
            _selectedTournamentInPlay.UpdatePlayerScore(_selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex],
                _selectedTournamentInPlay.AllRounds[lbRound.SelectedIndex].Fights[lbFight.SelectedIndex],
                Convert.ToInt32(cbPlayer1Score.Value), Convert.ToInt32(cbPlayer2Score.Value));
            try
            {
                tournamentManager.SaveGame(_selectedTournamentInPlay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trownEX = true;
            }

            if (trownEX == false)
                MessageBox.Show("game Saved");

            lbRound.Items.Clear();
            foreach (var r in _selectedTournamentInPlay.AllRounds) lbRound.Items.Add(r.RoundNumber);
        }
    }


    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl1.SelectedIndex == 1)
            if (tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1].isGameStartable())
            {
                _selectedTournamentInPlay =
                    (TournamentInPlay)tournamentManager.AllTournaments[lbTournaments.SelectedIndex - 1];
                lbRound.Items.Clear();
                foreach (var r in _selectedTournamentInPlay.AllRounds) lbRound.Items.Add(r.RoundNumber);
            }
    }


    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    //btnManage
    private void button1_Click_1(object sender, EventArgs e)
    {
        tabControl1.SelectedTab = tabPage1;
    }

    private void btPlay_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedTab = tabPage2;
    }
}