namespace World.Net.Countries;

internal sealed class Taiwan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Taiwan;

    public string Name { get; } = "Taiwan";

    public string OfficialName { get; } = "Republic of China (Taiwan)";

    public string NativeName => "臺灣";

    public string Capital { get; } = "Taipei";

    public int NumericCode { get; } = 158;

    public string ISO2Code { get; } = "TW";

    public string ISO3Code { get; } = "TWN";

    public string[] CallingCode { get; } = ["+886"];

    public IEnumerable<State> States => new[]
    {
        new State("Taipei", "TW-TPE", "Municipality"),
        new State("New Taipei", "TW-NWT", "Municipality"),
        new State("Taoyuan", "TW-TAO", "Municipality"),
        new State("Taichung", "TW-TXG", "Municipality"),
        new State("Tainan", "TW-TNN", "Municipality"),
        new State("Kaohsiung", "TW-KHH", "Municipality"),
        new State("Keelung", "TW-KEE", "City"),
        new State("Hsinchu", "TW-HSZ", "City"),
        new State("Chiayi", "TW-CYI", "City"),
        new State("Changhua", "TW-CWH", "County"),
        new State("Chiayi County", "TW-CYQ", "County"),
        new State("Hsinchu County", "TW-HSQ", "County"),
        new State("Hualien", "TW-HWA", "County"),
        new State("Kaohsiung County", "TW-KAQ", "County"),
        new State("Miaoli", "TW-MIA", "County"),
        new State("Nantou", "TW-NAN", "County"),
        new State("Penghu", "TW-PEN", "County"),
        new State("Pingtung", "TW-PIF", "County"),
        new State("Yilan", "TW-YIL", "County"),
        new State("Yunlin", "TW-YUN", "County"),
        new State("Taitung", "TW-TTT", "County"),
        new State("Lienchiang", "TW-LIE", "County")
    };
}

