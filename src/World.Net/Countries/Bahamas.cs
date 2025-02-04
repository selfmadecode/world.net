
namespace World.Net.Countries;

internal sealed class Bahamas : ICountry
{
    public int Id => CountryIdentifier.Bahamas;

    public string Name { get; } = "The Bahamas";

    public string OfficialName { get; } = "Commonwealth of the Bahamas";

    public string NativeName => nameof(Bahamas);

    public string Capital { get; } = "Nassau";

    public int NumericCode { get; } = 044;

    public string ISO2Code { get; } = "BS";

    public string ISO3Code { get; } = "BHS";

    public string CallingCode { get; } = "+1 242";

    
}
