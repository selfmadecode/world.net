using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class LiechtensteinTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Liechtenstein;
        public string Name { get; } = "Liechtenstein";
        public string OfficialName { get; } = "Principality of Liechtenstein";
        public string NativeName { get; } = "Fürstentum Liechtenstein";
        public string Capital { get; } = "Vaduz";
        public int NumericCode { get; } = 438;
        public string ISO2Code { get; } = "LI";
        public string ISO3Code { get; } = "LIE";
        public string[] CallingCode { get; } = ["+423"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Balzers", "LI-01", "Municipality"),
            new("Eschen", "LI-02", "Municipality"),
            new("Gamprin", "LI-03", "Municipality"),
            new("Mauren", "LI-04", "Municipality"),
            new("Planken", "LI-05", "Municipality"),
            new("Ruggell", "LI-06", "Municipality"),
            new("Schaan", "LI-07", "Municipality"),
            new("Schellenberg", "LI-08", "Municipality"),
            new("Triesen", "LI-09", "Municipality"),
            new("Triesenberg", "LI-10", "Municipality"),
            new("Vaduz", "LI-11", "Municipality")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLiechtenstein()
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
