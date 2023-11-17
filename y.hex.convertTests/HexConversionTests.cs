// <copyright file="HexConversionTests.cs" company="Youri">
// Copyright (c) Youri. All rights reserved.
// </copyright>

namespace y.hex.convert.Tests
{
    using NUnit.Framework;
    using y.hex.convert;

    [TestFixture()]
    public class HexConversionTests
    {
        [TestCase("FFFFD8F0", -10000)]
        [TestCase("FFEE", -18)]
        [TestCase("00F1", 241)]
        [TestCase("00008C09", 35849)]
        public void FromHexTest(string hexString, int expected)
        {
            Assert.That(hexString.FromHex, Is.EqualTo(expected));
        }
    }
}