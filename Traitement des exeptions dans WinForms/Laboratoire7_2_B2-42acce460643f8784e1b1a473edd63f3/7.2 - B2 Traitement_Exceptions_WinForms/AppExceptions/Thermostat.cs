using System;

namespace AppExceptions
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Modélise un thermostat électronique contrôlant la température d'une 
    /// plinthe de chauffage.
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class Thermostat
    {
        #region Constantes
        /// ================================================================================
        /// <summary>
        /// Température minimale autorisée par un Thermostat
        /// </summary>
        public const double MIN_TEMPERATURE = 5.0;

        /// ================================================================================
        /// <summary>
        /// Température maximale autorisée par un Thermostat
        /// </summary>
        public const double MAX_TEMPERATURE = 35.0;

        /// ================================================================================
        /// <summary>
        /// Température initiale d'un Thermostat
        /// </summary>
        private const double TEMPERATURE_DÉFAUT = 20.0;

        #endregion

        #region CHAMPS (variable membre) ET PROPRIÉTÉ
        ///==================================================================================
        private double m_temperature;
        /// ---------------------------------------------------------------------------------
        /// <summary>
        ///    Obtient la température actuelle du thermostat
        /// </summary>
        public double Temperature
        {
            get { return m_temperature; }
            protected set
            {
                if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
                    throw new ArgumentOutOfRangeException();
                m_temperature = value;
            }
    }
        #endregion

        #region CONSTRUCTEUR
        ///======================================================================================
        /// <summary>
        ///   Initialise une nouvelle instance de la classe Thermostat. 
        /// </summary>
        ///--------------------------------------------------------------------------------------
        public Thermostat(double pTemperature = TEMPERATURE_DÉFAUT)
        {
            Temperature = pTemperature;
        }

        #endregion

        #region MÉTHODES
        ///==================================================================================
        /// <summary>
        ///   Augmente la température d'un degré.
        /// </summary>
        /// ---------------------------------------------------------------------------------
        public void AugmenterTemperature()
        {
            Temperature++;
        }
        ///==================================================================================
        /// <summary>
        ///   Diminue la température d'un degré.
        /// </summary>
        /// ---------------------------------------------------------------------------------
        public void DiminuerTemperature()
        {
            Temperature--;
        }

        #endregion
    }
}
