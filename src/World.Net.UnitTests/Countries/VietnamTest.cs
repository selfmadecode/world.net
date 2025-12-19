using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public sealed class VietnamTest : AssertCountryTestBase
    {
        private const string COUNTRY_NAME = "Vietnam";
        private const string NATIVE_NAME = "Cộng hòa Xã hội Chủ nghĩa Việt Nam";
        private const string CAPITAL = "Hanoi";
        private const string OFFICIAL_NAME = "Socialist Republic of Vietnam";
        private const string ISO2_CODE = "VN";
        private const string ISO3_CODE = "VNM";
        private const int NUMERIC_CODE = 704;
        private readonly string[] CALLING_CODE = ["+84"];
        private const CountryIdentifier EXPECTEDID = CountryIdentifier.Vietnam;

        private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
        {
        ("An Giang", "VN-44", "Province"),
        ("Bà Rịa–Vũng Tàu", "VN-43", "Province"),
        ("Bắc Giang", "VN-54", "Province"),
        ("Bắc Kạn", "VN-53", "Province"),
        ("Bạc Liêu", "VN-50", "Province"),
        ("Bắc Ninh", "VN-56", "Province"),
        ("Bến Tre", "VN-51", "Province"),
        ("Bình Định", "VN-31", "Province"),
        ("Bình Dương", "VN-74", "Province"),
        ("Bình Phước", "VN-70", "Province"),
        ("Bình Thuận", "VN-40", "Province"),
        ("Cà Mau", "VN-49", "Province"),
        ("Cần Thơ", "VN-CT", "Municipality"),
        ("Cao Bằng", "VN-04", "Province"),
        ("Đà Nẵng", "VN-DN", "Municipality"),
        ("Đắk Lắk", "VN-33", "Province"),
        ("Đắk Nông", "VN-72", "Province"),
        ("Điện Biên", "VN-11", "Province"),
        ("Đồng Nai", "VN-75", "Province"),
        ("Đồng Tháp", "VN-67", "Province"),
        ("Gia Lai", "VN-30", "Province"),
        ("Hà Giang", "VN-02", "Province"),
        ("Hà Nam", "VN-63", "Province"),
        ("Hà Nội", "VN-HN", "Municipality"),
        ("Hà Tĩnh", "VN-24", "Province"),
        ("Hải Dương", "VN-61", "Province"),
        ("Hải Phòng", "VN-HP", "Municipality"),
        ("Hậu Giang", "VN-64", "Province"),
        ("Hòa Bình", "VN-14", "Province"),
        ("Hưng Yên", "VN-66", "Province"),
        ("Khánh Hòa", "VN-34", "Province"),
        ("Kiên Giang", "VN-47", "Province"),
        ("Kon Tum", "VN-28", "Province"),
        ("Lai Châu", "VN-12", "Province"),
        ("Lâm Đồng", "VN-35", "Province"),
        ("Lạng Sơn", "VN-20", "Province"),
        ("Lào Cai", "VN-10", "Province"),
        ("Long An", "VN-41", "Province"),
        ("Nam Định", "VN-67", "Province"),
        ("Nghệ An", "VN-28", "Province"),
        ("Ninh Bình", "VN-18", "Province"),
        ("Ninh Thuận", "VN-36", "Province"),
        ("Phú Thọ", "VN-68", "Province"),
        ("Phú Yên", "VN-32", "Province"),
        ("Quảng Bình", "VN-23", "Province"),
        ("Quảng Nam", "VN-27", "Province"),
        ("Quảng Ngãi", "VN-29", "Province"),
        ("Quảng Ninh", "VN-22", "Province"),
        ("Quảng Trị", "VN-25", "Province"),
        ("Sóc Trăng", "VN-52", "Province"),
        ("Sơn La", "VN-15", "Province"),
        ("Tây Ninh", "VN-37", "Province"),
        ("Thái Bình", "VN-60", "Province"),
        ("Thái Nguyên", "VN-19", "Province"),
        ("Thanh Hóa", "VN-21", "Province"),
        ("Thừa Thiên–Huế", "VN-26", "Province"),
        ("Tiền Giang", "VN-42", "Province"),
        ("TP Hồ Chí Minh", "VN-HCM", "Municipality"),
        ("Trà Vinh", "VN-48", "Province"),
        ("Tuyên Quang", "VN-07", "Province"),
        ("Vĩnh Long", "VN-45", "Province"),
        ("Vĩnh Phúc", "VN-58", "Province"),
        ("Yên Bái", "VN-06", "Province")
    };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForVietnam()
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
