using UniversityExplorer.Models;

namespace UniversityExplorer.Services;

public class StudentApplicationService
{
    private readonly HttpClient _http;

    public StudentApplicationService(HttpClient http)
    {
        _http = http;
    }

    // GET: all applications
    public async Task<List<StudentApplication>> GetApplicationsAsync()
    {
        var apps = await _http.GetFromJsonAsync<List<StudentApplication>>("studentapplication");
        return apps ?? new List<StudentApplication>();
    }

    // GET: one application by id (used by the Edit page)
    public async Task<StudentApplication?> GetApplicationAsync(int id)
    {
        return await _http.GetFromJsonAsync<StudentApplication>($"studentapplication/{id}");
    }

    // POST: create a new application
    public async Task CreateApplicationAsync(StudentApplication application)
    {
        var response = await _http.PostAsJsonAsync("studentapplication", application);
        response.EnsureSuccessStatusCode(); // throws an error if the API says no
    }

    // PUT: update an existing application
    public async Task UpdateApplicationAsync(StudentApplication application)
    {
        var response = await _http.PutAsJsonAsync($"studentapplication/{application.Id}", application);
        response.EnsureSuccessStatusCode();
    }
}