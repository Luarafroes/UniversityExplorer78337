using UniversityExplorer.Models;

namespace UniversityExplorer.Services;

public class CountryService
{
    private readonly HttpClient _http;

    // The HttpClient is given to us by .NET (dependency injection)
    public CountryService(HttpClient http)
    {
        _http = http;
    }

    // Gets all countries, sorted A to Z
    public async Task<List<Country>> GetCountriesAsync()
    {
        var countries = await _http.GetFromJsonAsync<List<Country>>("countries");
        return countries?.OrderBy(c => c.Name).ToList() ?? new List<Country>();
    }
}