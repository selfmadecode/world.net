namespace World.Net.Countries;

internal sealed class Angola : ICountry
{
    public int Id => CountryIdentifier.Angola;

    public string Name { get; } = nameof(Angola);

    public string OfficialName { get; } = "Republic of Angola";

    public string NativeName { get; } = nameof(Angola);

    public string Capital { get; } = "Luanda";

    public int NumericCode { get; } = 024;

    public string ISO2Code { get; } = "AO";

    public string ISO3Code { get; } = "AGO";

    public string CallingCode { get; } = "+244";

    public IEnumerable<State> States =>
    [
        new("Bengo", "BGO"),
        new("Benguela", "BGU"),
        new ("Bié", "BIE"),
        new ("Cabinda", "CAB"),
        new ("Cuando Cubango", "CCU"),
        new ("Cuanza", "CUS"),
        new ("Cuanza Norte", "CNO"),
        new ("Cunene", "CNN"),
        new ("Huambo", "HUA"),
        new ("Huíla", "HUI"),
        new ("Luanda", "LUA"),
        new ("Lunda Norte", "LNO"),
        new ("Lunda Sul", "LSU"),
        new ("Malanje", "MAL"),
        new ("Moxico", "MOX"),
        new ("Uíge", "UIG"),
        new ("Zaire", "ZAI")
    ];
}