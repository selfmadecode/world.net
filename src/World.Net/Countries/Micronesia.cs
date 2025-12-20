namespace World.Net.Countries;

internal sealed class Micronesia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Micronesia;

    public string Name { get; } = "Micronesia";

    public string OfficialName { get; } = "Federated States of Micronesia";

    public string NativeName => "Federated States of Micronesia";

    public string Capital { get; } = "Palikir";

    public int NumericCode { get; } = 583;

    public string ISO2Code { get; } = "FM";

    public string ISO3Code { get; } = "FSM";

    public string[] CallingCode { get; } = ["+691"];

    public IEnumerable<State> States => new[]
    {
        new State("Chuuk", "FM-TRK", "State"),
        new State("Kosrae", "FM-KSA", "State"),
        new State("Pohnpei", "FM-PNI", "State"),
        new State("Yap", "FM-YAP", "State")
    };
}

