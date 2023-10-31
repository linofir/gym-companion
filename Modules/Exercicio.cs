using System.Text.Json;
using System.Text.Json.Serialization;

namespace GymCompanion.Modules;

class Exercicio
{

    public Guid Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("primaryMuscles")]
    public List<String>? GrupoMuscular { get; set; }

    [JsonPropertyName("secondaryMuscles")]
    public List<string>? GrupoMuscularSecundario { get; set; }

    [JsonPropertyName("level")]
    public string? Nivel { get; set; }

    [JsonPropertyName("force")]
    public string? Tipo { get; set; }

    [JsonPropertyName("mechanic")]
    public string? Mecanica { get; set; }

    [JsonPropertyName("strength")]
    public string? Categoria { get; set; }

    [JsonPropertyName("instructions")]
    public List<string>? Instrucao { get; set; }

    public List<string>? Imagens { get; set; }

    public string? Descricao 
    { 
        get
        {
            foreach (var musc in GrupoMuscular!)
            {
                return $"O {Nome} pertence ao grupo {musc}"; 
            }
            return $"O {Nome} pertence ao grupo (vazio)";

        }
    
    }

    public string? DescricaoImg 
    { 
        get
        {
            // foreach (var img in Imagens!)
            // {
            //     return $"O {Nome} tem as imagens: {img}"; 
            // }
            return $"O {Nome} tem as imagens:\n {Imagens![0]}\n {Imagens[1]} ";

        }
    
    }

    
}