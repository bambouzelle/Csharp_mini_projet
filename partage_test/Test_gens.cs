using projet_csharp_2;
using System;
using Xunit;

namespace partage_test
{
    public class Test_gens
    {
        [Fact]
        public void creation_gens()
        {
            var nom = "jean-françois";
            var argent_mis = 26;

            var personne = new gens() { prenom = nom, argent_deposer = argent_mis };

            Assert.NotNull(personne);
            Assert.IsType<gens>(personne);
            Assert.Equal(argent_mis, personne.argent_deposer);
            Assert.Equal(nom, personne.prenom);
        }
    }
}
