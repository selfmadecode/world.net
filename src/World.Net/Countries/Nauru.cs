namespace World.Net.Countries;

internal sealed class Nauru : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Nauru;

    public string Name { get; } = "Nauru";

    public string OfficialName { get; } = "Republic of Nauru";

    public string NativeName => "Nauru";

    public string Capital { get; } = "Yaren";

    public int NumericCode { get; } = 520;

    public string ISO2Code { get; } = "NR";

    public string ISO3Code { get; } = "NRU";

    public string[] CallingCode { get; } = ["+674"];

    public IEnumerable<State> States => new[]
    {
        new State("Aiwo", "NR-01", "District"),
        new State("Anabar", "NR-02", "District"),
        new State("Anetan", "NR-03", "District"),
        new State("Anibare", "NR-04", "District"),
        new State("Baiti", "NR-05", "District"),
        new State("Boe", "NR-06", "District"),
        new State("Buada", "NR-07", "District"),
        new State("Denigomodu", "NR-08", "District"),
        new State("Ewa", "NR-09", "District"),
        new State("Ijuw", "NR-10", "District"),
        new State("Meneng", "NR-11", "District"),
        new State("Nibok", "NR-12", "District"),
        new State("Uaboe", "NR-13", "District"),
        new State("Yaren", "NR-14", "District")
    };
}

