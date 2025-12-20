using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class MayotteTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Mayotte";
        private const string OFFICIAL_NAME = "Department of Mayotte";
        private const string NATIVE_NAME = "Mayotte";
        private const string CAPITAL = "Mamoudzou";
        private const string ISO2_CODE = "YT";
        private const string ISO3_CODE = "MYT";
        private const int NUMERIC_CODE = 175;
        private readonly string[] CALLING_CODE = ["+262"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mayotte;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForMayotte()
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
