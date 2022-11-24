using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Produit
    {
        private string _code;
        private string _libellé;
        Categorie uneCategorie;
        private int _prixht;

        public string Code { get => _code; set => _code = value; }
        public string Libellé { get => _libellé; set => _libellé = value; }
        public Categorie categorie { get => uneCategorie; set => uneCategorie = value; }
        public int Prixht { get => _prixht; set => _prixht = value; }


        public Produit(string code, string libellé, Categorie categorie, int prixht)
        {
            _code = code;
            _libellé = libellé;
            uneCategorie = categorie;
            _prixht = prixht;
        }
    }
}

