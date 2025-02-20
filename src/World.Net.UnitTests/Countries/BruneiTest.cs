namespace World.Net.UnitTests.Countries
{
    public sealed class BruneiTest
    {
        private const string BRUNEI_NAME = "Brunei";
        private const int BRUNEI_STATE_COUNT = 4;
        private const string BRUNEI_OFFICIAL_NAME = "Nation of Brunei, the Abode of Peace";
        private const string BRUNEI_NATIVE_NAME = "Negara Brunei Darussalam";
        private const string BRUNEI_CAPITAL = "Bandar Seri Begawan";
        private const int BRUNEI_NUMERIC_CODE = 096;
        private const string BRUNEI_ISO2_CODE = "BN";
        private const string BRUNEI_ISO3_CODE = "BRN";
        private const string BRUNEI_CALLING_CODE = "+673";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_for_Brunei()
        {
            // Arrange
            int existingCountryId = CountryIdentifier.Brunei;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(BRUNEI_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(BRUNEI_STATE_COUNT, country.States.Count());
            Assert.Equal(BRUNEI_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(BRUNEI_NATIVE_NAME, country.NativeName);
            Assert.Equal(BRUNEI_CAPITAL, country.Capital);
            Assert.Equal(BRUNEI_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(BRUNEI_ISO2_CODE, country.ISO2Code);
            Assert.Equal(BRUNEI_ISO3_CODE, country.ISO3Code);
            Assert.Equal(BRUNEI_CALLING_CODE, country.CallingCode);
        }
    }
}
