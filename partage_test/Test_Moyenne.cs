using projet_csharp_2;
using System;
using System.Collections.Generic;
using Xunit;

namespace partage_test
{
    public class Test_Moyenne 
    {
        [Fact]
        public void test_Moyenne()
        {
            List<gens> nb_test = new List<gens>();
            decimal moyenne = 0;

            nb_test.Add(new gens() { prenom = "Jean_françois", argent_deposer = 30 });
            nb_test.Add(new gens() { prenom = "jean", argent_deposer = 40 });
            nb_test.Add(new gens() { prenom = "Damien", argent_deposer = 70 });
            nb_test.Add(new gens() { prenom = "Patrick", argent_deposer = 60 });
            nb_test.Add(new gens() { prenom = "Aled", argent_deposer = 30 });
            nb_test.Add(new gens() { prenom = "je_sais_pas", argent_deposer = 48 });

            moyenne = Algo.Calculer_moyenne(nb_test);

            Assert.Equal(moyenne, (decimal)46.333);
        }
    }
}