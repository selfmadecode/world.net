namespace World.Net.Countries;

internal sealed class SintMaarten : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SintMaartenDutchPart;

    //<inheritdoc/>
    public string Name { get; } = "Sint Maarten (Dutch part)";

    //<inheritdoc/>
    public string OfficialName { get; } = "Sint Maarten";

    //<inheritdoc/>
    public string NativeName => "Sint Maarten";

    //<inheritdoc/>
    public string Capital { get; } = "Philipsburg";

    //<inheritdoc/>
    public int NumericCode { get; } = 534;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SX";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SXM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-721"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
