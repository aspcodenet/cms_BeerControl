using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerControlCms.Rules
{
    class AlcoholeBuyingRules
    {
        public enum LocationType
        {
            None,
            Krogen,
            Systemet
        }
        static public bool CanBuyAlcohol(int age, LocationType location, bool hasLeg, decimal promille)
        {
            if (!hasLeg) return false;
            if (promille >= 1.0m) return false;
            if (age >= 18 && location == LocationType.Krogen) return true;
            if (age >= 20 && location == LocationType.Systemet) return true;
            return false;
        }
    }
}
