namespace Cdek.Calculator.Services
{
    public interface ICdekAuthorization
    {
        Task<string> GetAccessToken();
    }

    public class CdekAuthorization : ICdekAuthorization
    {
        private const string TokenUrl = "https://api.edu.cdek.ru/v2/oauth/token";
        private const string Account = "EMscd6r9JnFiQ3bLoyjJY6eM78JrJceI";
        private const string SecurePassword = "PjLZkKBHEiLK3YsjtNrt3TGNG0ahs3kG";

        public async Task<string> GetAccessToken()
        {
            using (var httpClient = new HttpClient())
            {
                var parameters = new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", Account },
                    { "client_secret", SecurePassword }
                };

                var response = await httpClient.PostAsync(TokenUrl, new FormUrlEncodedContent(parameters));
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var accessToken = Newtonsoft.Json.JsonConvert.DeserializeObject<AccessTokenResponse>(responseContent)?.access_token;

                return accessToken;
            }
        }

        private class AccessTokenResponse
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string scope { get; set; }
            public string jti { get; set; }
        }
    }
}
