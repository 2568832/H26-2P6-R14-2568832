namespace InterfaceUtilisateur
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //int a = 10;
            //int b = 0;
            //// Exeption avec 
            //try
            //{
            //    int resultat = a / b;
            //    MessageBox.Show(resultat.ToString());

            //}
            //catch (DivideByZeroException e) 
            //{
            //    MessageBox.Show(e.Message);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    MessageBox.Show(e.Message);

            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Attention division par zéro !!!");

            //}


            //List<int> nombres = new List<int>() { 10, 20 };

            //nombres[3] = 45;


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormThermostat());
        }
    }
}