
namespace World.Net.UnitTests.Countries;

public sealed class MongoliaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Mongolia";
    private const string OFFICIAL_NAME = "Mongolia";
    private const string NATIVE_NAME = "Монгол Улс";
    private const string CAPITAL = "Ulaanbaatar";
    private const string ISO2_CODE = "MN";
    private const string ISO3_CODE = "MNG";
    private const int NUMERIC_CODE = 496;
    private readonly string[] CALLING_CODE = ["+976"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Mongolia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Arkhangai", "MN-073", "Province"),
    ("Bayan-Ölgii", "MN-071", "Province"),
    ("Bayankhongor", "MN-069", "Province"),
    ("Bulgan", "MN-067", "Province"),
    ("Darkhan-Uul", "MN-037", "Province"),
    ("Dornod", "MN-061", "Province"),
    ("Dornogovi", "MN-063", "Province"),
    ("Dundgovi", "MN-059", "Province"),
    ("Govi-Altai", "MN-065", "Province"),
    ("Govisümber", "MN-064", "Province"),
    ("Khentii", "MN-039", "Province"),
    ("Khovd", "MN-043", "Province"),
    ("Khövsgöl", "MN-041", "Province"),
    ("Ömnögovi", "MN-053", "Province"),
    ("Orkhon", "MN-035", "Province"),
    ("Övörkhangai", "MN-055", "Province"),
    ("Selenge", "MN-049", "Province"),
    ("Sükhbaatar", "MN-051", "Province"),
    ("Töv", "MN-047", "Province"),
    ("Uvs", "MN-046", "Province"),
    ("Zavkhan", "MN-057", "Province"),
    ("Ulaanbaatar", "MN-1", "Municipality")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMongolia()
    {
        var country = CountryProvider.GetCountry(EXPECTEDID);

        AssertCorrectInformation(
            country,
            EXPECTEDID,
            COUNTRY_NAME,
            OFFICIAL_NAME,
            NATIVE_NAME,
            CAPITAL,
            NUMERIC_CODE,
            ISO2_CODE,
            ISO3_CODE,
            CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
