namespace World.Net.Countries;

internal sealed class Anguilla : ICountry
{
    public int Id { get; } = CountryIdentifier.Anguilla;

    public string Name { get; } = nameof(Anguilla);

    public string OfficialName { get; } = nameof(Anguilla);

    public string NativeName { get; } = nameof(Anguilla);

    public string Capital { get; } = "The Valley";

    public int NumericCode { get; } = 660;

    public string ISO2Code { get; } = "AI";

    public string ISO3Code { get; } = "AIA";

    public string CallingCode { get; } = "+1264";

    public IEnumerable<State> States =>
    [
        new State("Blowing Point", string.Empty, "District"),
        new State("East End", string.Empty, "District"),
        new State("George Hill", string.Empty, "District"),
        new State("Island Harbour", string.Empty, "District"),
        new State("North Hill", string.Empty, "District"),
        new State("North Side", string.Empty, "District"),
        new State("Sandy Ground", string.Empty, "District"),
        new State("Sandy Hill", string.Empty, "District"),
        new State("South Hill", string.Empty, "District"),
        new State("Stoney Ground", string.Empty, "District"),
        new State("The Farrington", string.Empty, "District"),
        new State("The Quarter", string.Empty, "District"),
        new State("The Valley", string.Empty, "District"),
        new State("West End", string.Empty, "District")
    ];
}
