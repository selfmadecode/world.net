using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class UzbekistanTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Uzbekistan";
        private const string NATIVE_NAME = "Oʻzbekiston Respublikasi";
        private const string CAPITAL = "Tashkent";
        private const string OFFICIAL_NAME = "Republic of Uzbekistan";
        private const string ISO2_CODE = "UZ";
        private const string ISO3_CODE = "UZB";
        private const int NUMERIC_CODE = 860;
        private readonly string[] CALLING_CODE = ["+998"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Uzbekistan;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Andijan", "UZ-AN", "Region"),
        ("Bukhara", "UZ-BU", "Region"),
        ("Fergana", "UZ-FA", "Region"),
        ("Jizzakh", "UZ-JI", "Region"),
        ("Kashkadarya", "UZ-KA", "Region"),
        ("Khorezm", "UZ-KH", "Region"),
        ("Namangan", "UZ-NG", "Region"),
        ("Navoiy", "UZ-NW", "Region"),
        ("Samarkand", "UZ-SA", "Region"),
        ("Sirdaryo", "UZ-SI", "Region"),
        ("Surxondaryo", "UZ-SU", "Region"),
        ("Tashkent Region", "UZ-TO", "Region"),
        ("Republic of Karakalpakstan", "UZ-QA", "Autonomous Republic"),
        ("Tashkent", "UZ-TK", "City")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForUzbekistan()
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
