using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class FalklandIslandsTest
    {
        private const string FALKLANDS_NAME = "FalklandIslands";
        private const string FALKLANDS_OFFICIAL_NAME = "Falkland Islands";
        private const string FALKLANDS_NATIVE_NAME = "Falkland Islands";
        private const string FALKLANDS_CAPITAL = "Stanley";
        private const int FALKLANDS_NUMERIC_CODE = 238;
        private const string FALKLANDS_ISO2_CODE = "FK";
        private const string FALKLANDS_ISO3_CODE = "FLK";
        private readonly string[] FALKLANDS_CALLING_CODE = ["500"];
        private static readonly string[] VALID_STATE_TYPES = { "Overseas Territory" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForFalklandIslands()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.FalklandIslands;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(FALKLANDS_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Single(country.States);
            Assert.Equal(FALKLANDS_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(FALKLANDS_NATIVE_NAME, country.NativeName);
            Assert.Equal(FALKLANDS_CAPITAL, country.Capital);
            Assert.Equal(FALKLANDS_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(FALKLANDS_ISO2_CODE, country.ISO2Code);
            Assert.Equal(FALKLANDS_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(FALKLANDS_CALLING_CODE, country.CallingCode);
        }
    }
}
