namespace World.Net.Countries;

internal sealed class Moldova : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Moldova;

    public string Name { get; } = "Moldova";

    public string OfficialName { get; } = "Republic of Moldova";

    public string NativeName => "Republica Moldova";

    public string Capital { get; } = "Chișinău";

    public int NumericCode { get; } = 498;

    public string ISO2Code { get; } = "MD";

    public string ISO3Code { get; } = "MDA";

    public string[] CallingCode { get; } = ["+373"];

    public IEnumerable<State> States => new[]
    {
        new State("Bălți", "MD-BA", "City"),
        new State("Bender", "MD-BD", "City"),
        new State("Chișinău", "MD-CU", "City"),
        new State("Anenii Noi", "MD-AN", "District"),
        new State("Basarabeasca", "MD-BS", "District"),
        new State("Briceni", "MD-BR", "District"),
        new State("Cahul", "MD-CA", "District"),
        new State("Cantemir", "MD-CT", "District"),
        new State("Călărași", "MD-CL", "District"),
        new State("Cimișlia", "MD-CM", "District"),
        new State("Criuleni", "MD-CR", "District"),
        new State("Dondușeni", "MD-DO", "District"),
        new State("Drochia", "MD-DR", "District"),
        new State("Dubăsari", "MD-DU", "District"),
        new State("Edineț", "MD-ED", "District"),
        new State("Fălești", "MD-FA", "District"),
        new State("Florești", "MD-FL", "District"),
        new State("Glodeni", "MD-GL", "District"),
        new State("Hîncești", "MD-HI", "District"),
        new State("Ialoveni", "MD-IA", "District"),
        new State("Leova", "MD-LE", "District"),
        new State("Nisporeni", "MD-NI", "District"),
        new State("Ocnița", "MD-OC", "District"),
        new State("Orhei", "MD-OR", "District"),
        new State("Rezina", "MD-RE", "District"),
        new State("Rîșcani", "MD-RI", "District"),
        new State("Sîngerei", "MD-SI", "District"),
        new State("Soroca", "MD-SO", "District"),
        new State("Strășeni", "MD-ST", "District"),
        new State("Șoldănești", "MD-SD", "District"),
        new State("Ștefan Vodă", "MD-SV", "District"),
        new State("Taraclia", "MD-TA", "District"),
        new State("Telenești", "MD-TE", "District"),
        new State("Ungheni", "MD-UN", "District"),
        new State("Gagauzia", "MD-GA", "Autonomous Region")
    };
}

