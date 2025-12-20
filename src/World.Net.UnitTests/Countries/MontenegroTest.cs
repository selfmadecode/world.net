using System;
namespace World.Net.UnitTests.Countries;

public sealed class MontenegroTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Montenegro";
    private const string OFFICIAL_NAME = "Montenegro";
    private const string NATIVE_NAME = "Crna Gora";
    private const string CAPITAL = "Podgorica";
    private const string ISO2_CODE = "ME";
    private const string ISO3_CODE = "MNE";
    private const int NUMERIC_CODE = 499;
    private readonly string[] CALLING_CODE = ["+382"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Montenegro;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Andrijevica", "ME-01", "Municipality"),
    ("Bar", "ME-02", "Municipality"),
    ("Berane", "ME-03", "Municipality"),
    ("Bijelo Polje", "ME-04", "Municipality"),
    ("Budva", "ME-05", "Municipality"),
    ("Cetinje", "ME-06", "Municipality"),
    ("Danilovgrad", "ME-07", "Municipality"),
    ("Herceg Novi", "ME-08", "Municipality"),
    ("Kolašin", "ME-09", "Municipality"),
    ("Kotor", "ME-10", "Municipality"),
    ("Mojkovac", "ME-11", "Municipality"),
    ("Nikšić", "ME-12", "Municipality"),
    ("Plav", "ME-13", "Municipality"),
    ("Pljevlja", "ME-14", "Municipality"),
    ("Plužine", "ME-15", "Municipality"),
    ("Podgorica", "ME-16", "Municipality"),
    ("Rožaje", "ME-17", "Municipality"),
    ("Šavnik", "ME-18", "Municipality"),
    ("Tivat", "ME-19", "Municipality"),
    ("Ulcinj", "ME-20", "Municipality"),
    ("Žabljak", "ME-21", "Municipality")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForMontenegro()
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
