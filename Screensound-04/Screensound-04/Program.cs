using Screensound_04.Models;
using Screensound_04.Filtros;

using (HttpClient client = new HttpClient())

    try
    {
        string resposta = await client.GetStringAsync("https://valeriaaparecida.github.io/screensound/songs.json");
        var musicas = System.Text.Json.JsonSerializer.Deserialize<List<Musica>>(resposta);


        LinqFilter.FiltrarMusicasDeUmArtistaEMCSharp(musicas);
        //musicas[0].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");


        //var musicasPreferidas = new MusicasPreferidaS("Guilherme");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1467]);
        //musicasPreferidas.ExibirMusicasFavoritas();


        //var musicasPreferidasVal = new MusicasPreferidaS("Val");
        //musicasPreferidasVal.AdicionarMusicasFavoritas(musicas[239]);
        //musicasPreferidasVal.AdicionarMusicasFavoritas(musicas[1737]);
        //musicasPreferidasVal.AdicionarMusicasFavoritas(musicas[43]);
        //musicasPreferidasVal.AdicionarMusicasFavoritas(musicas[541]);
        //musicasPreferidasVal.AdicionarMusicasFavoritas(musicas[1297]);
        //musicasPreferidasVal.ExibirMusicasFavoritas();
        //musicasPreferidasVal.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }