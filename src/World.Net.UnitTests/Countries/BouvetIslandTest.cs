namespace World.Net.UnitTests.Countries;

public sealed class BouvetIslandTest
{
    private const string BOUVETISLAND_NAME = "Bouvet Island";
    private const string BOUVETISLAND_OFFICIAL_NAME = "Bouvetøya";
    private const string BOUVETISLAND_NATIVE_NAME = "Bouvetøya";
    private const string BOUVETISLAND_CAPITAL = "";
    private const int BOUVETISLAND_NUMERIC_CODE = 074;
    private const string BOUVETISLAND_ISO2_CODE = "BV";
    private const string BOUVETISLAND_ISO3_CODE = "BVT";
    private readonly string[] BOUVETISLAND_CALLING_CODE = ["+0055"];


    [Fact]
    public void BouvetIsland_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.BouvetIsland;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BOUVETISLAND_NAME, country.Name);
        Assert.Equal(BOUVETISLAND_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BOUVETISLAND_NATIVE_NAME, country.NativeName);
        Assert.Equal(BOUVETISLAND_CAPITAL, country.Capital);
        Assert.Equal(BOUVETISLAND_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BOUVETISLAND_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BOUVETISLAND_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BOUVETISLAND_CALLING_CODE, country.CallingCode);
    }
}
