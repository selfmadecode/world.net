using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SaoTomeAndPrincipeTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "São Tomé and Príncipe";
        private const string NATIVE_NAME = "São Tomé e Príncipe";
        private const string CAPITAL = "São Tomé";
        private const string OFFICIAL_NAME = "Democratic Republic of São Tomé and Príncipe";
        private const string ISO2_CODE = "ST";
        private const string ISO3_CODE = "STP";
        private const int NUMERIC_CODE = 678;
        private readonly string[] CALLING_CODE = ["+239"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaoTomeAndPrincipe;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("São Tomé", "ST-ST", "Province"),
        new("Príncipe", "ST-PN", "Province")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSaoTomeAndPrincipe()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
            AssertCorrectInformation(
                country,
                EXPECTEDID,
                COUNTRY_NAME,
                OFFICIAL_NAME,
                NATIVE_NAME,
                CAPITAL,
                NUMERIC_CODE,
                ISO2_CODE,
                ISO3_CODE,
                CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }

}
