namespace World.Net.Countries;

internal sealed class Anguilla : ICountry
{
    ///<inheritdoc/>
    public int Id { get; } = CountryIdentifier.Anguilla;

    ///<inheritdoc/>
    public string Name { get; } = nameof(Anguilla);

    ///<inheritdoc/>
    public string OfficialName { get; } = nameof(Anguilla);

    ///<inheritdoc/>
    public string NativeName { get; } = nameof(Anguilla);

    ///<inheritdoc/>
    public string Capital { get; } = "The Valley";

    ///<inheritdoc/>
    public int NumericCode { get; } = 660;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AI";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "AIA";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+1-264";

    ///<inheritdoc/>
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
