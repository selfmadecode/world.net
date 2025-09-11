namespace World.Net.Countries;

internal sealed class Kenya : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Kenya;

    public string Name => "Kenya";

    public string OfficialName => "Republic of Kenya";

    public string NativeName => "Kenya";

    public string Capital => "Nairobi";

    public int NumericCode => 404;

    public string ISO2Code => "KE";

    public string ISO3Code => "KEN";

    public string[] CallingCode => ["+254"];

    public IEnumerable<State> States =>
    [
        new("Baringo", "KE-01", "County"),
        new("Bomet", "KE-02", "County"),
        new("Bungoma", "KE-03", "County"),
        new("Busia", "KE-04", "County"),
        new("Elgeyo-Marakwet", "KE-05", "County"),
        new("Embu", "KE-06", "County"),
        new("Garissa", "KE-07", "County"),
        new("Homa Bay", "KE-08", "County"),
        new("Isiolo", "KE-09", "County"),
        new("Kajiado", "KE-10", "County"),
        new("Kakamega", "KE-11", "County"),
        new("Kericho", "KE-12", "County"),
        new("Kiambu", "KE-13", "County"),
        new("Kilifi", "KE-14", "County"),
        new("Kirinyaga", "KE-15", "County"),
        new("Kisii", "KE-16", "County"),
        new("Kisumu", "KE-17", "County"),
        new("Kitui", "KE-18", "County"),
        new("Kwale", "KE-19", "County"),
        new("Laikipia", "KE-20", "County"),
        new("Lamu", "KE-21", "County"),
        new("Machakos", "KE-22", "County"),
        new("Makueni", "KE-23", "County"),
        new("Mandera", "KE-24", "County"),
        new("Marsabit", "KE-25", "County"),
        new("Meru", "KE-26", "County"),
        new("Migori", "KE-27", "County"),
        new("Mombasa", "KE-28", "County"),
        new("Murang'a", "KE-29", "County"),
        new("Nairobi City", "KE-30", "County"),
        new("Nakuru", "KE-31", "County"),
        new("Nandi", "KE-32", "County"),
        new("Narok", "KE-33", "County"),
        new("Nyamira", "KE-34", "County"),
        new("Nyandarua", "KE-35", "County"),
        new("Nyeri", "KE-36", "County"),
        new("Samburu", "KE-37", "County"),
        new("Siaya", "KE-38", "County"),
        new("Taita-Taveta", "KE-39", "County"),
        new("Tana River", "KE-40", "County"),
        new("Tharaka-Nithi", "KE-41", "County"),
        new("Trans Nzoia", "KE-42", "County"),
        new("Turkana", "KE-43", "County"),
        new("Uasin Gishu", "KE-44", "County"),
        new("Vihiga", "KE-45", "County"),
        new("Wajir", "KE-46", "County"),
        new("West Pokot", "KE-47", "County")
    ];
}
