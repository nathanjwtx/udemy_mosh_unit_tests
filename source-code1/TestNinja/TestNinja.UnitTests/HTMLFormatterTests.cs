using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HTMLFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // Strings are casesensitive. Use .ignorecase if not required to be casesensitive

            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // More General
//            Assert.That(result, Does.StartWith("<strong>"));
//            Assert.That(result, Does.EndWith("</strong>"));
//            Assert.That(result, Does.Contain("abc"));
        }

    }
}
