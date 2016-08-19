﻿using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEulerTests.Problems
{
    public class Problem150Tests
    {
        private Problem150 _instance;

        [SetUp]
        public void SetUp()
        {
            _instance = new Problem150();
        }

        [Test]
        public void Single()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { 1 };
            jaggedArray[1] = new[] { 1, -150 };
            jaggedArray[2] = new[] { 1, 1, 1 };

            //act
            var actual = _instance.GetSmallestSubtriangleSum(jaggedArray, 1);

            //assert
            Assert.That(actual[0], Is.EqualTo(-150));
        }

        [Test]
        public void SmallTriganle()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { 1 };
            jaggedArray[1] = new[] { 1, -1 };
            jaggedArray[2] = new[] { 1, -1, -1 };

            //act
            var actual = _instance.GetSmallestSubtriangleSum(jaggedArray, 1);

            //assert
            Assert.That(actual[0], Is.EqualTo(-3));
        }

        [Test]
        public void WholeTriangle()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { -1 };
            jaggedArray[1] = new[] { -1, -1 };
            jaggedArray[2] = new[] { -1, -1, -1 };

            //act
            var actual = _instance.GetSmallestSubtriangleSum(jaggedArray, 1);

            //assert
            Assert.That(actual[0], Is.EqualTo(-6));
        }

        [Test]
        public void Multiple()
        {
            //arrange
            var jaggedArray = new int[4][];
            jaggedArray[0] = new[] { -1 };
            jaggedArray[1] = new[] { -1, -1 };
            jaggedArray[2] = new[] { -1, -1, -1 };
            jaggedArray[3] = new[] { -1, -1, -1, -1 };

            //act
            var actual = _instance.GetSmallestSubtriangleSum(jaggedArray, 3);

            //assert
            Assert.That(actual[0], Is.EqualTo(-10));
            Assert.That(actual[1], Is.EqualTo(-6));
            Assert.That(actual[2], Is.EqualTo(-6));
        }

        [Test]
        public void Example()
        {
            //arrange
            var jaggedArray = new int[6][];
            jaggedArray[0] = new[] { 15 };
            jaggedArray[1] = new[] { -14, -7 };
            jaggedArray[2] = new[] { 20, -13, -5 };
            jaggedArray[3] = new[] { -3, 8, 23, -26 };
            jaggedArray[4] = new[] { 1, -4, -5, -18, 5 };
            jaggedArray[5] = new[] { -16, 31, 2, 9, 28, 3 };

            //act
            var actual = _instance.GetSmallestSubtriangleSum(jaggedArray, 5);

            //assert
            Assert.That(actual[0], Is.EqualTo(-42));
            Assert.That(actual[1], Is.EqualTo(-39));
            Assert.That(actual[2], Is.EqualTo(-26));
            Assert.That(actual[3], Is.EqualTo(-26 ));
            Assert.That(actual[4], Is.EqualTo(-25));
        }
    }
}
