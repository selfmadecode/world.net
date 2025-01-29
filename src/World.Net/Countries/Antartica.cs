namespace World.Net.Countries;

internal sealed class Antartica : ICountry
{
    public int Id { get; } = CountryIdentifier.Antarctica;

    public string Name { get; } = nameof(Antartica);

    public string OfficialName { get; } = nameof(Antartica);

    public string NativeName { get; } = nameof(Antartica);

    public string Capital { get; } = string.Empty;

    public int NumericCode { get; } = 010;

    public string ISO2Code { get; } = "AQ";

    public string ISO3Code { get; } = "ATA";

    public string CallingCode { get; } = "+672";

    public IEnumerable<State> States { get; } = [];
}
