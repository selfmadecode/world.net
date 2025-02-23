// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.
namespace World.Net;

/// <summary>
/// Provides access to country-related data and operations.
/// </summary>
/// <remarks>
/// This class is responsible for managing a collection of countries, ensuring lazy initialization 
/// and thread-safety. It serves as a central repository for retrieving country instances.
/// </remarks>
public static class CountryProvider
{
    /// <summary>
    /// Lazy initialization of the countries dictionary, thread-safe by default.
    /// </summary>
    /// <remarks>
    /// The collection contains instances of classes that implement the <see cref="ICountry"/> interface.
    /// It is initialized once, upon first access, and remains read-only thereafter.
    /// </remarks>
    private static readonly Lazy<IDictionary<CountryIdentifier, ICountry>> _countries = new(() =>
    {
        return CountryInitializer.Initialize();
    });

    /// <summary>
    /// Retrieves a read-only collection of all available countries.
    /// </summary>
    /// <returns>
    /// An <see cref="IReadOnlyCollection{ICountry}"/> representing all available countries.
    /// </returns>
    /// <remarks>
    /// This method ensures that the countries dictionary is initialized upon first access, and the returned
    /// collection is read-only and thread-safe.
    /// </remarks>
    public static IReadOnlyCollection<ICountry> GetAllCountries()
    {
        return _countries.Value.Values.ToList().AsReadOnly();
    }

    /// <summary>
    /// Retrieves a country by its unique identifier.
    /// </summary>
    /// <param name="countryIdentifier">The unique identifier of the country to retrieve.</param>
    /// <returns>The <see cref="ICountry"/> instance corresponding to the specified <paramref name="countryIdentifier"/>.</returns>
    /// <exception cref="CountryNotFoundException">
    /// Thrown when no country with the specified <paramref name="countryIdentifier"/> exists.
    /// </exception>
    public static ICountry GetCountry(CountryIdentifier countryIdentifier)
    {
        if (_countries.Value.TryGetValue(countryIdentifier, out ICountry? country))
        {
            return country;
        }

        throw new CountryNotFoundException($"Country with id {countryIdentifier} was not found.");
    }
}
