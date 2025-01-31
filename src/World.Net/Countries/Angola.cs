namespace World.Net.Countries;

internal sealed class Angola : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Angola;

    ///<inheritdoc/>
    public string Name { get; } = nameof(Angola);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Angola";

    ///<inheritdoc/>
    public string NativeName { get; } = nameof(Angola);

    ///<inheritdoc/>
    public string Capital { get; } = "Luanda";

    ///<inheritdoc/>
    public int NumericCode { get; } = 024;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AO";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "AGO";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+244";

    ///<inheritdoc/>
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