
namespace World.Net.Countries;

internal sealed class CaymanIslands : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.CaymanIslands;

    public string Name => "Cayman Islands";

    public string OfficialName => "Cayman Islands";

    public string NativeName => "Cayman Islands";

    public string Capital => throw new NotImplementedException();

    public int NumericCode => throw new NotImplementedException();

    public string ISO2Code => throw new NotImplementedException();

    public string ISO3Code => throw new NotImplementedException();

    public string CallingCode => throw new NotImplementedException();

    public IEnumerable<State> States => throw new NotImplementedException();
}
