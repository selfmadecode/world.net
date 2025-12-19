using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class VanuatuTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Vanuatu";
        private const string NATIVE_NAME = "Ripablik blong Vanuatu";
        private const string CAPITAL = "Port Vila";
        private const string OFFICIAL_NAME = "Republic of Vanuatu";
        private const string ISO2_CODE = "VU";
        private const string ISO3_CODE = "VUT";
        private const int NUMERIC_CODE = 548;
        private readonly string[] CALLING_CODE = ["+678"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Vanuatu;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Malampa", "VU-MAP", "Province"),
        ("Penama", "VU-PAM", "Province"),
        ("Sanma", "VU-SAM", "Province"),
        ("Shefa", "VU-SEE", "Province"),
        ("Tafea", "VU-TAE", "Province"),
        ("Torba", "VU-TOB", "Province")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForVanuatu()
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
