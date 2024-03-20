using GymCompanion.Modules;
namespace GymCompanion.DataBase;

public enum Musculos
{
    abdominals,
    hamstrings,
    adductors,
    quadriceps,
    biceps,
    shoulders,
    chest,
    middleback,
    calves,
    glutes,
    lowerback,
    lats,
    triceps,
    traps,
    forearms,
    neck,
    abductors,
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
    private List<string> FiltrosString = new()
    {
        "Id",
        "Nome",
        "GrupoMuscular",
        "Nivel",
        "Mecanica",
        "Categoria",
        "Tipo",
        "Equipamento"
       
    };
    public static void FilterBy(Exercicios listaConsulta, Filtros filtroSelecionado, string value)
    {
        // int filtroIndex = (int)filtroSelecionado;
        // string filtro = FiltrosString[filtroIndex];
        switch(filtroSelecionado)
        {
            case Filtros.Id:
            Console.WriteLine(value);
            FilterByID(listaConsulta, value);
            break;
            case Filtros.Nome:
            Console.WriteLine(value);
            FilterByName(listaConsulta, value);
            break;
            case Filtros.GrupoMuscular:
            Console.WriteLine(value);
            //FilterByGrupoMuscular(listaConsulta, value)
            break;
            case Filtros.Nivel:
            Console.WriteLine(value);
            FilterByNivel(listaConsulta, value);
            break;
            case Filtros.Mecanica:
            Console.WriteLine(value);
            break;
            case Filtros.Categoria:
            Console.WriteLine(value);
            FilterByCategoria(listaConsulta, value);
            break;
            case Filtros.Tipo:
            Console.WriteLine(value);
            break;
            case Filtros.Equipamento:
            Console.WriteLine(value);
            FilterByGrupoEquip(listaConsulta, value);
            break;

        }   

        // var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.Nome!.Contains(value)).ToList();
        // if(exerciciosEncontrados != null)
        // {
        //     Console.WriteLine($"Foi encontrado {exerciciosEncontrados.Count} exercício(s): \n");
        //     int counter = 0;
        //     foreach (var exercicio in exerciciosEncontrados)
        //     {
        //         counter += 1;
        //         Console.WriteLine($"Exercício {counter}: \n{exercicio.Descricao}");
        //     }
        // }else Console.WriteLine("Nenhum Exercício encontrado");
        
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
        var exerciciosEncontrados = listaConsulta.listaExercicios.Where(ex => ex.GrupoMuscular!.Contains(musculo.ToString())).ToList();
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
                Console.WriteLine($"{musculo},");
            }
        }else Console.WriteLine("Nenhum Exercício encontrado");
    }


}