using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SamoaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Samoa";
        private const string NATIVE_NAME = "Sāmoa";
        private const string CAPITAL = "Apia";
        private const string OFFICIAL_NAME = "Independent State of Samoa";
        private const string ISO2_CODE = "WS";
        private const string ISO3_CODE = "WSM";
        private const int NUMERIC_CODE = 882;
        private readonly string[] CALLING_CODE = ["+685"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Samoa;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("A'ana", "WS-AA", "District"),
        new("Aiga-i-le-Tai", "WS-AL", "District"),
        new("Atua", "WS-AT", "District"),
        new("Fa'asaleleaga", "WS-FS", "District"),
        new("Gaga'emauga", "WS-GE", "District"),
        new("Gaga'ifomauga", "WS-GF", "District"),
        new("Palauli", "WS-PA", "District"),
        new("Satupa'itea", "WS-SA", "District"),
        new("Tuamasaga", "WS-TU", "District"),
        new("Va'a-o-Fonoti", "WS-VF", "District"),
        new("Vaisigano", "WS-VS", "District")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSamoa()
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
