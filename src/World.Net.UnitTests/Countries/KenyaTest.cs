using World.Net;
using World.Net.Helpers;

namespace World.Net.UnitTests.Countries;

public sealed class KenyaTest
{
    private const string KENYA_COUNTRY_NAME = "Kenya";
    private const string KENYA_NATIVE_NAME = "Kenya";
    private const string KENYA_CAPITAL = "Nairobi";
    private const string KENYA_OFFICIAL_NAME = "Republic of Kenya";
    private const string KENYA_ISO2_CODE = "KE";
    private const string KENYA_ISO3_CODE = "KEN";
    private const int KENYA_NUMERIC_CODE = 404;
    private readonly string[] KENYA_CALLING_CODE = ["+254"];
    private const int KENYA_STATE_COUNT = 47;
    private static readonly string[] VALID_STATE_TYPES = { "County" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForKenya()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Kenya;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(KENYA_COUNTRY_NAME, country.Name);
        Assert.Equal(KENYA_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(KENYA_NATIVE_NAME, country.NativeName);
        Assert.Equal(KENYA_CAPITAL, country.Capital);
        Assert.Equal(KENYA_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(KENYA_ISO2_CODE, country.ISO2Code);
        Assert.Equal(KENYA_ISO3_CODE, country.ISO3Code);
        Assert.Equal(KENYA_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(KENYA_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
