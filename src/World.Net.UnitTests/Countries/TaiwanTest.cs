using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class TaiwanTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Taiwan";
        private const string NATIVE_NAME = "臺灣";
        private const string CAPITAL = "Taipei";
        private const string OFFICIAL_NAME = "Republic of China (Taiwan)";
        private const string ISO2_CODE = "TW";
        private const string ISO3_CODE = "TWN";
        private const int NUMERIC_CODE = 158;
        private readonly string[] CALLING_CODE = ["+886"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Taiwan;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Taipei", "TW-TPE", "Municipality"),
        ("New Taipei", "TW-NWT", "Municipality"),
        ("Taoyuan", "TW-TAO", "Municipality"),
        ("Taichung", "TW-TXG", "Municipality"),
        ("Tainan", "TW-TNN", "Municipality"),
        ("Kaohsiung", "TW-KHH", "Municipality"),
        ("Keelung", "TW-KEE", "City"),
        ("Hsinchu", "TW-HSZ", "City"),
        ("Chiayi", "TW-CYI", "City"),
        ("Changhua", "TW-CWH", "County"),
        ("Chiayi County", "TW-CYQ", "County"),
        ("Hsinchu County", "TW-HSQ", "County"),
        ("Hualien", "TW-HWA", "County"),
        ("Kaohsiung County", "TW-KAQ", "County"),
        ("Miaoli", "TW-MIA", "County"),
        ("Nantou", "TW-NAN", "County"),
        ("Penghu", "TW-PEN", "County"),
        ("Pingtung", "TW-PIF", "County"),
        ("Yilan", "TW-YIL", "County"),
        ("Yunlin", "TW-YUN", "County"),
        ("Taitung", "TW-TTT", "County"),
        ("Lienchiang", "TW-LIE", "County")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForTaiwan()
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
