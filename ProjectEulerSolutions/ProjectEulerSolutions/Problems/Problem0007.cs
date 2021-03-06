﻿using ConceptualMath.Numbers.Generation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Numerics;

namespace ProjectEulerSolutions
{
    [TestClass]
    public class Problem0007
    {
        /*
         * By listing the first six prime numbers:
         * 
         *      2, 3, 5, 7, 11, and 13, 
         *      
         *  we can see that the 6th prime is 13.

            What is the 10,001st prime number?
         */

        [TestMethod]
        public void SixthPrimeNumber_Is13()
        {
            var n = 6;
            BigInteger selectedPrime = nthPrime(n);

            Assert.AreEqual(13, selectedPrime);
        }

        [TestMethod]
        public void TenThousandAndFirstPrimeNumber_Is104743()
        {
            var n = 10001;
            BigInteger selectedPrime = nthPrime(n);

            Assert.AreEqual(104743, selectedPrime);
        }

        private static BigInteger nthPrime(int n)
        {
            return Sequences.Primes()
                            .Skip(n - 1)
                            .First();
        }
    }
}
