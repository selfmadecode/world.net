


██     ██  ██████  ██████     ██      ██████       ███     ██  ███████  ████████
██     ██ ██    ██ ██   ██    ██      ██    ██     █████   ██  ██          ██
██  █  ██ ██    ██ ██████     ██      ██    ██     ██  ██  ██  ██████      ██
██ ███ ██ ██    ██ ██    ██   ██      ██    ██     ██   ██ ██  ██          ██
 ███ ███   ██████  ██     ██  ███████ ██████    ██ ██    ████  ███████     ██

===============================================================================

# World.Net

## Overview
A simple package designed to:
- Retrieve a list of all countries.
- Fetch specific details about a country using its identifier.

---

## Features
1. **Get All Countries**:
   - Retrieve a read-only list of all available countries, including their names and capitals.

2. **Get Country by ID**:
   - Fetch detailed information about a specific country using its unique ID.

3. **Custom Exception Handling**:
   - Throws a `CountryNotFoundException` when an invalid country ID is queried.

4. **Thread-Safe Initialization**:
   - Ensures lazy and thread-safe initialization of country data.

---

## Code Example
Here’s how you can use the package to display all countries and details of Afghanistan:

```csharp
using World.Net;
using World.Net.Helpers;

Console.WriteLine("All Countries:");
var countries = CountryProvider.GetAllCountries();
foreach (var country in countries)
{
    Console.WriteLine($"Name: {country.Name}, Capital: {country.Capital}");
}

Console.WriteLine("\nDetails for Afghanistan:");
var afghanistan = CountryProvider.GetCountry(CountryIdentifier.AfghanistanId);
Console.WriteLine($"Official Name: {afghanistan.OfficialName}, Capital: {afghanistan.Capital}");
