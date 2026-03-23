using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Intro_aux_exceptions_en_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX1
            try
            {
                int x = int.Parse("bonjour");
                Console.WriteLine(x);
            }
            catch (Exception e)
            {
                Console.WriteLine("Écheque mot");
            }

            // Ex3

            CompteBancaire compteBancaire = new CompteBancaire();

            try
            {
                compteBancaire.Retirer(150);
            }
            catch (InvalidOperationException a)
            {
                Console.WriteLine(a.Message);
            }

            //EX4

            try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"La première ligne du fichier est : {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("fichier introuvable.");
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("dossier introuvable.");
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erreur IOException");
                Console.WriteLine(ex.Message);
            }
        }


    }
}

