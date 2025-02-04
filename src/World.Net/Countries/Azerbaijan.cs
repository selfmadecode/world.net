
namespace World.Net.Countries;

internal class Azerbaijan : ICountry
{
    public int Id => CountryIdentifier.Azerbaijan;

    public string Name { get; } = "Azerbaijan";

    public string OfficialName { get; } = "Republic of Azerbaijan";

    public string NativeName { get; } = "Azərbaycan";

    public string Capital { get; } = "Baku";

    public int NumericCode { get; } = 031;

    public string ISO2Code { get; } = "AZ";

    public string ISO3Code { get; } = "AZE";

    public string CallingCode { get; } = "+994";

    public IEnumerable<State> States => [
        
    ];
}
