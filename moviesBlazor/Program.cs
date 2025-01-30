using moviesBlazor.Components;
using System.Net.Http;
using moviesBlazor.BlazorModels;

namespace moviesBlazor 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddBlazorBootstrap();
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            // ????? ?-UserService ?-Singleton
            builder.Services.AddSingleton<UserService>();

            
            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Register HttpClient for server-side Blazor
            builder.Services.AddHttpClient();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
