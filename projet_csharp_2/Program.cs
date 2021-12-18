using System;
using System.Collections.Generic;

namespace projet_csharp_2
{
    public class gens
    {
        public string prenom { get; set; }
        public decimal argent_deposer { get; set; }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            decimal argent_total = 0;
            decimal argent_a_rendre = 0;
            int nb_personne = 0;
            int count = 0;
            int count2 = 0;
            List<gens> nb_gens = new List<gens>();
            List<gens> personne_qui_Doit = new List<gens>();
            List<gens> personnd_qui_recoivent = new List<gens>();
            nb_gens.Add(new gens() { prenom = "damien", argent_deposer = 50 });
            nb_gens.Add(new gens() { prenom = "jean", argent_deposer = 10 });
            nb_gens.Add(new gens() { prenom = "oui", argent_deposer = 10 });
            nb_gens.Add(new gens() { prenom = "oui2", argent_deposer = 30 });
            nb_gens.Add(new gens() { prenom = "philipe", argent_deposer = 25 });

            foreach (gens gens in nb_gens)
            {
                argent_total = argent_total + gens.argent_deposer;
                nb_personne++;
            }

            argent_a_rendre = argent_total / nb_personne;

            foreach (gens gens in nb_gens)
            {
                gens.argent_deposer = gens.argent_deposer - argent_a_rendre;
                if (gens.argent_deposer > 0)
                {
                    personnd_qui_recoivent.Add(gens);
                }
                if (gens.argent_deposer < 0)
                {
                    personne_qui_Doit.Add(gens);
                } 
            }
            foreach (gens gens in personnd_qui_recoivent)
            {
                while (personnd_qui_recoivent[count].argent_deposer != 0)
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
        }
    }
}
