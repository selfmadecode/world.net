using World.Net;
using World.Net.Helpers;

namespace World.Net.UnitTests.Countries;

public sealed class KenyaTest : AssertCountryTestBase
{
    private const string KENYA_COUNTRY_NAME = "Kenya";
    private const string KENYA_NATIVE_NAME = "Kenya";
    private const string KENYA_CAPITAL = "Nairobi";
    private const string KENYA_OFFICIAL_NAME = "Republic of Kenya";
    private const string KENYA_ISO2_CODE = "KE";
    private const string KENYA_ISO3_CODE = "KEN";
    private const int KENYA_NUMERIC_CODE = 404;
    private readonly string[] KENYA_CALLING_CODE = ["+254"];
    private static readonly string[] VALID_STATE_TYPES = { "County" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.Kenya;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Baringo", "KE-01", "County"),
        ("Bomet", "KE-02", "County"),
        ("Bungoma", "KE-03", "County"),
        ("Busia", "KE-04", "County"),
        ("Elgeyo-Marakwet", "KE-05", "County"),
        ("Embu", "KE-06", "County"),
        ("Garissa", "KE-07", "County"),
        ("Homa Bay", "KE-08", "County"),
        ("Isiolo", "KE-09", "County"),
        ("Kajiado", "KE-10", "County"),
        ("Kakamega", "KE-11", "County"),
        ("Kericho", "KE-12", "County"),
        ("Kiambu", "KE-13", "County"),
        ("Kilifi", "KE-14", "County"),
        ("Kirinyaga", "KE-15", "County"),
        ("Kisii", "KE-16", "County"),
        ("Kisumu", "KE-17", "County"),
        ("Kitui", "KE-18", "County"),
        ("Kwale", "KE-19", "County"),
        ("Laikipia", "KE-20", "County"),
        ("Lamu", "KE-21", "County"),
        ("Machakos", "KE-22", "County"),
        ("Makueni", "KE-23", "County"),
        ("Mandera", "KE-24", "County"),
        ("Marsabit", "KE-25", "County"),
        ("Meru", "KE-26", "County"),
        ("Migori", "KE-27", "County"),
        ("Mombasa", "KE-28", "County"),
        ("Murang'a", "KE-29", "County"),
        ("Nairobi City", "KE-30", "County"),
        ("Nakuru", "KE-31", "County"),
        ("Nandi", "KE-32", "County"),
        ("Narok", "KE-33", "County"),
        ("Nyamira", "KE-34", "County"),
        ("Nyandarua", "KE-35", "County"),
        ("Nyeri", "KE-36", "County"),
        ("Samburu", "KE-37", "County"),
        ("Siaya", "KE-38", "County"),
        ("Taita-Taveta", "KE-39", "County"),
        ("Tana River", "KE-40", "County"),
        ("Tharaka-Nithi", "KE-41", "County"),
        ("Trans Nzoia", "KE-42", "County"),
        ("Turkana", "KE-43", "County"),
        ("Uasin Gishu", "KE-44", "County"),
        ("Vihiga", "KE-45", "County"),
        ("Wajir", "KE-46", "County"),
        ("West Pokot", "KE-47", "County")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForKenya()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        Assert.NotNull(country);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));

        AssertCorrectInformation(
            country,
            ExpectedId,
            KENYA_COUNTRY_NAME,
            KENYA_OFFICIAL_NAME,
            KENYA_NATIVE_NAME,
            KENYA_CAPITAL,
            KENYA_NUMERIC_CODE,
            KENYA_ISO2_CODE,
            KENYA_ISO3_CODE,
            KENYA_CALLING_CODE,
            ExpectedStates
        );
    }
}
