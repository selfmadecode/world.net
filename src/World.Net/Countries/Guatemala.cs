namespace World.Net.Countries;

internal sealed class Guatemala : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Guatemala;

    //<inheritdoc/>
    public string Name { get; } = "Guatemala";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Guatemala";

    //<inheritdoc/>
    public string NativeName => "Guatemala";

    //<inheritdoc/>
    public string Capital { get; } = "Guatemala City";

    //<inheritdoc/>
    public int NumericCode { get; } = 320;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GT";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GTM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+502"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alta Verapaz", "GT-AV", "Department"),
        new("Baja Verapaz", "GT-BV", "Department"),
        new("Chimaltenango", "GT-CM", "Department"),
        new("Chiquimula", "GT-CQ", "Department"),
        new("El Progreso", "GT-PR", "Department"),
        new("Escuintla", "GT-ES", "Department"),
        new("Guatemala", "GT-GU", "Department"),
        new("Huehuetenango", "GT-HU", "Department"),
        new("Izabal", "GT-IZ", "Department"),
        new("Jalapa", "GT-JA", "Department"),
        new("Jutiapa", "GT-JU", "Department"),
        new("Petén", "GT-PE", "Department"),
        new("Quetzaltenango", "GT-QZ", "Department"),
        new("Quiché", "GT-QC", "Department"),
        new("Retalhuleu", "GT-RE", "Department"),
        new("Sacatepéquez", "GT-SA", "Department"),
        new("San Marcos", "GT-SM", "Department"),
        new("Santa Rosa", "GT-SR", "Department"),
        new("Sololá", "GT-SO", "Department"),
        new("Suchitepéquez", "GT-SU", "Department"),
        new("Totonicapán", "GT-TO", "Department"),
        new("Zacapa", "GT-ZA", "Department")
    ];
}
