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
        public static Utilisateur GetUtilisateur(String userName)
        {

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur where login_utilisateur = @username";
            cmd.Parameters.Add(new SqlParameter("@username", userName));

            SqlDataReader monReader = cmd.ExecuteReader();

            monReader.Read();

            if (monReader.HasRows)
            {
                int id;
                int.TryParse(monReader["id_utilisateur"].ToString(), out id);
                string nom = monReader["login_utilisateur"].ToString();
                string password = monReader["mdp_utilisateur"].ToString();

                maConnexion.Close();
                return new Utilisateur(id, nom, password);

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
