using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class WesternSaharaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Western Sahara";
        private const string NATIVE_NAME = "الصحراء الغربية";
        private const string CAPITAL = "El Aaiún";
        private const string OFFICIAL_NAME = "Sahrawi Arab Democratic Republic";
        private const string ISO2_CODE = "EH";
        private const string ISO3_CODE = "ESH";
        private const int NUMERIC_CODE = 732;
        private readonly string[] CALLING_CODE = ["+212"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.WesternSahara;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForWesternSahara()
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
