namespace World.Net.Countries;

internal sealed class SouthKorea : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SouthKorea;

    //<inheritdoc/>
    public string Name { get; } = "South Korea";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Korea";

    //<inheritdoc/>
    public string NativeName => "대한민국";

    //<inheritdoc/>
    public string Capital { get; } = "Seoul";

    //<inheritdoc/>
    public int NumericCode { get; } = 410;

    //<inheritdoc/>
    public string ISO2Code { get; } = "KR";

    //<inheritdoc/>
    public string ISO3Code { get; } = "KOR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+82"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Seoul", "KR-11", "Special City"),
        new State("Busan", "KR-26", "Metropolitan City"),
        new State("Daegu", "KR-27", "Metropolitan City"),
        new State("Incheon", "KR-28", "Metropolitan City"),
        new State("Gwangju", "KR-29", "Metropolitan City"),
        new State("Daejeon", "KR-30", "Metropolitan City"),
        new State("Ulsan", "KR-31", "Metropolitan City"),
        new State("Sejong", "KR-50", "Special Self-Governing City"),

        new State("Gyeonggi", "KR-41", "Province"),
        new State("Gangwon", "KR-42", "Province"),
        new State("North Chungcheong", "KR-43", "Province"),
        new State("South Chungcheong", "KR-44", "Province"),
        new State("North Jeolla", "KR-45", "Province"),
        new State("South Jeolla", "KR-46", "Province"),
        new State("North Gyeongsang", "KR-47", "Province"),
        new State("South Gyeongsang", "KR-48", "Province"),
        new State("Jeju", "KR-49", "Special Self-Governing Province")
    };
}

