using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DaprPoc.MicroService.FrontEnd;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        BaseAddress = new Uri("https://localhost:7050"),
        
    });

await builder.Build().RunAsync();
