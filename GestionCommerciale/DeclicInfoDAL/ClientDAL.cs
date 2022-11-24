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
    public class ClientDAL
    {
        public static List<Client> getClients()
        {
            string Code;
            string Nom;
            string Adresse_livraison_client_num;
            string Adresse_livraison_client_rue;
            string Adresse_livraison_client_ville;
            string Adresse_livraison_client_code_postal;
            string Adresse_facturation_client_num;
            string Adresse_facturation_client_rue;
            string Adresse_facturation_client_ville;
            string Adresse_facturation_client_code_postal;
            string Telephone;
            string Fax;
            string Email;
            Client unClient;

            //connexion BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Client
            List<Client> listClients = new List<Client>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT [code_client] ,[nom_client], [adresse_facture_client_ville], [adresse_facture_client_code_postal], [adresse_facture_client_rue], [adresse_facture_client_num], [adresse_livraison_client_ville], [adresse_livraison_client_code_postal], [adresse_livraison_client_rue], [adresse_livraison_client_num], [telephone_client], [fax_client], [email_client] FROM [gestionClient].[dbo].[client]";
            SqlDataReader monReader = cmd.ExecuteReader();

            //Remplissage de la Liste
            while (monReader.Read())
            {
                Code = monReader["code_client"].ToString();
                if (monReader["code_client"] == DBNull.Value)
                {
                    Nom = default(string);
                }
                else
                {
                    Nom = monReader["nom_client"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_livraison_client_num = default(string);
                }
                else
                {
                    Adresse_livraison_client_num = monReader["adresse_livraison_client_num"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_livraison_client_rue = default(string);
                }
                else
                {
                    Adresse_livraison_client_rue = monReader["adresse_livraison_client_rue"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_livraison_client_ville = default(string);
                }
                else
                {
                    Adresse_livraison_client_ville = monReader["adresse_livraison_client_ville"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_livraison_client_code_postal = default(string);
                }
                else
                {
                    Adresse_livraison_client_code_postal = monReader["adresse_livraison_client_code_postal"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_facturation_client_num = default(string);
                }
                else
                {
                    Adresse_facturation_client_num = monReader["adresse_facture_client_num"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_facturation_client_rue = default(string);
                }
                else
                {
                    Adresse_facturation_client_rue = monReader["adresse_facture_client_rue"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_facturation_client_ville = default(string);
                }
                else
                {
                    Adresse_facturation_client_ville = monReader["adresse_facture_client_ville"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_facturation_client_code_postal = default(string);
                }
                else
                {
                    Adresse_facturation_client_code_postal = monReader["adresse_facture_client_code_postal"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Telephone = default(string);
                }
                else
                {
                    Telephone = monReader["telephone_client"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Fax = default(string);
                }
                else
                {
                    Fax = monReader["fax_client"].ToString();
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Email = default(string);
                }
                else
                {
                    Email = monReader["email_client"].ToString();
                }

                unClient = new Client(Code, Nom, Adresse_livraison_client_num, Adresse_livraison_client_rue, Adresse_livraison_client_ville, Adresse_livraison_client_code_postal, Adresse_facturation_client_num, Adresse_facturation_client_rue,
                Adresse_facturation_client_ville, Adresse_facturation_client_code_postal, Telephone, Fax, Email);
                listClients.Add(unClient);

            }

            //Fermeture de la connexion 
            maConnexion.Close();
            return listClients;
        }

        public static void deleteClient(string code_client)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@code_client", code_client));
            cmd.CommandText = "DELETE FROM client WHERE code_client = @code_client";
            SqlDataReader monReader = cmd.ExecuteReader();
            maConnexion.Close();

        }
    }
}
