using FastwayCourier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests {
    [TestClass]
    public class GettingParcelQuoteFromNelson_Should {

        ParcelQuoteFromNelson instance = new ParcelQuoteFromNelson();


        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ThrowKeyNotFoundException_When_InvaldZone() {
            string zone = "memes";

            instance.CalculateQuote(26, zone);
        }


        [TestMethod]
        public void Return4_15When1Or25Withpink() {

            decimal maxSize = 25m;
            decimal expected = 4.15m;
            string zone = "pink";


            Assert.AreEqual(expected, instance.CalculateQuote(1, zone).Price);
            Assert.AreEqual(expected, instance.CalculateQuote(maxSize, zone).Price);
        }

        [TestMethod]
        public void Return12_95When1Or15Withorange() {

            decimal maxSize = 15m;
            decimal expected = 12.95m;
            string zone = "orange";


            Assert.AreEqual(expected, instance.CalculateQuote(1, zone).Price);
            Assert.AreEqual(expected, instance.CalculateQuote(maxSize, zone).Price);
        }

        [TestMethod]
        public void Return6_95When1Or25Withblue() {

            decimal maxSize = 25m;
            decimal expected = 6.95m;
            string zone = "blue";


            Assert.AreEqual(expected, instance.CalculateQuote(1, zone).Price);
            Assert.AreEqual(expected, instance.CalculateQuote(maxSize, zone).Price);
        }

        [TestMethod]
        public void Return8_70When1Or15Withlime() {

            decimal maxSize = 15m;
            decimal expected = 8.70m;
            string zone = "lime";


            Assert.AreEqual(expected, instance.CalculateQuote(1, zone).Price);
            Assert.AreEqual(expected, instance.CalculateQuote(maxSize, zone).Price);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_0Withpink() {
            string zone = "pink";

            instance.CalculateQuote(0, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_0Withorange() {
            string zone = "orange";

            instance.CalculateQuote(0, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_0Withblue() {
            string zone = "blue";

            instance.CalculateQuote(0, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_0Withlime() {
            string zone = "lime";

            instance.CalculateQuote(0, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_26Withpink() {
            string zone = "pink";

            instance.CalculateQuote(26, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_26Withorange() {
            string zone = "orange";

            instance.CalculateQuote(26, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_26Withblue() {
            string zone = "blue";

            instance.CalculateQuote(26, zone);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowArgumentOutOfRangeException_When_26Withlime() {
            string zone = "lime";

            instance.CalculateQuote(26, zone);
        }

        [TestMethod]
        public void Return19_15when_1ExtraTicketorange() {
            string zone = "orange";
            decimal size = 16;
            decimal expectedCost = 19.15m;

            var res = instance.CalculateQuote(size, zone);
            Assert.AreEqual(expectedCost, res.Price);
            Assert.AreEqual(1, res.ExcessTickets);
        }

        [TestMethod]
        public void Return25_35when_2ExtraTicketorange() {
            string zone = "orange";
            decimal size = 21;
            decimal expectedCost = 25.35m;

            var res = instance.CalculateQuote(size, zone);
            Assert.AreEqual(expectedCost, res.Price);
            Assert.AreEqual(2, res.ExcessTickets);
        }

        [TestMethod]
        public void Return14_90when_1ExtraTicketlime() {
            string zone = "lime";
            decimal size = 16;
            decimal expectedCost = 14.90m;

            var res = instance.CalculateQuote(size, zone);
            Assert.AreEqual(expectedCost, res.Price);
            Assert.AreEqual(1, res.ExcessTickets);
        }


    }
}
