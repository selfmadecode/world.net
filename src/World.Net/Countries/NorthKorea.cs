namespace World.Net.Countries;

internal sealed class NorthKorea : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.NorthKorea;

    //<inheritdoc/>
    public string Name { get; } = "North Korea";

    //<inheritdoc/>
    public string OfficialName { get; } = "Democratic People's Republic of Korea";

    //<inheritdoc/>
    public string NativeName => "조선민주주의인민공화국";

    //<inheritdoc/>
    public string Capital { get; } = "Pyongyang";

    //<inheritdoc/>
    public int NumericCode { get; } = 408;

    //<inheritdoc/>
    public string ISO2Code { get; } = "KP";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PRK";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+850"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Chagang", "KP-CHA", "Province"),
        new("North Hamgyong", "KP-HAMN", "Province"),
        new("South Hamgyong", "KP-HAMS", "Province"),
        new("North Hwanghae", "KP-HWAN", "Province"),
        new("South Hwanghae", "KP-HWAS", "Province"),
        new("Kangwon", "KP-KAN", "Province"),
        new("North Pyongan", "KP-PYON", "Province"),
        new("South Pyongan", "KP-PYOS", "Province"),
        new("Ryanggang", "KP-RYA", "Province"),
        new("Kaesong", "KP-KA", "Special City"),
        new("Nampo", "KP-NAM", "Special City"),
        new("Pyongyang", "KP-PY", "Directly Governed City"),
        new("Rason", "KP-RAS", "Directly Governed City"),
        new("Sinuiju", "KP-SIN", "Special City")
    ];
}

