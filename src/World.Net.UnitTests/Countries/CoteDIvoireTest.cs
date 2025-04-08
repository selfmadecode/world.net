namespace World.Net.UnitTests.Countries
{
    public sealed class CoteDIvoireTest
    {
        private const string COTEDIVOIRE_NAME = "Ivory Coast";
        private const int COTEDIVOIRE_STATE_COUNT = 31;
        private const string COTEDIVOIRE_OFFICIAL_NAME = "Republic of Côte d'Ivoire";
        private const string COTEDIVOIRE_NATIVE_NAME = "Côte d'Ivoire";
        private const string COTEDIVOIRE_CAPITAL = "Yamoussoukro";
        private const int COTEDIVOIRE_NUMERIC_CODE = 384;
        private const string COTEDIVOIRE_ISO2_CODE = "CI";
        private const string COTEDIVOIRE_ISO3_CODE = "CIV";
        private readonly string[] COTEDIVOIRE_CALLING_CODE = ["+225"];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForCookIslands()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.CoteDIvoire;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(COTEDIVOIRE_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(COTEDIVOIRE_STATE_COUNT, country.States.Count());
            Assert.Equal(COTEDIVOIRE_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(COTEDIVOIRE_NATIVE_NAME, country.NativeName);
            Assert.Equal(COTEDIVOIRE_CAPITAL, country.Capital);
            Assert.Equal(COTEDIVOIRE_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(COTEDIVOIRE_ISO2_CODE, country.ISO2Code);
            Assert.Equal(COTEDIVOIRE_ISO3_CODE, country.ISO3Code);
            Assert.Equal(COTEDIVOIRE_CALLING_CODE, country.CallingCode);
        }
    }
}
