using UniversityExplorer.Models;

namespace UniversityExplorer.Services;

public class UniversityService
{
    private readonly HttpClient _http;

    public UniversityService(HttpClient http)
    {
        _http = http;
    }

    // Gets all universities for one country
    public async Task<List<University>> GetUniversitiesAsync(string country)
    {
        // EscapeDataString makes names with spaces safe, e.g. "United Kingdom"
        var url = $"search?country={Uri.EscapeDataString(country)}";
        var universities = await _http.GetFromJsonAsync<List<University>>(url);
        return universities ?? new List<University>();
    }
}