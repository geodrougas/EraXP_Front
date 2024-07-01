using System.Net;
using EraXp.Frontend.Config;
using EraXp.Frontend.Controller;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EraXp.Frontend.Views;
using Microsoft.AspNetCore.Components;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient(new DefaultClientHandler(sp.GetService<NavigationManager>()!)) { BaseAddress = new Uri("http://localhost:5231/api/v1/") });
builder.Services.AddSingleton<UserController>();
builder.Services.AddMudServices();

await builder.Build().RunAsync();