using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class GuadeloupeTest : AssertCountryTestBase
    {
        private const string GUADELOUPE_COUNTRY_NAME = "Guadeloupe";
        private const string GUADELOUPE_NATIVE_NAME = "Guadeloupe";
        private const string GUADELOUPE_CAPITAL = "Basse-Terre";
        private const string GUADELOUPE_OFFICIAL_NAME = "Guadeloupe";
        private const string GUADELOUPE_ISO2_CODE = "GP";
        private const string GUADELOUPE_ISO3_CODE = "GLP";
        private const int GUADELOUPE_NUMERIC_CODE = 312;
        private readonly string[] GUADELOUPE_CALLING_CODE = ["+590"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Guadeloupe;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = [];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForGuadeloupe()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
            AssertCorrectInformation(
                country,
                EXPECTEDID,
                GUADELOUPE_COUNTRY_NAME,
                GUADELOUPE_OFFICIAL_NAME,
                GUADELOUPE_NATIVE_NAME,
                GUADELOUPE_CAPITAL,
                GUADELOUPE_NUMERIC_CODE,
                GUADELOUPE_ISO2_CODE,
                GUADELOUPE_ISO3_CODE,
                GUADELOUPE_CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }
}
