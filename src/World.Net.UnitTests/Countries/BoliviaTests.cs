namespace World.Net.UnitTests.Countries;

internal static class BoliviaTestData
{
    internal const string COUNTRY_NAME = "Bolivia";
    internal const string NATIVE_NAME = "Bolivia";
    internal const string CAPITAL = "Sucre";
    internal const string OFFICIAL_NAME = "Plurinational State of Bolivia";
    internal const string ISO2_CODE = "BO";
    internal const string ISO3_CODE = "BOL";
    internal const int NUMERIC_CODE = 68;
    internal static readonly string[] CALLING_CODE = ["+591"];
    internal const string STATE_TYPE = "Department";
    internal const int EXPECTED_STATE_COUNT = 9;
}

public sealed class BoliviaTest
{
    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForBolivia()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Bolivia;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);

        Assert.Equal(BoliviaTestData.COUNTRY_NAME, country.Name);
        Assert.Equal(BoliviaTestData.OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(BoliviaTestData.NATIVE_NAME, country.NativeName);
        Assert.Equal(BoliviaTestData.CAPITAL, country.Capital);
        Assert.Equal(BoliviaTestData.NUMERIC_CODE, country.NumericCode);
        Assert.Equal(BoliviaTestData.ISO2_CODE, country.ISO2Code);
        Assert.Equal(BoliviaTestData.ISO3_CODE, country.ISO3Code);
        Assert.Equal(BoliviaTestData.CALLING_CODE, country.CallingCode);

        Assert.NotNull(country.States);
        Assert.Equal(BoliviaTestData.EXPECTED_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Equal(BoliviaTestData.STATE_TYPE, state.Type));
    }
}
