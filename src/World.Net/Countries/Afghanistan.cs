namespace World.Net.Countries;

internal sealed class Afghanistan : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.AfghanistanId;

    ///<inheritdoc/>
    public string Name => nameof(Afghanistan);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Islamic Republic of Afghanistan";

    ///<inheritdoc/>
    public string NativeName { get; } = "افغانستان";

    ///<inheritdoc/>
    public string Capital { get; } = "Kabul";

    ///<inheritdoc/>
    public int NumericCode { get; } = 004;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AF";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "AFG";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+93";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Badakhshan", "AF-BDS"),
        new("Badghis", "AF-BDG"),
        new("Baghlan", "AF-BGL"),
        new("Balkh", "AF-BAL"),
        new("Bamyan", "AF-BAM"),
        new("Daykundi", "AF-DAY"),
        new("Farah", "AF-FRA"),
        new("Faryab", "AF-FYB"),
        new("Ghazni", "AF-GHA"),
        new("Ghor", "AF-GHO"),
        new("Helmand", "AF-HEL"),
        new("Herat", "AF-HER"),
        new("Jowzjan", "AF-JOW"),
        new("Kabul", "AF-KAB"),
        new("Kandahar", "AF-KAN"),
        new("Kapisa", "AF-KAP"),
        new("Khost", "AF-KHO"),
        new("Kunar", "AF-KNR"),
        new("Kunduz", "AF-KDZ"),
        new("Laghman", "AF-LAG"),
        new("Logar", "AF-LOG"),
        new("Nangarhar", "AF-NAN"),
        new("Nimroz", "AF-NIM"),
        new("Nuristan", "AF-NUR"),
        new("Paktia", "AF-PIA"),
        new("Paktika", "AF-PKA"),
        new("Panjshir", "AF-PAN"),
        new("Parwan", "AF-PAR"),
        new("Samangan", "AF-SAM"),
        new("Sar-e Pol", "AF-SAR"),
        new("Takhar", "AF-TAK"),
        new("Urozgan", "AF-URU"),
        new("Wardak", "AF-WAR"),
        new("Zabul", "AF-ZAB")
    ];
}
