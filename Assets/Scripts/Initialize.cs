using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize
{
    [RuntimeInitializeOnLoadMethod]
    public static void InitializeOnLoad()
    {
        Application.targetFrameRate = 15;
    }
}
