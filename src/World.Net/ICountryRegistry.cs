namespace World.Net;

internal interface ICountryRegistry
{
    Dictionary<int, ICountry> GetCountry();
}
