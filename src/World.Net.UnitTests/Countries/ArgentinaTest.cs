namespace World.Net.UnitTests.Countries;

public sealed class ArgentinaTest
{
    private const string ARGENTINA_NAME = "Argentina";
    private const int ARGENTINA_STATE_COUNT = 24;
    private const string ARGENTINA_OFFICIAL_NAME = "Argentine Republic";
    private const string ARGENTINA_NATIVE_NAME = "Argentina";
    private const string ARGENTINA_CAPITAL = "Buenos Aires";
    private const int ARGENTINA_NUMERIC_CODE = 032;
    private const string ARGENTINA_ISO2_CODE = "AR";
    private const string ARGENTINA_ISO3_CODE = "ARG";
    private readonly string[] ARGENTINA_CALLING_CODE = ["+54"];


    [Fact]
    public void ARGENTINA_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Argentina;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ARGENTINA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(ARGENTINA_STATE_COUNT, country.States.Count());
        Assert.Equal(ARGENTINA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ARGENTINA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ARGENTINA_CAPITAL, country.Capital);
        Assert.Equal(ARGENTINA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ARGENTINA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ARGENTINA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ARGENTINA_CALLING_CODE, country.CallingCode);
    }
}
