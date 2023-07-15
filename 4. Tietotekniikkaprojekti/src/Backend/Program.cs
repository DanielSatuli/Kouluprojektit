using Microsoft.EntityFrameworkCore;
using ItemApi.Data;
using System.Configuration;
using Microsoft.AspNetCore.Cors.Infrastructure;
using EmailService;

namespace ItemApi;

// DO NOT remove the Program class declaration or the Main method. These are needed for the tests.

// DO edit the content of Main method to handle the task requirements.
public class Program
{

    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.WebHost.UseStaticWebAssets();

        //Add allow all CORS policy to allow calls from clients
        builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
        {
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
            policy.AllowAnyOrigin();
        }));

        builder.Services.AddDbContext<ItemContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("ItemDb")));
        builder.Services.AddDbContext<HistoryContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("HistoryDb")));
        builder.Services.AddDbContext<EmailContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("EmailDb")));

        var emailConfig = builder.Configuration
        .GetSection("EmailConfiguration")
        .Get<EmailConfiguration>();
        builder.Services.AddSingleton(emailConfig);

        builder.Services.AddScoped<IEmailSender, EmailSender>();



        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                
            });
        }
        //seed the db
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;

            SeedData.Initialize(services);
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseCors();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}