using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class MacauSARTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.MacauSAR;
        public string Name { get; } = "Macau S.A.R.";
        public string OfficialName { get; } = "Macao Special Administrative Region of the People's Republic of China";
        public string NativeName { get; } = "中華人民共和國澳門特別行政區";
        public string Capital { get; } = "Macau";
        public int NumericCode { get; } = 446;
        public string ISO2Code { get; } = "MO";
        public string ISO3Code { get; } = "MAC";
        public string[] CallingCode { get; } = ["+853"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Macau Peninsula", "MO-PN", "Region"),
            new("Taipa", "MO-TA", "Region"),
            new("Coloane", "MO-CO", "Region"),
            new("Cotai", "MO-CT", "Region")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForMacauSAR()
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
