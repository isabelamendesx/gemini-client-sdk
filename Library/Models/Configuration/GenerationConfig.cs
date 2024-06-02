namespace Library.Models.Parameters;

// TO DO: Adicionar validações e analisar transformar em value objects
public sealed class GenerationConfig
{
    public List<string> StopSequences { get; set; } = [];
    public int? CandidateCount { get; set; } = 1;
    public int? MaxOutputTokens { get; set; } 
    public float? Temperature { get; set; } // 0,0 - 2,0
    public int? TopK { get; set; }
    public int? TopP { get; set; }
}

//candidate_count: Número de respostas alternativas a serem geradas(útil para comparar opções).
//max_output_tokens: Limite máximo de "palavras" (tokens) na resposta(controla o tamanho).
//temperature: Grau de criatividade/aleatoriedade na resposta(valores mais altos = mais criativo).
//top_p: Alternativa ao temperature para controlar a criatividade, mas de forma mais precisa.
//top_k: Limita as escolhas do modelo às k palavras mais prováveis(afeta a diversidade). 1 = maior probabidade de acerto
//Outros parâmetros:

