using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class GuamTest : AssertCountryTestBase
    {
        private const string GUAM_COUNTRY_NAME = "Guam";
        private const string GUAM_NATIVE_NAME = "Guam";
        private const string GUAM_CAPITAL = "Hagåtña";
        private const string GUAM_OFFICIAL_NAME = "Guam";
        private const string GUAM_ISO2_CODE = "GU";
        private const string GUAM_ISO3_CODE = "GUM";
        private const int GUAM_NUMERIC_CODE = 316;
        private readonly string[] GUAM_CALLING_CODE = ["+1-671"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Guam;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForGuam()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
            AssertCorrectInformation(
                country,
                EXPECTEDID,
                GUAM_COUNTRY_NAME,
                GUAM_OFFICIAL_NAME,
                GUAM_NATIVE_NAME,
                GUAM_CAPITAL,
                GUAM_NUMERIC_CODE,
                GUAM_ISO2_CODE,
                GUAM_ISO3_CODE,
                GUAM_CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }
}
