namespace World.Net.Countries;

internal sealed class Mauritius : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mauritius;

    public string Name { get; } = "Mauritius";

    public string OfficialName { get; } = "Republic of Mauritius";

    public string NativeName => "Maurice";

    public string Capital { get; } = "Port Louis";

    public int NumericCode { get; } = 480;

    public string ISO2Code { get; } = "MU";

    public string ISO3Code { get; } = "MUS";

    public string[] CallingCode { get; } = ["+230"];

    public IEnumerable<State> States => new[]
    {
        new State("Black River", "MU-BL", "District"),
        new State("Flacq", "MU-FL", "District"),
        new State("Grand Port", "MU-GP", "District"),
        new State("Moka", "MU-MO", "District"),
        new State("Pamplemousses", "MU-PA", "District"),
        new State("Plaines Wilhems", "MU-PW", "District"),
        new State("Port Louis", "MU-PL", "District"),
        new State("Rivière du Rempart", "MU-RR", "District"),
        new State("Savanne", "MU-SA", "District")
    };
}

