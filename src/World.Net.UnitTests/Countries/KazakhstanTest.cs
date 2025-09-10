namespace World.Net.UnitTests.Countries;

internal static class KazakhstanTestData
{
    internal const string COUNTRY_NAME = "Kazakhstan";
    internal const string NATIVE_NAME = "?????????";
    internal const string CAPITAL = "Astana";
    internal const string OFFICIAL_NAME = "Republic of Kazakhstan";
    internal const string ISO2_CODE = "KZ";
    internal const string ISO3_CODE = "KAZ";
    internal const int NUMERIC_CODE = 398;
    internal static readonly string[] CALLING_CODE = ["+7"];
    internal const string REGION_TYPE = "Region";
    internal const string CITY_TYPE = "City";
    internal const int EXPECTED_REGION_COUNT = 14;
    internal const int EXPECTED_CITY_COUNT = 3;
}

public sealed class KazakhstanTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForKazakhstan()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Kazakhstan;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(KazakhstanTestData.COUNTRY_NAME, country.Name);
        Assert.Equal(KazakhstanTestData.OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(KazakhstanTestData.NATIVE_NAME, country.NativeName);
        Assert.Equal(KazakhstanTestData.CAPITAL, country.Capital);
        Assert.Equal(KazakhstanTestData.NUMERIC_CODE, country.NumericCode);
        Assert.Equal(KazakhstanTestData.ISO2_CODE, country.ISO2Code);
        Assert.Equal(KazakhstanTestData.ISO3_CODE, country.ISO3Code);
        Assert.Equal(KazakhstanTestData.CALLING_CODE, country.CallingCode);

        Assert.NotNull(country.States);
        Assert.Equal(KazakhstanTestData.EXPECTED_REGION_COUNT + KazakhstanTestData.EXPECTED_CITY_COUNT, country.States.Count());
        Assert.Equal(KazakhstanTestData.EXPECTED_REGION_COUNT, country.States.Count(s => s.Type == KazakhstanTestData.REGION_TYPE));
        Assert.Equal(KazakhstanTestData.EXPECTED_CITY_COUNT, country.States.Count(s => s.Type == KazakhstanTestData.CITY_TYPE));
    }
}
