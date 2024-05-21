using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Games_Rental_System
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
            pnlUpdate.Visible = false;
            pnlGetClient.Visible = true;
        }
        private void inpUsernameSearch_Click(object sender, EventArgs e)
        {
            inpUsernameSearch.SelectAll();
        }

        private void inpClientFirstName_Click(object sender, EventArgs e)
        {
            inpClientFirstName.SelectAll();
        }

        private void inpClientSecondName_Click(object sender, EventArgs e)
        {
            inpClientSecondName.SelectAll();
        }

        private void inpClientPhone_Click(object sender, EventArgs e)
        {
            inpClientPhone.SelectAll();
        }

        private void inpClientUsername_Click(object sender, EventArgs e)
        {
            inpClientUsername.SelectAll();
        }

        private void inpCLientPassword_Click(object sender, EventArgs e)
        {
            inpCLientPassword.SelectAll();
        }

        private void inpCLientPasswordConfirm_Click(object sender, EventArgs e)
        {
            inpCLientPasswordConfirm.SelectAll();
        }
        private void getClientButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _clientUsername = inpUsernameSearch.Text.ToString();
                string _Query = "SELECT * FROM CLIENT WHERE C_USERNAME=@username;";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@username", _clientUsername));
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    inpClientUsername.Text = data["C_USERNAME"].ToString();
                    inpCLientPassword.Text = data["C_PASSWORD"].ToString();
                    inpCLientPasswordConfirm.Text = data["C_PASSWORD"].ToString();
                    inpClientPhone.Text = data["C_PHONENUM"].ToString();
                    inpClientFirstName.Text = data["C_FIRSTNAME"].ToString();
                    inpClientSecondName.Text = data["C_LASTNAME"].ToString();
                    pnlGetClient.Visible = false;
                    pnlUpdate.Visible = true;
                }
                else
                {
                    MessageBox.Show("Client doesn't exists");
                }
                    con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _clientUsernameOld = inpUsernameSearch.Text.ToString();
                string _clientUsername = inpClientUsername.Text.ToString();
                string _clientPassword = inpCLientPassword.Text.ToString();
                string _clientPasswordConfirm = inpCLientPasswordConfirm.Text.ToString();
                string _clientPhone = inpClientPhone.Text.ToString();
                string _clientFirstName = inpClientFirstName.Text.ToString();
                string _clientSecondName = inpClientSecondName.Text.ToString();
                string _Query = "UPDATE CLIENT SET C_USERNAME = @username, C_PASSWORD = @password, C_PHONENUM = @phone, C_FIRSTNAME = @firstName, C_LASTNAME = @lastName WHERE C_USERNAME = @oldusername;";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@oldusername", _clientUsernameOld));
                command.Parameters.Add(new SqlParameter("@username", _clientUsername));
                command.Parameters.Add(new SqlParameter("@password", _clientPassword));
                command.Parameters.Add(new SqlParameter("@phone", _clientPhone));
                command.Parameters.Add(new SqlParameter("@firstName", _clientFirstName));
                command.Parameters.Add(new SqlParameter("@lastName", _clientSecondName));
                command.ExecuteNonQuery();
                MessageBox.Show("Client data updated successfully");
                inpUsernameSearch.Text = "Enter Client Username";
                pnlUpdate.Visible = false;
                pnlGetClient.Visible = true;
                con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }

        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {

        }

        private void pnlUpdate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
