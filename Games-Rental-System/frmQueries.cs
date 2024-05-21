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
    public partial class frmQueries : Form
    {
        public frmQueries()
        {
            InitializeComponent();
        }

        private void cbQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlCon.sqlcon);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("");
                switch (cbQueries.SelectedIndex)
                {
                    case 0:
                        command = new SqlCommand(@"
                            SELECT G_NAME
                            FROM RENT
                            GROUP BY G_NAME
                            HAVING COUNT(G_NAME) = (
                                    SELECT TOP 1 COUNT(G_NAME)

                                    FROM RENT

                                    GROUP BY G_NAME

                                    ORDER BY COUNT(G_NAME) DESC); ", con);
                        break;

                    case 1:
                        command = new SqlCommand(@"SELECT G_NAME
                        FROM GAME
                        WHERE G_NAME NOT IN(
                            SELECT G_NAME

                            FROM RENT

                            WHERE MONTH(RENT_DATE) = MONTH(GETDATE()) - 1 and YEAR(RENT_DATE) = YEAR(GETDATE())
                        ); ", con);
                        break;

                    case 2:
                        command = new SqlCommand(@"SELECT C_FIRSTNAME +' '+ C_LASTNAME AS NAME
                        FROM CLIENT
                        WHERE C_USERNAME IN
                            (
                                SELECT C_USERNAME

                                FROM RENT

                                WHERE MONTH(RENT_DATE) = MONTH(GETDATE()) - 1 and YEAR(RENT_DATE) = YEAR(GETDATE())

                                GROUP BY C_USERNAME

                                HAVING COUNT(C_USERNAME) = (
                                    SELECT TOP 1 COUNT(C_USERNAME)

                                    FROM RENT

                                    WHERE MONTH(RENT_DATE) = MONTH(GETDATE()) - 1 and YEAR(RENT_DATE) = YEAR(GETDATE())

                                    GROUP BY C_USERNAME

                                    ORDER BY COUNT(C_USERNAME) DESC)
                                ); ", con);
                        break;

                    case 3:
                        command = new SqlCommand(@"SELECT V_NAME
                        FROM GAME, RENT
                        WHERE GAME.G_NAME = RENT.G_NAME AND MONTH(RENT_DATE) = MONTH(GETDATE()) - 1 and YEAR(RENT_DATE) = YEAR(GETDATE())
                        GROUP BY V_NAME
                        HAVING  COUNT(GAME.G_NAME) = (
                            SELECT TOP 1 COUNT(GAME.G_NAME)

                            FROM GAME, RENT

                            WHERE GAME.G_NAME = RENT.G_NAME AND MONTH(RENT_DATE) = MONTH(GETDATE()) - 1 and YEAR(RENT_DATE) = YEAR(GETDATE())

                            GROUP BY V_NAME

                            ORDER BY COUNT(GAME.G_NAME)DESC); ", con);
                        break;

                    case 4:
                        command = new SqlCommand(@"SELECT V_NAME
                        FROM GAME
                        WHERE V_NAME NOT IN(
                            SELECT V_NAME

                            FROM GAME, RENT

                            WHERE GAME.G_NAME = RENT.G_NAME AND MONTH(RENT_DATE) = MONTH(GETDATE()) - 1 and YEAR(RENT_DATE) = YEAR(GETDATE())

                            GROUP BY V_NAME); ", con);
                        break;

                    case 5:
                        command = new SqlCommand(@"SELECT DISTINCT V_NAME
                        FROM GAME
                        WHERE YEAR(G_DATE) <> YEAR(GETDATE()) - 1; ", con);
                        break;

                }
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                grdData.ReadOnly = true;
                grdData.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }
        }
    }
}
