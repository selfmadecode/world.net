using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SaintKittsAndNevisTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Saint Kitts and Nevis";
        private const string NATIVE_NAME = "Saint Kitts and Nevis";
        private const string CAPITAL = "Basseterre";
        private const string OFFICIAL_NAME = "Federation of Saint Kitts and Nevis";
        private const string ISO2_CODE = "KN";
        private const string ISO3_CODE = "KNA";
        private const int NUMERIC_CODE = 659;
        private readonly string[] CALLING_CODE = ["+1-869"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.SaintKittsAndNevis;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Saint Kitts", "KN-K", "Island"),
        new("Nevis", "KN-N", "Island")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSaintKittsAndNevis()
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
