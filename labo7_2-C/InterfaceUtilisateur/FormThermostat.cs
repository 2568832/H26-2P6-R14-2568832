using Modele;
using System;

namespace InterfaceUtilisateur
{
    public partial class FormThermostat : Form
    {
        Thermostat thermostat;
        public FormThermostat()
        {
            InitializeComponent();

            thermostat = new Thermostat();
            lblTemperature.Text = thermostat.Temperature.ToString();
        }

        private void btnAugmenter_Click(object sender, EventArgs e)
        {

            // TODO 02 : Attraper l'exception et afficher un MessageBox contenant un message approprié

            try
            {
                thermostat.augmenterTemperature();
                lblTemperature.Text = thermostat.Temperature.ToString();
            }
            catch (Exception ex)
            {
                // Le message d'exeption
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiminuer_Click(object sender, EventArgs e)
        {
            // TODO 03 : Attraper l'exception et afficher un MessageBox contenant un message approprié
            thermostat.diminuerTemperature();
            lblTemperature.Text = thermostat.Temperature.ToString();
        }

        private void FormThermostat_Load(object sender, EventArgs e)
        {

        }
    }
}
