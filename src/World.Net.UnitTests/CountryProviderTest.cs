using World.Net.Helpers;

namespace World.Net.UnitTests;

public sealed class CountryProviderTest
{
    private const string AFGHANISTAN_ISO2_CODE = "AF";
    private const string AFGHANISTAN_ISO3_CODE = "AFG";
    private const string AFGHANISTAN_CAPITAL = "Kabul";
    private const int AFGHANISTAN_NUMERIC_CODE = 004;
    private readonly string[] AFGHANISTAN_CALLING_CODE = ["+93"];
    private const int AFGHANISTAN_STATE_COUNT = 34;
    private const string AFGHANISTAN_NAME = "Afghanistan";
    private const string AFGHANISTAN_NATIVE_NAME = "افغانستان";
    private const string AFGHANISTAN_OFFICIAL_NAME = "Islamic Republic of Afghanistan";
    [Fact]
    public void GetAllCountries_ShouldReturn_NonEmptyAndNonNullCollection()
    {
        var countries = CountryProvider.GetAllCountries();

        Assert.NotEmpty(countries);
        Assert.NotNull(countries);
    }

    [Fact]
    public void GetCountry_ShouldReturn_Country_WhenCountryExists()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Afghanistan;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);
        
        // Assert
        Assert.NotNull(country);
        Assert.NotEmpty(country.Name);
        Assert.NotEmpty(country.States);
        Assert.Equal(AFGHANISTAN_ISO2_CODE, country.ISO2Code);
        Assert.Equal(AFGHANISTAN_ISO3_CODE, country.ISO3Code);
        Assert.Equal(AFGHANISTAN_CAPITAL, country.Capital);
        Assert.Equal(AFGHANISTAN_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(AFGHANISTAN_CALLING_CODE, country.CallingCode);
        Assert.Equal(AFGHANISTAN_STATE_COUNT, country.States.Count());
        Assert.Equal(AFGHANISTAN_NAME, country.Name);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(AFGHANISTAN_NATIVE_NAME, country.NativeName);
        Assert.Equal(AFGHANISTAN_OFFICIAL_NAME, country.OfficialName);        
    }

    [Fact]
    public void GetCountry_ShouldThrow_CountryNotFoundException_WhenCountryDoesNotExist()
    {
        // Arrange
        CountryIdentifier nonExistingCountryId = (CountryIdentifier)9999999;

        // Act & Assert
        var exception = Assert.Throws<CountryNotFoundException>(() => CountryProvider.GetCountry(nonExistingCountryId));
        Assert.Equal($"Country with id {nonExistingCountryId} was not found.", exception.Message);
    }
}