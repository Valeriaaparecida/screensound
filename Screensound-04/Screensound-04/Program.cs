using Screensound_04.Models;

using (HttpClient client = new HttpClient())

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = System.Text.Json.JsonSerializer.Deserialize<List<Musica>>(resposta);
       
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }