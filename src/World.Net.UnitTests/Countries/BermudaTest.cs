namespace World.Net.UnitTests.Countries;
public static class BermudaTestData
{
    public const string COUNTRY_NAME = "Bermuda";
    public const string NATIVE_NAME = "Bermuda";
    public const string CAPITAL = "Hamilton";
    public const string OFFICIAL_NAME = "Bermuda";
    public const string ISO2_CODE = "BM";
    public const string ISO3_CODE = "BMU";
    public const int NUMERIC_CODE = 60;
    public const string CALLING_CODE = "+1-441";
    public const string STATE_TYPE = "Municipality";
    public const int EXPECTED_STATE_COUNT = 9;
}

public sealed class BermudaTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForBermuda()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Bermuda;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);

        Assert.Equal(BermudaTestData.COUNTRY_NAME, country.Name);
        Assert.Equal(BermudaTestData.OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BermudaTestData.NATIVE_NAME, country.NativeName);
        Assert.Equal(BermudaTestData.CAPITAL, country.Capital);
        Assert.Equal(BermudaTestData.NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BermudaTestData.ISO2_CODE, country.ISO2Code);
        Assert.Equal(BermudaTestData.ISO3_CODE, country.ISO3Code);
        Assert.Equal(BermudaTestData.CALLING_CODE, country.CallingCode);

        Assert.NotNull(country.States);
        Assert.Equal(BermudaTestData.EXPECTED_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BermudaTestData.STATE_TYPE, state.Type));
    }
}

