
namespace World.Net.Countries;

internal sealed class AlandIslands : ICountry
{
    ///<inheritdoc/>
    public int Id { get; } = CountryIdentifier.AlandIslands;

    ///<inheritdoc/>
    public string Name { get; } = nameof(AlandIslands);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Åland Islands";

    ///<inheritdoc/>
    public string NativeName { get; } = "Åland";

    ///<inheritdoc/>
    public string Capital { get; } = "Mariehamn";

    ///<inheritdoc/>
    public int NumericCode { get; } = 248;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AX";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ALA";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+358";

    ///<inheritdoc/>
    public IEnumerable<State> States  { get; } =
    [
        new("Mariehamn", "", "Municipality"),
        new("Jomala", "", "Municipality"),
        new("Finström", "", "Municipality"),
        new("Lemland", "", "Municipality"),
        new("Saltvik", "", "Municipality"),
        new("Hammarland", "", "Municipality"),
        new("Sund", "", "Municipality"),
        new("Eckerö", "", "Municipality"),
        new("Föglö", "", "Municipality"),
        new("Geta", "", "Municipality"),
        new("Brändö", "", "Municipality"),
        new("Vårdö", "", "Municipality"),
        new("Lumparland", "", "Municipality"),
        new("Kumlinge", "", "Municipality"),
        new("Kökar", "", "Municipality"),
        new("Sottunga", "", "Municipality"),
    ];
}
