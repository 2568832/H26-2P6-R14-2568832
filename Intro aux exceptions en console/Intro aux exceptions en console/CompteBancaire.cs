using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_aux_exceptions_en_console
{
    public class CompteBancaire
    {
        
            public double Solde { get; private set; }

            public CompteBancaire()
            {
                Solde = 100.0;
            }

            public void Retirer(double montant)
            {
                
            if (montant > Solde)
                {
                    throw new InvalidOperationException(
                        $"Impossible de retirer {montant}$ : solde insuffisant ({Solde}$)."
                    );
                }

                Solde -= montant;
            }
        

    }
}
