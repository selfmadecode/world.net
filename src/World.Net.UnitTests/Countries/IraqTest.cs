namespace World.Net.UnitTests.Countries;
public sealed class IraqTest : AssertCountryTestBase
{
    private const string IRAQ_COUNTRY_NAME = "Iraq";
    private const string IRAQ_NATIVE_NAME = "العراق";
    private const string IRAQ_CAPITAL = "Baghdad";
    private const string IRAQ_OFFICIAL_NAME = "Republic of Iraq";
    private const string IRAQ_ISO2_CODE = "IQ";
    private const string IRAQ_ISO3_CODE = "IRQ";
    private const int IRAQ_NUMERIC_CODE = 368;
    private readonly string[] IRAQ_CALLING_CODE = ["+964"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.Iraq;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Al Anbar", "IQ-AN", "Governorate"),
        ("Al Muthanna", "IQ-MU", "Governorate"),
        ("Al-Qādisiyyah", "IQ-QA", "Governorate"),
        ("Babylon", "IQ-BB", "Governorate"),
        ("Baghdad", "IQ-BG", "Governorate"),
        ("Basra", "IQ-BA", "Governorate"),
        ("Dhi Qar", "IQ-DQ", "Governorate"),
        ("Diyala", "IQ-DI", "Governorate"),
        ("Dohuk", "IQ-DA", "Governorate"),
        ("Erbil", "IQ-AR", "Governorate"),
        ("Karbala", "IQ-KA", "Governorate"),
        ("Kirkuk", "IQ-KI", "Governorate"),
        ("Maysan", "IQ-MA", "Governorate"),
        ("Najaf", "IQ-NA", "Governorate"),
        ("Nineveh", "IQ-NI", "Governorate"),
        ("Saladin", "IQ-SD", "Governorate"),
        ("Sulaymaniyah", "IQ-SU", "Governorate"),
        ("Wasit", "IQ-WA", "Governorate")

    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIraq()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            IRAQ_COUNTRY_NAME,
            IRAQ_OFFICIAL_NAME,
            IRAQ_NATIVE_NAME,
            IRAQ_CAPITAL,
            IRAQ_NUMERIC_CODE,
            IRAQ_ISO2_CODE,
            IRAQ_ISO3_CODE,
            IRAQ_CALLING_CODE,
            ExpectedStates
        );
    }
}

