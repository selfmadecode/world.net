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
}
