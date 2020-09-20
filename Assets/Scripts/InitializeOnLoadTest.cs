using UnityEngine;

public static class InitializeOnLoadTest
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    public static void SubsystemRegistration()
    {
        Log(nameof(SubsystemRegistration));
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
    public static void AfterAssembliesLoaded()
    {
        Log(nameof(AfterAssembliesLoaded));
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    public static void BeforeSplashScreen()
    {
        Log(nameof(BeforeSplashScreen));
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void BeforeSceneLoad()
    {
        Log(nameof(BeforeSceneLoad));
    }


    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void AfterSceneLoad()
    {
        Log(nameof(AfterSceneLoad));
    }

    public static void Log(string functionName)
    {
        Debug.Log($"RuntimeInitialize: {functionName}");
    }
}
