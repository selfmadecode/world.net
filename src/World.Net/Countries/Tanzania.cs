namespace World.Net.Countries;

internal sealed class Tanzania : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Tanzania;

    public string Name { get; } = "Tanzania";

    public string OfficialName { get; } = "United Republic of Tanzania";

    public string NativeName => "Jamhuri ya Muungano wa Tanzania";

    public string Capital { get; } = "Dodoma";

    public int NumericCode { get; } = 834;

    public string ISO2Code { get; } = "TZ";

    public string ISO3Code { get; } = "TZA";

    public string[] CallingCode { get; } = ["+255"];

    public IEnumerable<State> States => new[]
    {
        new State("Arusha", "TZ-AR", "Region"),
        new State("Dar es Salaam", "TZ-DA", "Region"),
        new State("Dodoma", "TZ-DO", "Region"),
        new State("Geita", "TZ-GE", "Region"),
        new State("Iringa", "TZ-IR", "Region"),
        new State("Kagera", "TZ-KA", "Region"),
        new State("Katavi", "TZ-KT", "Region"),
        new State("Kigoma", "TZ-KI", "Region"),
        new State("Kilimanjaro", "TZ-KL", "Region"),
        new State("Lindi", "TZ-LI", "Region"),
        new State("Manyara", "TZ-MA", "Region"),
        new State("Mara", "TZ-MR", "Region"),
        new State("Mbeya", "TZ-MB", "Region"),
        new State("Morogoro", "TZ-MO", "Region"),
        new State("Mtwara", "TZ-MT", "Region"),
        new State("Mwanza", "TZ-MW", "Region"),
        new State("Njombe", "TZ-NJ", "Region"),
        new State("Pwani", "TZ-PW", "Region"),
        new State("Rukwa", "TZ-RU", "Region"),
        new State("Ruvuma", "TZ-RV", "Region"),
        new State("Shinyanga", "TZ-SH", "Region"),
        new State("Simiyu", "TZ-SI", "Region"),
        new State("Singida", "TZ-SN", "Region"),
        new State("Tabora", "TZ-TA", "Region"),
        new State("Tanga", "TZ-TE", "Region"),
        new State("Songwe", "TZ-SO", "Region"),
        new State("Zanzibar North", "TZ-ZN", "Region"),
        new State("Zanzibar South", "TZ-ZS", "Region"),
        new State("Zanzibar Central/South", "TZ-ZC", "Region"),
        new State("Zanzibar West", "TZ-ZW", "Region"),
        new State("Zanzibar Urban/West", "TZ-ZU", "Region")
    };
}

