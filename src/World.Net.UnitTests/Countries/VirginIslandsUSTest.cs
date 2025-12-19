using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class VirginIslandsUSTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Virgin Islands (US)";
        private const string NATIVE_NAME = "United States Virgin Islands";
        private const string CAPITAL = "Charlotte Amalie";
        private const string OFFICIAL_NAME = "United States Virgin Islands";
        private const string ISO2_CODE = "VI";
        private const string ISO3_CODE = "VIR";
        private const int NUMERIC_CODE = 850;
        private readonly string[] CALLING_CODE = ["+1-340"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.VirginIslandsUS;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForVirginIslandsUS()
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
