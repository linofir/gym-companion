using GymCompanion.Modules;
namespace GymCompanion.DataBase;

public enum Musculos
{
    Null = 0,
    Abdominals,
    Hamstrings,
    Adductors,
    Quadriceps,
    Biceps,
    Shoulders,
    Chest,
    MiddleBack,
    Calves,
    Glutes,
    LowerBack,
    Lats,
    Triceps,
    Traps,
    Forearms,
    Neck,
    Abductors
}

public enum Filtros
{
    Id,
    Nome,
    GrupoMuscular,
    Nivel,
    Mecanica,
    Categoria,
    Tipo,
    Equipamento
}
internal class Filter
{
    public List<string> MuscString = new()
    {
        "",
        "Abdominals",
        "Hamstrings",
        "Adductors",
        "Quadriceps",
        "Biceps",
        "Shoulders",
        "Chest",
        "MiddleBack",
        "Calves",
        "Glutes",
        "LowerBack",
        "Lats",
        "Triceps",
        "Traps",
        "Forearms",
        "Neck",
        "Abductors",
    };
    public static void FilterBy(Exercicios listaConsulta, string nome)
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

    public static Exercicios FilterByNivel(Exercicios listaConsulta, string nivel)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Nivel!.Contains(nivel)).ToList();
        Exercicios listaFiltrada = new("listaFiltrada");
        if(exerciciosEncontrados != null)
        {
            listaFiltrada.listaExercicios = exerciciosEncontrados!;
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        return listaFiltrada;
        
    }

    public static Exercicios FilterByCategoria(Exercicios listaConsulta, string categoria)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Categoria!.Contains(categoria)).ToList();
        Exercicios listaFiltrada = new("listaFiltrada");
        if(exerciciosEncontrados != null)
        {
            listaFiltrada.listaExercicios = exerciciosEncontrados!;
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        return listaFiltrada;
    }

    public static Exercicios FilterByGrupoMuscular(Exercicios listaConsulta, Musculos musculo)
    {
        string grupoMuscular = musculo.ToString();
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.GrupoMuscular!.Contains(grupoMuscular)).ToList();
        Exercicios listaFiltrada = new("listaFiltrada");
        if(exerciciosEncontrados != null)
        {
            listaFiltrada.listaExercicios = exerciciosEncontrados!;
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
                Console.WriteLine(musculo.ToString().GetType());
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        return listaFiltrada!;
    }

    public static Exercicios FilterByGrupoEquip(Exercicios listaConsulta, string equipamento)
    {
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Equipamento! == null || ex.Equipamento!.Contains(equipamento)).ToList();
        Exercicios listaFiltrada = new("listaFiltrada");
        if(exerciciosEncontrados != null)
        {
            listaFiltrada.listaExercicios = exerciciosEncontrados!;
            Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
            int counter = 0;
            foreach (var exercicio in exerciciosEncontrados)
            {
                counter += 1;

                Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
        return listaFiltrada!;
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
                string musculoUpper = char.ToUpper(musculo[0]) + musculo.Substring(1);
                Console.WriteLine($"{musculoUpper},");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
    }


}