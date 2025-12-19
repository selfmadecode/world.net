using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class ZimbabweTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Zimbabwe";
        private const string NATIVE_NAME = "Republic of Zimbabwe";
        private const string CAPITAL = "Harare";
        private const string OFFICIAL_NAME = "Republic of Zimbabwe";
        private const string ISO2_CODE = "ZW";
        private const string ISO3_CODE = "ZWE";
        private const int NUMERIC_CODE = 716;
        private readonly string[] CALLING_CODE = ["+263"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Zimbabwe;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Bulawayo", "ZW-BU", "Province"),
        ("Harare", "ZW-HA", "Province"),
        ("Manicaland", "ZW-MA", "Province"),
        ("Mashonaland Central", "ZW-MC", "Province"),
        ("Mashonaland East", "ZW-ME", "Province"),
        ("Mashonaland West", "ZW-MW", "Province"),
        ("Masvingo", "ZW-MV", "Province"),
        ("Matabeleland North", "ZW-MN", "Province"),
        ("Matabeleland South", "ZW-MS", "Province"),
        ("Midlands", "ZW-MI", "Province")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForZimbabwe()
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
