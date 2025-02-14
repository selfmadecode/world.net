
namespace World.Net.Countries;

internal sealed class Bolivia : ICountry
{
    //<inheritdoc/>
    public int Id => CountryIdentifier.Bolivia;

    //<inheritdoc/>
    public string Name { get; } = nameof(Bolivia);

    //<inheritdoc/>
    public string OfficialName { get; } = "Plurinational State of Bolivia";

    //<inheritdoc/>
    public string NativeName { get; } = nameof(Bolivia);

    //<inheritdoc/>
    public string Capital { get; } = "Sucre";

    //<inheritdoc/>
    public int NumericCode { get; } = 068;

    //<inheritdoc/>
    public string ISO2Code { get; } = "BO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "BOL";

    //<inheritdoc/>
    public string CallingCode { get; } = "+591";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Beni", "BEN", "Department"),
        new("Chuquisaca", "CHU", "Department"),
        new("Cochabamba", "CBB", "Department"),
        new("La Paz", "LPZ", "Department"),
        new("Oruro", "ORU", "Department"),
        new("Pando", "PAN", "Department"),
        new("Potosí", "POT", "Department"),
        new("Santa Cruz", "SCZ", "Department"),
        new("Tarija", "TJA", "Department")
    ];
}
