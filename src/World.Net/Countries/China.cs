namespace World.Net.Countries;

internal sealed class China : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.China;

    public string Name => "China";

    public string OfficialName => "People's Republic of China";

    public string NativeName => "中国";

    public string Capital => "Beijing";

    public int NumericCode => 156;

    public string ISO2Code => "CN";

    public string ISO3Code => "CHN";

    public string[] CallingCode => ["+86"];

    public IEnumerable<State> States =>
    [
        new("Anhui", "AH", "Province"),
        new("Beijing", "BJ", "Municipality"),
        new("Chongqing", "CQ", "Municipality"),
        new("Fujian", "FJ", "Province"),
        new("Gansu", "GS", "Province"),
        new("Guangdong", "GD", "Province"),
        new("Guangxi Zhuang", "GX", "Autonomous Region"),
        new("Guizhou", "GZ", "Province"),
        new("Hainan", "HI", "Province"),
        new("Hebei", "HE", "Province"),
        new("Heilongjiang", "HL", "Province"),
        new("Henan", "HA", "Province"),
        new("Hong Kong", "HK", "Special Administrative Region"),
        new("Hubei", "HB", "Province"),
        new("Hunan", "HN", "Province"),
        new("Inner Mongolia", "NM", "Autonomous Region"),
        new("Jiangsu", "JS", "Province"),
        new("Jiangxi", "JX", "Province"),
        new("Jilin", "JL", "Province"),
        new("Liaoning", "LN", "Province"),
        new("Macau SAR", "MO", "Special Administrative Region"),
        new("Ningxia Huizu", "NX", "Autonomous Region"),
        new("Qinghai", "QH", "Province"),
        new("Shaanxi", "SN", "Province"),
        new("Shandong", "SD", "Province"),
        new("Shanghai", "SH", "Municipality"),
        new("Shanxi", "SX", "Province"),
        new("Sichuan", "SC", "Province"),
        new("Taiwan", "TW", "Municipality"),
        new("Tianjin", "TJ", "Municipality"),
        new("Tibet", "XZ", "Autonomous Region"),
        new("Xinjiang", "XJ", "Autonomous Region"),
        new("Yunnan", "YN", "Province"),
        new("Zhejiang", "ZJ", "Province")
    ];
}
