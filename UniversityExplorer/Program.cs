using UniversityExplorer.Components;
using UniversityExplorer.Services;
using UniversityExplorer.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<CountryService>(client =>
    client.BaseAddress = new Uri("https://countries.dev/"));

builder.Services.AddHttpClient<UniversityService>(client =>
    client.BaseAddress = new Uri("http://universities.hipolabs.com/"));

builder.Services.AddHttpClient<StudentApplicationService>(client =>
    client.BaseAddress = new Uri("https://edutots.net/api/"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
