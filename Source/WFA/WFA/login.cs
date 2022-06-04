using BLL;
using DAL;
using Entities;

namespace WFA;

public partial class login : Form
{
    private readonly IGameDB gameDB;
    private readonly ITournamentDB tournamentDB;
    private readonly IUserDB userDB;
    private readonly UserManager userManager;

    public login(IUserDB userDB, IGameDB gameDB, ITournamentDB tournamentDB)
    {
        InitializeComponent();
        userManager = new UserManager(userDB);
        this.userDB = userDB;
        this.gameDB = gameDB;
        this.tournamentDB = tournamentDB;
        tbPass.PasswordChar = '*';
    }

    private void btLogin_Click(object sender, EventArgs e)
    {
        if (userManager.Login(tbUser.Text, tbPass.Text))
        {
            if (userManager.GetUser(tbUser.Text).accType == AccTypes.Staff)
            {
                var fm1 = new Form1(userDB, gameDB, tournamentDB);
                Hide();
                fm1.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("you dont have the required access level");
            }
        }
        else
        {
            MessageBox.Show("wrong credentials");
        }
    }

    private void tbPass_TextChanged(object sender, EventArgs e)
    {
    }
}