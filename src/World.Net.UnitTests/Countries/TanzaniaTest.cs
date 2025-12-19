using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries;

public sealed class TanzaniaTest : AssertCountryTestBase
{
    private const string COUNTRY_NAME = "Tanzania";
    private const string NATIVE_NAME = "Jamhuri ya Muungano wa Tanzania";
    private const string CAPITAL = "Dodoma";
    private const string OFFICIAL_NAME = "United Republic of Tanzania";
    private const string ISO2_CODE = "TZ";
    private const string ISO3_CODE = "TZA";
    private const int NUMERIC_CODE = 834;
    private readonly string[] CALLING_CODE = ["+255"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Tanzania;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    {
    ("Arusha", "TZ-AR", "Region"),
    ("Dar es Salaam", "TZ-DA", "Region"),
    ("Dodoma", "TZ-DO", "Region"),
    ("Geita", "TZ-GE", "Region"),
    ("Iringa", "TZ-IR", "Region"),
    ("Kagera", "TZ-KA", "Region"),
    ("Katavi", "TZ-KT", "Region"),
    ("Kigoma", "TZ-KI", "Region"),
    ("Kilimanjaro", "TZ-KL", "Region"),
    ("Lindi", "TZ-LI", "Region"),
    ("Manyara", "TZ-MA", "Region"),
    ("Mara", "TZ-MR", "Region"),
    ("Mbeya", "TZ-MB", "Region"),
    ("Morogoro", "TZ-MO", "Region"),
    ("Mtwara", "TZ-MT", "Region"),
    ("Mwanza", "TZ-MW", "Region"),
    ("Njombe", "TZ-NJ", "Region"),
    ("Pwani", "TZ-PW", "Region"),
    ("Rukwa", "TZ-RU", "Region"),
    ("Ruvuma", "TZ-RV", "Region"),
    ("Shinyanga", "TZ-SH", "Region"),
    ("Simiyu", "TZ-SI", "Region"),
    ("Singida", "TZ-SN", "Region"),
    ("Tabora", "TZ-TA", "Region"),
    ("Tanga", "TZ-TE", "Region"),
    ("Songwe", "TZ-SO", "Region"),
    ("Zanzibar North", "TZ-ZN", "Region"),
    ("Zanzibar South", "TZ-ZS", "Region"),
    ("Zanzibar Central/South", "TZ-ZC", "Region"),
    ("Zanzibar West", "TZ-ZW", "Region"),
    ("Zanzibar Urban/West", "TZ-ZU", "Region")
};

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTanzania()
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
