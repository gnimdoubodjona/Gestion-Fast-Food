using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace GestionFastFood
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Address du  server sql et de la base de donnée
            String Connection = "Data Source=DESKTOP-ICJ0M76\\SQLEXPRESS;Initial Catalog=FastFood;Integrated Security=True";



            //Etablir la connexion
            SqlConnection con = new SqlConnection(Connection);

            //Ouvrir la connexion
            con.Open();

            //Preparer la requete

            String PlatsMenu = TextBox1.Text;
            String Prix = TextBox2.Text;
            String HeureDeDisponibiliteDuPlats = TextBox3.Text;

            String Query = "INSERT INTO Menu(PlatsMenu,Prix,HeureDeDisponibiliteDuPlats) VALUES('" + PlatsMenu + "','" + Prix + "','" + HeureDeDisponibiliteDuPlats + "') ";


            //excecuter la requete
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                cmd.Parameters.AddWithValue("@PlatsMenu", PlatsMenu);
                cmd.Parameters.AddWithValue("@Prix", Prix);
                cmd.Parameters.AddWithValue("@HeureDeDisponibiliteDuPlats", HeureDeDisponibiliteDuPlats);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "Swal.fire('Succès', 'Votre Plat à été ajouter avec succès.', 'success');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "Swal.fire('Échec', 'Aucun Plat n\'a été ajouter.', 'error');", true);
                }
            }

            //Close connection
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AfficherMenu.aspx");
        }

    }
    }
