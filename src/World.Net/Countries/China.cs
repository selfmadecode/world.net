namespace World.Net.Countries
{
    internal sealed class China : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.China;

        ///<inheritdoc/>
        public string Name => nameof(China);

        ///<inheritdoc/>
        public string OfficialName { get; } = "People's Republic of China";

        ///<inheritdoc/>
        public string NativeName { get; } = "中国";

        ///<inheritdoc/>
        public string Capital { get; } = "Beijing";

        ///<inheritdoc/>
        public int NumericCode { get; } = 156;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CN";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "CHN";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+86";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Anhui", "CN-AH", "Province"),
            new("Beijing", "CN-BJ", "Municipality"),
            new("Chongqing", "CN-CQ", "Municipality"),
            new("Fujian", "CN-FJ", "Province"),
            new("Gansu", "CN-GS", "Province"),
            new("Guangdong", "CN-GD", "Province"),
            new("Guangxi Zhuang", "CN-GX", "Autonomous Region"),
            new("Guizhou", "CN-GZ", "Province"),
            new("Hainan", "CN-HI", "Province"),
            new("Hebei", "CN-HE", "Province"),
            new("Heilongjiang", "CN-HL", "Province"),
            new("Henan", "CN-HA", "Province"),
            new("Hong Kong SAR", "CN-HK", "Special Administrative Region"),
            new("Hubei", "CN-HB", "Province"),
            new("Hunan", "CN-HN", "Province"),
            new("Inner Mongolia", "CN-NM", "Autonomous Region"),
            new("Jiangsu", "CN-JS", "Province"),
            new("Jiangxi", "CN-JX", "Province"),
            new("Jilin", "CN-JL", "Province"),
            new("Liaoning", "CN-LN", "Province"),
            new("Macau SAR", "CN-MO", "Special Administrative Region"),
            new("Ningxia Huizu", "CN-NX", "Autonomous Region"),
            new("Qinghai", "CN-QH", "Province"),
            new("Shaanxi", "CN-SN", "Province"),
            new("Shandong", "CN-SD", "Province"),
            new("Shanghai", "CN-SH", "Municipality"),
            new("Shanxi", "CN-SX", "Province"),
            new("Sichuan", "CN-SC", "Province"),
            new("Taiwan", "CN-TW", "Province"),
            new("Tianjin", "CN-TJ", "Municipality"),
            new("Xinjiang", "CN-XJ", "Autonomous Region"),
            new("Xizang", "CN-XZ", "Autonomous Region"),
            new("Yunnan", "CN-YN", "Province"),
            new("Zhejiang", "CN-ZJ", "Province"),
        ];
    }
}
