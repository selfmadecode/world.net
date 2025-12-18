namespace World.Net.UnitTests.Countries;

public sealed class GuineaBissauTest : AssertCountryTestBase
{
    private const string GUINEABISSAU_COUNTRY_NAME = "Guinea-Bissau";
    private const string GUINEABISSAU_NATIVE_NAME = "Guiné-Bissau";
    private const string GUINEABISSAU_CAPITAL = "Bissau";
    private const string GUINEABISSAU_OFFICIAL_NAME = "Republic of Guinea-Bissau";
    private const string GUINEABISSAU_ISO2_CODE = "GW";
    private const string GUINEABISSAU_ISO3_CODE = "GNB";
    private const int GUINEABISSAU_NUMERIC_CODE = 624;
    private readonly string[] GUINEABISSAU_CALLING_CODE = ["+245"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.GuineaBissau;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Bafatá", "GW-BFA", "Region"),
        new("Biombo", "GW-BIB", "Region"),
        new("Bissau", "GW-BS", "Region"),
        new("Bolama", "GW-BM", "Region"),
        new("Cacheu", "GW-CA", "Region"),
        new("Gabu", "GW-GA", "Region"),
        new("Oio", "GW-OI", "Region"),
        new("Quinara", "GW-QU", "Region"),
        new("Tombali", "GW-TO", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGuineaBissau()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GUINEABISSAU_COUNTRY_NAME,
            GUINEABISSAU_OFFICIAL_NAME,
            GUINEABISSAU_NATIVE_NAME,
            GUINEABISSAU_CAPITAL,
            GUINEABISSAU_NUMERIC_CODE,
            GUINEABISSAU_ISO2_CODE,
            GUINEABISSAU_ISO3_CODE,
            GUINEABISSAU_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}

