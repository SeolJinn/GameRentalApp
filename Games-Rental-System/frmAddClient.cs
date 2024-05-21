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
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _clientUsername = inpClientUsername.Text.ToString();
                string _clientPassword = inpCLientPassword.Text.ToString();
                string _clientPasswordConfirm = inpCLientPasswordConfirm.Text.ToString();
                string _clientPhone = inpClientPhone.Text.ToString();
                string _clientFirstName = inpClientFirstName.Text.ToString();
                string _clientSecondName = inpClientSecondName.Text.ToString();
                string _Query = "SELECT C_USERNAME FROM CLIENT WHERE C_USERNAME=@username;";
                string _Query2 = "insert into CLIENT (C_USERNAME,C_PHONENUM,C_FIRSTNAME,C_LASTNAME,C_PASSWORD) VALUES (@username,@phone,@firstName,@lastName,@password);";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@username", _clientUsername));
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    MessageBox.Show("Client already exists");
                }
                else
                {
                    data.Close();
                    if (_clientPassword == _clientPasswordConfirm)
                    {
                        command = new SqlCommand(_Query2, con);
                        command.Parameters.Add(new SqlParameter("@username", _clientUsername));
                        command.Parameters.Add(new SqlParameter("@password", _clientPassword));
                        command.Parameters.Add(new SqlParameter("@phone", _clientPhone));
                        command.Parameters.Add(new SqlParameter("@firstName", _clientFirstName));
                        command.Parameters.Add(new SqlParameter("@lastName", _clientSecondName));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Client added successfully");
                        inpClientFirstName.Text = "Enter Client First Name";
                        inpClientSecondName.Text = "Enter Client Second Name";
                        inpClientPhone.Text = "Enter Client Phone Number";
                        inpClientUsername.Text = "Enter Client Username";
                        inpCLientPassword.Text = "Enter Client Password";
                        inpCLientPasswordConfirm.Text = "Enter Client Password";
                    }
                    else
                    {

                        MessageBox.Show("The two passwords are not the same");
                    }
                }
                con.Close();
            
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

    }
    
}
