using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ApiFullSwaggerDocumintation.OpenApi;

public class EnumSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type.IsEnum)
        {
            schema.Enum.Clear(); // Clear existing enum values if any
            var enumDescriptions = Enum.GetValues(context.Type)
                .Cast<object>()
                .Select(e => new OpenApiString($"{e} = {(int)e}")); // Convert enum values to OpenApiString

            foreach (var enumDescription in enumDescriptions)
            {
                schema.Enum.Add(enumDescription); // Add each value individually
            }
        }
    }
}