namespace AppExceptions
{
    /// -----------------------------------------------------------------------------------------------------
    /// <summary>
    ///	 Représente une personne : son numéro d'assurance sociale et son nom.
    /// </summary>
    /// -----------------------------------------------------------------------------------------------------
    public class Personne
    {
        public string Nas { get; set; }
        public string Nom { get; set; }
        public Personne(string pInfos)
        {
            string[] tabInfos = pInfos.Split(',');
            Nas = tabInfos[0];
            Nom = tabInfos[1];
        }
        public override string ToString()
        {
            return Nom + ":" + Nas;
        }
    }
}
