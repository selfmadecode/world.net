namespace World.Net.Countries;

internal sealed class WesternSahara : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.WesternSahara;

    public string Name { get; } = "Western Sahara";

    public string OfficialName { get; } = "Sahrawi Arab Democratic Republic";

    public string NativeName => "الصحراء الغربية";

    public string Capital { get; } = "El Aaiún";

    public int NumericCode { get; } = 732;

    public string ISO2Code { get; } = "EH";

    public string ISO3Code { get; } = "ESH";

    public string[] CallingCode { get; } = ["+212"];

    public IEnumerable<State> States => Array.Empty<State>();
}

