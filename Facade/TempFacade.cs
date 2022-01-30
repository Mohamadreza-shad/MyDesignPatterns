using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class TempFacade
    {
        public int TempratureInCentigrade(string postalCode)
        {
            var zoneFinder = new ZoneFinder();
            int zone = zoneFinder.FindZone(postalCode);

            var tempService = new TempratureService();
            int tempInF = tempService.GetTempInFahrenheit(zone);

            var tempConvertor = new TempratureConvertor();
            int tempInC = tempConvertor.CalculateTempInC(tempInF);
            return tempInC;
        }
    }
}