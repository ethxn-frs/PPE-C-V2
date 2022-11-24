using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DeclicInfoDAL;
using System.Runtime.Remoting.Messaging;

namespace DeclicInfoBLL
{
    public class ClientBLL
    {
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexionde la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<Client> getClients()
        {
            return ClientDAL.getClients();
        }

        public static void deleteClient (string code)
        {
            ClientDAL.deleteClient(code);
        }
    }
}