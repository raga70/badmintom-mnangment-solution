using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Entities;

namespace WFA
{
    public partial class login : Form
    {
        private UserManager userManager;
        private IUserDB userDB;
        private IGameDB gameDB;
        private ITournamentDB tournamentDB;
        public login(IUserDB userDB, IGameDB gameDB, ITournamentDB tournamentDB)
        {
            InitializeComponent();
            userManager = new UserManager(userDB);
            this.userDB = userDB;
            this.gameDB = gameDB;
            this.tournamentDB = tournamentDB;

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (userManager.Login(tbUser.Text, tbPass.Text))
            {
                if (userManager.GetUser(tbUser.Text).accType == AccTypes.Staff)
                {
                    Form1 fm1 = new Form1(userDB, gameDB, tournamentDB);
                    this.Hide();
                    fm1.ShowDialog();
                    this.Close();
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
    }
}
