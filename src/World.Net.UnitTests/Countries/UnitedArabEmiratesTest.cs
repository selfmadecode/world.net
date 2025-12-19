using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class UnitedArabEmiratesTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "United Arab Emirates";
        private const string NATIVE_NAME = "الإمارات العربية المتحدة";
        private const string CAPITAL = "Abu Dhabi";
        private const string OFFICIAL_NAME = "United Arab Emirates";
        private const string ISO2_CODE = "AE";
        private const string ISO3_CODE = "ARE";
        private const int NUMERIC_CODE = 784;
        private readonly string[] CALLING_CODE = ["+971"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.UnitedArabEmirates;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Abu Dhabi", "AE-AZ", "Emirate"),
        ("Ajman", "AE-AJ", "Emirate"),
        ("Dubai", "AE-DU", "Emirate"),
        ("Fujairah", "AE-FU", "Emirate"),
        ("Ras Al Khaimah", "AE-RK", "Emirate"),
        ("Sharjah", "AE-SH", "Emirate"),
        ("Umm Al Quwain", "AE-UQ", "Emirate")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForUAE()
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
