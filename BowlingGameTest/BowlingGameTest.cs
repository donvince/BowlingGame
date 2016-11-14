using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game g;

        [TestInitialize]
        public void Initialize()
        {
            g = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);
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
            RollMany(20, 1);
            Assert.AreEqual(20, g.Score());
        }
    }
}
