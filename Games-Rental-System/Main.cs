using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace Games_Rental_System
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            pnlNav.Height = browseButton.Height;
            pnlNav.Top = browseButton.Top;
            pnlNav.Left = browseButton.Left;
            frmBrowse frmBrowse_vrb = new frmBrowse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBrowse_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmBrowse_vrb);
            frmBrowse_vrb.Show();
            if (User.isAdmin)
            {
                addGameButton.Visible = true;
                updateGameButton.Visible = true;
                addClientButton.Visible = true;
                updateClientButton.Visible = true;
                registerButton.Visible = true;
                queriesButton.Visible = true;
            }
            else
            {
                addGameButton.Visible = false;
                updateGameButton.Visible = false;
                addClientButton.Visible = false;
                updateClientButton.Visible = false;
                registerButton.Visible = false;
                queriesButton.Visible=false;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = browseButton.Height;
            pnlNav.Top = browseButton.Top;
            pnlNav.Left = browseButton.Left;
            browseButton.BackColor = Color.FromArgb(46, 51, 73);

            
            this.pnlFormLoader.Controls.Clear();
            frmBrowse frmBrowse_vrb = new frmBrowse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBrowse_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmBrowse_vrb);
            frmBrowse_vrb.Show();


        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = addGameButton.Height;
            pnlNav.Top = addGameButton.Top;
            addGameButton.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmAddGame frmAddGame_vrb = new frmAddGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddGame_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAddGame_vrb);
            frmAddGame_vrb.Show();
        }

        private void updateGameButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = updateGameButton.Height;
            pnlNav.Top = updateGameButton.Top;
            updateGameButton.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmUpdateGame frmUpdateGame_vrb = new frmUpdateGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmUpdateGame_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmUpdateGame_vrb);
            frmUpdateGame_vrb.Show();
            
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = addClientButton.Height;
            pnlNav.Top = addClientButton.Top;
            addClientButton.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmAddClient frmAddClient_vrb = new frmAddClient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddClient_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAddClient_vrb);
            frmAddClient_vrb.Show();
            
        }
        private void updateClientButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = updateClientButton.Height;
            pnlNav.Top = updateClientButton.Top;
            updateClientButton.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmUpdateClient frmUpdateclient_vrb = new frmUpdateClient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmUpdateclient_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmUpdateclient_vrb);
            frmUpdateclient_vrb.Show();
        }

        private void queriesButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = queriesButton.Height;
            pnlNav.Top = queriesButton.Top;
            queriesButton.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmQueries frmQueries_vrb = new frmQueries() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmQueries_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmQueries_vrb);
            frmQueries_vrb.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login Login_vrb = new Login();
            this.Hide();
            Login_vrb.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {        
            new Register().Show();
        }

        private void browseButton_Leave(object sender, EventArgs e)
        {
            browseButton.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void addGameButton_Leave(object sender, EventArgs e)
        {
            addGameButton.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void updateGameButton_Leave(object sender, EventArgs e)
        {
            updateGameButton.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void addClientButton_Leave(object sender, EventArgs e)
        {
            addClientButton.BackColor = Color.FromArgb(24, 17, 68);
        }
        private void updateClientButton_Leave(object sender, EventArgs e)
        {
            updateClientButton.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void registerButton_Leave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void queriesButton_Leave(object sender, EventArgs e)
        {
            queriesButton.BackColor = Color.FromArgb(24, 17, 68);
        }
    }
}
