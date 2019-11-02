using System.Collections.Generic;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_Three_Int_To_New_Stack_Return_Count_Of_3()
        {
            List<int> numbers = new List<int>{1, 2, 3};

            Fundamentals.Stack<int> testStack = new Fundamentals.Stack<int>();

            foreach(var x in numbers)
            {
                testStack.Push(x);
            }

            Assert.That(testStack.Count, Is.EqualTo(numbers.Count));
        }

        [Test]
        public void Push_Three_Strings_To_New_Stack_Return_Count_Of_3()
        {

        }
    }
}