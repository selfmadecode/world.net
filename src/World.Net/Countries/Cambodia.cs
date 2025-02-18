namespace World.Net.Countries;

internal sealed class Cambodia : ICountry
{
    //<inheritdoc/>
    public int Id => CountryIdentifier.Cambodia;

    //<inheritdoc/>
    public string Name { get; } = "Cambodia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Cambodia";

    //<inheritdoc/>
    public string NativeName => "កម\u17d2ព\u17bbជ\u17b6";

    //<inheritdoc/>
    public string Capital { get; } = "Phnom Penh";

    //<inheritdoc/>
    public int NumericCode { get; } = 116;

    //<inheritdoc/>
    public string ISO2Code { get; } = "KH";

    //<inheritdoc/>
    public string ISO3Code { get; } = "KHM";

    //<inheritdoc/>
    public string CallingCode { get; } = "+855";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Banteay Meanchey", "1"),
        new("Battambang", "2"),
        new("Kampong Cham", "3"),
        new("Kampong Chhnang", "4"),
        new("Kampong Speu", "5"),
        new("Kampong Thom", "6"),
        new("Kampot", "7"),
        new("Kandal", "8"),
        new("Koh Kong", "9"),
        new("Kratié", "10"),
        new("Mondulkiri", "11"),
        new("Phnom Penh", "12", "Municipality"),
        new("Preah Vihear", "13"),
        new("Prey Veng", "14"),
        new("Pursat", "15"),
        new("Ratanakiri", "16"),
        new("Siem Reap", "17"),
        new("Preah Sihanouk", "18"),
        new("Stung Treng", "19"),
        new("Svay Rieng", "20"),
        new("Takéo", "21"),
        new("Oddar Meanchey", "22"),
        new("Kep", "23"),
        new("Pailin", "24"),
        new("Tbong Khmum", "25")
    ];
}
