namespace World.Net.Countries;

internal sealed class Bhutan : ICountry
{
    public int Id => CountryIdentifier.Bhutan;

    public string Name { get; } = "Bhutan";

    public string OfficialName { get; } = "Kingdom of Bhutan";

    public string NativeName { get; } = "ʼbrug-yul";

    public string Capital { get; } = "Thimphu";

    public int NumericCode { get; } = 064;

    public string ISO2Code { get; } = "BM";

    public string ISO3Code { get; } = "BMU";

    public string CallingCode { get; } = "+975";

    public IEnumerable<State> States => throw new NotImplementedException();
}
