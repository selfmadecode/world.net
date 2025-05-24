namespace World.Net.UnitTests.Countries
{
    public sealed class ElSalvadorTest
    {
        private const string ELSALVADOR_NAME = "ElSalvador";
        private const int ELSALVADOR_STATE_COUNT = 14;
        private const string ELSALVADOR_OFFICIAL_NAME = "Republic of El Salvador";
        private const string ELSALVADOR_NATIVE_NAME = "República de El Salvador";
        private const string ELSALVADOR_CAPITAL = "San Salvador";
        private const int ELSALVADOR_NUMERIC_CODE = 222;
        private const string ELSALVADOR_ISO2_CODE = "SV";
        private const string ELSALVADOR_ISO3_CODE = "SLV";
        private readonly string[] ELSALVADOR_CALLING_CODE = ["503"];
        private static readonly string[] VALID_STATE_TYPES = { "Department" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForElSalvador()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.ElSalvador;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(ELSALVADOR_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(ELSALVADOR_STATE_COUNT, country.States.Count());
            Assert.Equal(ELSALVADOR_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(ELSALVADOR_NATIVE_NAME, country.NativeName);
            Assert.Equal(ELSALVADOR_CAPITAL, country.Capital);
            Assert.Equal(ELSALVADOR_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(ELSALVADOR_ISO2_CODE, country.ISO2Code);
            Assert.Equal(ELSALVADOR_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(ELSALVADOR_CALLING_CODE, country.CallingCode);
        }
    }
}
