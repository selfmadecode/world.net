namespace World.Net.UnitTests.Countries;

public sealed class ChinaTest
{
    private const string CHINA_COUNTRY_NAME = "China";
    private const string CHINA_NATIVE_NAME = "中国";
    private const string CHINA_CAPITAL = "Beijing";
    private const string CHINA_OFFICIAL_NAME = "People's Republic of China";
    private const string CHINA_ISO2_CODE = "CN";
    private const string CHINA_ISO3_CODE = "CHN";
    private const int CHINA_NUMERIC_CODE = 156;
    private const string CHINA_CALLING_CODE = "+86";
    private const int CHINA_STATE_COUNT = 34; // 23 Provinces, 4 Municipalities, 5 Autonomous Regions, 2 SAR
    private static readonly string[] VALID_STATE_TYPES = { "Province", "Municipality", "Autonomous Region", "Special Administrative Region" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForChina()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.China;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(CHINA_COUNTRY_NAME, country.Name);
        Assert.Equal(CHINA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(CHINA_NATIVE_NAME, country.NativeName);
        Assert.Equal(CHINA_CAPITAL, country.Capital);
        Assert.Equal(CHINA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(CHINA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(CHINA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(CHINA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(CHINA_STATE_COUNT, country.States.Count());

        // Assert that each state has a valid type
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
