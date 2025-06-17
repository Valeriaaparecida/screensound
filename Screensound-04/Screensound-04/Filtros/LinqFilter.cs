
using Screensound_04.Models;



namespace Screensound_04.Filtros;

internal class LinqFilter
{
    public static void  FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();
        Console.WriteLine("Gêneros musicais disponíveis:");
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
