using System;
using System.Windows.Forms;

namespace AppCompteurHydro
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Représente un compteur hydro électrique 
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class CompteurHydro
    {

        #region CHAMPS (variable membre) ET PROPRIÉTÉ

        ///==================================================================================
        private int m_consommationActuelle;
        /// ---------------------------------------------------------------------------------
        /// <summary>
        ///    Obtient la consommation totale actuelle 
        /// </summary>
        public int ConsommationActuelle
        {
            get { return m_consommationActuelle; }
        }

        #endregion

        #region CONSTRUCTEUR

        ///==================================================================================
        /// <summary>
        ///   Initialise une nouvelle instance. 
        /// </summary>
        public CompteurHydro()
        {
            m_consommationActuelle = 0;
        }

        #endregion

        #region MÉTHODE

        ///==================================================================================
        /// <summary>
        /// Augmente la quantité d'électricité consommée.
        /// </summary>
        /// <param name="pQuantitéKwh">Quantité d'électricité à ajouter au compteur</param>
        public void Consommer(int pQuantitéKwh)
        {
            // TODO 01 : Ajouter le code nécessaire pour lancer une exception lorsque pQuantitéKwh est négatif.
            // L'exception à lancer est ArgumentOutOfRangeException
            if (pQuantitéKwh < 0)
            {
                throw new ArgumentOutOfRangeException();
                m_consommationActuelle += pQuantitéKwh;
            }

        }

        #endregion
    }
}
