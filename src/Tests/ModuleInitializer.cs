public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyNSubstitute.Enable();

        #endregion

        VerifyDiffPlex.Initialize();
    }
}