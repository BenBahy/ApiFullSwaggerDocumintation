using ApiFullSwaggerDocumintation.OpenApi;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace ApiFullSwaggerDocumintation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            // Enables annotation support
            options.EnableAnnotations();

            // Enables example filters for request/response            
            options.ExampleFilters();    
            
            // Configure Enum Descriptions
            options.SchemaFilter<EnumSchemaFilter>();

            // Add metadata information
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "API Full Swagger Documentation",
                Version = "v1",
                Description = "A detailed Swagger documentation for API, including DTOs and enums.",
                Contact = new OpenApiContact
                {
                    Name = "Ahmed Alameer",
                    Email = "ben.bahy@gmail.com", // Replace with your actual email
                    Url = new Uri("https://www.linkedin.com/in/benbahy/") // Replace with your actual URL
                }
            });
        });

        // Registers the examples
        builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>(); 

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
