namespace World.Net.UnitTests.Countries
{
    public sealed class BritishIndianOceanTerritoryTest
    {
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_NAME = "British Indian Ocean Territory";
        private const int BRITISH_INDIAN_OCEAN_TERRITORY_STATE_COUNT = 0;
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_OFFICIAL_NAME = "British Indian Ocean Territory";
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_NATIVE_NAME = "British Indian Ocean Territory";
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_CAPITAL = "Diego Garcia";
        private const int BRITISH_INDIAN_OCEAN_TERRITORY_NUMERIC_CODE = 086;
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_ISO2_CODE = "IO";
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_ISO3_CODE = "IOT";
        private const string BRITISH_INDIAN_OCEAN_TERRITORY_CALLING_CODE = "+246";


        [Fact]
        public void British_Indian_Ocean_Territory_HasExpectedInformation()
        {
            // Arrange
            int existingCountryId = CountryIdentifier.BritishIndianOceanTerritory;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_STATE_COUNT, country.States.Count());
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_NATIVE_NAME, country.NativeName);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_CAPITAL, country.Capital);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_ISO2_CODE, country.ISO2Code);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_ISO3_CODE, country.ISO3Code);
            Assert.Equal(BRITISH_INDIAN_OCEAN_TERRITORY_CALLING_CODE, country.CallingCode);
        }
    }
}
