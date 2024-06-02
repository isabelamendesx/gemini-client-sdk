using Library.Models.Enum;
using Library.Models.Parameters;

namespace Library.Builders;

public class SafetySettingsBuilder
{
    private readonly List<SafetySetting> _safetySettings = [];

    public SafetySettingsBuilder AddSafetySetting(Category category, HarmThreshold threshold)
    {
        var safetySetting = new SafetySetting
        {
            Category = category,
            Threshold = threshold,
        };
        _safetySettings.Add(safetySetting);
        return this;
    }

    public SafetySettingsBuilder AddSafetySetting(SafetySetting safetySetting)
    {
        _safetySettings.Add(safetySetting);
        return this;
    }

    public IEnumerable<SafetySetting> Build()
    {
        return _safetySettings;
    }
}
