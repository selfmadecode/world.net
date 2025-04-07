namespace World.Net.UnitTests.Countries;

public sealed class BeninTest
{
    private const string BENIN_NAME = "Benin";
    private const string BENIN_OFFICIAL_NAME = "Republic of Benin";
    private const string BENIN_NATIVE_NAME = "Bénin";
    private const string BENIN_CAPITAL = "Porto-Novo";
    private const int BENIN_NUMERIC_CODE = 204;
    private const string BENIN_ISO2_CODE = "BJ";
    private const string BENIN_ISO3_CODE = "BEN";
    private readonly string[] BENIN_CALLING_CODE = ["+229"];
    private const int BENIN_DEPARTMENT_COUNT = 12;
    private const string BENIN_STATE_TYPE = "Department";
    
    [Fact]
    public void BeninTest_HasExpectedInformation()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Benin;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        //Assert
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(BENIN_NAME, country.Name);
        Assert.Equal(BENIN_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BENIN_NATIVE_NAME, country.NativeName);
        Assert.Equal(BENIN_CAPITAL, country.Capital);
        Assert.Equal(BENIN_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BENIN_ISO2_CODE, country.ISO2Code);
        Assert.Equal(BENIN_ISO3_CODE, country.ISO3Code);
        Assert.Equal(BENIN_CALLING_CODE, country.CallingCode);

        // Validate states (departments)
        Assert.NotNull(country.States);
        Assert.Equal(BENIN_DEPARTMENT_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BENIN_STATE_TYPE, state.Type));
    }
}
