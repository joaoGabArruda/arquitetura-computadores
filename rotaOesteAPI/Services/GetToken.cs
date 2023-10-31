using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class GetAccessToken
{
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _redirectUri;
    private readonly string _code;

    public GetAccessToken(string clientid, string clientsecret, string redirect_uri, string code)
    {
        _clientId = clientid;
        _clientSecret = clientsecret;
        _redirectUri = redirect_uri;
        _code = code;
    }

    public async Task<string> ExecuteAsync()
    {
        using (var client = new HttpClient())
        {
            var tokenEndpoint = new Uri("https://signin.johndeere.com/oauth/auz/token");
            var authorizationHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authorizationHeader);

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("code", _code),
                new KeyValuePair<string, string>("redirect_uri", _redirectUri),
                new KeyValuePair<string, string>("client_id", _clientId)
            });

            var response = await client.PostAsync(tokenEndpoint, content);
            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }
    }
}