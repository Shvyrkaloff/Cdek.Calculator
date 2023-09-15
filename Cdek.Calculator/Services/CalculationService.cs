using Cdek.Application.Entities;
using System.Net.Http.Headers;

namespace Cdek.Calculator.Services;

public interface ICalculationService
{
    Task<HttpResponseMessage> CalculationByTariffCode(CalculationByTariffCodeRequest request);
}

public class CalculationService : ICalculationService
{
    private readonly HttpClient? _httpClient;

    private readonly ITokenStorage? _tokenStorage;

    public CalculationService(IHttpClientFactory? clientFactory, ITokenStorage? tokenStorage)
    {
        _tokenStorage = tokenStorage;
        _httpClient = clientFactory?.CreateClient("API");
    }

    public virtual async Task<HttpResponseMessage> CalculationByTariffCode(CalculationByTariffCodeRequest request)
    {
        if (_httpClient != null)
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _tokenStorage?.token);

        var result = await _httpClient?.PostAsJsonAsync($"calculator/tariff", request)!;
        return result;
    }
}