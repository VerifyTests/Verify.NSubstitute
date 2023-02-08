namespace VerifyTests;

public static class VerifyNSubstitute
{
    public static bool Initialized { get; private set; }

    [Obsolete("Use Initialize()")]
    public static void Enable() =>
        Initialize();

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();
        VerifierSettings
            .AddExtraSettings(serializerSettings =>
            {
                var converters = serializerSettings.Converters;
                converters.Add(new CallConverter());
            });
    }
}