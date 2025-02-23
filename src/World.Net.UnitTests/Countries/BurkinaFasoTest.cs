namespace World.Net.UnitTests.Countries
{
    public sealed class BurkinaFasoTest
    {
        private const string BURKINA_FASO_NAME = "Burkina Faso";
        private const int BURKINA_FASO_STATE_COUNT = 57;
        private const string BURKINA_FASO_OFFICIAL_NAME = "The Republic of Burkina Faso";
        private const string BURKINA_FASO_NATIVE_NAME = "Burkina Faso";
        private const string BURKINA_FASO_CAPITAL = "Ouagadougou";
        private const int BURKINA_FASO_NUMERIC_CODE = 854;
        private const string BURKINA_FASO_ISO2_CODE = "BF";
        private const string BURKINA_FASO_ISO3_CODE = "BFA";
        private const string BURKINA_FASO_CALLING_CODE = "+226";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_for_BurkinaFaso()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.BurkinaFaso;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(BURKINA_FASO_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(BURKINA_FASO_STATE_COUNT, country.States.Count());
            Assert.Equal(BURKINA_FASO_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(BURKINA_FASO_NATIVE_NAME, country.NativeName);
            Assert.Equal(BURKINA_FASO_CAPITAL, country.Capital);
            Assert.Equal(BURKINA_FASO_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(BURKINA_FASO_ISO2_CODE, country.ISO2Code);
            Assert.Equal(BURKINA_FASO_ISO3_CODE, country.ISO3Code);
            Assert.Equal(BURKINA_FASO_CALLING_CODE, country.CallingCode);
        }
    }
}
