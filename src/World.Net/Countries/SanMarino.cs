namespace World.Net.Countries;

internal sealed class SanMarino : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SanMarino;

    //<inheritdoc/>
    public string Name { get; } = "San Marino";

    //<inheritdoc/>
    public string OfficialName { get; } = "Most Serene Republic of San Marino";

    //<inheritdoc/>
    public string NativeName => "San Marino";

    //<inheritdoc/>
    public string Capital { get; } = "San Marino";

    //<inheritdoc/>
    public int NumericCode { get; } = 674;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SMR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+378"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Acquaviva", "SM-AC", "Municipality"),
        new("Borgo Maggiore", "SM-BM", "Municipality"),
        new("Chiesanuova", "SM-CH", "Municipality"),
        new("Domagnano", "SM-DO", "Municipality"),
        new("Faetano", "SM-FA", "Municipality"),
        new("Fiorentino", "SM-FI", "Municipality"),
        new("Montegiardino", "SM-MG", "Municipality"),
        new("San Marino", "SM-SM", "Municipality"),
        new("Serravalle", "SM-SE", "Municipality")
    ];
}
