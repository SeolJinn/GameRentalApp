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
using System.IO;

namespace Games_Rental_System
{
    public partial class frmUpdateGame : Form
    {
        public frmUpdateGame()
        {
            InitializeComponent();
            pnlUpdate.Visible = false;
            pnlGetGame.Visible = true;
        }

        private void inpGameName_Click(object sender, EventArgs e)
        {
            inpGameName.SelectAll();
        }

        private void inpVendorName_Click(object sender, EventArgs e)
        {
            inpVendorName.SelectAll();

        }

        private void inpGameAmount_Click(object sender, EventArgs e)
        {
            inpGameAmount.SelectAll();
        }

        private void inpGamePrice_Click(object sender, EventArgs e)
        {
            inpGamePrice.SelectAll();
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            Stream? mystream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = openFileDialog.OpenFile()) != null)
                    {
                        pbPhoto.Image = new Bitmap(openFileDialog.FileName);
                    }
                }
                catch
                {
                    MessageBox.Show("Select Correct Image Type");
                }
            }
        }

        private void getGameButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _Gamename = inpGamenameSearch.Text.ToString();
                string _Query = "SELECT * FROM GAME WHERE G_NAME=@gamename;";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@gamename", _Gamename));
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    inpGameName.Text = data["G_NAME"].ToString();
                    inpVendorName.Text = data["V_NAME"].ToString();
                    inpGameAmount.Text = data["G_AMOUNT"].ToString();
                    inpGamePrice.Text = data["G_PRICE"].ToString();
                    Categories.Text = data["G_CATEGORY"].ToString();
                    MemoryStream ms = new MemoryStream((byte[])data["G_PHOTO"]);
                    Image img = new Bitmap(ms);
                    pbPhoto.Image = img;
                    pnlGetGame.Visible = false;
                    pnlUpdate.Visible = true;
                }
                else
                {
                    MessageBox.Show("Game doesn't exists");
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
                string _gameOldName = inpGamenameSearch.Text.ToString();
                string _gameName = inpGameName.Text.ToString();
                string _vendorName = inpVendorName.Text.ToString();
                string _gameAmount = inpGameAmount.Text.ToString();
                string _gamePrice = inpGamePrice.Text.ToString();
                string _gameCategory = Categories.Text.ToString();
                MemoryStream stream = new MemoryStream();
                pbPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pic = stream.ToArray();
                string _Query = "UPDATE GAME SET G_NAME=@gameName, V_NAME=@vendorName, G_AMOUNT=@amount, G_PRICE=@price, G_PHOTO=@pic, G_CATEGORY=@category WHERE G_NAME=@gameOldname;";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@gameOldname", _gameOldName));
                command.Parameters.Add(new SqlParameter("@gameName", _gameName));
                command.Parameters.Add(new SqlParameter("@vendorName", _vendorName));
                command.Parameters.Add(new SqlParameter("@amount", _gameAmount));
                command.Parameters.Add(new SqlParameter("@price", _gamePrice));
                command.Parameters.Add("@pic", SqlDbType.Image).Value = pic;
                command.Parameters.Add(new SqlParameter("@category", _gameCategory));
                command.ExecuteNonQuery();
                MessageBox.Show("Game data updated successfully");
                inpGamenameSearch.Text = "Enter Game Name";
                pnlUpdate.Visible = false;
                pnlGetGame.Visible = true;
                con.Close();

            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }
        }
    }
}
