using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class UnitedStatesTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "United States";
        private const string NATIVE_NAME = "United States";
        private const string CAPITAL = "Washington, D.C.";
        private const string OFFICIAL_NAME = "United States of America";
        private const string ISO2_CODE = "US";
        private const string ISO3_CODE = "USA";
        private const int NUMERIC_CODE = 840;
        private readonly string[] CALLING_CODE = ["+1"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.UnitedStates;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Alabama", "US-AL", "State"),
        ("Alaska", "US-AK", "State"),
        ("Arizona", "US-AZ", "State"),
        ("Arkansas", "US-AR", "State"),
        ("California", "US-CA", "State"),
        ("Colorado", "US-CO", "State"),
        ("Connecticut", "US-CT", "State"),
        ("Delaware", "US-DE", "State"),
        ("Florida", "US-FL", "State"),
        ("Georgia", "US-GA", "State"),
        ("Hawaii", "US-HI", "State"),
        ("Idaho", "US-ID", "State"),
        ("Illinois", "US-IL", "State"),
        ("Indiana", "US-IN", "State"),
        ("Iowa", "US-IA", "State"),
        ("Kansas", "US-KS", "State"),
        ("Kentucky", "US-KY", "State"),
        ("Louisiana", "US-LA", "State"),
        ("Maine", "US-ME", "State"),
        ("Maryland", "US-MD", "State"),
        ("Massachusetts", "US-MA", "State"),
        ("Michigan", "US-MI", "State"),
        ("Minnesota", "US-MN", "State"),
        ("Mississippi", "US-MS", "State"),
        ("Missouri", "US-MO", "State"),
        ("Montana", "US-MT", "State"),
        ("Nebraska", "US-NE", "State"),
        ("Nevada", "US-NV", "State"),
        ("New Hampshire", "US-NH", "State"),
        ("New Jersey", "US-NJ", "State"),
        ("New Mexico", "US-NM", "State"),
        ("New York", "US-NY", "State"),
        ("North Carolina", "US-NC", "State"),
        ("North Dakota", "US-ND", "State"),
        ("Ohio", "US-OH", "State"),
        ("Oklahoma", "US-OK", "State"),
        ("Oregon", "US-OR", "State"),
        ("Pennsylvania", "US-PA", "State"),
        ("Rhode Island", "US-RI", "State"),
        ("South Carolina", "US-SC", "State"),
        ("South Dakota", "US-SD", "State"),
        ("Tennessee", "US-TN", "State"),
        ("Texas", "US-TX", "State"),
        ("Utah", "US-UT", "State"),
        ("Vermont", "US-VT", "State"),
        ("Virginia", "US-VA", "State"),
        ("Washington", "US-WA", "State"),
        ("West Virginia", "US-WV", "State"),
        ("Wisconsin", "US-WI", "State"),
        ("Wyoming", "US-WY", "State"),
        ("District of Columbia", "US-DC", "Federal District")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForUnitedStates()
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

}
