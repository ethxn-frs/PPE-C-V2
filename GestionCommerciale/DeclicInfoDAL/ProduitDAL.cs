using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace DeclicInfoDAL
{
    public class ProduitDAL
    {
        public static List<Produit> getProduit()
        {
            string code;
            string libellé;
            string catégorie;
            int prixht;
            Produit unProduit;

            //connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Produit> Inventaire = new List<Produit>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT [code_produit], [libelle_produit], [categorie_produit].[nom_categorie_produit], [prixht_produit] FROM [produit] INNER JOIN [categorie_produit]    ON ([produit].[id_categorie_produit] = [categorie_produit].[id_categorie_produit])";
            SqlDataReader monReader = cmd.ExecuteReader();

            //Remplissage de la Liste
            while (monReader.Read())
            {
                code = monReader["code_produit"].ToString();
                if (monReader["code_produit"] == DBNull.Value)
                {
                    libellé = default(string);
                }
                else
                {
                    libellé = monReader["libelle_produit"].ToString();
                }
                if (monReader["code_produit"] == DBNull.Value)
                {
                    catégorie = default(string);
                }
                else
                {
                    catégorie = monReader["nom_categorie_produit"].ToString();
                }
                if (monReader["code_produit"] == DBNull.Value)
                {
                    prixht = default(int);
                }
                else
                {
                    prixht = (int)monReader["prixht_produit"];
                }

                unProduit = new Produit(code, libellé, catégorie, prixht);
                Inventaire.Add(unProduit);

            }

            //Fermeture de la connexion 
            maConnexion.Close();
            return Inventaire;
        }

        public static void deleteProduit(string code_produit)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@code_produit", code_produit));
            cmd.CommandText = "DELETE FROM produit WHERE code_produit = @code_produit";
            SqlDataReader monReader = cmd.ExecuteReader();
            maConnexion.Close();

        }

        public static void addProduit( string libellé_produit, int catégorie_produit, int prixht)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@libellé_produit", libellé_produit));
            cmd.Parameters.Add(new SqlParameter("@catégorie_produit", catégorie_produit));
            cmd.Parameters.Add(new SqlParameter("@prixht", prixht));
            cmd.CommandText = "INSERT INTO produit (libelle_produit, id_categorie_produit, prixht_produit) VALUES(@libellé_produit, @catégorie_produit, @prixht)";
            cmd.ExecuteNonQuery();
        }

        public static void editProduit(string code_produit, string libellé_produit, int catégorie_produit, int prixht)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@code_produit", code_produit));
            cmd.Parameters.Add(new SqlParameter("@libellé_produit", libellé_produit));
            cmd.Parameters.Add(new SqlParameter("@catégorie_produit", catégorie_produit));
            cmd.Parameters.Add(new SqlParameter("@prixht", prixht));
            cmd.CommandText = " Update produit Set libelle_produit = @libellé_produit, id_categorie_produit = @catégorie_produit, prixht_produit = @prixht where id_categorie_produit = @catégorie_produit";
            cmd.ExecuteNonQuery();
        }
    }
}
