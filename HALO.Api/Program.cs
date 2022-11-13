using HALO.Api.Models;
using HALO.Api.Contexts;
using HALO.Api.Services;
using HALO.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
builder.Services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
IConfigurationSection appSettingsSection = configuration.GetSection("AppSettings");
AppSettings appSettings = appSettingsSection.Get<AppSettings>();
var dbConnectionString = configuration.GetConnectionString("DEV");

switch(environment.EnvironmentName)
{
    case "DEV":
        break;

    case "QA":
        appSettings.Audience = appSettings.AudienceQA;
        dbConnectionString = configuration.GetConnectionString("QA");
        break;

    case "UAT":
        appSettings.Audience = appSettings.AudienceUAT;
        dbConnectionString = configuration.GetConnectionString("UAT");
        break;

    default:
        appSettings.Audience = appSettings.AudienceProd;
        dbConnectionString = configuration.GetConnectionString("Prod");
        break;
}

builder.Services.AddScoped<IMetadataService, MetadataService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IInteractionService, InteractionService>();
builder.Services.AddScoped<IHapscaseService, HapscaseService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICarescaseService, CarescaseService>();
builder.Services.AddScoped<IOutreachService, OutreachService>();

builder.Services.AddDbContext<HALOdB>(options => options.UseSqlServer(      
    dbConnectionString,
    // This ill setup  Maximum Retry count to be 10,
    // Maximum Delay per each retry to 30 seconds, and additional 
    // SQLerror number that should be considered transient to be NULL.
    providerOptions => providerOptions.EnableRetryOnFailure(
            maxRetryCount: 10,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null
        )
    ));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddResponseCaching();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json", "HALO API V1"));
}

app.UseHttpsRedirection();
app.UseResponseCaching();
app.UseAuthorization();
app.MapControllers();
app.Run();
