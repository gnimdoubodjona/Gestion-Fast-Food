using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace GestionFastFood
{
    public partial class AfficherMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            //Address du server sql et de la base de donnée
            String Connection = "Data Source=DESKTOP-ICJ0M76\\SQLEXPRESS;Initial Catalog=FastFood;Integrated Security=True";


            //Etablir la connexion
            SqlConnection con = new SqlConnection(Connection);

            //Ouvrir une connexion
            con.Open();

            //Préparer une requete
            String Query = "SELECT PlatsMenu, Prix,HeureDeDisponibiliteDuPlats FROM Menu";

            //Excecuter la requete
            SqlCommand cmd = new SqlCommand(Query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            
            GridView1.DataSource = reader;
            GridView1.DataBind();

            //Fermer la connexion
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

    }
}