using Screensound_04.Models;
using Screensound_04.Filtros;

using (HttpClient client = new HttpClient())

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = System.Text.Json.JsonSerializer.Deserialize<List<Musica>>(resposta);
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }