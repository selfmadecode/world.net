namespace World.Net.UnitTests.Countries
{
    public sealed class ChinaTest
    {
        private const string CHINA_NAME = "China";
        private const int CHINA_STATE_COUNT = 34;
        private const string CHINA_OFFICIAL_NAME = "People's Republic of China";
        private const string CHINA_NATIVE_NAME = "中国";
        private const string CHINA_CAPITAL = "Beijing";
        private const int CHINA_NUMERIC_CODE = 156;
        private const string CHINA_ISO2_CODE = "CN";
        private const string CHINA_ISO3_CODE = "CHN";
        private const string CHINA_CALLING_CODE = "+86";

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForChina()
        {
            // Arrange
            CountryIdentifier existingCountryId = CountryIdentifier.China;

            // Act
            var country = CountryProvider.GetCountry(existingCountryId);

            //Assert
            Assert.Equal(existingCountryId, country.Id);
            Assert.Equal(CHINA_NAME, country.Name);
            Assert.NotNull(country.States);
            Assert.Equal(CHINA_STATE_COUNT, country.States.Count());
            Assert.Equal(CHINA_OFFICIAL_NAME, country.OfficialName);
            Assert.Equal(CHINA_NATIVE_NAME, country.NativeName);
            Assert.Equal(CHINA_CAPITAL, country.Capital);
            Assert.Equal(CHINA_NUMERIC_CODE, country.NumericCode);
            Assert.Equal(CHINA_ISO2_CODE, country.ISO2Code);
            Assert.Equal(CHINA_ISO3_CODE, country.ISO3Code);
            Assert.Equal(CHINA_CALLING_CODE, country.CallingCode);
        }
    }
}
