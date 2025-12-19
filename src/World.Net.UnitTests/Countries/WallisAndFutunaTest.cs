using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class WallisAndFutunaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Wallis and Futuna";
        private const string NATIVE_NAME = "Wallis et Futuna";
        private const string CAPITAL = "Mata-Utu";
        private const string OFFICIAL_NAME = "Territory of the Wallis and Futuna Islands";
        private const string ISO2_CODE = "WF";
        private const string ISO3_CODE = "WLF";
        private const int NUMERIC_CODE = 876;
        private readonly string[] CALLING_CODE = ["+681"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.WallisAndFutunaIslands;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Alo", "WF-AL", "District"),
        ("Sigave", "WF-SG", "District"),
        ("Uvea", "WF-UV", "District")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForWallisAndFutuna()
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
