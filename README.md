[![NuGet Version](https://img.shields.io/nuget/v/Countries.World.net.svg?style=flat&logo=nuget)](https://www.nuget.org/packages/Countries.World.Net)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Countries.World.net.svg?style=flat&logo=nuget)](https://www.nuget.org/packages/Countries.World.net)
[![License](https://img.shields.io/github/license/selfmadecode/World.net.svg?style=flat)](LICENSE)
[![.NET ≥ 2.1](https://img.shields.io/badge/.NET-%E2%89%A52.1-512BD4?logo=dot-net&style=flat)](https://dotnet.microsoft.com/)
[![GitHub issues](https://img.shields.io/github/issues/selfmadecode/World.net.svg?style=flat)](https://github.com/selfmadecode/World.net/issues)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat)](https://github.com/selfmadecode/World.net/pulls)

 
 # Countries.World.Net

## Overview
A simple nuget package designed to:
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

```
## Contributors

Thanks to the following people who have contributed to this project:
- **Samuel Idam** [Deanology](https://github.com/deanology)
- **Reagan Reuben** [ReaganDev](https://github.com/ReaganDev)
