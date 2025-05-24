using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class EritreaTest
    {
        private const string ERITREA_NAME = "Eritrea";
        private const int ERITREA_STATE_COUNT = 6;
        private const string ERITREA_OFFICIAL_NAME = "State of Eritrea";
        private const string ERITREA_NATIVE_NAME = "ሃገረ ኤርትራ";
        private const string ERITREA_CAPITAL = "Asmara";
        private const int ERITREA_NUMERIC_CODE = 232;
        private const string ERITREA_ISO2_CODE = "ER";
        private const string ERITREA_ISO3_CODE = "ERI";
        private readonly string[] ERITREA_CALLING_CODE = ["291"];
        private static readonly string[] VALID_STATE_TYPES = { "Region" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEritrea()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Eritrea;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(ERITREA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(ERITREA_STATE_COUNT, country.States.Count());
            Assert.Equal(ERITREA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(ERITREA_NATIVE_NAME, country.NativeName);
            Assert.Equal(ERITREA_CAPITAL, country.Capital);
            Assert.Equal(ERITREA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(ERITREA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(ERITREA_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(ERITREA_CALLING_CODE, country.CallingCode);
        }
    }
}
