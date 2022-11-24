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
            int Adresse_livraison_client_num;
            string Adresse_livraison_client_rue;
            string Adresse_livraison_client_ville;
            int Adresse_livraison_client_code_postal;
            int Adresse_facturation_client_num;
            string Adresse_facturation_client_rue;
            string Adresse_facturation_client_ville;
            int Adresse_facturation_client_code_postal;
            int Telephone;
            int Fax;
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
                    Adresse_livraison_client_num = default(int);
                }
                else
                {
                    Adresse_livraison_client_num = Int32.Parse(monReader["adresse_livraison_client_num"].ToString()) ;
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
                    Adresse_livraison_client_code_postal = default(int);
                }
                else
                {
                    Adresse_livraison_client_code_postal = Int32.Parse(monReader["adresse_livraison_client_code_postal"].ToString()) ;
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Adresse_facturation_client_num = default(int);
                }
                else
                {
                    Adresse_facturation_client_num = Int32.Parse(monReader["adresse_facture_client_num"].ToString());
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
                    Adresse_facturation_client_code_postal = default(int);
                }
                else
                {
                    Adresse_facturation_client_code_postal = Int32.Parse(monReader["adresse_facture_client_code_postal"].ToString()) ;
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Telephone = default(int);
                }
                else
                {
                    Telephone = Int32.Parse(monReader["telephone_client"].ToString());
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Fax = default(int);
                }
                else
                {
                    Fax = Int32.Parse(monReader["fax_client"].ToString());
                }
                if (monReader["code_client"] == DBNull.Value)
                {
                    Email = default(string);
                }
                else
                {
                    Email = monReader["email_client"].ToString();
                }

                unClient = new Client(Code ,Nom, Adresse_livraison_client_num, Adresse_livraison_client_rue, Adresse_livraison_client_ville, Adresse_livraison_client_code_postal, Adresse_facturation_client_num, Adresse_facturation_client_rue,
                Adresse_facturation_client_ville, Adresse_facturation_client_code_postal, Telephone, Fax, Email);
                listClients.Add(unClient);

            }

            //Fermeture de la connexion 
            maConnexion.Close();
            return listClients;
        }
        public static void addClient(Client unClient)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@nom", unClient.Nom));
            cmd.Parameters.Add(new SqlParameter("@email", unClient.Email));
            cmd.Parameters.Add(new SqlParameter("@fax", unClient.Fax));
            cmd.Parameters.Add(new SqlParameter("@telephone", unClient.Telephone));
            cmd.Parameters.Add(new SqlParameter("@adresse_facturation_num", unClient.Adresse_facturation_client_num));
            cmd.Parameters.Add(new SqlParameter("@adresse_facturation_rue", unClient.Adresse_facturation_client_rue));
            cmd.Parameters.Add(new SqlParameter("@adresse_facturation_ville", unClient.Adresse_facturation_client_ville));
            cmd.Parameters.Add(new SqlParameter("@adresse_facturation_code_postal", unClient.Adresse_facturation_client_code_postal));
            cmd.Parameters.Add(new SqlParameter("@adresse_livraison_num", unClient.Adresse_livraison_client_num));
            cmd.Parameters.Add(new SqlParameter("@adresse_livraison_rue", unClient.Adresse_livraison_client_rue));
            cmd.Parameters.Add(new SqlParameter("@adresse_livraison_ville", unClient.Adresse_livraison_client_ville));
            cmd.Parameters.Add(new SqlParameter("@adresse_livraison_code_postal", unClient.Adresse_livraison_client_code_postal));
            cmd.CommandText = "INSERT INTO client (nom_client, telephone_client, fax_client, email_client, adresse_facture_client_ville, adresse_facture_client_num, adresse_facture_client_rue,adresse_facture_client_code_postal, adresse_livraison_client_ville, adresse_livraison_client_num, adresse_livraison_client_rue, adresse_livraison_client_code_postal) VALUES (@nom, @telephone, @fax, @email, @adresse_facturation_ville, @adresse_facturation_num, @adresse_facturation_rue, @adresse_facturation_code_postal, @adresse_livraison_ville, @adresse_livraison_num, @adresse_livraison_rue, @adresse_livraison_code_postal)";
            cmd.ExecuteNonQuery();
        }
    }
}
