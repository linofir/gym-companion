namespace GymCompanion.Modules;

class Exercicios
{
    private List<Exercicio> listaExercicios = new();

    public Exercicios(string nome)
    {
        Nome = nome;
    }
    public int Quantidade { get => listaExercicios.Count; }

    public string? Nome { get; set; }

    public void AddExercicio(Exercicio exercicioSelecionado)
    {
        if(listaExercicios.Contains(exercicioSelecionado))
        {
            Console.Write($"Esse exercício já está na lista: {exercicioSelecionado!.Nome}");
        }else
        {
            listaExercicios.Add(exercicioSelecionado);
            //Console.WriteLine($"{exercicioSelecionado!.Nome} foi adicionado\n");
        }

        
    }

    public void ExibirExercicios()
    {
        int counter = 0;
        Console.WriteLine($"Os Exercicios({Quantidade}) da Lista {Nome}: ");
        foreach (var exercicio in listaExercicios)
        {
            counter += 1;
            Console.WriteLine($"Exercício {counter}: {exercicio.DescricaoImg}");
            
        }
    }

    public void RemoveExercicio(Exercicio exercicioSelecionado)
    {
        if(listaExercicios.Contains(exercicioSelecionado))
        {
            listaExercicios.Remove(exercicioSelecionado);
            Console.WriteLine($"{exercicioSelecionado!.Nome} foi removido\n");
        }else
        {
            Console.WriteLine("Esse exercício não está cadastrado, Exercícios cadastrados:");
        }
        
    }

    public void AddImagesPath(List<string> imagesPath, Exercicio exercicio)
    {
        exercicio.Imagens = imagesPath;
    }
}