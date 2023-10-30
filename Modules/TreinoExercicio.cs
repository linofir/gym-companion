namespace GymCompanion.Modules;

class TreinoExercicio
{
    public TreinoExercicio(Exercicio exercicio, Serie serie)
    {
        Exercicio = exercicio;
        SerieExercicio = serie;
    }
    public Exercicio? Exercicio { get; set; }
    public Serie? SerieExercicio { get; set; }
    public string Descricao { get => $"{Exercicio!.Descricao}, está definido dessa forma:\n {SerieExercicio!.Descricao}"; }

}