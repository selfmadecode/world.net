using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class TurkmenistanTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Turkmenistan";
        private const string NATIVE_NAME = "Türkmenistan";
        private const string CAPITAL = "Ashgabat";
        private const string OFFICIAL_NAME = "Turkmenistan";
        private const string ISO2_CODE = "TM";
        private const string ISO3_CODE = "TKM";
        private const int NUMERIC_CODE = 795;
        private readonly string[] CALLING_CODE = ["+993"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Turkmenistan;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Ahal", "TM-A", "Region"),
        ("Balkan", "TM-B", "Region"),
        ("Dashoguz", "TM-D", "Region"),
        ("Lebap", "TM-L", "Region"),
        ("Mary", "TM-M", "Region"),
        ("Ashgabat", "TM-AŞ", "Capital City")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForTurkmenistan()
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
