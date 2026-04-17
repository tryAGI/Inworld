#nullable enable

namespace Inworld;

public partial class InworldClient
{
    // Inworld uses HTTP Basic auth with a Base64-encoded API key issued by the
    // Portal. The generated code emits "Authorization: Bearer <key>", but
    // Inworld expects "Authorization: Basic <key>". Rewrite the scheme name
    // from "Bearer" to "Basic" at request time.
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Name: "Bearer" })
            {
                Authorizations[i] = new EndPointAuthorization
                {
                    Type = auth.Type,
                    Location = auth.Location,
                    Name = "Basic",
                    Value = auth.Value,
                };
            }
        }
    }
}
