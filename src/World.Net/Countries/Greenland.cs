namespace World.Net.Countries;

internal sealed class Greenland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Greenland;

    //<inheritdoc/>
    public string Name { get; } = "Greenland";

    //<inheritdoc/>
    public string OfficialName { get; } = "Greenland";

    //<inheritdoc/>
    public string NativeName => "Kalaallit Nunaat";

    //<inheritdoc/>
    public string Capital { get; } = "Nuuk";

    //<inheritdoc/>
    public int NumericCode { get; } = 304;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GL";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GRL";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+299"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Avannaata", "GL-AV", "Municipality"),
        new("Kujalleq", "GL-KU", "Municipality"),
        new("Qeqertalik", "GL-QT", "Municipality"),
        new("Qeqqata", "GL-QE", "Municipality"),
        new("Sermersooq", "GL-SM", "Municipality")
    ];
}
