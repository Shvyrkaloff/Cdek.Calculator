using Cdek.Application.Entities;
using Cdek.Calculator.Services;

namespace Cdek.Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAntDesign();
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddScoped<ICalculationService, CalculationService>();
        builder.Services.AddScoped<ICdekAuthorization, CdekAuthorization>();
        builder.Services.AddSingleton<ITokenStorage, TokenStorage>();

        builder.Services.AddHttpClient("API", client =>
        {
            client.BaseAddress = new Uri("https://api.edu.cdek.ru/v2/");
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}