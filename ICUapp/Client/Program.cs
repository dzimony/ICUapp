using ICUapp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjI5ODc2QDMyMzAyZTMxMmUzMG5UNXVaN3huMlZHMnpCRHlPT1IrRjlTSDUxdlF1UXBqUkNyd24wQzJGQ1U9");
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
