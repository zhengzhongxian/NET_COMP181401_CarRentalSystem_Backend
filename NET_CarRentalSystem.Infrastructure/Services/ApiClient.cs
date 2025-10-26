using System.Text;
using NET_CarRentalSystem.Infrastructure.Interfaces;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class ApiClient(HttpClient httpClient) : IApiClient
{

    public async Task<T?> GetAsync<T>(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
        AddHeaders(request, headers);

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<T>();
    }

    public async Task<string> GetStringAsync(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
        AddHeaders(request, headers);

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
        AddHeaders(request, headers);

        var json = data.ToJson();
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<TResponse>();
    }

    public async Task<T?> PostFormDataAsync<T>(string endpoint, Dictionary<string, object> formData, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post,
            endpoint);
        AddHeaders(request,
            headers);

        var formContent = new FormUrlEncodedContent(
            formData.ToDictionary(kvp => kvp.Key,
                kvp => kvp.Value.ToString() ?? string.Empty));
        request.Content = formContent;

        using var response = await httpClient.SendAsync(request,
            cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<T>();
    }

    public async Task<T?> PostMultipartAsync<T>(string endpoint, MultipartFormDataContent content, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
        AddHeaders(request, headers);
        request.Content = content;

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
        return responseContent.FromJson<T>();
    }

    public async Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Put, endpoint);
        AddHeaders(request, headers);

        var json = data.ToJson();
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<TResponse>();
    }

    public async Task<T?> PutFormDataAsync<T>(string endpoint, Dictionary<string, object> formData, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Put, endpoint);
        AddHeaders(request, headers);

        var formContent = new FormUrlEncodedContent(
            formData.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.ToString() ?? string.Empty));
        request.Content = formContent;

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<T>();
    }

    public async Task<T?> PutMultipartAsync<T>(string endpoint, MultipartFormDataContent content, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Put, endpoint);
        AddHeaders(request, headers);
        request.Content = content;

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
        return responseContent.FromJson<T>();
    }

    public async Task<TResponse?> PatchAsync<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Patch, endpoint);
        AddHeaders(request, headers);

        var json = data.ToJson();
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<TResponse>();
    }

    public async Task<bool> DeleteAsync(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Delete, endpoint);
        AddHeaders(request, headers);

        using var response = await httpClient.SendAsync(request, cancellationToken);
        return response.IsSuccessStatusCode;
    }

    public async Task<T?> DeleteAsync<T>(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(HttpMethod.Delete, endpoint);
        AddHeaders(request, headers);

        using var response = await httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return content.FromJson<T>();
    }

    private static void AddHeaders(HttpRequestMessage request, Dictionary<string, string>? headers)
    {
        if (headers == null) return;

        foreach (var header in headers)
        {
            request.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }
    }
}
