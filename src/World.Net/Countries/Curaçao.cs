namespace World.Net.Countries;

internal sealed class Curaçao : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Curacao;

    //<inheritdoc/>
    public string Name { get; } = "Curaçao";

    //<inheritdoc/>
    public string OfficialName { get; } = "Country of Curaçao";

    //<inheritdoc/>
    public string NativeName => "Kòrsou";

    //<inheritdoc/>
    public string Capital { get; } = "Willemstad";

    //<inheritdoc/>
    public int NumericCode { get; } = 531;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CW";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CUW";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+599"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Curaçao", "CW", "Country")
    ];
}
