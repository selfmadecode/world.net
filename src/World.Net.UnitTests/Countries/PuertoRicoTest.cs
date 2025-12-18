using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class PuertoRicoTest : AssertCountryTestBase
    {
        private const string PR_COUNTRY_NAME = "Puerto Rico";
        private const string PR_NATIVE_NAME = "Puerto Rico";
        private const string PR_CAPITAL = "San Juan";
        private const string PR_OFFICIAL_NAME = "Commonwealth of Puerto Rico";
        private const string PR_ISO2_CODE = "PR";
        private const string PR_ISO3_CODE = "PRI";
        private const int PR_NUMERIC_CODE = 630;
        private readonly string[] PR_CALLING_CODE = ["+1-787", "+1-939"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.PuertoRico;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Puerto Rico", "PR-PR", "Territory")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForPuertoRico()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
            AssertCorrectInformation(
                country,
                EXPECTEDID,
                PR_COUNTRY_NAME,
                PR_OFFICIAL_NAME,
                PR_NATIVE_NAME,
                PR_CAPITAL,
                PR_NUMERIC_CODE,
                PR_ISO2_CODE,
                PR_ISO3_CODE,
                PR_CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }

}
