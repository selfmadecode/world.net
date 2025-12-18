namespace World.Net.UnitTests.Countries;

public sealed class IndiaTest : AssertCountryTestBase
{
    private const string INDIA_COUNTRY_NAME = "India";
    private const string INDIA_NATIVE_NAME = "भारत";
    private const string INDIA_CAPITAL = "New Delhi";
    private const string INDIA_OFFICIAL_NAME = "Republic of India";
    private const string INDIA_ISO2_CODE = "IN";
    private const string INDIA_ISO3_CODE = "IND";
    private const int INDIA_NUMERIC_CODE = 356;
    private readonly string[] INDIA_CALLING_CODE = ["+91"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.India;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Andhra Pradesh", "IN-AP", "State"),
        new("Arunachal Pradesh", "IN-AR", "State"),
        new("Assam", "IN-AS", "State"),
        new("Bihar", "IN-BR", "State"),
        new("Chhattisgarh", "IN-CT", "State"),
        new("Goa", "IN-GA", "State"),
        new("Gujarat", "IN-GJ", "State"),
        new("Haryana", "IN-HR", "State"),
        new("Himachal Pradesh", "IN-HP", "State"),
        new("Jharkhand", "IN-JH", "State"),
        new("Karnataka", "IN-KA", "State"),
        new("Kerala", "IN-KL", "State"),
        new("Madhya Pradesh", "IN-MP", "State"),
        new("Maharashtra", "IN-MH", "State"),
        new("Manipur", "IN-MN", "State"),
        new("Meghalaya", "IN-ML", "State"),
        new("Mizoram", "IN-MZ", "State"),
        new("Nagaland", "IN-NL", "State"),
        new("Odisha", "IN-OR", "State"),
        new("Punjab", "IN-PB", "State"),
        new("Rajasthan", "IN-RJ", "State"),
        new("Sikkim", "IN-SK", "State"),
        new("Tamil Nadu", "IN-TN", "State"),
        new("Telangana", "IN-TG", "State"),
        new("Tripura", "IN-TR", "State"),
        new("Uttar Pradesh", "IN-UP", "State"),
        new("Uttarakhand", "IN-UT", "State"),
        new("West Bengal", "IN-WB", "State"),
        new("Andaman and Nicobar Islands", "IN-AN", "Union Territory"),
        new("Chandigarh", "IN-CH", "Union Territory"),
        new("Dadra and Nagar Haveli and Daman and Diu", "IN-DN", "Union Territory"),
        new("Delhi", "IN-DL", "Union Territory"),
        new("Jammu and Kashmir", "IN-JK", "Union Territory"),
        new("Ladakh", "IN-LA", "Union Territory"),
        new("Lakshadweep", "IN-LD", "Union Territory"),
        new("Puducherry", "IN-PY", "Union Territory")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIndia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            INDIA_COUNTRY_NAME,
            INDIA_OFFICIAL_NAME,
            INDIA_NATIVE_NAME,
            INDIA_CAPITAL,
            INDIA_NUMERIC_CODE,
            INDIA_ISO2_CODE,
            INDIA_ISO3_CODE,
            INDIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
