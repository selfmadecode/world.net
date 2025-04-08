namespace World.Net.UnitTests.Countries
{
    public sealed class CostaRicaTest
    {
        private const string COSTARICA_NAME = "Costa Rica";
        private const int COSTARICA_STATE_COUNT = 7;
        private const string COSTARICA_OFFICIAL_NAME = "Republic of Costa Rica";
        private const string COSTARICA_NATIVE_NAME = "Costa Rica";
        private const string COSTARICA_CAPITAL = "San Jose";
        private const int COSTARICA_NUMERIC_CODE = 188;
        private const string COSTARICA_ISO2_CODE = "CR";
        private const string COSTARICA_ISO3_CODE = "CRI";
        private readonly string[] COSTARICA_CALLING_CODE = ["+506"];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForCostaRica()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.CostaRica;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(COSTARICA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(COSTARICA_STATE_COUNT, country.States.Count());
            Assert.Equal(COSTARICA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(COSTARICA_NATIVE_NAME, country.NativeName);
            Assert.Equal(COSTARICA_CAPITAL, country.Capital);
            Assert.Equal(COSTARICA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(COSTARICA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(COSTARICA_ISO3_CODE, country.ISO3Code);
            Assert.Equal(COSTARICA_CALLING_CODE, country.CallingCode);
        }
    }
}
