using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests {
    class ZoneInfo {

        public decimal Cost { get; }
        public decimal MaxWeight { get; }
        public decimal ExcessThreashHold { get; }
        public decimal ExcessMutiplier { get; }
        public decimal ExcessWeightCheckpoints { get; }
        public ZoneInfo(decimal _pricePerKG, decimal _maxWeight, decimal _excessThreashhold, decimal _excessMuktiplyer, decimal _excessWeightCheckpoints) {
            Cost = _pricePerKG;
            MaxWeight =_maxWeight;
            ExcessThreashHold = _excessThreashhold;
            ExcessMutiplier = _excessMuktiplyer;
            ExcessWeightCheckpoints = _excessWeightCheckpoints;
        }

        public ZoneInfo(decimal _pricePerKG, decimal _maxWeight) : this(_pricePerKG, _maxWeight, _maxWeight, 0, 0) {
        }

        public decimal Calculate(decimal weight) {
            if(weight > MaxWeight) {
                throw new TooHeavyException();
            }

            decimal price = 0;
            if(weight > ExcessThreashHold) {
                weight -= ExcessThreashHold;
                price = Cost;

                while (weight > 0) {
                    price += ExcessMutiplier;
                    weight -= ExcessWeightCheckpoints;
                }
            } else {
                price = Cost;
            }
            return price;
        }

    }

    class TooHeavyException : Exception { }
}
