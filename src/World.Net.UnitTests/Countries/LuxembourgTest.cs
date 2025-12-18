using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class LuxembourgTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Luxembourg;
        public string Name { get; } = "Luxembourg";
        public string OfficialName { get; } = "Grand Duchy of Luxembourg";
        public string NativeName { get; } = "Groussherzogtum Lëtzebuerg";
        public string Capital { get; } = "Luxembourg City";
        public int NumericCode { get; } = 442;
        public string ISO2Code { get; } = "LU";
        public string ISO3Code { get; } = "LUX";
        public string[] CallingCode { get; } = ["+352"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Capellen", "LU-CA", "Canton"),
            new("Clervaux", "LU-CL", "Canton"),
            new("Diekirch", "LU-DI", "Canton"),
            new("Echternach", "LU-EC", "Canton"),
            new("Esch-sur-Alzette", "LU-ES", "Canton"),
            new("Grevenmacher", "LU-GR", "Canton"),
            new("Luxembourg", "LU-LU", "Canton"),
            new("Mersch", "LU-ME", "Canton"),
            new("Redange", "LU-RD", "Canton"),
            new("Remich", "LU-RM", "Canton"),
            new("Vianden", "LU-VD", "Canton"),
            new("Wiltz", "LU-WI", "Canton")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLuxembourg()
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
