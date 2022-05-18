namespace VerifyTests;

public static class VerifyNSubstitute
{
    public static void Enable() =>
        VerifierSettings
            .AddExtraSettings(serializerSettings =>
            {
                var converters = serializerSettings.Converters;
                converters.Add(new CallConverter());
            });
}