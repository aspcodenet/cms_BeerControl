using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerControlCms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du leg J/N?");
            var hasLeg = Console.ReadLine() == "J";

            Console.WriteLine("Hur gammal är du?");
            var ageInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Var är du (1=krogen, 2=systemet)");
            var locationInput= Console.ReadLine();
            var locationType = Rules.AlcoholeBuyingRules.LocationType.None;
            if(locationInput == "1")
                locationType = Rules.AlcoholeBuyingRules.LocationType.Krogen;
            else if (locationInput == "2")
                locationType = Rules.AlcoholeBuyingRules.LocationType.Systemet;

            Console.WriteLine("Vad är din promillehalt");
            var promilleHalt = Convert.ToDecimal(Console.ReadLine());

            var canBuy = Rules.AlcoholeBuyingRules.CanBuyAlcohol(
                ageInput, locationType, hasLeg, promilleHalt);
            if (canBuy)
                Console.WriteLine("Hurra");

        }
    }
}
