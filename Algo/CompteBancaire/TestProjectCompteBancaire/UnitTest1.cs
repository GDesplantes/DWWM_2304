using CL_CompteBancaire;
namespace TestProjectCompteBancaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCrediter()
        {
            CompteBancaire compteSchoumi = new CompteBancaire();
            compteSchoumi.Crediter(125d,false,compteSchoumi);
            Assert.IsTrue(compteSchoumi.SoldeActuel == 250);
            
        }

        [TestMethod]

        public void TestMethodDebiter()
        {
            CompteBancaire compteSchoumi =new CompteBancaire();
            bool ok = compteSchoumi.Debite(50,false,compteSchoumi);
            Assert.IsTrue(ok);
            Assert.IsTrue(compteSchoumi.SoldeActuel == 75);
        }

        [TestMethod]

        public void TestMethodSoldeSuperieur()
        {
            CompteBancaire compteSchoumi = new CompteBancaire();
            CompteBancaire compteKay = new CompteBancaire(-15, "Kay", 58123541, 5000);
            bool okSuperieur = compteKay.SoldeSuperieur(compteSchoumi);
            Assert.IsTrue(okSuperieur);

        }
        
        [TestMethod]

        public void TestMethodTransferer()
        {
            CompteBancaire compteSchoumi = new CompteBancaire();
            CompteBancaire compteKay = new CompteBancaire(-15, "Kay", 58123541, 5000);
            bool oktransfert = compteSchoumi.Transferer(25, compteKay);
            Assert.IsTrue(oktransfert);
            Assert.IsTrue(compteSchoumi.SoldeActuel == 100);
        }


    }
}