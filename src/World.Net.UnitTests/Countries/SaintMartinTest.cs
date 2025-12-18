using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SaintMartinTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Saint-Martin";
        private const string NATIVE_NAME = "Saint-Martin";
        private const string CAPITAL = "Marigot";
        private const string OFFICIAL_NAME = "Collectivity of Saint-Martin";
        private const string ISO2_CODE = "MF";
        private const string ISO3_CODE = "MAF";
        private const int NUMERIC_CODE = 663;
        private readonly string[] CALLING_CODE = ["+590"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintMartinFrenchPart;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Saint-Martin", "MF-MF", "Territory")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSaintMartin()
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
