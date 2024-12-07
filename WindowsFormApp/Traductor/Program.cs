using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string subscriptionKey = "TU_CLAVE_DE_AZURE"; // Reemplaza con tu clave
        string endpoint = "https://api.cognitive.microsofttranslator.com/";
        string region = "TU_REGION"; // Por ejemplo, "westus"

        Console.WriteLine("Ingresa el texto en español para traducir:");
        string textoOriginal = Console.ReadLine();

        string textoIngles = await TraducirTexto(textoOriginal, "es", "en", subscriptionKey, endpoint, region);
        string textoFrances = await TraducirTexto(textoOriginal, "es", "fr", subscriptionKey, endpoint, region);

        Console.WriteLine($"\nTraducción en inglés: {textoIngles}");
        Console.WriteLine($"Traducción en francés: {textoFrances}");
    }

    static async Task<string> TraducirTexto(string texto, string idiomaOrigen, string idiomaDestino, string subscriptionKey, string endpoint, string region)
    {
        using (HttpClient client = new HttpClient())
        {
            string ruta = $"{endpoint}translate?api-version=3.0&from={idiomaOrigen}&to={idiomaDestino}";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Region", region);

            var cuerpoSolicitud = new object[] { new { Text = texto } };
            string contenidoJson = JsonSerializer.Serialize(cuerpoSolicitud);
            StringContent contenido = new StringContent(contenidoJson, Encoding.UTF8, "application/json");

            HttpResponseMessage respuesta = await client.PostAsync(ruta, contenido);
            string respuestaContenido = await respuesta.Content.ReadAsStringAsync();

            if (respuesta.IsSuccessStatusCode)
            {
                var resultado = JsonSerializer.Deserialize<JsonElement>(respuestaContenido);
                string traduccion = resultado[0].GetProperty("translations")[0].GetProperty("text").GetString();
                return traduccion;
            }
            else
            {
                Console.WriteLine($"Error en la traducción: {respuestaContenido}");
                return string.Empty;
            }
        }
    }
}
