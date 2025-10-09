namespace World.Net.UnitTests.Countries;

public sealed class FinlandTest : AssertCountryTestBase
{
    private const string FINLAND_COUNTRY_NAME = "Finland";
    private const string FINLAND_NATIVE_NAME = "Suomen tasavalta / Republiken Finland";
    private const string FINLAND_CAPITAL = "Helsinki";
    private const string FINLAND_OFFICIAL_NAME = "Republic of Finland";
    private const string FINLAND_ISO2_CODE = "FI";
    private const string FINLAND_ISO3_CODE = "FIN";
    private const int FINLAND_NUMERIC_CODE = 246;
    private readonly string[] FINLAND_CALLING_CODE = ["+358"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.Finland;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        new("Åland", "FI-01", "Region"),
        new("Central Finland", "FI-08", "Region"),
        new("Central Ostrobothnia", "FI-07", "Region"),
        new("Etelä-Karjala", "FI-02", "Region"),
        new("Etelä-Pohjanmaa", "FI-03", "Region"),
        new("Etelä-Savo", "FI-04", "Region"),
        new("Kainuu", "FI-05", "Region"),
        new("Kanta-Häme", "FI-06", "Region"),
        new("Keski-Pohjanmaa", "FI-09", "Region"),
        new("Keski-Suomi", "FI-10", "Region"),
        new("Kymenlaakso", "FI-11", "Region"),
        new("Lappi", "FI-12", "Region"),
        new("Pirkanmaa", "FI-13", "Region"),
        new("Pohjanmaa", "FI-14", "Region"),
        new("Pohjois-Karjala", "FI-15", "Region"),
        new("Pohjois-Pohjanmaa", "FI-16", "Region"),
        new("Pohjois-Savo", "FI-17", "Region"),
        new("Päijät-Häme", "FI-18", "Region"),
        new("Satakunta", "FI-19", "Region"),
        new("Uusimaa", "FI-20", "Region"),
        new("Varsinais-Suomi", "FI-21", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFinland()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            FINLAND_COUNTRY_NAME,
            FINLAND_OFFICIAL_NAME,
            FINLAND_NATIVE_NAME,
            FINLAND_CAPITAL,
            FINLAND_NUMERIC_CODE,
            FINLAND_ISO2_CODE,
            FINLAND_ISO3_CODE,
            FINLAND_CALLING_CODE,
            ExpectedStates
        );
    }
}

