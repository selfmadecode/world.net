using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class LithuaniaTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Lithuania;
        public string Name { get; } = "Lithuania";
        public string OfficialName { get; } = "Republic of Lithuania";
        public string NativeName { get; } = "Lietuvos Respublika";
        public string Capital { get; } = "Vilnius";
        public int NumericCode { get; } = 440;
        public string ISO2Code { get; } = "LT";
        public string ISO3Code { get; } = "LTU";
        public string[] CallingCode { get; } = ["+370"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Alytus County", "LT-AL", "County"),
            new("Kaunas County", "LT-KU", "County"),
            new("Klaipėda County", "LT-KL", "County"),
            new("Marijampolė County", "LT-MR", "County"),
            new("Panevėžys County", "LT-PN", "County"),
            new("Šiauliai County", "LT-SA", "County"),
            new("Tauragė County", "LT-TA", "County"),
            new("Telšiai County", "LT-TE", "County"),
            new("Utena County", "LT-UT", "County"),
            new("Vilnius County", "LT-VL", "County")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLithuania()
        {
            var country = CountryProvider.GetCountry(Id);

            AssertCorrectInformation(
                country,
                Id,
                Name,
                OfficialName,
                NativeName,
                Capital,
                NumericCode,
                ISO2Code,
                ISO3Code,
                CallingCode,
                States
            );
        }
    }
}
