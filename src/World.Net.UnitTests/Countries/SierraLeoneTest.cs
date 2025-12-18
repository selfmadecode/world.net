using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SierraLeoneTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Sierra Leone";
        private const string NATIVE_NAME = "Sierra Leone";
        private const string CAPITAL = "Freetown";
        private const string OFFICIAL_NAME = "Republic of Sierra Leone";
        private const string ISO2_CODE = "SL";
        private const string ISO3_CODE = "SLE";
        private const int NUMERIC_CODE = 694;
        private readonly string[] CALLING_CODE = ["+232"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.SierraLeone;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Eastern Province", "SL-E", "Province"),
        new("Northern Province", "SL-N", "Province"),
        new("North Western Province", "SL-NW", "Province"),
        new("Southern Province", "SL-S", "Province"),
        new("Western Area", "SL-W", "Province")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSierraLeone()
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
