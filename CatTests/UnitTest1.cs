using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;
namespace CatTesting
{
    [TestClass]
    public class CatTesting
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }
        [TestMethod]
        public void IsNotInitiallyTired()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.IsFalse(keyboardCat.Hungry);
            Assert.IsFalse(keyboardCat.Tired);
            keyboardCat.Eat();
            
        }
    }
}