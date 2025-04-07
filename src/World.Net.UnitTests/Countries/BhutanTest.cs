namespace World.Net.UnitTests.Countries;

internal static class BhutanTestData
{
    internal const string COUNTRY_NAME = "Bhutan";
    internal const string NATIVE_NAME = "ʼbrug-yul";
    internal const string CAPITAL = "Thimphu";
    internal const string OFFICIAL_NAME = "Kingdom of Bhutan";
    internal const string ISO2_CODE = "BT";
    internal const string ISO3_CODE = "BTN";
    internal const int NUMERIC_CODE = 64;
    internal static readonly string[] CALLING_CODE = ["+975"];
    internal const string STATE_TYPE = "District";
    internal const int EXPECTED_STATE_COUNT = 20;
}

public sealed class BhutanTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForBhutan()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Bhutan;

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
