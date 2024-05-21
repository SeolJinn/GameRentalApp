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
    public partial class GameItem : UserControl
    {
        private SqlDataReader _game;
        public GameItem()
        {
            InitializeComponent();
        }
        public GameItem(SqlDataReader game) :this()
        {
            _game = game;
            TName.Text = _game["G_NAME"].ToString();
            TPrice.Text = _game["G_PRICE"].ToString()+"$";
            TAmount.Text = _game["G_AMOUNT"].ToString()+" CDs";
            MemoryStream ms = new MemoryStream((byte[])_game["G_PHOTO"]);
            Image img = new Bitmap(ms);
            pbPhoto.Image = img;
            if (User.isAdmin)
            {
                rentButton.Visible = false;
                returnButton.Visible = false;
            }
            else
            {
                rentButton.Visible = true;
                returnButton.Visible = true;
            }
            if ((int)_game["G_AMOUNT"] == 0)
            {
                rentButton.Enabled = false;
            }
            else
            {
                rentButton.Enabled = true;
            }
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _gamename = TName.Text.ToString();
                string _username = User.User_Name;
                int _amount = Int32.Parse(TAmount.Text.ToString().Remove(TAmount.Text.ToString().Length - 4));
                DateTime _today = DateTime.Now;
                string _Query = "SELECT * FROM RENT WHERE C_USERNAME=@username AND G_NAME=@gamename AND RETURN_DATE IS NULL;";
                string _Query2 = "insert into RENT (C_USERNAME,G_NAME,RENT_DATE) VALUES (@username,@gamename,@rentdate);";
                string _Query3 = "UPDATE GAME SET G_AMOUNT = G_AMOUNT - 1 WHERE G_NAME = @gamename; ";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@username", _username));
                command.Parameters.Add(new SqlParameter("@gamename", _gamename));
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    MessageBox.Show("Game already Rented you need to return it first");
                }
                else
                {
                    data.Close();
                    command = new SqlCommand(_Query2, con);
                    command.Parameters.Add(new SqlParameter("@username", _username));
                    command.Parameters.Add(new SqlParameter("@gamename", _gamename));
                    command.Parameters.Add(new SqlParameter("@rentdate", _today));
                    command.ExecuteNonQuery();
                    command = new SqlCommand(_Query3, con);
                    command.Parameters.Add(new SqlParameter("@gamename", _gamename));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Game rented successfully");
                    _amount--;
                    if (_amount == 0)
                    {
                        rentButton.Enabled = false;
                    }
                    else
                    {
                        rentButton.Enabled = true;
                    }
                    TAmount.Text = _amount.ToString() + " CDs";

                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _gamename = TName.Text.ToString();
                string _username = User.User_Name;
                String _p = TPrice.Text.ToString();
                float _price = float.Parse(_p.Remove(_p.Length - 1));
                int _amount = Int32.Parse(TAmount.Text.ToString().Remove(TAmount.Text.ToString().Length - 4));
                DateTime _today = DateTime.Now;
                string _Query = "SELECT * FROM RENT WHERE C_USERNAME=@username AND G_NAME=@gamename AND RETURN_DATE IS NULL ;";
                string _Query2 = "UPDATE RENT SET RETURN_DATE=@returndate WHERE C_USERNAME=@username AND G_NAME=@gamename AND RETURN_DATE IS NULL;";
                string _Query3 = "UPDATE GAME SET G_AMOUNT = G_AMOUNT + 1 WHERE G_NAME = @gamename; ";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@username", _username));
                command.Parameters.Add(new SqlParameter("@gamename", _gamename));
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                        DateTime rentDate = (DateTime)data["RENT_DATE"];
                        data.Close();
                        command = new SqlCommand(_Query2, con);
                        int totalDays = (_today - rentDate).Days;
                        if ((_today - rentDate).Hours > 0 || (_today - rentDate).Minutes > 0)
                        {
                            totalDays++;
                        }
                        double _pay = totalDays * _price;
                        command.Parameters.Add(new SqlParameter("@username", _username));
                        command.Parameters.Add(new SqlParameter("@gamename", _gamename));
                        command.Parameters.Add(new SqlParameter("@returndate", _today));
                        command.ExecuteNonQuery();
                        command = new SqlCommand(_Query3, con);
                        command.Parameters.Add(new SqlParameter("@gamename", _gamename));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Game Returned successfully and you should pay " + _pay.ToString() + "$ for renting the game for " + totalDays.ToString() + " days");
                        _amount++;
                        if (_amount == 0)
                        {
                            rentButton.Enabled = false;
                        }
                        else
                        {
                            rentButton.Enabled = true;
                        }
                    TAmount.Text = _amount.ToString()+" CDs";

                }
                else
                {
                MessageBox.Show("You have to rent the Game first");
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }
        }
    }
}
