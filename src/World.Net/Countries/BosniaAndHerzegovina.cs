namespace World.Net.Countries;

internal sealed class BosniaAndHerzegovina : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.BosniaAndHerzegovina;

    ///<inheritdoc/>
    public string Name => "Bosnia And Herzegovina";

    ///<inheritdoc/>
    public string OfficialName { get; } = "Bosna i Hercegovina";

    ///<inheritdoc/>
    public string NativeName { get; } = "Bosna i Hercegovina";

    ///<inheritdoc/>
    public string Capital { get; } = "Sarajevo";

    ///<inheritdoc/>
    public int NumericCode { get; } = 070;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BA";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BIH";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+387";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Bosnian Podrinje", "05", "Canton"),
        new("Brčko", "BRC", "District"),
        new("Canton 10", "10", "Canton"),
        new("Central Bosnia", "06", "Canton"),
        new("Federation of Bosnia and Herzegovina", "BIH", "Entity"),
        new("Herzegovina-Neretva", "07", "Canton"),
        new("Posavina", "02", "Canton"),
        new("Republika Srpska", "SRP", "Entity"),
        new("Sarajevo", "09", "Canton"),
        new("Tuzla", "03", "Canton"),
        new("Una-Sana", "01", "Canton"),
        new("West Herzegovina", "08", "Canton"),
        new("Zenica-Doboj", "04", "Canton")
    ];
}
