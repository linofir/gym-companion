namespace GymCompanion.Modules;

class Exercicio
{
    public Exercicio(string nome, string grupoMuscular )
    {
        Nome = nome;
        GrupoMuscular = grupoMuscular;
    }
    public string? Nome { get; set; }
    public string? GrupoMuscular { get; set; }
    public string? Tipo { get; set; }
    public string? Descricao { get => $"O {Nome} pertence ao grupo {GrupoMuscular}"; }

    
}