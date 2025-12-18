using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class SerbiaTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Serbia";
        private const string NATIVE_NAME = "Srbija";
        private const string CAPITAL = "Belgrade";
        private const string OFFICIAL_NAME = "Republic of Serbia";
        private const string ISO2_CODE = "RS";
        private const string ISO3_CODE = "SRB";
        private const int NUMERIC_CODE = 688;
        private readonly string[] CALLING_CODE = ["+381"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Serbia;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        [
            new("Belgrade", "RS-00", "District"),
        new("Bor", "RS-14", "District"),
        new("Braničevo", "RS-11", "District"),
        new("Central Banat", "RS-02", "District"),
        new("Jablanica", "RS-23", "District"),
        new("Kolubara", "RS-09", "District"),
        new("Mačva", "RS-08", "District"),
        new("Moravica", "RS-17", "District"),
        new("Nišava", "RS-20", "District"),
        new("North Bačka", "RS-01", "District"),
        new("North Banat", "RS-03", "District"),
        new("Pčinja", "RS-24", "District"),
        new("Pirot", "RS-22", "District"),
        new("Pomoravlje", "RS-13", "District"),
        new("Rasina", "RS-19", "District"),
        new("Raška", "RS-18", "District"),
        new("South Bačka", "RS-06", "District"),
        new("South Banat", "RS-04", "District"),
        new("Srem", "RS-07", "District"),
        new("Šumadija", "RS-12", "District"),
        new("Toplica", "RS-21", "District"),
        new("West Bačka", "RS-05", "District"),
        new("Zaječar", "RS-15", "District"),
        new("Zlatibor", "RS-16", "District")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForSerbia()
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
