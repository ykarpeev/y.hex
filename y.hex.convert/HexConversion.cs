﻿// <copyright file="HexConversion.cs" company="Youri">
// Copyright (c) Youri. All rights reserved.
// </copyright>

namespace y.hex.convert
{
    using System;
    using System.Buffers.Binary;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// Hex to integer conversion supporting signed 2's complement.
    /// </summary>
    public static class HexConversion
    {
        /// <summary>
        /// Convert from hex string to an integer.
        /// </summary>
        /// <param name="hex">Hex value.</param>
        /// <returns>Integer value.</returns>
        public static int FromHex(this string hex)
        {
            var ba = Enumerable.Range(0, hex.Length / 2).
                Select(x => Convert.ToByte(hex.Substring(x * 2, 2), 16));

            var span = new ReadOnlySpan<byte>(ba.Reverse().ToArray());

            if (hex.Length == 4)
            {
                return BinaryPrimitives.ReadInt16LittleEndian(span);
            }
            else
            {
                return BinaryPrimitives.ReadInt32LittleEndian(span);
            }
        }
    }
}