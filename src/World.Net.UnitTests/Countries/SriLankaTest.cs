using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SriLankaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Sri Lanka";
        private const string NATIVE_NAME = "ශ්‍රී ලංකාව";
        private const string CAPITAL = "Sri Jayawardenepura Kotte";
        private const string OFFICIAL_NAME = "Democratic Socialist Republic of Sri Lanka";
        private const string ISO2_CODE = "LK";
        private const string ISO3_CODE = "LKA";
        private const int NUMERIC_CODE = 144;
        private readonly string[] CALLING_CODE = ["+94"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.SriLanka;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Central", "LK-CE", "Province"),
        ("Eastern", "LK-EP", "Province"),
        ("North Central", "LK-NC", "Province"),
        ("Northern", "LK-NU", "Province"),
        ("North Western", "LK-NW", "Province"),
        ("Sabaragamuwa", "LK-SG", "Province"),
        ("Southern", "LK-SO", "Province"),
        ("Uva", "LK-UVA", "Province"),
        ("Western", "LK-WP", "Province")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSriLanka()
        {
            var country = CountryProvider.GetCountry(EXPECTEDID);

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
