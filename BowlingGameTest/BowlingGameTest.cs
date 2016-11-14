using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        /*
         * Code Smell tracker:
         * - Roll loop is duplicated
         */

        private Game g;

        [TestInitialize]
        public void Initialize()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            var n = 20;
            int pins = 0;
            RollMany(n, pins);
            Assert.AreEqual(0, g.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.Roll(pins);
            }
        }

        [TestMethod]
        public void TestAllOnes()
        {
            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }
            Assert.AreEqual(20, g.Score());
        }
    }
}
