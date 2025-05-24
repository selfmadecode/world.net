namespace World.Net.UnitTests.Countries
{
    public class EswatiniTest
    {
        private const string ESWATINI_NAME = "Eswatini";
        private const int ESWATINI_STATE_COUNT = 4;
        private const string ESWATINI_OFFICIAL_NAME = "Kingdom of Eswatini";
        private const string ESWATINI_NATIVE_NAME = "eSwatini";
        private const string ESWATINI_CAPITAL = "Mbabane";
        private const int ESWATINI_NUMERIC_CODE = 748;
        private const string ESWATINI_ISO2_CODE = "SZ";
        private const string ESWATINI_ISO3_CODE = "SWZ";
        private readonly string[] ESWATINI_CALLING_CODE = ["268"];
        private static readonly string[] VALID_STATE_TYPES = { "Region" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEswatini()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Eswatini;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(ESWATINI_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(ESWATINI_STATE_COUNT, country.States.Count());
            Assert.Equal(ESWATINI_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(ESWATINI_NATIVE_NAME, country.NativeName);
            Assert.Equal(ESWATINI_CAPITAL, country.Capital);
            Assert.Equal(ESWATINI_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(ESWATINI_ISO2_CODE, country.ISO2Code);
            Assert.Equal(ESWATINI_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(ESWATINI_CALLING_CODE, country.CallingCode);
        }
    }
}
