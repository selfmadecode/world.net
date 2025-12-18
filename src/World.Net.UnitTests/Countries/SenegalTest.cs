using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SenegalTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Senegal";
        private const string NATIVE_NAME = "Sénégal";
        private const string CAPITAL = "Dakar";
        private const string OFFICIAL_NAME = "Republic of Senegal";
        private const string ISO2_CODE = "SN";
        private const string ISO3_CODE = "SEN";
        private const int NUMERIC_CODE = 686;
        private readonly string[] CALLING_CODE = ["+221"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Senegal;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Dakar", "SN-DK", "Region"),
        new("Diourbel", "SN-DB", "Region"),
        new("Fatick", "SN-FK", "Region"),
        new("Kaffrine", "SN-KA", "Region"),
        new("Kaolack", "SN-KL", "Region"),
        new("Kédougou", "SN-KE", "Region"),
        new("Kolda", "SN-KD", "Region"),
        new("Louga", "SN-LG", "Region"),
        new("Matam", "SN-MT", "Region"),
        new("Saint-Louis", "SN-SL", "Region"),
        new("Sédhiou", "SN-SE", "Region"),
        new("Tambacounda", "SN-TC", "Region"),
        new("Thiès", "SN-TH", "Region"),
        new("Ziguinchor", "SN-ZG", "Region")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSenegal()
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
