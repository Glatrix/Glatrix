using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class Function : IHttpFunction
{
    private readonly ILogger _logger;

    public Function(ILogger<Function> logger) =>
        _logger = logger;

    public async Task HandleAsync(HttpContext context)
    {
        HttpRequest request = context.Request;

        string body = "";
        using (StreamReader stream = new StreamReader(context.Request.Body))
        {
            body = await stream.ReadToEndAsync();
        }

        _logger.LogInformation(body);
        
    }
}