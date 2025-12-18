using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SingaporeTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Singapore";
        private const string NATIVE_NAME = "Singapore";
        private const string CAPITAL = "Singapore";
        private const string OFFICIAL_NAME = "Republic of Singapore";
        private const string ISO2_CODE = "SG";
        private const string ISO3_CODE = "SGP";
        private const int NUMERIC_CODE = 702;
        private readonly string[] CALLING_CODE = ["+65"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Singapore;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSingapore()
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
