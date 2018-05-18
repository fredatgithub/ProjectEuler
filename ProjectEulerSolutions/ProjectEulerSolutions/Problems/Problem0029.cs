﻿using ConceptualMath.Numbers.Generation;
using ConceptualMath.Numbers.Prime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static ConceptualMath.Numbers.Generation.Sequences;

namespace ProjectEulerSolutions
{

    [TestClass]
    public class Problem0029
    {
        /*
         * Consider all integer combinations of a^b for 2 ≤ a ≤ 5 and 2 ≤ b ≤ 5:

            2^2=4, 2^3=8, 2^4=16, 2^5=32
            3^2=9, 3^3=27, 3^4=81, 3^5=243
            4^2=16, 4^3=64, 4^4=256, 4^5=1024
            5^2=25, 5^3=125, 5^4=625, 5^5=3125
            If they are then placed in numerical order, with any repeats removed,
            we get the following sequence of 15 distinct terms:

            4, 8, 9, 16, 25, 27, 32, 64, 81, 125, 243, 256, 625, 1024, 3125

            How many distinct terms are in the sequence generated by ab for 
            2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?
        */
        [TestMethod]
        public void NumberOfDistinctTermsInCombinationsOfAToTheBForAAndBBetween2And5_Is15()
        {
            var n = 5;
            var result = NumbersBetween(2, n + 1)
                .FullJoin(
                    NumbersBetween(2, n + 1),
                    (a, b) => BigInteger.Pow(a, (int)b)
                ).ToHashSet()
                .Count();

            Assert.AreEqual(15, result);
        }


        [TestMethod]
        public void NumberOfDistinctTermsInCombinationsOfAToTheBForAAndBBetween2And100_Is9183()
        {
            //brute force method for maximum development time efficiency /s
            var n = 100;
            var result = NumbersBetween(2, n + 1)
                .FullJoin(
                    NumbersBetween(2, n + 1),
                    (a, b) => BigInteger.Pow(a, (int)b)
                ).ToHashSet()
                .Count();

            Assert.AreEqual(9183, result);
        }
    }
}