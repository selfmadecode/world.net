---
mode: 'agent'
tools: ['codebase']
description: 'Generate a new Country class and Unit Test for World.Net by only providing the country name. If no country name is provided, ask for it and wait for user input.'
---

# Copilot Country Creation Prompt for World.Net

## Instructions
When you are asked to "create a country":

1. **Prompt for Country Name**
   - Always check if the user included the country name.
   - If the name **is provided** (e.g., "Create a country: Kenya"), use it directly.
   - If the name **is not provided** (e.g., "Create a country"), immediately ask:
     > "What is the name of the country you would like to create? Please provide the official country name (e.g., 'Nigeria')."
   - After the user provides the country name, **continue automatically** with the workflow.  
   - Do not ask for any additional information such as ISO codes, capitals, or calling codes. Use official ISO/UN data automatically.


2. **Read C# and World.Net Standards**
   - Read and apply the standards from `src/.copilot/csharp-standards.instructions.md` and `src/.copilot/worldnet-standards.instructions.md`.
   - Ensure all generated code follows these conventions (naming, formatting, documentation, etc.).

3. **Create the Country Class**
   - Place in `src/World.Net/Countries/`.
   - Class name must match the country (e.g., `Nigeria.cs` ? `public sealed class Nigeria : ICountry`).
   - Implement all `ICountry` properties: `Id`, `Name`, `OfficialName`, `NativeName`, `Capital`, `NumericCode`, `ISO2Code`, `ISO3Code`, `CallingCode`, `States`.
   - Use immutable properties (fixed values, no setters).
   - Use the correct `CountryIdentifier.<Name>` for `Id`.
   - All data must be ISO/UN recognized and complete.

4. **Register in CountryInitializer**
   - Add the new country to `CountryInitializer.Initialize()` in `src/World.Net/Helpers/CountryInitializer.cs`.
   - Use: `{ CountryIdentifier.<Name>, new <Name>() },`
   - Keep entries alphabetically ordered by enum key.
   - Do not duplicate entries.

5. **Add to CountryIdentifier Enum**
   - Add a new entry to `CountryIdentifier` in `src/World.Net/Helpers/CountryIdentifier.cs` if not present.
   - Enum name must match the class name exactly.
   - Keep enum entries alphabetically ordered.

6. **Create Unit Tests**
   - Place in `src/World.Net.UnitTests/Countries/`.
   - File name: `<CountryName>Test.cs`.
   - Class name: `<CountryName>Test`.
   - Use constants for all expected values.
   - Test must retrieve the country via `CountryProvider.GetCountry(CountryIdentifier.<Name>)` and assert all properties.
   - Example:
     ```csharp
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
     ```
   - Validate all states/regions for count and type if applicable.

7. **General Rules**
   - All country classes must be immutable.
   - No country logic outside the Countries folder.
   - No incomplete or placeholder data.
   - Always run unit tests after adding a country.

## Copilot Workflow
When asked to "create a country":
1. Ask for the country name.
2. Read and apply the C# standards from `src/.copilot/csharp-standards.instructions.md`.
3. Search for the country in `CountryIdentifier` and add if missing.
4. Create the country class in `src/World.Net/Countries/`.
5. Register it in `CountryInitializer`.
6. Create a unit test in `src/World.Net.UnitTests/Countries/`.
7. Run a build and all tests to verify correctness.

## Example Directory Structure
```
src/World.Net/Countries/Nigeria.cs
src/World.Net/Helpers/CountryInitializer.cs
src/World.Net/Helpers/CountryIdentifier.cs
src/World.Net.UnitTests/Countries/NigeriaTest.cs
```

## Additional Guidance
- Use `text_search` to discover related code and avoid duplication.
- Always check for existing enum/class/test before creating new ones.
- Follow the naming and ordering conventions strictly.
- Use only ISO/UN official data for all country properties.
- If a country has subdivisions (states, provinces, etc.), list them in the `States` property using the correct type and ISO codes.
- If you are unsure about a country's data, do not create a placeholder—skip or request clarification.

---
This file is for Copilot agent prompt use. Do not edit unless updating the automation workflow or standards.
