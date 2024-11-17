using Swashbuckle.AspNetCore.Filters;

namespace ApiFullSwaggerDocumintation.OpenApi.Examples;

public class BadRequestResponseExample : IMultipleExamplesProvider<BadRequestResponse>
{
    public IEnumerable<SwaggerExample<BadRequestResponse>> GetExamples()
    {
        yield
            return SwaggerExample.Create("InvalidIndex", BadRequestResponse.InvalidIndex);
        yield
            return SwaggerExample.Create("InvalidRequestPayload", BadRequestResponse.InvalidRequestPayload);
    }
}