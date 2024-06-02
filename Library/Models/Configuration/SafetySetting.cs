using Library.Models.Enum;

namespace Library.Models.Parameters;

public sealed class SafetySetting
{
    public Category Category { get; set; }
    public HarmThreshold Threshold { get; set; }
}

//stop_sequences: Sequências de texto que, se geradas, interrompem a resposta.
//safety_settings: Opções para filtrar conteúdo impróprio ou prejudicial.