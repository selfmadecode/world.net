namespace World.Net.UnitTests.Countries;

public sealed class ArgentinaTest
{
    private const string Argentina_NAME = "Argentina";
    private const int Argentina_STATE_COUNT = 24;
    private const string Argentina_OFFICIAL_NAME = "Argentine Republic";
    private const string Argentina_NATIVE_NAME = "Argentina";
    private const string Argentina_CAPITAL = "Buenos Aires";
    private const int Argentina_NUMERIC_CODE = 032;
    private const string Argentina_ISO2_CODE = "AR";
    private const string Argentina_ISO3_CODE = "ARG";
    private const string Argentina_CALLING_CODE = "+54";


    [Fact]
    public void Argentina_HasExpectedInformation()
    {
        // Arrange
        int existingCountryId = CountryIdentifier.Argentina;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(Argentina_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(Argentina_STATE_COUNT, country.States.Count());
        Assert.Equal(Argentina_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(Argentina_NATIVE_NAME, country.NativeName);
        Assert.Equal(Argentina_CAPITAL, country.Capital);
        Assert.Equal(Argentina_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(Argentina_ISO2_CODE, country.ISO2Code);
        Assert.Equal(Argentina_ISO3_CODE, country.ISO3Code);
        Assert.Equal(Argentina_CALLING_CODE, country.CallingCode);
    }
}
