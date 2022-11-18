using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Categorie
    {
        private string _id;
        private string _libelle;

        public Categorie(string id, string libelle)
        {
            _id = id;
            _libelle = libelle;
        }

        public string Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }

    }
}
