using CL_Bouteille;

namespace TestUnitaireBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBouteilleOuvrirEtatOuvert()
        {
            Bouteille bOuvrir = new Bouteille();//bt ouverte
            bool ok = bOuvrir.Ouvrir();
            Assert.IsTrue(ok == false);//ou Asset.IsFalse(ok)
            Assert.IsTrue(bOuvrir.Ouverte == true);
        }

        [TestMethod]
        public void TestMethodBouteilleOuvrirEtatFermer()
        {
            Bouteille bfermer = new Bouteille();
            bool ok = bfermer.Fermer();
            Assert.IsTrue(ok);
            Assert.IsTrue(bfermer.Ouverte == false);
        }

    }

    // public class TestBouteille
    // {
    //  public void TestMethodBouteilleOuvrirEtatFermer()
    // {
    //     Bouteille bfermer = new Bouteille();
    //     bool ok = bfermer.Fermer();
    //    Assert.IsTrue(ok);
    //    Assert.IsTrue(bfermer.Ouverte == false);
    // }
    //}
}