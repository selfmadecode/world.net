using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class UnitedKingdomTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "United Kingdom";
        private const string NATIVE_NAME = "United Kingdom";
        private const string CAPITAL = "London";
        private const string OFFICIAL_NAME = "United Kingdom of Great Britain and Northern Ireland";
        private const string ISO2_CODE = "GB";
        private const string ISO3_CODE = "GBR";
        private const int NUMERIC_CODE = 826;
        private readonly string[] CALLING_CODE = ["+44"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.UnitedKingdom;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("England", "GB-ENG", "Country"),
        ("Scotland", "GB-SCT", "Country"),
        ("Wales", "GB-WLS", "Country"),
        ("Northern Ireland", "GB-NIR", "Country")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForUnitedKingdom()
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
