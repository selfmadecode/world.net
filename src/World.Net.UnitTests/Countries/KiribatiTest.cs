using World.Net;
using World.Net.Helpers;

namespace World.Net.UnitTests.Countries;

public sealed class KiribatiTest
{
    private const string KIRIBATI_COUNTRY_NAME = "Kiribati";
    private const string KIRIBATI_NATIVE_NAME = "Kiribati";
    private const string KIRIBATI_CAPITAL = "South Tarawa";
    private const string KIRIBATI_OFFICIAL_NAME = "Republic of Kiribati";
    private const string KIRIBATI_ISO2_CODE = "KI";
    private const string KIRIBATI_ISO3_CODE = "KIR";
    private const int KIRIBATI_NUMERIC_CODE = 296;
    private readonly string[] KIRIBATI_CALLING_CODE = ["+686"];
    private const int KIRIBATI_STATE_COUNT = 3;
    private static readonly string[] VALID_STATE_TYPES = { "Group" };

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForKiribati()
    {
        // Arrange
        CountryIdentifier existingCountryId = CountryIdentifier.Kiribati;

        // Act
        var country = CountryProvider.GetCountry(existingCountryId);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(existingCountryId, country.Id);
        Assert.Equal(KIRIBATI_COUNTRY_NAME, country.Name);
        Assert.Equal(KIRIBATI_OFFICIAL_NAME, country.OfficialName);
        Assert.Equal(KIRIBATI_NATIVE_NAME, country.NativeName);
        Assert.Equal(KIRIBATI_CAPITAL, country.Capital);
        Assert.Equal(KIRIBATI_NUMERIC_CODE, country.NumericCode);
        Assert.Equal(KIRIBATI_ISO2_CODE, country.ISO2Code);
        Assert.Equal(KIRIBATI_ISO3_CODE, country.ISO3Code);
        Assert.Equal(KIRIBATI_CALLING_CODE, country.CallingCode);
        Assert.NotNull(country.States);
        Assert.Equal(KIRIBATI_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));
    }
}
