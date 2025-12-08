using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class MadagascarTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Madagascar;
        public string Name { get; } = "Madagascar";
        public string OfficialName { get; } = "Republic of Madagascar";
        public string NativeName { get; } = "Repoblikan’i Madagasikara";
        public string Capital { get; } = "Antananarivo";
        public int NumericCode { get; } = 450;
        public string ISO2Code { get; } = "MG";
        public string ISO3Code { get; } = "MDG";
        public string[] CallingCode { get; } = ["+261"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Antananarivo", "MG-T", "Province"),
            new("Antsiranana", "MG-D", "Province"),
            new("Fianarantsoa", "MG-F", "Province"),
            new("Mahajanga", "MG-M", "Province"),
            new("Toamasina", "MG-A", "Province"),
            new("Toliara", "MG-U", "Province")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForMadagascar()
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
