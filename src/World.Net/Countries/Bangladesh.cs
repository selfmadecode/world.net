namespace World.Net.Countries;

internal sealed class Bangladesh : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Bangladesh;

    ///<inheritdoc/>
    public string Name => nameof(Bangladesh);

    ///<inheritdoc/>
    public string OfficialName { get; } = "People's Republic of Bangladesh";

    ///<inheritdoc/>
    public string NativeName { get; } = "Bangladesh";

    ///<inheritdoc/>
    public string Capital { get; } = "Dhaka";

    ///<inheritdoc/>
    public int NumericCode { get; } = 050;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BD";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BGD";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+880";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Barisal", "BD-A", "Division"),
        new("Chittagong", "BD-B", "Division"),
        new("Dhaka", "BD-C", "Division"),
        new("Khulna", "BD-D", "Division"),
        new("Mymensingh", "BD-M", "Division"),
        new("Rajshahi", "BD-E", "Division"),
        new("Rangpur", "BD-F", "Division"),
        new("Sylhet", "BD-G", "Division")
    ];
}
