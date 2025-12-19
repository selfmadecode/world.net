using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class TurkeyTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Turkey";
        private const string NATIVE_NAME = "Türkiye";
        private const string CAPITAL = "Ankara";
        private const string OFFICIAL_NAME = "Republic of Turkey";
        private const string ISO2_CODE = "TR";
        private const string ISO3_CODE = "TUR";
        private const int NUMERIC_CODE = 792;
        private readonly string[] CALLING_CODE = ["+90"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Turkey;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("Adana", "TR-01", "Province"),
        ("Adıyaman", "TR-02", "Province"),
        ("Afyonkarahisar", "TR-03", "Province"),
        ("Ağrı", "TR-04", "Province"),
        ("Amasya", "TR-05", "Province"),
        ("Ankara", "TR-06", "Province"),
        ("Antalya", "TR-07", "Province"),
        ("Artvin", "TR-08", "Province"),
        ("Aydın", "TR-09", "Province"),
        ("Balıkesir", "TR-10", "Province"),
        ("Bilecik", "TR-11", "Province"),
        ("Bingöl", "TR-12", "Province"),
        ("Bitlis", "TR-13", "Province"),
        ("Bolu", "TR-14", "Province"),
        ("Burdur", "TR-15", "Province"),
        ("Bursa", "TR-16", "Province"),
        ("Çanakkale", "TR-17", "Province"),
        ("Çankırı", "TR-18", "Province"),
        ("Çorum", "TR-19", "Province"),
        ("Denizli", "TR-20", "Province"),
        ("Diyarbakır", "TR-21", "Province"),
        ("Edirne", "TR-22", "Province"),
        ("Elazığ", "TR-23", "Province"),
        ("Erzincan", "TR-24", "Province"),
        ("Erzurum", "TR-25", "Province"),
        ("Eskişehir", "TR-26", "Province"),
        ("Gaziantep", "TR-27", "Province"),
        ("Giresun", "TR-28", "Province"),
        ("Gümüşhane", "TR-29", "Province"),
        ("Hakkari", "TR-30", "Province"),
        ("Hatay", "TR-31", "Province"),
        ("Isparta", "TR-32", "Province"),
        ("Mersin", "TR-33", "Province"),
        ("İstanbul", "TR-34", "Province"),
        ("İzmir", "TR-35", "Province"),
        ("Kars", "TR-36", "Province"),
        ("Kastamonu", "TR-37", "Province"),
        ("Kayseri", "TR-38", "Province"),
        ("Kırklareli", "TR-39", "Province"),
        ("Kırşehir", "TR-40", "Province"),
        ("Kocaeli", "TR-41", "Province"),
        ("Konya", "TR-42", "Province"),
        ("Kütahya", "TR-43", "Province"),
        ("Malatya", "TR-44", "Province"),
        ("Manisa", "TR-45", "Province"),
        ("Kahramanmaraş", "TR-46", "Province"),
        ("Mardin", "TR-47", "Province"),
        ("Muğla", "TR-48", "Province"),
        ("Muş", "TR-49", "Province"),
        ("Nevşehir", "TR-50", "Province"),
        ("Niğde", "TR-51", "Province"),
        ("Ordu", "TR-52", "Province"),
        ("Rize", "TR-53", "Province"),
        ("Sakarya", "TR-54", "Province"),
        ("Samsun", "TR-55", "Province"),
        ("Siirt", "TR-56", "Province"),
        ("Sinop", "TR-57", "Province"),
        ("Sivas", "TR-58", "Province"),
        ("Tekirdağ", "TR-59", "Province"),
        ("Tokat", "TR-60", "Province"),
        ("Trabzon", "TR-61", "Province"),
        ("Tunceli", "TR-62", "Province"),
        ("Şanlıurfa", "TR-63", "Province"),
        ("Uşak", "TR-64", "Province"),
        ("Van", "TR-65", "Province"),
        ("Yozgat", "TR-66", "Province"),
        ("Zonguldak", "TR-67", "Province"),
        ("Aksaray", "TR-68", "Province"),
        ("Bayburt", "TR-69", "Province"),
        ("Karaman", "TR-70", "Province"),
        ("Kırıkkale", "TR-71", "Province"),
        ("Batman", "TR-72", "Province"),
        ("Şırnak", "TR-73", "Province"),
        ("Bartın", "TR-74", "Province"),
        ("Ardahan", "TR-75", "Province"),
        ("Iğdır", "TR-76", "Province"),
        ("Yalova", "TR-77", "Province"),
        ("Karabük", "TR-78", "Province"),
        ("Kilis", "TR-79", "Province"),
        ("Osmaniye", "TR-80", "Province"),
        ("Düzce", "TR-81", "Province")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForTurkey()
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
