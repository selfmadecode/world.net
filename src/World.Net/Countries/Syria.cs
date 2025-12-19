namespace World.Net.Countries;

internal sealed class Syria : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Syria;

    //<inheritdoc/>
    public string Name { get; } = "Syria";

    //<inheritdoc/>
    public string OfficialName { get; } = "Syrian Arab Republic";

    //<inheritdoc/>
    public string NativeName => "الجمهورية العربية السورية";

    //<inheritdoc/>
    public string Capital { get; } = "Damascus";

    //<inheritdoc/>
    public int NumericCode { get; } = 760;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SY";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SYR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+963"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Al-Hasakah", "SY-HA", "Governorate"),
        new State("Al-Ladhiqiyah", "SY-LA", "Governorate"),
        new State("Al-Qunaytirah", "SY-QU", "Governorate"),
        new State("Ar-Raqqah", "SY-RQ", "Governorate"),
        new State("As-Suwayda", "SY-SU", "Governorate"),
        new State("Dar‘a", "SY-DR", "Governorate"),
        new State("Dayr az-Zawr", "SY-DY", "Governorate"),
        new State("Rif Dimashq", "SY-DI", "Governorate"),
        new State("Dimashq", "SY-DI", "Governorate"),
        new State("Hamah", "SY-HM", "Governorate"),
        new State("Hims", "SY-HI", "Governorate"),
        new State("Idlib", "SY-ID", "Governorate"),
        new State("Tartus", "SY-TA", "Governorate"),
        new State("Raqqa", "SY-RQ", "Governorate")
    };
}

