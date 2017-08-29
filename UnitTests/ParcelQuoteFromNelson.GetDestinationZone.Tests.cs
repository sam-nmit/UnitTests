using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;
using System.Collections.Generic;

namespace UnitTests {
 //   [TestClass]
    public class ParcelQuoteFromNelson_GetDestinationZone_Tests {

        ParcelQuoteFromNelson instance = new ParcelQuoteFromNelson();

        [TestMethod]
        public void GetDestinationZone_ValidInputs() {

            var zones = new Dictionary<string, string>() {
                {"mapua", "Pink"},
                {"atawhai", "Pink"},
                {"nelson", "Pink"},
                {"maitai", "Pink"},
                {"hope", "Pink"},
                {"brightwater", "Pink"},
                {"wakefield", "Pink"},
                {"picton", "Pink"},
                {"renwick", "Pink"},
                {"blenhiem", "Pink"},
                {"takaka", "Blue"},
                {"havelock", "Blue"},
                {"waihopai valley", "Blue"},
                {"seddon", "Blue"},
                {"ward", "Blue"},
                {"murchison", "Lime"},
                {"nelson lakes national park", "Lime"},
                {"reefton", "Orange"},
                {"hanmer springs", "Orange"},
                {"kaikoura", "Orange"}
            };


            foreach(var zone in zones) {
                Assert.AreEqual(instance.GetDestinationZone(zone.Key), zone.Value, true);
            }
            

        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException), AllowDerivedTypes =true)]
        public void GetDestinationZone_InvalidInput() {

            instance.GetDestinationZone("unknownPlace");

        }

        [TestMethod]
        public void GetDestinationZone_WrongZone() {

            var zones = new Dictionary<string, string>() {
                {"mapua", "red"},
                {"atawhai", "green"},
                {"nelson", "meme"},
                {"maitai", "blue"},
                {"hope", "red"},
                {"brightwater", "purple"},
            };

            foreach (var zone in zones) {
                Assert.AreNotEqual(instance.GetDestinationZone(zone.Key), zone.Value, true);
            }

        }



    }
}
