public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init() =>
        VerifyNSubstitute.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}