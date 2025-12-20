namespace World.Net.Countries;

internal sealed class Mongolia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mongolia;

    public string Name { get; } = "Mongolia";

    public string OfficialName { get; } = "Mongolia";

    public string NativeName => "Монгол Улс";

    public string Capital { get; } = "Ulaanbaatar";

    public int NumericCode { get; } = 496;

    public string ISO2Code { get; } = "MN";

    public string ISO3Code { get; } = "MNG";

    public string[] CallingCode { get; } = ["+976"];

    public IEnumerable<State> States => new[]
    {
        new State("Arkhangai", "MN-073", "Province"),
        new State("Bayan-Ölgii", "MN-071", "Province"),
        new State("Bayankhongor", "MN-069", "Province"),
        new State("Bulgan", "MN-067", "Province"),
        new State("Darkhan-Uul", "MN-037", "Province"),
        new State("Dornod", "MN-061", "Province"),
        new State("Dornogovi", "MN-063", "Province"),
        new State("Dundgovi", "MN-059", "Province"),
        new State("Govi-Altai", "MN-065", "Province"),
        new State("Govisümber", "MN-064", "Province"),
        new State("Khentii", "MN-039", "Province"),
        new State("Khovd", "MN-043", "Province"),
        new State("Khövsgöl", "MN-041", "Province"),
        new State("Ömnögovi", "MN-053", "Province"),
        new State("Orkhon", "MN-035", "Province"),
        new State("Övörkhangai", "MN-055", "Province"),
        new State("Selenge", "MN-049", "Province"),
        new State("Sükhbaatar", "MN-051", "Province"),
        new State("Töv", "MN-047", "Province"),
        new State("Uvs", "MN-046", "Province"),
        new State("Zavkhan", "MN-057", "Province"),
        new State("Ulaanbaatar", "MN-1", "Municipality")
    };
}

