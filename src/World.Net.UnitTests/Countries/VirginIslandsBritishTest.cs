using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class VirginIslandsBritishTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Virgin Islands (British)";
        private const string NATIVE_NAME = "British Virgin Islands";
        private const string CAPITAL = "Road Town";
        private const string OFFICIAL_NAME = "British Virgin Islands";
        private const string ISO2_CODE = "VG";
        private const string ISO3_CODE = "VGB";
        private const int NUMERIC_CODE = 92;
        private readonly string[] CALLING_CODE = ["+1-284"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.VirginIslandsBritish;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForVirginIslandsBritish()
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
