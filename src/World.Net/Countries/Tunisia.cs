namespace World.Net.Countries;

internal sealed class Tunisia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Tunisia;

    public string Name { get; } = "Tunisia";

    public string OfficialName { get; } = "Republic of Tunisia";

    public string NativeName => "تونس";

    public string Capital { get; } = "Tunis";

    public int NumericCode { get; } = 788;

    public string ISO2Code { get; } = "TN";

    public string ISO3Code { get; } = "TUN";

    public string[] CallingCode { get; } = ["+216"];

    public IEnumerable<State> States => new[]
    {
        new State("Ariana", "TN-12", "Governorate"),
        new State("Beja", "TN-31", "Governorate"),
        new State("Ben Arous", "TN-13", "Governorate"),
        new State("Bizerte", "TN-23", "Governorate"),
        new State("Gabes", "TN-81", "Governorate"),
        new State("Gafsa", "TN-71", "Governorate"),
        new State("Jendouba", "TN-32", "Governorate"),
        new State("Kairouan", "TN-41", "Governorate"),
        new State("Kasserine", "TN-42", "Governorate"),
        new State("Kebili", "TN-73", "Governorate"),
        new State("Kef", "TN-33", "Governorate"),
        new State("Mahdia", "TN-53", "Governorate"),
        new State("Manouba", "TN-14", "Governorate"),
        new State("Medenine", "TN-82", "Governorate"),
        new State("Monastir", "TN-52", "Governorate"),
        new State("Nabeul", "TN-21", "Governorate"),
        new State("Sfax", "TN-81", "Governorate"),
        new State("Sidi Bouzid", "TN-43", "Governorate"),
        new State("Siliana", "TN-34", "Governorate"),
        new State("Sousse", "TN-51", "Governorate"),
        new State("Tataouine", "TN-83", "Governorate"),
        new State("Tozeur", "TN-72", "Governorate"),
        new State("Tunis", "TN-11", "Governorate"),
        new State("Zaghouan", "TN-22", "Governorate")
    };
}
