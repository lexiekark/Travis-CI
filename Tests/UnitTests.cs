﻿using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

		// Implement 3 tests per operation, following a similar pattern as above

		//Subtract
		[Test]
		public void Subtract_Valid()
		{
			Assert.AreEqual(9, Program.Subtract("11", "2"));
			Assert.AreEqual(1, Program.Subtract("3", "2"));
			Assert.AreEqual(0, Program.Subtract("7", "7"));
		}

		[Test]
		public void Subtract_Invalid()
		{
			Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
			Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
			Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
		}

		[Test]
		public void Subtract_Null()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
		}

		//Multiply

		[Test]
		public void Multiply_Valid()
		{
			Assert.AreEqual(2, Program.Multiply("1", "2"));
			Assert.AreEqual(6, Program.Multiply("3", "2"));
			Assert.AreEqual(35, Program.Multiply("5", "7"));
		}

		[Test]
		public void Multiply_Invalid()
		{
			Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
			Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
			Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
		}

		[Test]
		public void Multiply_Null()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
		}

		//Divide

		[Test]
		public void Divide_Valid()
		{
			Assert.AreEqual(2, Program.Divide("2", "1"));
			Assert.AreEqual(1, Program.Divide("3", "3"));
			Assert.AreEqual(5, Program.Divide("15", "3"));
		}

		[Test]
		public void Divide_Invalid()
		{
			Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
			Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
			Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
		}

		[Test]
		public void Divide_Null()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
		}

		//Power

		[Test]
		public void Power_Valid()
		{
			Assert.AreEqual(1, Program.Power("1", "2"));
			Assert.AreEqual(9, Program.Power("3", "2"));
			Assert.AreEqual(125, Program.Power("5", "3"));
		}

		[Test]
		public void Power_Invalid()
		{
			Assert.Throws<FormatException>(() => Program.Power("1", "a"));
			Assert.Throws<FormatException>(() => Program.Power("a", "1"));
			Assert.Throws<FormatException>(() => Program.Power("a", "a"));
		}

		[Test]
		public void Power_Null()
		{
			Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
			Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
			Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
		}
	}
}
