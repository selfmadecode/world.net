namespace World.Net.UnitTests.Countries;

public sealed class KazakhstanTest : AssertCountryTestBase
{
    private const CountryIdentifier ExpectedId = CountryIdentifier.Kazakhstan;
    private const string ExpectedName = "Kazakhstan";
    private const string ExpectedOfficialName = "Republic of Kazakhstan";
    private const string ExpectedNativeName = "?????????";
    private const string ExpectedCapital = "Astana";
    private const int ExpectedNumericCode = 398;
    private const string ExpectedISO2Code = "KZ";
    private const string ExpectedISO3Code = "KAZ";
    private static readonly string[] ExpectedCallingCode = ["+7"];
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Akmola", "KZ-AKM", "Region"),
        ("Aktobe", "KZ-AKT", "Region"),
        ("Almaty", "KZ-ALM", "Region"),
        ("Atyrau", "KZ-ATY", "Region"),
        ("East Kazakhstan", "KZ-VOS", "Region"),
        ("Jambyl", "KZ-ZHA", "Region"),
        ("Karaganda", "KZ-KAR", "Region"),
        ("Kostanay", "KZ-KUS", "Region"),
        ("Kyzylorda", "KZ-KZY", "Region"),
        ("Mangystau", "KZ-MAN", "Region"),
        ("Pavlodar", "KZ-PAV", "Region"),
        ("North Kazakhstan", "KZ-SEV", "Region"),
        ("Turkistan", "KZ-TUR", "Region"),
        ("West Kazakhstan", "KZ-ZAP", "Region"),
        ("Nur-Sultan", "KZ-NUR", "City"),
        ("Almaty City", "KZ-ALA", "City"),
        ("Shymkent", "KZ-SHY", "City")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForKazakhstan()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            ExpectedName,
            ExpectedOfficialName,
            ExpectedNativeName,
            ExpectedCapital,
            ExpectedNumericCode,
            ExpectedISO2Code,
            ExpectedISO3Code,
            ExpectedCallingCode,
            ExpectedStates
        );
    }
}
