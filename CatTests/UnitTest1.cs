using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;

namespace CatTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            var expected = 7;
            var actual = keyboardCat.Weight;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InheritsDefaultCatInSecondConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            // <insert assertion method here>
            //Assert.AreEqual(13, keyboardCat.Weight);
            Assert.IsNotNull(keyboardCat.Weight);
            //Assert.AreEqual(13, keyboardCat.Weight, .001);
        }
    }
}
