using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class LibyaTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Libya;
        public string Name { get; } = "Libya";
        public string OfficialName { get; } = "State of Libya";
        public string NativeName { get; } = "دولة ليبيا";
        public string Capital { get; } = "Tripoli";
        public int NumericCode { get; } = 434;
        public string ISO2Code { get; } = "LY";
        public string ISO3Code { get; } = "LBY";
        public string[] CallingCode { get; } = ["+218"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Al Butnan", "LY-BU", "District"),
            new("Al Jabal al Akhdar", "LY-JA", "District"),
            new("Al Jabal al Gharbi", "LY-JG", "District"),
            new("Al Jafara", "LY-JI", "District"),
            new("Al Jufra", "LY-JU", "District"),
            new("Al Kufra", "LY-KF", "District"),
            new("Al Marj", "LY-MJ", "District"),
            new("Al Marqab", "LY-MB", "District"),
            new("Al Wahat", "LY-WA", "District"),
            new("Nalut", "LY-NL", "District"),
            new("Misrata", "LY-MI", "District"),
            new("Murzuq", "LY-MQ", "District"),
            new("Sabha", "LY-SB", "District"),
            new("Sirt", "LY-SR", "District"),
            new("Tripoli", "LY-TB", "District"),
            new("Wadi al Hayat", "LY-WD", "District"),
            new("Wadi ash Shati'", "LY-WS", "District"),
            new("Zawiya", "LY-ZA", "District")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLibya()
        {
            var country = CountryProvider.GetCountry(Id);

            AssertCorrectInformation(
                country,
                Id,
                Name,
                OfficialName,
                NativeName,
                Capital,
                NumericCode,
                ISO2Code,
                ISO3Code,
                CallingCode,
                States
            );
        }
    }
}
