using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Fundamentals.Stack<int> _stack;

        [SetUp]
        public void Setup()
        {
            _stack = new Fundamentals.Stack<int>();
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
        }

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
            List<string> strings = new List<string>{"hello nathan", "this is a longer string", "wibble"};

            Fundamentals.Stack<string> testStack = new Fundamentals.Stack<string>();

            foreach (string s in strings)
            {
                testStack.Push(s);
            }

            Assert.That(testStack.Count, Is.EqualTo(strings.Count));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Push_No_Value_Expected_Throws_Error()
        {
            Fundamentals.Stack<string> strings = new Fundamentals.Stack<string>();

            Assert.Throws<ArgumentNullException>(() => strings.Push(null));
        }

        [Test]
        public void Pop_Returns_Last_Value_In_Stack()
        {
            Fundamentals.Stack<int> numbers = new Fundamentals.Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            Assert.AreEqual(numbers.Pop(), 3);
        }
        
        [Test]
        public void Pop_Throws_InvalidOperationException_When_Called_On_Empty_Stack()
        {
            Fundamentals.Stack<int> numbers = new Fundamentals.Stack<int>();

            Assert.That(() => numbers.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_Removes_Popped_Item_From_List()
        {
            _stack.Pop();
            
            Assert.AreEqual(_stack.Count, 2);
        }

        [Test]
        public void Peek_Return_Last_Item_In_Stack()
        {
            int actualResult = _stack.Peek();

            Assert.AreEqual(actualResult, 3);
        }

        [Test]
        public void Peek_Throws_InvalidOperationException_When_Stack_Is_Empty()
        {
            Fundamentals.Stack<string> strings = new Fundamentals.Stack<string>();

            Assert.Throws<InvalidOperationException>(() => strings.Peek());
        }

        [Test]
        public void Peek_Does_Not_Remove_Last_Item_From_Stack()
        {
            _stack.Peek();

            Assert.AreEqual(_stack.Count, 3);
        }
    }
}