using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class TuvaluTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Tuvalu";
        private const string NATIVE_NAME = "Tuvalu";
        private const string CAPITAL = "Funafuti";
        private const string OFFICIAL_NAME = "Tuvalu";
        private const string ISO2_CODE = "TV";
        private const string ISO3_CODE = "TUV";
        private const int NUMERIC_CODE = 798;
        private readonly string[] CALLING_CODE = ["+688"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Tuvalu;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
            ("Funafuti", "TV-FUN", "Island"),
            ("Nanumea", "TV-NAN", "Island"),
            ("Nanumanga", "TV-NMG", "Island"),
            ("Niutao", "TV-NT", "Island"),
            ("Nui", "TV-NUI", "Island"),
            ("Nukufetau", "TV-NKF", "Island"),
            ("Nukulaelae", "TV-NKL", "Island"),
            ("Vaitupu", "TV-VAI", "Island"),
            ("Nukulaelae", "TV-NKL", "Island")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForTuvalu()
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
