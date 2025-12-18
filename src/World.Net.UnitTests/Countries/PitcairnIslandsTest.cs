using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class PitcairnIslandsTest : AssertCountryTestBase
    {
        private const string PITCAIRN_COUNTRY_NAME = "Pitcairn Islands";
        private const string PITCAIRN_NATIVE_NAME = "Pitcairn Islands";
        private const string PITCAIRN_CAPITAL = "Adamstown";
        private const string PITCAIRN_OFFICIAL_NAME = "Pitcairn, Henderson, Ducie and Oeno Islands";
        private const string PITCAIRN_ISO2_CODE = "PN";
        private const string PITCAIRN_ISO3_CODE = "PCN";
        private const int PITCAIRN_NUMERIC_CODE = 612;
        private readonly string[] PITCAIRN_CALLING_CODE = ["+64"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.PitcairnIsland;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Pitcairn Island", "PN-PI", "Island")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForPitcairnIslands()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
            AssertCorrectInformation(
                country,
                EXPECTEDID,
                PITCAIRN_COUNTRY_NAME,
                PITCAIRN_OFFICIAL_NAME,
                PITCAIRN_NATIVE_NAME,
                PITCAIRN_CAPITAL,
                PITCAIRN_NUMERIC_CODE,
                PITCAIRN_ISO2_CODE,
                PITCAIRN_ISO3_CODE,
                PITCAIRN_CALLING_CODE,
                EXPECTED_STATES
            );
        }
    }

}
