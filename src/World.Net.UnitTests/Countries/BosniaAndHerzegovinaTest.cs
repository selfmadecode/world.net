namespace World.Net.UnitTests.Countries;

public sealed class BosniaAndHerzegovinaTest
{
    private const string BOSNIA_AND_HERZEGOVINA_NAME = "Bosnia And Herzegovina";
    private const int BOSNIA_AND_HERZEGOVINA_STATE_COUNT = 13;
    private const string BOSNIA_AND_HERZEGOVINA_OFFICIAL_NAME = "Bosna i Hercegovina";
    private const string BOSNIA_AND_HERZEGOVINA_NATIVE_NAME = "Bosna i Hercegovina";
    private const string BOSNIA_AND_HERZEGOVINA_CAPITAL = "Sarajevo";
    private const int BOSNIA_AND_HERZEGOVINA_NUMERIC_CODE = 070;
    private const string BOSNIA_AND_HERZEGOVINA_ISO2_CODE = "BA";
    private const string BOSNIA_AND_HERZEGOVINA_ISO3_CODE = "BIH";
    private const string BOSNIA_AND_HERZEGOVINA_CALLING_CODE = "+387";


    [Fact]
    public void Bosnia_And_Herzegovina_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.BosniaAndHerzegovina;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_NAME, country.Name);
        Assert.NotNull(country.States);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_STATE_COUNT, country.States.Count());
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_NATIVE_NAME, country.NativeName);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_CAPITAL, country.Capital);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BOSNIA_AND_HERZEGOVINA_CALLING_CODE, country.CallingCode);
    }
}
