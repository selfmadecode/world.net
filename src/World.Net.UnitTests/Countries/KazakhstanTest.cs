namespace World.Net.UnitTests.Countries;

public sealed class KazakhstanTest : AssertCountryTestBase
{
    private const CountryIdentifier ExpectedId = CountryIdentifier.Kazakhstan;
    private const string ExpectedName = "Kazakhstan";
    private const string ExpectedOfficialName = "Republic of Kazakhstan";
    private const string ExpectedNativeName = "Қазақстан";
    private const string ExpectedCapital = "Astana";
    private const int ExpectedNumericCode = 398;
    private const string ExpectedISO2Code = "KZ";
    private const string ExpectedISO3Code = "KAZ";
    private static readonly string[] ExpectedCallingCode = ["+7"];
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Abai", "KZ-10", "Region"),
        ("Akmola", "KZ-11", "Region"),
        ("Aktobe", "KZ-15", "Region"),
        ("Almaty", "KZ-19", "Region"),
        ("Atyrau", "KZ-23", "Region"),
        ("East Kazakhstan", "KZ-63", "Region"),
        ("Jambyl", "KZ-31", "Region"),
        ("Jetisu", "KZ-33", "Region"),
        ("Karaganda", "KZ-35", "Region"),
        ("Kostanay", "KZ-39", "Region"),
        ("Kyzylorda", "KZ-43", "Region"),
        ("Mangystau", "KZ-47", "Region"),
        ("Pavlodar", "KZ-55", "Region"),
        ("North Kazakhstan", "KZ-59", "Region"),
        ("Turkistan", "KZ-61", "Region"),
        ("Ulytau", "KZ-62", "Region"),
        ("West Kazakhstan", "KZ-27", "Region"),
        ("Astana", "KZ-71", "City"),
        ("Almaty City", "KZ-75", "City"),
        ("Shymkent", "KZ-79", "City")
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
