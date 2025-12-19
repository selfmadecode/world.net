using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class YemenTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Yemen";
        private const string NATIVE_NAME = "الجمهورية اليمنية";
        private const string CAPITAL = "Sana’a";
        private const string OFFICIAL_NAME = "Republic of Yemen";
        private const string ISO2_CODE = "YE";
        private const string ISO3_CODE = "YEM";
        private const int NUMERIC_CODE = 887;
        private readonly string[] CALLING_CODE = ["+967"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Yemen;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Abyan", "YE-AB", "Governorate"),
        ("Aden", "YE-AD", "Governorate"),
        ("Al Bayda", "YE-BD", "Governorate"),
        ("Al Hudaydah", "YE-HD", "Governorate"),
        ("Al Jawf", "YE-JW", "Governorate"),
        ("Al Mahrah", "YE-MR", "Governorate"),
        ("Al Mahwit", "YE-MW", "Governorate"),
        ("Amran", "YE-AM", "Governorate"),
        ("Dhamar", "YE-DH", "Governorate"),
        ("Hadhramaut", "YE-HU", "Governorate"),
        ("Hajjah", "YE-HJ", "Governorate"),
        ("Ibb", "YE-IB", "Governorate"),
        ("Lahij", "YE-LH", "Governorate"),
        ("Ma’rib", "YE-MA", "Governorate"),
        ("Raymah", "YE-RH", "Governorate"),
        ("Sa’dah", "YE-SD", "Governorate"),
        ("Sana’a", "YE-SN", "Governorate"),
        ("Shabwah", "YE-SH", "Governorate"),
        ("Socotra", "YE-SS", "Governorate"),
        ("Ta’izz", "YE-TA", "Governorate")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForYemen()
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
