using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase_Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<UserSessionService>();

await builder.Build().RunAsync();

var host = builder.Build();
var sessionService = host.Services.GetRequiredService<UserSessionService>();
sessionService.Login("test@example.com"); // Test kullanıcısı giriş yaptı
await host.RunAsync();
