using GymCompanion.Modules;
namespace GymCompanion.DataBase;

internal class Filter
{
    //nome, id, grupo muscular, nivel, categoria
    public static void FilterByName(Exercicios listaConsulta, string nome)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Nome!.Contains(nome)).ToList();
        if(exerciciosEncontrados != null)
        {
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;
                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        
    }

    public static void FilterByID(Exercicios listaConsulta, string id)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Id!.Contains(id)).ToList();
        if(exerciciosEncontrados != null)
        {
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;
                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        
    }

    public static void FilterByNivel(Exercicios listaConsulta, string nivel)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Nivel!.Contains(nivel)).ToList();
        if(exerciciosEncontrados != null)
        {
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        
    }

    public static void FilterByCategoria(Exercicios listaConsulta, string categoria)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Categoria!.Contains(categoria)).ToList();
        if(exerciciosEncontrados != null)
        {
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
    }

    public static void FilterByGrupoMuscular(Exercicios listaConsulta, string grupoMuscular)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.GrupoMuscular!.Contains(grupoMuscular)).ToList();
        if(exerciciosEncontrados != null)
        {
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
    }

    public static void ExibirGruposMusculares(Exercicios listaConsulta)
    {
        var musculosEncontrados = listaConsulta.listaExercicios.SelectMany(ex => ex.GrupoMuscular!).Distinct().ToList();
        if(musculosEncontrados != null)
        {
            Console.WriteLine($"Foi encontrado {musculosEncontrados.Count} Grupos Musculares(s): \n");
            int counter = 0;
            foreach (var musculo in musculosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"-{musculo}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
    }


}