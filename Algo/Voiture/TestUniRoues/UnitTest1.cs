using CL_Voiture;

namespace TestUniRoues
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodRoueStop()
        {
            Roue roueAArreter = new Roue();
            bool ok = roueAArreter.Stopper();
            Assert.IsFalse(ok);
        }

        [TestMethod]
        public void TestMethodRoueTourne()
        {
            Roue roueATourner = new Roue();
            bool ok = roueATourner.Tourner();
            Assert.IsTrue(ok);
        }

       // [TestMethod]

       // public void 
    }
}