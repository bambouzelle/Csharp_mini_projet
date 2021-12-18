using System;
using System.Collections.Generic;

namespace projet_csharp_2
{
    public class gens
    {
        public string prenom { get; set; }
        public decimal argent_deposer { get; set; }
    }
    public class Algo
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            decimal moyenne = 0;
            List<gens> nb_gens = new List<gens>();
            List<gens> personne_qui_Doit = new List<gens>();
            List<gens> personnd_qui_recoivent = new List<gens>();
            nb_gens.Add(new gens() { prenom = "damien", argent_deposer = 50 });
            nb_gens.Add(new gens() { prenom = "jean", argent_deposer = 10 });
            nb_gens.Add(new gens() { prenom = "oui", argent_deposer = 10 });
            nb_gens.Add(new gens() { prenom = "oui2", argent_deposer = 30 });
            nb_gens.Add(new gens() { prenom = "philipe", argent_deposer = 25 });
            nb_gens.Add(new gens() { prenom = "oui3", argent_deposer = 15 });

            moyenne = Calculer_moyenne(nb_gens);

            foreach (gens gens in nb_gens)
            {
                gens.argent_deposer = Math.Round (gens.argent_deposer - moyenne,2, MidpointRounding.ToZero);
                if (gens.argent_deposer > 0)
                {
                    personnd_qui_recoivent.Add(gens);
                }
                if (gens.argent_deposer < 0)
                {
                    personne_qui_Doit.Add(gens);
                } 
            }
                while ( count < personnd_qui_recoivent.Count)
                {
                    if (personnd_qui_recoivent[count].argent_deposer <= -personne_qui_Doit[count2].argent_deposer)
                    {
                        personne_qui_Doit[count2].argent_deposer = personnd_qui_recoivent[count].argent_deposer+personne_qui_Doit[count2].argent_deposer;
                        Console.WriteLine(personne_qui_Doit[count2].prenom + " doit " + personnd_qui_recoivent[count].argent_deposer + " euro a " + personnd_qui_recoivent[count].prenom);
                        count++;
                    }
                    else
                    {
                        personnd_qui_recoivent[count].argent_deposer = personnd_qui_recoivent[count].argent_deposer + personne_qui_Doit[count2].argent_deposer;
                        Console.WriteLine(personne_qui_Doit[count2].prenom + " doit " + -personne_qui_Doit[count2].argent_deposer + " euro a " + personnd_qui_recoivent[count].prenom);
                        count2++;
                    }
                }
        }
        public static decimal Calculer_moyenne(List<gens> nb_gens)
        {
            decimal argent_total = 0;
            decimal argent_a_rendre = 0;
            int nb_personne = 0;

            foreach (gens gens in nb_gens)
            {
                argent_total = Math.Round(argent_total + gens.argent_deposer, 2, MidpointRounding.ToZero);
                nb_personne++;
            }

            argent_a_rendre = Math.Round(argent_total / nb_personne,3,MidpointRounding.ToEven);

            return argent_a_rendre;
        }
    }
}
