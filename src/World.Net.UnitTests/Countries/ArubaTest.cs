namespace World.Net.UnitTests.Countries;

public sealed class ArubaTest
{
    private const string ARUBA_NAME = "Aruba";
    private const int ARUBA_STATE_COUNT = 8;
    private const string ARUBA_OFFICIAL_NAME = "Country of Aruba";
    private const string ARUBA_NATIVE_NAME = "Aruba";
    private const string ARUBA_CAPITAL = "Oranjestad";
    private const int ARUBA_NUMERIC_CODE = 533;
    private const string ARUBA_ISO2_CODE = "AW";
    private const string ARUBA_ISO3_CODE = "ABW";
    private readonly string[] ARUBA_CALLING_CODE = ["+297"];


    [Fact]
    public void Aruba_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Aruba;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(ARUBA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(ARUBA_STATE_COUNT, country.States.Count());
        Assert.Equal(ARUBA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(ARUBA_NATIVE_NAME, country.NativeName);
        Assert.Equal(ARUBA_CAPITAL, country.Capital);
        Assert.Equal(ARUBA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(ARUBA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(ARUBA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(ARUBA_CALLING_CODE, country.CallingCode);
    }
}
