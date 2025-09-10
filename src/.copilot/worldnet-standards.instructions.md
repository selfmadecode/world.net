---
applyTo: "**/*.cs"
---

# World.Net Standards

## Country Classes
- All countries live under `World.Net/Countries/`.
- Each country must implement the `ICountry` interface.
- Class name must match the country name (e.g., `Nigeria.cs` ? `public sealed class Nigeria : ICountry`).
- `ICountry` must expose: Id, Name, OfficialName, NativeName, Capital, NumericCode, ISO2Code, ISO3Code, CallingCode.
- Use `CountryIdentifier.<Name>` enum for the `Id` property.

## CountryInitializer
- All countries must be added to `CountryInitializer`:
  ```csharp
  _countries.Add(CountryIdentifier.Nigeria, new Nigeria());
- Do not duplicate entries.
- Keep entries alphabetically ordered by enum key where possible.

## CountryIdentifier Enum

- Every country must have a unique enum entry in CountryIdentifier.
- Enum names must match the class names exactly (e.g., Nigeria ? CountryIdentifier.Nigeria).
- Enum entries should be alphabetically ordered.

## Unit Tests

- Each country must have a dedicated test class in World.Net.UnitTests/.
- Test class name format: <CountryName>Test.
- Each test must:
- Retrieve the country instance via CountryProvider.GetCountry(CountryIdentifier.<Name>).
- Validate all properties (Name, OfficialName, NativeName, Capital, NumericCode, ISO2Code, ISO3Code, CallingCode) against constants defined in the test.

Example:
[Fact]
public void GetCountry_ReturnsCorrectInformation_ForNigeria()
{
    var country = CountryProvider.GetCountry(CountryIdentifier.Nigeria);

    Assert.Equal(CountryIdentifier.Nigeria, country.Id);
    Assert.Equal("Nigeria", country.Name);
    Assert.Equal("Federal Republic of Nigeria", country.OfficialName);
    Assert.Equal("Nigeria", country.NativeName);
    Assert.Equal("Abuja", country.Capital);
    Assert.Equal(566, country.NumericCode);
    Assert.Equal("NG", country.ISO2Code);
    Assert.Equal("NGA", country.ISO3Code);
    Assert.Equal(new[] { "+234" }, country.CallingCode);
}

## General Rules

- All countries must be immutable objects (properties return fixed values).
- Do not hardcode country logic outside of the Countries folder.
- Do not expose incomplete or placeholder data; all country classes must include valid ISO and UN-recognized information.
- Always run unit tests after adding a new country to ensure correctness.
