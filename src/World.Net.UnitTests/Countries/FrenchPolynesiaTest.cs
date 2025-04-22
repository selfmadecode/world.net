namespace World.Net.UnitTests.Countries;
public sealed class FrenchPolynesiaTest
{
    private const string FRENCH_POLYNESIA_NAME = "French Polynesia";
    private const int FRENCH_POLYNESIA_STATE_COUNT = 5;
    private const string FRENCH_POLYNESIA_OFFICIAL_NAME = "Polynésie française";
    private const string FRENCH_POLYNESIA_NATIVE_NAME = "Polynésie française";
    private const string FRENCH_POLYNESIA_CAPITAL = "Papeete";
    private const int FRENCH_POLYNESIA_NUMERIC_CODE = 258;
    private const string FRENCH_POLYNESIA_ISO2_CODE = "PF";
    private const string FRENCH_POLYNESIA_ISO3_CODE = "PYF";
    private readonly string[] FRENCH_POLYNESIA_CALLING_CODE = ["+689"];


    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFrench_Polynesia()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.FrenchPolynesia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(FRENCH_POLYNESIA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(FRENCH_POLYNESIA_STATE_COUNT, country.States.Count());
        Assert.Equal(FRENCH_POLYNESIA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(FRENCH_POLYNESIA_NATIVE_NAME, country.NativeName);
        Assert.Equal(FRENCH_POLYNESIA_CAPITAL, country.Capital);
        Assert.Equal(FRENCH_POLYNESIA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(FRENCH_POLYNESIA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(FRENCH_POLYNESIA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(FRENCH_POLYNESIA_CALLING_CODE, country.CallingCode);
    }
}
