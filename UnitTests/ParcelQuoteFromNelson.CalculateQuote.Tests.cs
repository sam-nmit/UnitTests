using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTests {
   // [TestClass]
    public class ParcelQuoteFromNelson_CalculateQuote_Tests {

        Random r = new Random();
        ParcelQuoteFromNelson instance = new ParcelQuoteFromNelson();
        Dictionary<string, ZoneInfo> TestZones = new Dictionary<string, ZoneInfo>() {
            {"pink", new ZoneInfo(4.15m,25) },
            {"orange", new ZoneInfo(12.95m,25, 15, 6.20m, 5) },
            {"blue", new ZoneInfo(6.85m,25) },
            {"lime", new ZoneInfo(8.70m,25, 15, 6.20m, 10) },
        };

        [TestMethod]
        public void CalculateQuote_VerifyCosts() {

            // No Excess
            foreach(var zone in TestZones) {
                var weight = r.Next(1, (int)zone.Value.ExcessThreashHold);
                Debug.WriteLine(weight, zone.Key);

                Assert.AreEqual(instance.CalculateQuote(weight, zone.Key).Price, zone.Value.Calculate(weight));
            }

            
            // With excess
            foreach (var zone in TestZones) {
                var weight = r.Next((int)zone.Value.ExcessThreashHold, (int)zone.Value.MaxWeight);
                Assert.AreEqual(instance.CalculateQuote(weight, zone.Key).Price, zone.Value.Calculate(weight));
            }
            
        }

        [TestMethod]
        public void CalculateQuote_WeightOver() {
            try {
                foreach (var zone in TestZones) {
                    instance.CalculateQuote(zone.Value.MaxWeight + 1, zone.Key);
                }
            } catch (ArgumentOutOfRangeException) {

            }
            
        }
    }
}
