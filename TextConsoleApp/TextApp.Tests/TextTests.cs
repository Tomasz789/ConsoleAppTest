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
    public class TextTests
    {
        [Test]
        public void CheckIfStringNull()
        {
            Assert.Throws<ArgumentNullException>(() => TextClass.CountUnequal(null));
        }
    }
}
