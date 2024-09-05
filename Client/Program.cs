using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyFirstBlazor.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

public class Person
{
 public Person(string firstName, string lastName)
 {
 FirstName = firstName;
 LastName = lastName;
 }
 public string? FirstName { get; set; } = string.Empty;
 public string? LastName { get; set; } = string.Empty;
}