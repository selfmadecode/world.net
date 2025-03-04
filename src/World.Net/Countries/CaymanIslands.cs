
namespace World.Net.Countries;

internal sealed class CaymanIslands : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.CaymanIslands;

    public string Name => "Cayman Islands";

    public string OfficialName => "Cayman Islands";

    public string NativeName => "Cayman Islands";

    public string Capital => "George Town";

    public int NumericCode => 136;

    public string ISO2Code => "KY";

    public string ISO3Code => "CYM";

    public string CallingCode => "+1 345";

    public IEnumerable<State> States =>
    [
        new("Cayman Brac", "", ""),
        new("Grand Cayman", "", ""),
        new("Little Cayman", "", "")
    ];
}
