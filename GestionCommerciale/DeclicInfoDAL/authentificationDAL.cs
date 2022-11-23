using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclicInfoBO;

namespace DeclicInfoDAL
{
    public class authentificationDAL
    {
        public static Utilisateur GetUtilisateur(Utilisateur unUtilisateur)
        {

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur where login_utilisateur = @username and mdp_utilisateur = @password";
            cmd.Parameters.Add(new SqlParameter("@username", unUtilisateur.Nom_utilisateur1));
            cmd.Parameters.Add(new SqlParameter("@password", unUtilisateur.Password_utilisateur1));

            SqlDataReader monReader = cmd.ExecuteReader();

            monReader.Read();

            if (monReader.HasRows)
            {
                string nom = monReader["login_utilisateur"].ToString();
                string password = monReader["mdp_utilisateur"].ToString();

                maConnexion.Close();
                return new Utilisateur( nom, password);

            }
            else
            {
                monReader.Close();
                maConnexion.Close();
                return null;

            }

        }
    }
}
