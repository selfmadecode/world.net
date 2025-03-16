namespace World.Net.UnitTests.Countries
{
    public sealed class CentralAfricanRepublicTest
    {
        private const string CENTRAL_AFRICAN_REPUBLIC_NAME = "Central African Republic";
        private const int CENTRAL_AFRICAN_REPUBLIC_STATE_COUNT = 17;
        private const string CENTRAL_AFRICAN_REPUBLIC_OFFICIAL_NAME = "Central African Republic";
        private const string CENTRAL_AFRICAN_REPUBLIC_NATIVE_NAME = "Ködörösêse tî Bêafrîka";
        private const string CENTRAL_AFRICAN_REPUBLIC_CAPITAL = "Bangui";
        private const int CENTRAL_AFRICAN_REPUBLIC_NUMERIC_CODE = 140;
        private const string CENTRAL_AFRICAN_REPUBLIC_ISO2_CODE = "CF";
        private const string CENTRAL_AFRICAN_REPUBLIC_ISO3_CODE = "CAF";
        private const string CENTRAL_AFRICAN_REPUBLIC_CALLING_CODE = "+236";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForCentralAfricanRepublic()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.CentralAfricanRepublic;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_STATE_COUNT, country.States.Count());
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_NATIVE_NAME, country.NativeName);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_CAPITAL, country.Capital);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_ISO2_CODE, country.ISO2Code);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_ISO3_CODE, country.ISO3Code);
            Assert.Equal(CENTRAL_AFRICAN_REPUBLIC_CALLING_CODE, country.CallingCode);
        }
    }
}
