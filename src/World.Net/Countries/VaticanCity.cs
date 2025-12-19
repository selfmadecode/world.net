namespace World.Net.Countries;

internal sealed class VaticanCity : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.VaticanCityState;

    public string Name { get; } = "Vatican City State (Holy See)";

    public string OfficialName { get; } = "Vatican City State";

    public string NativeName => "Stato della Città del Vaticano";

    public string Capital { get; } = "Vatican City";

    public int NumericCode { get; } = 336;

    public string ISO2Code { get; } = "VA";

    public string ISO3Code { get; } = "VAT";

    public string[] CallingCode { get; } = ["+379"];

    public IEnumerable<State> States => Array.Empty<State>();
}

