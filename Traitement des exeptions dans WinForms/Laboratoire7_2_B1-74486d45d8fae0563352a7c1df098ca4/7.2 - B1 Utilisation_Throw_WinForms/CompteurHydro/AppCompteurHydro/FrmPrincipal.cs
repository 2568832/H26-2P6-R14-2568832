using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppCompteurHydro
{
    public partial class FrmPrincipal : Form
    {

        private CompteurHydro m_objCompteurHydro;
        //==================================================================================================
        // Constructeur du formulaire
        public FrmPrincipal()
        {
            InitializeComponent();

            m_objCompteurHydro = new CompteurHydro();
        }
        //==================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //==================================================================================================
        private void mnuOpérationConsommer100Kw_Click(object sender, EventArgs e)
        {
            try
            {
                m_objCompteurHydro.Consommer(-100);

                lblConsommation.Text = m_objCompteurHydro.ConsommationActuelle.ToString("000000");
            }
            catch (ArgumentOutOfRangeException a)
            {
                MessageBox.Show(a.Message);
            }
            
        }
        //==================================================================================================
        private void mnuOpérationConsommer5250Kw_Click(object sender, EventArgs e)
        {
            m_objCompteurHydro.Consommer(5250);

            lblConsommation.Text = m_objCompteurHydro.ConsommationActuelle.ToString("000000");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
