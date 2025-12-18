namespace World.Net.Countries;

internal sealed class Nigeria : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Nigeria;

    //<inheritdoc/>
    public string Name { get; } = "Nigeria";

    //<inheritdoc/>
    public string OfficialName { get; } = "Federal Republic of Nigeria";

    //<inheritdoc/>
    public string NativeName => "Nigeria";

    //<inheritdoc/>
    public string Capital { get; } = "Abuja";

    //<inheritdoc/>
    public int NumericCode { get; } = 566;

    //<inheritdoc/>
    public string ISO2Code { get; } = "NG";

    //<inheritdoc/>
    public string ISO3Code { get; } = "NGA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+234"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Abia", "NG-AB", "State"),
        new("Adamawa", "NG-AD", "State"),
        new("Akwa Ibom", "NG-AK", "State"),
        new("Anambra", "NG-AN", "State"),
        new("Bauchi", "NG-BA", "State"),
        new("Bayelsa", "NG-BY", "State"),
        new("Benue", "NG-BE", "State"),
        new("Borno", "NG-BO", "State"),
        new("Cross River", "NG-CR", "State"),
        new("Delta", "NG-DE", "State"),
        new("Ebonyi", "NG-EB", "State"),
        new("Edo", "NG-ED", "State"),
        new("Ekiti", "NG-EK", "State"),
        new("Enugu", "NG-EN", "State"),
        new("Gombe", "NG-GO", "State"),
        new("Imo", "NG-IM", "State"),
        new("Jigawa", "NG-JI", "State"),
        new("Kaduna", "NG-KD", "State"),
        new("Kano", "NG-KN", "State"),
        new("Katsina", "NG-KT", "State"),
        new("Kebbi", "NG-KE", "State"),
        new("Kogi", "NG-KO", "State"),
        new("Kwara", "NG-KW", "State"),
        new("Lagos", "NG-LA", "State"),
        new("Nasarawa", "NG-NA", "State"),
        new("Niger", "NG-NI", "State"),
        new("Ogun", "NG-OG", "State"),
        new("Ondo", "NG-ON", "State"),
        new("Osun", "NG-OS", "State"),
        new("Oyo", "NG-OY", "State"),
        new("Plateau", "NG-PL", "State"),
        new("Rivers", "NG-RI", "State"),
        new("Sokoto", "NG-SO", "State"),
        new("Taraba", "NG-TA", "State"),
        new("Yobe", "NG-YO", "State"),
        new("Zamfara", "NG-ZA", "State"),
        new("Federal Capital Territory", "NG-FC", "Federal Capital Territory")
    ];
}
