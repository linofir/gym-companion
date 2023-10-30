namespace GymCompanion.Modules;

class Serie 
{

    public Serie(int quantidade, int repeticoes, string descanco = "normal")
    {
        Quantidade = quantidade;
        Repeticoes = repeticoes;
        Descanso = descanco;
    }
    public int Quantidade { get; set; }
    public int Repeticoes { get; set; }
    public string? Descanso { get; set; }
    public int DescansoTempo 
    { 
        get
        {
            if(Descanso == "normal")
            {
                return 90;
            }else{
                return 30;
            }
        }
    }
      
    public string? Estrategia { get; set; }

    public string Descricao { get => $"Series: {Quantidade}\n Repetições: {Repeticoes} \n Descanso: {Descanso}\n Tempo de descaso: {DescansoTempo}\n"; }

}