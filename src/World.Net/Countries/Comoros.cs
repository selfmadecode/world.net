namespace World.Net.Countries;

internal sealed class Comoros : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Comoros;

    //<inheritdoc/>
    public string Name { get; } = "Comoros";

    //<inheritdoc/>
    public string OfficialName { get; } = "Union of the Comoros";

    //<inheritdoc/>
    public string NativeName => "Komori";

    //<inheritdoc/>
    public string Capital { get; } = "Moroni";

    //<inheritdoc/>
    public int NumericCode { get; } = 174;

    //<inheritdoc/>
    public string ISO2Code { get; } = "KM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "COM";

    //<inheritdoc/>
    public string CallingCode { get; } = "+269";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Anjouan", "KM-A", "Autonomous Island"),
        new("Grande Comore", "KM-G", "Autonomous Island"),
        new("Mohéli", "KM-M", "Autonomous Island")
    ];
}
