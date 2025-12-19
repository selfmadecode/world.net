using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class ThailandTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Thailand";
        private const string NATIVE_NAME = "ประเทศไทย";
        private const string CAPITAL = "Bangkok";
        private const string OFFICIAL_NAME = "Kingdom of Thailand";
        private const string ISO2_CODE = "TH";
        private const string ISO3_CODE = "THA";
        private const int NUMERIC_CODE = 764;
        private readonly string[] CALLING_CODE = ["+66"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Thailand;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
            ("Amnat Charoen", "TH-37", "Province"),
        ("Ang Thong", "TH-15", "Province"),
        ("Bangkok", "TH-10", "Province"),
        ("Bueng Kan", "TH-38", "Province"),
        ("Buri Ram", "TH-31", "Province"),
        ("Chachoengsao", "TH-24", "Province"),
        ("Chai Nat", "TH-18", "Province"),
        ("Chaiyaphum", "TH-36", "Province"),
        ("Chanthaburi", "TH-22", "Province"),
        ("Chiang Mai", "TH-50", "Province"),
        ("Chiang Rai", "TH-57", "Province"),
        ("Chonburi", "TH-20", "Province"),
        ("Chumphon", "TH-86", "Province"),
        ("Kalasin", "TH-46", "Province"),
        ("Kamphaeng Phet", "TH-62", "Province"),
        ("Kanchanaburi", "TH-71", "Province"),
        ("Khon Kaen", "TH-40", "Province"),
        ("Krabi", "TH-81", "Province"),
        ("Lampang", "TH-52", "Province"),
        ("Lamphun", "TH-51", "Province"),
        ("Loei", "TH-42", "Province"),
        ("Lopburi", "TH-16", "Province"),
        ("Mae Hong Son", "TH-58", "Province"),
        ("Maha Sarakham", "TH-44", "Province"),
        ("Mukdahan", "TH-49", "Province"),
        ("Nakhon Nayok", "TH-26", "Province"),
        ("Nakhon Pathom", "TH-73", "Province"),
        ("Nakhon Phanom", "TH-48", "Province"),
        ("Nakhon Ratchasima", "TH-30", "Province"),
        ("Nakhon Sawan", "TH-60", "Province"),
        ("Nakhon Si Thammarat", "TH-80", "Province"),
        ("Nan", "TH-55", "Province"),
        ("Narathiwat", "TH-96", "Province"),
        ("Nong Bua Lamphu", "TH-39", "Province"),
        ("Nong Khai", "TH-43", "Province"),
        ("Nonthaburi", "TH-12", "Province"),
        ("Pathum Thani", "TH-13", "Province"),
        ("Pattani", "TH-94", "Province"),
        ("Phang Nga", "TH-82", "Province"),
        ("Phatthalung", "TH-93", "Province"),
        ("Phayao", "TH-56", "Province"),
        ("Phetchabun", "TH-67", "Province"),
        ("Phetchaburi", "TH-76", "Province"),
        ("Phichit", "TH-66", "Province"),
        ("Phitsanulok", "TH-65", "Province"),
        ("Phra Nakhon Si Ayutthaya", "TH-14", "Province"),
        ("Phrae", "TH-54", "Province"),
        ("Phuket", "TH-83", "Province"),
        ("Prachinburi", "TH-25", "Province"),
        ("Prachuap Khiri Khan", "TH-77", "Province"),
        ("Ranong", "TH-85", "Province"),
        ("Ratchaburi", "TH-70", "Province"),
        ("Rayong", "TH-21", "Province"),
        ("Roi Et", "TH-45", "Province"),
        ("Sa Kaeo", "TH-27", "Province"),
        ("Sakon Nakhon", "TH-47", "Province"),
        ("Samut Prakan", "TH-11", "Province"),
        ("Samut Sakhon", "TH-74", "Province"),
        ("Samut Songkhram", "TH-75", "Province"),
        ("Saraburi", "TH-19", "Province"),
        ("Satun", "TH-91", "Province"),
        ("Sing Buri", "TH-17", "Province"),
        ("Si Sa Ket", "TH-33", "Province"),
        ("Songkhla", "TH-90", "Province"),
        ("Sukhothai", "TH-64", "Province"),
        ("Suphan Buri", "TH-72", "Province"),
        ("Surat Thani", "TH-84", "Province"),
        ("Tak", "TH-63", "Province"),
        ("Trang", "TH-92", "Province"),
        ("Trat", "TH-23", "Province"),
        ("Ubon Ratchathani", "TH-34", "Province"),
        ("Udon Thani", "TH-41", "Province"),
        ("Uthai Thani", "TH-61", "Province"),
        ("Uttaradit", "TH-53", "Province"),
        ("Yala", "TH-95", "Province"),
        ("Yasothon", "TH-35", "Province")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForThailand()
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
