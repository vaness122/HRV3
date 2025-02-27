using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class Client 
{
    private readonly HttpClient _httpClient;

    // Constructor to initialize the HttpClient
    public Client()
    {
        // You can configure the HttpClient here if needed (e.g., timeouts, headers)
        _httpClient = new HttpClient();
    }

    // Method to send a GET request
    public async Task<string> GetAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throws exception if not successful
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            // Handle exceptions (like network errors)
            return $"Error: {ex.Message}";
        }
    }

    // Method to send a POST request
    public async Task<string> PostAsync(string url, string jsonData)
    {
        try
        {
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode(); // Throws exception if not successful
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            // Handle exceptions (like network errors)
            return $"Error: {ex.Message}";
        }
    }

    // Method to send a PUT request
    public async Task<string> PutAsync(string url, string jsonData)
    {
        try
        {
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync(url, content);
            response.EnsureSuccessStatusCode(); // Throws exception if not successful
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            // Handle exceptions (like network errors)
            return $"Error: {ex.Message}";
        }
    }

    // Method to send a DELETE request
    public async Task<string> DeleteAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode(); // Throws exception if not successful
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            // Handle exceptions (like network errors)
            return $"Error: {ex.Message}";
        }
    }

    // Dispose of the HttpClient when done
    public void Dispose()
    {
        _httpClient.Dispose();
    }

    internal static async Task<HttpResponseMessage> PostAsync(string v, StringContent content)
    {
        throw new NotImplementedException();
    }
}
