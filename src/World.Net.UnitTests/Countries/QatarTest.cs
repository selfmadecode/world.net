using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class QatarTest : AssertCountryTestBase
    {
        private const string QATAR_COUNTRY_NAME = "Qatar";
        private const string QATAR_NATIVE_NAME = "دولة قطر";
        private const string QATAR_CAPITAL = "Doha";
        private const string QATAR_OFFICIAL_NAME = "State of Qatar";
        private const string QATAR_ISO2_CODE = "QA";
        private const string QATAR_ISO3_CODE = "QAT";
        private const int QATAR_NUMERIC_CODE = 634;
        private readonly string[] QATAR_CALLING_CODE = ["+974"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Qatar;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Ad Dawhah", "QA-DA", "Municipality"),
        new("Al Khor", "QA-KH", "Municipality"),
        new("Al Rayyan", "QA-RA", "Municipality"),
        new("Al Shamal", "QA-SH", "Municipality"),
        new("Al Wakrah", "QA-WA", "Municipality"),
        new("Al Shahaniya", "QA-SN", "Municipality"),
        new("Umm Salal", "QA-US", "Municipality"),
        new("Al Daayen", "QA-DAA", "Municipality")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForQatar()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
            AssertCorrectInformation(
                country,
                EXPECTEDID,
                QATAR_COUNTRY_NAME,
                QATAR_OFFICIAL_NAME,
                QATAR_NATIVE_NAME,
                QATAR_CAPITAL,
                QATAR_NUMERIC_CODE,
                QATAR_ISO2_CODE,
                QATAR_ISO3_CODE,
                QATAR_CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }

}
