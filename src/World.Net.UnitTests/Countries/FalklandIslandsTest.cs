using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace World.Net.UnitTests.Countries
{
    public sealed class FalklandIslandsTest : AssertCountryTestBase
    {
        private static CountryIdentifier Id => CountryIdentifier.FalklandIslands;
        private const string FALKLANDS_NAME = "FalklandIslands";
        private const string FALKLANDS_OFFICIAL_NAME = "Falkland Islands";
        private const string FALKLANDS_NATIVE_NAME = "Falkland Islands";
        private const string FALKLANDS_CAPITAL = "Stanley";
        private const int FALKLANDS_NUMERIC_CODE = 238;
        private const string FALKLANDS_ISO2_CODE = "FK";
        private const string FALKLANDS_ISO3_CODE = "FLK";
        private readonly string[] FALKLANDS_CALLING_CODE = ["500"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Falkland Islands", "FK", "Overseas Territory")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForFalklandIslands()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(Id);

            // Assert
            AssertCorrectInformation(
                country,
                Id,
                FALKLANDS_NAME,
                FALKLANDS_OFFICIAL_NAME,
                FALKLANDS_NATIVE_NAME,
                FALKLANDS_CAPITAL,
                FALKLANDS_NUMERIC_CODE,
                FALKLANDS_ISO2_CODE,
                FALKLANDS_ISO3_CODE,
                FALKLANDS_CALLING_CODE,
                States
            );
        }
    }
}
