using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class ZambiaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Zambia";
        private const string NATIVE_NAME = "Republic of Zambia";
        private const string CAPITAL = "Lusaka";
        private const string OFFICIAL_NAME = "Republic of Zambia";
        private const string ISO2_CODE = "ZM";
        private const string ISO3_CODE = "ZMB";
        private const int NUMERIC_CODE = 894;
        private readonly string[] CALLING_CODE = ["+260"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Zambia;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Central", "ZM-02", "Province"),
        ("Copperbelt", "ZM-08", "Province"),
        ("Eastern", "ZM-03", "Province"),
        ("Luapula", "ZM-04", "Province"),
        ("Lusaka", "ZM-09", "Province"),
        ("Muchinga", "ZM-13", "Province"),
        ("Northern", "ZM-05", "Province"),
        ("North-Western", "ZM-06", "Province"),
        ("Southern", "ZM-07", "Province"),
        ("Western", "ZM-01", "Province")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForZambia()
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
