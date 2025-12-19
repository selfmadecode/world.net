using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class VaticanCityTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Vatican City State (Holy See)";
        private const string NATIVE_NAME = "Stato della Città del Vaticano";
        private const string CAPITAL = "Vatican City";
        private const string OFFICIAL_NAME = "Vatican City State";
        private const string ISO2_CODE = "VA";
        private const string ISO3_CODE = "VAT";
        private const int NUMERIC_CODE = 336;
        private readonly string[] CALLING_CODE = ["+379"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.VaticanCityState;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES = Array.Empty<(string, string, string)>();

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForVaticanCity()
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
