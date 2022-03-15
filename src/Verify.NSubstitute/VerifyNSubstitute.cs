namespace VerifyTests;

public static class VerifyNSubstitute
{
    public static void Enable() =>
        VerifierSettings.ModifySerialization(settings =>
        {
            settings.AddExtraSettings(serializerSettings =>
            {
                var converters = serializerSettings.Converters;
                converters.Add(new CallConverter());
            });
        });
}