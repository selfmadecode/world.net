using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SouthSudanTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "South Sudan";
        private const string NATIVE_NAME = "South Sudan";
        private const string CAPITAL = "Juba";
        private const string OFFICIAL_NAME = "Republic of South Sudan";
        private const string ISO2_CODE = "SS";
        private const string ISO3_CODE = "SSD";
        private const int NUMERIC_CODE = 728;
        private readonly string[] CALLING_CODE = ["+211"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.SouthSudan;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Central Equatoria", "SS-EC", "State"),
        ("Eastern Equatoria", "SS-EE", "State"),
        ("Jonglei", "SS-JG", "State"),
        ("Lakes", "SS-LK", "State"),
        ("Northern Bahr el Ghazal", "SS-BN", "State"),
        ("Unity", "SS-UY", "State"),
        ("Upper Nile", "SS-NU", "State"),
        ("Warrap", "SS-WR", "State"),
        ("Western Bahr el Ghazal", "SS-BW", "State"),
        ("Western Equatoria", "SS-EW", "State")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSouthSudan()
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
