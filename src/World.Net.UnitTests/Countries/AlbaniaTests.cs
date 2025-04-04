namespace World.Net.UnitTests.Countries;

public sealed class AlbaniaTests
{
    private const string ALBANIA_NAME = "Albania";
    private const int ALBANIA_STATE_COUNT = 47;
    private const string ALBANIA_OFFICIAL_NAME = "Republic of Albania";
    private const string ALBANIA_NATIVE_NAME = "Republika e Shqipërisë";
    private const string ALBANIA_CAPITAL = "Tirana";
    private const int ALBANIA_NUMERIC_CODE = 008;
    private const string ALBANIA_ISO2_CODE = "AL";
    private const string ALBANIA_ISO3_CODE = "ALB";
    private readonly string[] ALBANIA_CALLING_CODE = ["+355"];


    [Fact]
    public void Albania_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Albania;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ALBANIA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(ALBANIA_STATE_COUNT, country.States.Count());
        Assert.Equal(ALBANIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ALBANIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ALBANIA_CAPITAL, country.Capital);
        Assert.Equal(ALBANIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ALBANIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ALBANIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ALBANIA_CALLING_CODE, country.CallingCode);
    }
}
