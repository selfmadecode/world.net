namespace World.Net.Countries;

internal sealed class Kuwait : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Kuwait;
    public string Name { get; } = "Kuwait";
    public string OfficialName { get; } = "State of Kuwait";
    public string NativeName { get; } = "???? ??????";
    public string Capital { get; } = "Kuwait City";
    public int NumericCode { get; } = 414;
    public string ISO2Code { get; } = "KW";
    public string ISO3Code { get; } = "KWT";
    public string[] CallingCode { get; } = ["+965"];
    public IEnumerable<State> States { get; } =
    [
        new State("Al Ahmadi", "KW-AH", "Governorate"),
        new State("Al Farwaniyah", "KW-FA", "Governorate"),
        new State("Al Asimah", "KW-KU", "Governorate"),
        new State("Al Jahra", "KW-JA", "Governorate"),
        new State("Hawalli", "KW-HA", "Governorate"),
        new State("Mubarak Al-Kabeer", "KW-MU", "Governorate")
    ];
}
