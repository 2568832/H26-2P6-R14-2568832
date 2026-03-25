using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace AppExceptions
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Exercice 1 - Intercepter une exception de la classe Thermostat
        private void BtnExemple1_Click(object sender, EventArgs e)
        {
            // DÉCOMMENTEZ
            Thermostat objThermostat;
            try
            {
                objThermostat = new Thermostat(999);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion

        #region Exercice 2 - Intercepter une exception provenant d'une erreur de manipulation d'un tableau 1D
        private void BtnExemple2_Click(object sender, EventArgs evt)
        {
            // DÉCOMMENTEZ
            int[] tab = new int[5];
            try
            {
                tab[10] = 99;

            }
            catch (Exception a)
            { 
                MessageBox.Show(a.Message);
            }
        }

        #endregion


        #region Exercice 3 - Intercepter les exceptions provenant d'une erreur de conversion 
        private void BtnExemple3_Click(object sender, EventArgs evt)
        {
            // DÉCOMMENTEZ

            try
            {
                string chaine1 = null;
                string chaine2 = "abcd";
                int nombre = 0;
                nombre = int.Parse(chaine1);
                MessageBox.Show("La valeur de nombre est : " + nombre.ToString());
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (NullReferenceException b)
            {
                MessageBox.Show(b.Message);
            }

        }
        #endregion

        #region Exercice 4 - Intercepter une exception survenant en cours de lecture
        private void BtnExemple4_Click(object sender, EventArgs evt)
        {
            // DÉCOMMENTEZ
            List<Personne> colPersonnes = new List<Personne>();

            try
            {
                StreamReader objStreamReader = new StreamReader("ListeDesPersonnes.txt");
                while (!objStreamReader.EndOfStream)
                {
                    string uneLigneLue = objStreamReader.ReadLine();
                    Personne unePersonne = new Personne(uneLigneLue);
                    colPersonnes.Add(unePersonne);


                }
                objStreamReader.Close();
                MessageBox.Show("Le nombre de personnes dans la liste est de : " + colPersonnes.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            
        }
        #endregion

        #region MnuFichierQuitter_Click
        private void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
