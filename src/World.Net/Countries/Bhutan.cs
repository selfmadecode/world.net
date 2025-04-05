namespace World.Net.Countries;

internal sealed class Bhutan : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Bhutan;
    
    //<inheritdoc/>    
    public string Name { get; } = "Bhutan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Bhutan";

    //<inheritdoc/>
    public string NativeName { get; } = "ʼbrug-yul";

    //<inheritdoc/>
    public string Capital { get; } = "Thimphu";

    //<inheritdoc/>
    public int NumericCode { get; } = 064;

    //<inheritdoc/>
    public string ISO2Code { get; } = "BT";

    //<inheritdoc/>
    public string ISO3Code { get; } = "BTN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+975"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Bumthang", "33", "District"),
        new("Chukha", "12", "District"),
        new("Dagana", "22", "District"),
        new("Gasa", "GA", "District"),
        new("Haa", "13", "District"),
        new("Lhuntse", "44", "District"),
        new("Mongar", "42", "District"),
        new("Paro", "11", "District"),
        new("Pemagatshel", "43", "District"),
        new("Punakha", "23", "District"),
        new("Samdrup Jongkhar", "45", "District"),
        new("Samtse", "14", "District"),
        new("Sarpang", "31", "District"),
        new("Thimphu", "15", "District"),
        new("Trashi Yangtse", "TY", "District"),
        new("Trashigang", "41", "District"),
        new("Trongsa", "32", "District"),
        new("Tsirang", "21", "District"),
        new("Wangdue Phodrang", "24", "District"),
        new("Zhemgang", "34", "District")
    ];
}
