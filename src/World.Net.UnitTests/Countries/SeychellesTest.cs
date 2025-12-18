using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SeychellesTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Seychelles";
        private const string NATIVE_NAME = "Sesel";
        private const string CAPITAL = "Victoria";
        private const string OFFICIAL_NAME = "Republic of Seychelles";
        private const string ISO2_CODE = "SC";
        private const string ISO3_CODE = "SYC";
        private const int NUMERIC_CODE = 690;
        private readonly string[] CALLING_CODE = ["+248"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Seychelles;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Anse aux Pins", "SC-01", "District"),
        new("Anse Boileau", "SC-02", "District"),
        new("Anse Etoile", "SC-03", "District"),
        new("Anse Royale", "SC-05", "District"),
        new("Au Cap", "SC-04", "District"),
        new("Baie Lazare", "SC-06", "District"),
        new("Baie Sainte Anne", "SC-07", "District"),
        new("Beau Vallon", "SC-08", "District"),
        new("Bel Air", "SC-09", "District"),
        new("Bel Ombre", "SC-10", "District"),
        new("Cascade", "SC-11", "District"),
        new("Glacis", "SC-12", "District"),
        new("Grand'Anse Mahé", "SC-13", "District"),
        new("Grand'Anse Praslin", "SC-14", "District"),
        new("La Digue", "SC-15", "District"),
        new("La Rivière Anglaise", "SC-16", "District"),
        new("Les Mamelles", "SC-24", "District"),
        new("Mont Buxton", "SC-17", "District"),
        new("Mont Fleuri", "SC-18", "District"),
        new("Plaisance", "SC-19", "District"),
        new("Pointe La Rue", "SC-20", "District"),
        new("Port Glaud", "SC-21", "District"),
        new("Roche Caiman", "SC-25", "District"),
        new("Saint Louis", "SC-22", "District"),
        new("Takamaka", "SC-23", "District")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSeychelles()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(EXPECTEDID);

            // Assert
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
