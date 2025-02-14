namespace World.Net.UnitTests.Countries;

public static class BhutanTestData
{
    public const string COUNTRY_NAME = "Bhutan";
    public const string NATIVE_NAME = "ʼbrug-yul";
    public const string CAPITAL = "Thimphu";
    public const string OFFICIAL_NAME = "Kingdom of Bhutan";
    public const string ISO2_CODE = "BT";
    public const string ISO3_CODE = "BTN";
    public const int NUMERIC_CODE = 64;
    public const string CALLING_CODE = "+975";
    public const string STATE_TYPE = "District";
    public const int EXPECTED_STATE_COUNT = 20;
}

public sealed class BhutanTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForBhutan()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Bhutan;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);

        Assert.Equal(BhutanTestData.COUNTRY_NAME, country.Name);
        Assert.Equal(BhutanTestData.OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BhutanTestData.NATIVE_NAME, country.NativeName);
        Assert.Equal(BhutanTestData.CAPITAL, country.Capital);
        Assert.Equal(BhutanTestData.NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BhutanTestData.ISO2_CODE, country.ISO2Code);
        Assert.Equal(BhutanTestData.ISO3_CODE, country.ISO3Code);
        Assert.Equal(BhutanTestData.CALLING_CODE, country.CallingCode);

        Assert.NotNull(country.States);
        Assert.Equal(BhutanTestData.EXPECTED_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BhutanTestData.STATE_TYPE, state.Type));
    }
}
