using System.Text.Json;
using System.Text.Json.Serialization;

namespace GymCompanion.Modules;

class Exercicio
{

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("grupoMuscular")]
    public List<String>? GrupoMuscular { get; set; }

    [JsonPropertyName("grupoMuscularSecundario")]
    public List<string>? GrupoMuscularSecundario{ get; set; }

    [JsonPropertyName("nivel")]
    public string? Nivel { get; set; }

    [JsonPropertyName("tipo")]
    public string? Tipo { get; set; }

    [JsonPropertyName("mecanica")]
    public string? Mecanica { get; set; }

    [JsonPropertyName("categoria")]
    public string? Categoria { get; set; }

    [JsonPropertyName("equipamento")]
    public string? Equipamento { get; set; }


    [JsonPropertyName("instrucoes")]
    public List<string>? Instrucao { get; set; }

    public List<string>? Imagens { get; set; }

    public string? Descricao
    {
        get
        {
            List<string> grupoMuscularDescricao = new();
            List<string> grupoSecundarioDescricao = new();
            List<string> imagensDescricao = new();
            List<string> instrucaoDescricao = new();
            if(GrupoMuscular != null)
            {
                grupoMuscularDescricao = GrupoMuscular!.Where(valor => valor != null).ToList();
            }else grupoMuscularDescricao.Add("sem valor");

            if(GrupoMuscularSecundario != null)
            {
                grupoSecundarioDescricao = GrupoMuscularSecundario!.Where(valor => valor != null).ToList();
            }else grupoSecundarioDescricao.Add("sem valor");

            if(Imagens != null)
            {
                imagensDescricao = Imagens!.Where(valor => valor != null).ToList();
            }else imagensDescricao.Add("sem valor");

            if(Instrucao != null)
            {
                instrucaoDescricao = Instrucao!.Where(valor => valor != null).ToList();
            }else instrucaoDescricao.Add("sem valor");
            
            string resposta = $@" 
            id = {Id}
            nome = {Nome}
            grupoMuscular = {string.Join(", ", grupoMuscularDescricao!)}
            grupoMuscularSecundario = {string.Join(", ", grupoSecundarioDescricao!)}
            nivel = {Nivel}
            tipo = {Tipo}
            mecanica = {Mecanica}
            categoria = {Categoria}
            equipamento = {Equipamento}
            instrucoes = {string.Join("\n", instrucaoDescricao!)}
            imagens =  {string.Join(" ,\n ", imagensDescricao!)}
            ";
            return resposta;
        }
    }

    public string PrintDescricao()
    {
        string resposta = $@" 
            id ={Id},/n
            nome = {Nome},/n
            grupoMuscular = {GrupoMuscular},/n
            grupoMuscularSecundario = {GrupoMuscularSecundario},/n
            nivel = {Nivel},/n
            tipo = {Tipo},/n
            mecanica = {Mecanica},/n
            categoria = {Categoria},/n
            equipamento = {Equipamento},/n
            instrucoes = {Instrucao},/n
            imagens =  {Imagens};
        ";
    
        return resposta;
    }
   


    
}