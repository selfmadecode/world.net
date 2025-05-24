namespace World.Net.UnitTests.Countries
{
    public sealed class EstoniaTest
    {
        private const string ESTONIA_NAME = "Estonia";
        private const int ESTONIA_STATE_COUNT = 15;
        private const string ESTONIA_OFFICIAL_NAME = "Republic of Estonia";
        private const string ESTONIA_NATIVE_NAME = "Eesti";
        private const string ESTONIA_CAPITAL = "Tallinn";
        private const int ESTONIA_NUMERIC_CODE = 233;
        private const string ESTONIA_ISO2_CODE = "EE";
        private const string ESTONIA_ISO3_CODE = "EST";
        private readonly string[] ESTONIA_CALLING_CODE = ["372"];
        private static readonly string[] VALID_STATE_TYPES = { "County" };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEstonia()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.Estonia;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            // Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(ESTONIA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(ESTONIA_STATE_COUNT, country.States.Count());
            Assert.Equal(ESTONIA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(ESTONIA_NATIVE_NAME, country.NativeName);
            Assert.Equal(ESTONIA_CAPITAL, country.Capital);
            Assert.Equal(ESTONIA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(ESTONIA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(ESTONIA_ISO3_CODE, country.ISO3Code);
            Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
            Assert.Equal(ESTONIA_CALLING_CODE, country.CallingCode);
        }
    }
}
