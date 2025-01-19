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
    private static readonly Lazy<IDictionary<int, ICountry>> _countries = new(() =>
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AfghanistanId, new Afghanistan() }
            // Future countries can be added here in the same format.
        };
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
}
