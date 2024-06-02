using Library.Models.Parameters;

namespace Library.Builders;

public class GenerationConfigBuilder
{
    private readonly GenerationConfig _generationConfig = new GenerationConfig();

    public GenerationConfigBuilder WithStopSequences(params string[] stopSequences)
    {
        _generationConfig.StopSequences.AddRange(stopSequences);
        return this;
    }

    public GenerationConfigBuilder WithCandidateCount(int candidateCount)
    {
        _generationConfig.CandidateCount = candidateCount;
        return this;
    }

    public GenerationConfigBuilder WithMaxOutputTokens(int maxOutputTokens)
    {
        _generationConfig.MaxOutputTokens = maxOutputTokens;
        return this;
    }

    public GenerationConfigBuilder WithTemperature(float temperature)
    {
        _generationConfig.Temperature = temperature;
        return this;
    }

    public GenerationConfigBuilder WithTopK(int topK)
    {
        _generationConfig.TopK = topK;
        return this;
    }

    public GenerationConfigBuilder WithTopP(int topP)
    {
        _generationConfig.TopP = topP;
        return this;
    }

    public GenerationConfig Build()
    {
        return _generationConfig;
    }
}
