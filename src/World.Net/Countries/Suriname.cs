namespace World.Net.Countries;

internal sealed class Suriname : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Suriname;

    //<inheritdoc/>
    public string Name { get; } = "Suriname";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Suriname";

    //<inheritdoc/>
    public string NativeName => "Republiek Suriname";

    //<inheritdoc/>
    public string Capital { get; } = "Paramaribo";

    //<inheritdoc/>
    public int NumericCode { get; } = 740;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SR";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SUR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+597"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Brokopondo", "SR-BR", "District"),
        new State("Commewijne", "SR-CM", "District"),
        new State("Coronie", "SR-CR", "District"),
        new State("Marowijne", "SR-MA", "District"),
        new State("Nickerie", "SR-NI", "District"),
        new State("Para", "SR-PR", "District"),
        new State("Paramaribo", "SR-PM", "District"),
        new State("Saramacca", "SR-SA", "District"),
        new State("Sipaliwini", "SR-SI", "District"),
        new State("Wanica", "SR-WA", "District")
    };
}
