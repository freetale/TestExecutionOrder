using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrderTest : MonoBehaviour
{
    public string Name = "A";
    protected virtual void Awake()
    {
        Log(nameof(Awake));
    }

    protected virtual void Start()
    {
        Log(nameof(Start));
    }

    protected virtual void OnDestroy()
    {
        Log(nameof(OnDestroy));
    }

    protected virtual void Update()
    {
        Log(nameof(Update));
    }
    protected virtual void FixedUpdate()
    {
        Log(nameof(FixedUpdate));
    }

    protected virtual void LateUpdate()
    {
        Log(nameof(LateUpdate));
    }

    protected virtual void OnEnable()
    {
        Log(nameof(OnEnable));
    }
    protected virtual void OnDisable()
    {
        Log(nameof(OnDisable));
    }

    private void Log(string functionName)
    {
        Debug.Log($"{Time.frameCount}:{functionName}: {Name} @{gameObject.name} {gameObject.scene.name}");
    }
}
