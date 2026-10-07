using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var urls = new ConcurrentDictionary<string, string>();

const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
var random = new Random();

string GerarCodigo(int tamanho = 6)
{
    return new string(Enumerable.Range(0, tamanho)
        .Select(_ => chars[random.Next(chars.Length)])
        .ToArray());
}

app.MapPost("/encurtar", (EncurtarRequest request, HttpRequest httpRequest) =>
{
    if (string.IsNullOrWhiteSpace(request.Url) || !Uri.TryCreate(request.Url, UriKind.Absolute, out _))
    {
        return Results.BadRequest(new { erro = "URL inválida." });
    }
    
    string codigo;
    do
    {
        codigo = GerarCodigo();
    } while (urls.ContainsKey(codigo));

    urls[codigo] = request.Url;

    var baseUrl = $"{httpRequest.Scheme}://{httpRequest.Host}";
    var urlEncurtada = $"{baseUrl}/{codigo}";

    return Results.Ok(new { urlOriginal = request.Url, urlEncurtada, codigo });
});

app.MapGet("/{codigo}", (string codigo) =>
{
    if (urls.TryGetValue(codigo, out var urlOriginal))
    {
        return Results.Redirect(urlOriginal);
    }

    return Results.NotFound(new { erro = "Código não encontrado." });
});

app.MapGet("/listar", () => Results.Ok(urls));

app.Run();

record EncurtarRequest(string Url);