namespace World.Net.Countries;

internal sealed class UnitedStates : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.UnitedStates;

    public string Name { get; } = "United States";

    public string OfficialName { get; } = "United States of America";

    public string NativeName => "United States";

    public string Capital { get; } = "Washington, D.C.";

    public int NumericCode { get; } = 840;

    public string ISO2Code { get; } = "US";

    public string ISO3Code { get; } = "USA";

    public string[] CallingCode { get; } = ["+1"];

    public IEnumerable<State> States => new[]
    {
        new State("Alabama", "US-AL", "State"),
        new State("Alaska", "US-AK", "State"),
        new State("Arizona", "US-AZ", "State"),
        new State("Arkansas", "US-AR", "State"),
        new State("California", "US-CA", "State"),
        new State("Colorado", "US-CO", "State"),
        new State("Connecticut", "US-CT", "State"),
        new State("Delaware", "US-DE", "State"),
        new State("Florida", "US-FL", "State"),
        new State("Georgia", "US-GA", "State"),
        new State("Hawaii", "US-HI", "State"),
        new State("Idaho", "US-ID", "State"),
        new State("Illinois", "US-IL", "State"),
        new State("Indiana", "US-IN", "State"),
        new State("Iowa", "US-IA", "State"),
        new State("Kansas", "US-KS", "State"),
        new State("Kentucky", "US-KY", "State"),
        new State("Louisiana", "US-LA", "State"),
        new State("Maine", "US-ME", "State"),
        new State("Maryland", "US-MD", "State"),
        new State("Massachusetts", "US-MA", "State"),
        new State("Michigan", "US-MI", "State"),
        new State("Minnesota", "US-MN", "State"),
        new State("Mississippi", "US-MS", "State"),
        new State("Missouri", "US-MO", "State"),
        new State("Montana", "US-MT", "State"),
        new State("Nebraska", "US-NE", "State"),
        new State("Nevada", "US-NV", "State"),
        new State("New Hampshire", "US-NH", "State"),
        new State("New Jersey", "US-NJ", "State"),
        new State("New Mexico", "US-NM", "State"),
        new State("New York", "US-NY", "State"),
        new State("North Carolina", "US-NC", "State"),
        new State("North Dakota", "US-ND", "State"),
        new State("Ohio", "US-OH", "State"),
        new State("Oklahoma", "US-OK", "State"),
        new State("Oregon", "US-OR", "State"),
        new State("Pennsylvania", "US-PA", "State"),
        new State("Rhode Island", "US-RI", "State"),
        new State("South Carolina", "US-SC", "State"),
        new State("South Dakota", "US-SD", "State"),
        new State("Tennessee", "US-TN", "State"),
        new State("Texas", "US-TX", "State"),
        new State("Utah", "US-UT", "State"),
        new State("Vermont", "US-VT", "State"),
        new State("Virginia", "US-VA", "State"),
        new State("Washington", "US-WA", "State"),
        new State("West Virginia", "US-WV", "State"),
        new State("Wisconsin", "US-WI", "State"),
        new State("Wyoming", "US-WY", "State"),
        new State("District of Columbia", "US-DC", "Federal District")
    };
}

