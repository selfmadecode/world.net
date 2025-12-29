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

    [Fact]
    public void GetCountries_ValidIdentifiers_ReturnsCorrectCountries()
    {
        // Arrange
        var indentifiers = new List<CountryIdentifier>
        {
            CountryIdentifier.Afghanistan,
            CountryIdentifier.Brazil
        };

        // Act
        var result = CountryProvider.GetCountries(indentifiers);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(indentifiers.Count, result.Count);
    }

    [Fact]
    public void GetCountries_EmptyIdentifiers_ReturnsEmptyList()
    {
        // Arrange
        var emptyIdentifiers = new List<CountryIdentifier>();

        // Act
        var result = CountryProvider.GetCountries(emptyIdentifiers);

        // Assert
        Assert.Empty(result);
        Assert.Equal(emptyIdentifiers.Count, result.Count);
    }

    [Fact]
    public void GetCountries_WhenIdentifiersContainDuplicates_ReturnsDistinctCountries()
    {
        // Arrange
        var indentifiers = new List<CountryIdentifier>
        {
            CountryIdentifier.Afghanistan,
            CountryIdentifier.Afghanistan,
            CountryIdentifier.Argentina,
            CountryIdentifier.Brazil,
            CountryIdentifier.Brazil
        };

        // Act
        var result = CountryProvider.GetCountries(indentifiers);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(3, result.Count);
    }
}