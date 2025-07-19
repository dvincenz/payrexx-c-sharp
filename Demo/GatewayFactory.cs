using System.Net;
using System.Text.Json;

namespace Demo;

public class GatewayFactory(string instance, string apiKey)
{
    public async Task<string> CreateGatewayAsync(CreateGatewayRequest gatewayRequest)
    {
        var requestUri = new Uri("https://api.payrexx.com/v1.0/Gateway/?instance=" + instance);

        var payload = JsonSerializer.Serialize(gatewayRequest, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        });


        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
        var content = new StringContent(payload, System.Text.Encoding.UTF8, "application/json");
        var response = await client.PostAsync(requestUri, content);

        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content.ReadAsStringAsync().Result;
            var payrexxResponseGateway =
                JsonSerializer.Deserialize<CreateGatewayResponse>( responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true } );
            if (payrexxResponseGateway?.Status == "success")
                return payrexxResponseGateway.Data.FirstOrDefault()?.Link ??
                       throw new InvalidOperationException("Failed to retrieve gateway link from response.");
        }

        throw new HttpRequestException($"Failed to create gateway. HTTP Status: {(int)response.StatusCode} {response.ReasonPhrase}");
    }

}