namespace World.Net.Countries;

internal sealed class Gabon : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Gabon;

    //<inheritdoc/>
    public string Name { get; } = "Gabon";

    //<inheritdoc/>
    public string OfficialName { get; } = "Gabonese Republic";

    //<inheritdoc/>
    public string NativeName => "R�publique gabonaise";

    //<inheritdoc/>
    public string Capital { get; } = "Libreville";

    //<inheritdoc/>
    public int NumericCode { get; } = 266;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GA";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GAB";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+241"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Estuaire", "GA-1"),
        new("Haut-Ogoou�", "GA-2"),
        new("Moyen-Ogoou�", "GA-3"),
        new("Ngouni�", "GA-4"),
        new("Nyanga", "GA-5"),
        new("Ogoou�-Ivindo", "GA-6"),
        new("Ogoou�-Lolo", "GA-7"),
        new("Ogoou�-Maritime", "GA-8"),
        new("Woleu-Ntem", "GA-9")
    ];
}
