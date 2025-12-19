namespace World.Net.Countries;

internal sealed class Vietnam : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Vietnam;

    public string Name { get; } = "Vietnam";

    public string OfficialName { get; } = "Socialist Republic of Vietnam";

    public string NativeName => "Cộng hòa Xã hội Chủ nghĩa Việt Nam";

    public string Capital { get; } = "Hanoi";

    public int NumericCode { get; } = 704;

    public string ISO2Code { get; } = "VN";

    public string ISO3Code { get; } = "VNM";

    public string[] CallingCode { get; } = ["+84"];

    public IEnumerable<State> States => new[]
    {
        new State("An Giang", "VN-44", "Province"),
        new State("Bà Rịa–Vũng Tàu", "VN-43", "Province"),
        new State("Bắc Giang", "VN-54", "Province"),
        new State("Bắc Kạn", "VN-53", "Province"),
        new State("Bạc Liêu", "VN-50", "Province"),
        new State("Bắc Ninh", "VN-56", "Province"),
        new State("Bến Tre", "VN-51", "Province"),
        new State("Bình Định", "VN-31", "Province"),
        new State("Bình Dương", "VN-74", "Province"),
        new State("Bình Phước", "VN-70", "Province"),
        new State("Bình Thuận", "VN-40", "Province"),
        new State("Cà Mau", "VN-49", "Province"),
        new State("Cần Thơ", "VN-CT", "Municipality"),
        new State("Cao Bằng", "VN-04", "Province"),
        new State("Đà Nẵng", "VN-DN", "Municipality"),
        new State("Đắk Lắk", "VN-33", "Province"),
        new State("Đắk Nông", "VN-72", "Province"),
        new State("Điện Biên", "VN-11", "Province"),
        new State("Đồng Nai", "VN-75", "Province"),
        new State("Đồng Tháp", "VN-67", "Province"),
        new State("Gia Lai", "VN-30", "Province"),
        new State("Hà Giang", "VN-02", "Province"),
        new State("Hà Nam", "VN-63", "Province"),
        new State("Hà Nội", "VN-HN", "Municipality"),
        new State("Hà Tĩnh", "VN-24", "Province"),
        new State("Hải Dương", "VN-61", "Province"),
        new State("Hải Phòng", "VN-HP", "Municipality"),
        new State("Hậu Giang", "VN-64", "Province"),
        new State("Hòa Bình", "VN-14", "Province"),
        new State("Hưng Yên", "VN-66", "Province"),
        new State("Khánh Hòa", "VN-34", "Province"),
        new State("Kiên Giang", "VN-47", "Province"),
        new State("Kon Tum", "VN-28", "Province"),
        new State("Lai Châu", "VN-12", "Province"),
        new State("Lâm Đồng", "VN-35", "Province"),
        new State("Lạng Sơn", "VN-20", "Province"),
        new State("Lào Cai", "VN-10", "Province"),
        new State("Long An", "VN-41", "Province"),
        new State("Nam Định", "VN-67", "Province"),
        new State("Nghệ An", "VN-28", "Province"),
        new State("Ninh Bình", "VN-18", "Province"),
        new State("Ninh Thuận", "VN-36", "Province"),
        new State("Phú Thọ", "VN-68", "Province"),
        new State("Phú Yên", "VN-32", "Province"),
        new State("Quảng Bình", "VN-23", "Province"),
        new State("Quảng Nam", "VN-27", "Province"),
        new State("Quảng Ngãi", "VN-29", "Province"),
        new State("Quảng Ninh", "VN-22", "Province"),
        new State("Quảng Trị", "VN-25", "Province"),
        new State("Sóc Trăng", "VN-52", "Province"),
        new State("Sơn La", "VN-15", "Province"),
        new State("Tây Ninh", "VN-37", "Province"),
        new State("Thái Bình", "VN-60", "Province"),
        new State("Thái Nguyên", "VN-19", "Province"),
        new State("Thanh Hóa", "VN-21", "Province"),
        new State("Thừa Thiên–Huế", "VN-26", "Province"),
        new State("Tiền Giang", "VN-42", "Province"),
        new State("TP Hồ Chí Minh", "VN-HCM", "Municipality"),
        new State("Trà Vinh", "VN-48", "Province"),
        new State("Tuyên Quang", "VN-07", "Province"),
        new State("Vĩnh Long", "VN-45", "Province"),
        new State("Vĩnh Phúc", "VN-58", "Province"),
        new State("Yên Bái", "VN-06", "Province")
    };
}

