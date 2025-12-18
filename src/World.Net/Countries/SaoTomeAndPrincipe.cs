namespace World.Net.Countries;

internal sealed class SaoTomeAndPrincipe : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaoTomeAndPrincipe;

    //<inheritdoc/>
    public string Name { get; } = "São Tomé and Príncipe";

    //<inheritdoc/>
    public string OfficialName { get; } = "Democratic Republic of São Tomé and Príncipe";

    //<inheritdoc/>
    public string NativeName => "São Tomé e Príncipe";

    //<inheritdoc/>
    public string Capital { get; } = "São Tomé";

    //<inheritdoc/>
    public int NumericCode { get; } = 678;

    //<inheritdoc/>
    public string ISO2Code { get; } = "ST";

    //<inheritdoc/>
    public string ISO3Code { get; } = "STP";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+239"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("São Tomé", "ST-ST", "Province"),
        new("Príncipe", "ST-PN", "Province")
    ];
}

