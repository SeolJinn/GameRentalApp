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
using System.Configuration;

namespace Games_Rental_System
{
    public partial class frmAddGame : Form
    {
        public frmAddGame()
        {
            InitializeComponent();
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
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if( (mystream=openFileDialog.OpenFile()) != null)
                    {
                        pbPhoto.Image = new Bitmap(openFileDialog.FileName);
                    }
                }catch
                {
                    MessageBox.Show("Select Correct Image Type");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                string _gameName = inpGameName.Text.ToString();
                string _vendorName = inpVendorName.Text.ToString();
                string _gameAmount = inpGameAmount.Text.ToString();
                string _gamePrice = inpGamePrice.Text.ToString();
                string _gameCategory = Categories.Text.ToString();
                DateTime today = DateTime.Now;
                MemoryStream stream = new MemoryStream();
                pbPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pic = stream.ToArray();
                string _Query = "SELECT * FROM GAME WHERE G_NAME=@gameName;";
                string _Query2 = "insert into GAME (G_NAME,V_NAME,G_AMOUNT,G_PRICE,G_PHOTO,A_USERNAME,G_DATE,G_CATEGORY) VALUES (@gameName,@vendorName,@amount,@price, @pic,@user,@date,@category);";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                command.Parameters.Add(new SqlParameter("@gameName", _gameName));
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    MessageBox.Show("Game already exists");
                }
                else
                {
                    data.Close();
                    command = new SqlCommand(_Query2, con);
                    command.Parameters.Add(new SqlParameter("@gameName", _gameName));
                    command.Parameters.Add(new SqlParameter("@vendorName", _vendorName));
                    command.Parameters.Add(new SqlParameter("@amount", _gameAmount));
                    command.Parameters.Add(new SqlParameter("@price", _gamePrice));
                    command.Parameters.Add("@pic", SqlDbType.Image).Value = pic;
                    command.Parameters.Add(new SqlParameter("@user", User.User_Name));
                    command.Parameters.Add(new SqlParameter("@date", today));
                    command.Parameters.Add(new SqlParameter("@category", _gameCategory));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Game added successfully");
                    inpGameName.Text = "Enter Game Name";
                    inpVendorName.Text = "Enter Vendor Name";
                    inpGameAmount.Text = "Enter Game Amount";
                    inpGamePrice.Text = "Enter Game Price";
                    pbPhoto.Image = Properties.Resources.Logo;
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