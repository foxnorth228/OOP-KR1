using NUnit.Framework;
using KR1;
using System;
using System.Collections.Generic;

namespace KR1.Tests
{
    public class MapEditorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KeyPressedTest()
        {
            char[] arr = new char[] { 'a', 'b', 'c' };
            List<char> list = new List<char>(arr);
            Assert.False(MapEditor.KeyPressed('a', list));
            Assert.True(MapEditor.KeyPressed('d', list));
            Assert.True(MapEditor.KeyPressed('a', null));
        }

        [Test]
        public void BorderChangedTest()
        {
            Assert.AreEqual(MapEditor.BorderChanged("5", 20), "5");
            Assert.AreEqual(MapEditor.BorderChanged("s", 20), "");
            Assert.AreEqual(MapEditor.BorderChanged("21", 20), "20");
        }

        [Test]
        public void CreateBorderTest()
        {
            Assert.AreEqual(MapEditor.CreateBorder(1, "5", 20), 5);
            Assert.AreEqual(MapEditor.CreateBorder(1, "21", 20), 20);
            Assert.AreEqual(MapEditor.CreateBorder(1, "", 20), 1);
            Assert.Throws<ArgumentException>(() => MapEditor.CreateBorder(1, "ss", 20));
        }
    }
}