namespace World.Net.Countries;

internal sealed class Reunion : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Reunion;

    //<inheritdoc/>
    public string Name { get; } = "Réunion";

    //<inheritdoc/>
    public string OfficialName { get; } = "Réunion";

    //<inheritdoc/>
    public string NativeName => "Réunion";

    //<inheritdoc/>
    public string Capital { get; } = "Saint-Denis";

    //<inheritdoc/>
    public int NumericCode { get; } = 638;

    //<inheritdoc/>
    public string ISO2Code { get; } = "RE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "REU";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+262"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Réunion", "RE-RE", "Region")
    ];
}

