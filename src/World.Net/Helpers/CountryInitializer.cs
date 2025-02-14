using System.Reflection;

namespace World.Net.Helpers;

internal sealed class CountryInitializer
{
    public static Dictionary<int, ICountry> Initialize()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AfghanistanId, new Afghanistan() },
            { CountryIdentifier.AlandIslands, new AlandIslands() },
            { CountryIdentifier.Albania, new Albania() },
            { CountryIdentifier.Algeria, new Algeria() },
            { CountryIdentifier.AmericanSamoa, new AmericanSamoa() },
            { CountryIdentifier.Andorra, new Andorra() },
            { CountryIdentifier.AntiguaAndBarbuda, new AntiguaAndBarbuda() },
            { CountryIdentifier.Armenia, new Armenia() },
            { CountryIdentifier.Argentina, new Argentina() },
            { CountryIdentifier.Angola, new Angola() },
            { CountryIdentifier.Anguilla, new Anguilla() },
            { CountryIdentifier.Antarctica, new Antarctica() },
            { CountryIdentifier.Aruba, new Aruba() },
            { CountryIdentifier.Australia, new Australia() },
            { CountryIdentifier.Austria, new Austria() },
            { CountryIdentifier.Azerbaijan, new Azerbaijan() },
            { CountryIdentifier.Bahamas, new TheBahamas() },
            { CountryIdentifier.Bahrain, new Bahrain() },
            { CountryIdentifier.Bangladesh, new Bangladesh() },
            { CountryIdentifier.Barbados, new Barbados() },
            { CountryIdentifier.Belarus, new Belarus() },
            { CountryIdentifier.Belgium, new Belgium() },
            { CountryIdentifier.Belize, new Belize() },
            { CountryIdentifier.Benin, new Benin() },
            { CountryIdentifier.Bermuda, new Bermuda() },
            { CountryIdentifier.Bhutan, new Bhutan() },
            { CountryIdentifier.Bolivia, new Bolivia() },
            { CountryIdentifier.BosniaAndHerzegovina, new BosniaAndHerzegovina() },
            { CountryIdentifier.Botswana, new Botswana() },
            { CountryIdentifier.BouvetIsland, new BouvetIsland() },

            // Future countries can be added here in the same format.
        };
    }

    public static Dictionary<int, ICountry> InitializeByReflection()
    {
        var registries = AppDomain.CurrentDomain.GetAssemblies()
       .Where(a => !a.IsDynamic && a.FullName?.StartsWith("World.Net") == true)
       .SelectMany(a =>
       {
           try
           {
               return a.GetTypes();
           }
           catch (ReflectionTypeLoadException ex)
           {
               return ex.Types.Where(t => t != null);
           }
       })
       .Where(t => t != null && 
       typeof(ICountryRegistry).IsAssignableFrom(t) && 
       !t.IsInterface && !t.IsAbstract)
       .Select(t => (ICountryRegistry)Activator.CreateInstance(t)!)
       .ToList();

        return registries
            .SelectMany(r => r.GetCountry())
            .ToDictionary(k => k.Key, v => v.Value);
    }
}
