namespace World.Net.UnitTests.Countries;

public sealed class TunisiaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Tunisia";
    private const string NATIVE_NAME = "تونس";
    private const string CAPITAL = "Tunis";
    private const string OFFICIAL_NAME = "Republic of Tunisia";
    private const string ISO2_CODE = "TN";
    private const string ISO3_CODE = "TUN";
    private const int NUMERIC_CODE = 788;
    private readonly string[] CALLING_CODE = ["+216"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Tunisia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Ariana", "TN-12", "Governorate"),
    ("Beja", "TN-31", "Governorate"),
    ("Ben Arous", "TN-13", "Governorate"),
    ("Bizerte", "TN-23", "Governorate"),
    ("Gabes", "TN-81", "Governorate"),
    ("Gafsa", "TN-71", "Governorate"),
    ("Jendouba", "TN-32", "Governorate"),
    ("Kairouan", "TN-41", "Governorate"),
    ("Kasserine", "TN-42", "Governorate"),
    ("Kebili", "TN-73", "Governorate"),
    ("Kef", "TN-33", "Governorate"),
    ("Mahdia", "TN-53", "Governorate"),
    ("Manouba", "TN-14", "Governorate"),
    ("Medenine", "TN-82", "Governorate"),
    ("Monastir", "TN-52", "Governorate"),
    ("Nabeul", "TN-21", "Governorate"),
    ("Sfax", "TN-81", "Governorate"),
    ("Sidi Bouzid", "TN-43", "Governorate"),
    ("Siliana", "TN-34", "Governorate"),
    ("Sousse", "TN-51", "Governorate"),
    ("Tataouine", "TN-83", "Governorate"),
    ("Tozeur", "TN-72", "Governorate"),
    ("Tunis", "TN-11", "Governorate"),
    ("Zaghouan", "TN-22", "Governorate")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTunisia()
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
