using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class UnitedStatesMinorOutlyingIslandsTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "United States Minor Outlying Islands";
        private const string NATIVE_NAME = "United States Minor Outlying Islands";
        private const string CAPITAL = null;
        private const string OFFICIAL_NAME = "United States Minor Outlying Islands";
        private const string ISO2_CODE = "UM";
        private const string ISO3_CODE = "UMI";
        private const int NUMERIC_CODE = 581;
        private readonly string[] CALLING_CODE = ["+1"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.UnitedStatesMinorOutlyingIslands;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForUSMinorOutlyingIslands()
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
