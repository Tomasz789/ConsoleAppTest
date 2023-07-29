using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextApp.Lib;

namespace TextApp.Tests
{
    [TestFixture]
    public class TextLibTests
    {
        [Test]

        public void TextLibEmptyString_ReturnsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TextClass.CountUnequal(string.Empty));
        }

        [Test]

        public void TextLibNullString_ReturnsArgumentNullException()
        {
            string? text = null;
            Assert.Throws<ArgumentNullException>(() => TextClass.CountUnequal(text));
        }

        [TestCase("a", ExpectedResult = 1)]
        [TestCase("ba", ExpectedResult = 2)]
        [TestCase("aaa", ExpectedResult = 1)]
        [TestCase("apple", ExpectedResult = 3)]
        [TestCase("banana", ExpectedResult = 1)]
        [TestCase("Dog", ExpectedResult = 3)]

        public int TextLibValidString_ReturnsCount(string text)
        {
            return TextClass.CountUnequal(text);
        }
    }
}
