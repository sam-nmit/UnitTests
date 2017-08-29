using FastwayCourier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests {
    [TestClass]
    public class GettingDestinationZone_Should {
        ParcelQuoteFromNelson instance = new ParcelQuoteFromNelson();

        [TestMethod]
        public void ReturnPink_WhenPinkZoneEntered() {
            var places = new string[] {
               "motueka",
                "mapua",
                "atawhai",
                "nelson",
                "maitai",
                "hope",
                "brightwater",
                "wakefield",
                "picton",
                "renwick",
                "blenheim"
            };

            foreach (string place in places) {
                Assert.AreEqual("Pink", instance.GetDestinationZone(place));
            }

        }

        [TestMethod]
        public void ReturnBlue_WhenBlueZoneEntered() {
            var places = new string[] {
                "takaka",
                "havelock",
                "waihopai valley",
                "seddon",
                "ward",
                 "riwaka"
            };

            foreach (string place in places) {
                Assert.AreEqual("Blue", instance.GetDestinationZone(place));
            }

        }

        [TestMethod]
        public void ReturnLime_WhenLimeZoneEntered() {
            var places = new string[] {
                "murchison",
                "nelson lakes national park"
            };

            foreach (string place in places) {
                Assert.AreEqual("Lime", instance.GetDestinationZone(place));
            }

        }

        [TestMethod]
        public void ReturnOrange_WhenOrangeEntered() {
            var places = new string[] {
                "reefton",
                "hanmer springs",
                "kaikoura"
            };

            foreach (string place in places) {
                Assert.AreEqual("Orange", instance.GetDestinationZone(place));
            }

        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ThrowKeyNotFoundException_WhenPlaceIsInvalid() {
            instance.GetDestinationZone("invalid");
        }

    }
}
