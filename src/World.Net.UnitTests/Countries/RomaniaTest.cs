namespace World.Net.UnitTests.Countries;

public sealed class RomaniaTest : AssertCountryTestBase
{
    private const string ROMANIA_COUNTRY_NAME = "Romania";
    private const string ROMANIA_NATIVE_NAME = "România";
    private const string ROMANIA_CAPITAL = "Bucharest";
    private const string ROMANIA_OFFICIAL_NAME = "Romania";
    private const string ROMANIA_ISO2_CODE = "RO";
    private const string ROMANIA_ISO3_CODE = "ROU";
    private const int ROMANIA_NUMERIC_CODE = 642;
    private readonly string[] ROMANIA_CALLING_CODE = ["+40"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Romania;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Alba", "RO-AB", "County"),
    new("Arad", "RO-AR", "County"),
    new("Argeș", "RO-AG", "County"),
    new("Bacău", "RO-BC", "County"),
    new("Bihor", "RO-BH", "County"),
    new("Bistrița-Năsăud", "RO-BN", "County"),
    new("Botoșani", "RO-BT", "County"),
    new("Brașov", "RO-BV", "County"),
    new("Brăila", "RO-BR", "County"),
    new("Buzău", "RO-BZ", "County"),
    new("Caraș-Severin", "RO-CS", "County"),
    new("Călărași", "RO-CL", "County"),
    new("Cluj", "RO-CJ", "County"),
    new("Constanța", "RO-CT", "County"),
    new("Covasna", "RO-CV", "County"),
    new("Dâmbovița", "RO-DB", "County"),
    new("Dolj", "RO-DJ", "County"),
    new("Galați", "RO-GL", "County"),
    new("Giurgiu", "RO-GR", "County"),
    new("Gorj", "RO-GJ", "County"),
    new("Harghita", "RO-HR", "County"),
    new("Hunedoara", "RO-HD", "County"),
    new("Ialomița", "RO-IL", "County"),
    new("Iași", "RO-IS", "County"),
    new("Ilfov", "RO-IF", "County"),
    new("Maramureș", "RO-MM", "County"),
    new("Mehedinți", "RO-MH", "County"),
    new("Mureș", "RO-MS", "County"),
    new("Neamț", "RO-NT", "County"),
    new("Olt", "RO-OT", "County"),
    new("Prahova", "RO-PH", "County"),
    new("Satu Mare", "RO-SM", "County"),
    new("Sălaj", "RO-SJ", "County"),
    new("Sibiu", "RO-SB", "County"),
    new("Suceava", "RO-SV", "County"),
    new("Teleorman", "RO-TR", "County"),
    new("Timiș", "RO-TM", "County"),
    new("Tulcea", "RO-TL", "County"),
    new("Vaslui", "RO-VS", "County"),
    new("Vâlcea", "RO-VL", "County"),
    new("Vrancea", "RO-VN", "County"),
    new("Bucharest", "RO-B", "Municipality")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForRomania()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            ROMANIA_COUNTRY_NAME,
            ROMANIA_OFFICIAL_NAME,
            ROMANIA_NATIVE_NAME,
            ROMANIA_CAPITAL,
            ROMANIA_NUMERIC_CODE,
            ROMANIA_ISO2_CODE,
            ROMANIA_ISO3_CODE,
            ROMANIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
