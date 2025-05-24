namespace World.Net.UnitTests.Countries
{
    public class EquatorialGuineaTest
    {
        private const string EQUATORIALGUINEA_NAME = "EquatorialGuinea";
        private const int EQUATORIALGUINEA_STATE_COUNT = 8;
        private const string EQUATORIALGUINEA_OFFICIAL_NAME = "Republic of Equatorial Guinea";
        private const string EQUATORIALGUINEA_NATIVE_NAME = "República de Guinea Ecuatorial";
        private const string EQUATORIALGUINEA_CAPITAL = "Malabo";
        private const int EQUATORIALGUINEA_NUMERIC_CODE = 226;
        private const string EQUATORIALGUINEA_ISO2_CODE = "GQ";
        private const string EQUATORIALGUINEA_ISO3_CODE = "GNQ";
        private readonly string[] EQUATORIALGUINEA_CALLING_CODE = ["240"];
        private static readonly string[] VALID_STATE_TYPES = { "Province" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEquatorialGuinea()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.EquatorialGuinea;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(EQUATORIALGUINEA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(EQUATORIALGUINEA_STATE_COUNT, country.States.Count());
            Assert.Equal(EQUATORIALGUINEA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(EQUATORIALGUINEA_NATIVE_NAME, country.NativeName);
            Assert.Equal(EQUATORIALGUINEA_CAPITAL, country.Capital);
            Assert.Equal(EQUATORIALGUINEA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(EQUATORIALGUINEA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(EQUATORIALGUINEA_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(EQUATORIALGUINEA_CALLING_CODE, country.CallingCode);
        }

    }
}
