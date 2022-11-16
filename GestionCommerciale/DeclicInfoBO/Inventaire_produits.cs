    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclicInfoBO
{
    public class Inventaire_Produits
    {
        private List<Produit> ListProduits;

        public Inventaire_Produits()
        {
            ListProduits = new List<Produit>();
        }

        public int NbrProduits
        {
            get { return ListProduits.Count; }
        }

        public void AjouterProduit(Produit unProduit)
        {
            ListProduits.Add(unProduit);
        }

        public void EnleverProduit(Produit unProduit)
        {
            ListProduits.Remove(unProduit);
        }

        public bool Exister(Produit unProduit)
        {
            return ListProduits.Contains(unProduit);
        }

        public List<Produit> ListeProduits()
        {
            return ListProduits;
        }
    }
}
