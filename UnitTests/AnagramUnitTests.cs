using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram_Finder;

namespace UnitTests
{
    [TestClass]
    public class AnagramUnitTests
    {
        private AnagramFinder finder;
        private InputValidator validator;


        [TestInitialize]
        public void TestInitialize()
        {
            finder = new AnagramFinder();
            validator = new InputValidator();
        }

        [TestMethod]
        public void ValidationTest_InputContainsInt()
        {
            string testInput = "fn1id";
            Assert.IsFalse(validator.InputValid(testInput));
        }
        
        [TestMethod]
        public void ValidationTest_InputContainsSpecialChar()
        {
            string testInput = "@_!$&";
            Assert.IsFalse(validator.InputValid(testInput));
        }
        
        [TestMethod]
        public void ValidationTest_InputIsEmpty()
        {
            string testInput = "";
            Assert.IsFalse(validator.InputValid(testInput));
        }

        [TestMethod]
        public void ValidationTest_InputIsNull()
        {
            string testInput = null;
            Assert.IsFalse(validator.InputValid(testInput));
        }

        [TestMethod]
        public void FinderTest_AnagramsFound()
        {
            string testInput = "spear";

            if(!validator.InputValid(testInput))
                Assert.Fail("Invalid string used");

            List<string> anagrams = finder.findAnagrams(testInput);

            if (anagrams.Count <= 0)
            {
                Assert.Fail("No anagrams returned from valid input");
            }
        }


    }
}
