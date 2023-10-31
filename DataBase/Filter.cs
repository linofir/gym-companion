using GymCompanion.Modules;

namespace GymCompanion.DataBase;

internal class Filter
{
    public static void FilterByCategory(List<Exercicio> lista)
    {
        var categoryList = lista.Select(ex => ex.Categoria ).Distinct().ToList();

        foreach(var exercise in categoryList)
        {
            Console.WriteLine($"Nome: {exercise}");
        }
    }
}