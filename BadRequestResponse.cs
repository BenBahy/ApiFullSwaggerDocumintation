using Swashbuckle.AspNetCore.Annotations;

namespace ApiFullSwaggerDocumintation;

[SwaggerSchema("Bad request response.")]
public class BadRequestResponse
{
    [SwaggerSchema("Bad request response message.")]
    public string Message { get; set; }

    public BadRequestResponse(string message)
    {
        Message = message;
    }

    internal static readonly BadRequestResponse InvalidIndex = new BadRequestResponse("Invalid index.");
    internal static readonly BadRequestResponse InvalidRequestPayload = new BadRequestResponse("Invalid request payload.");
}
