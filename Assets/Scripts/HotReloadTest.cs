using NaughtyAttributes;
using System;
using UnityEngine;

[ExecuteInEditMode]
public class HotReloadTest : ExecutionOrderTest
{
    public int FieldA;
    private int FieldB;
    [NonSerialized]
    public int FieldC;

    [NonSerialized]
    private int FieldD;
    
    public static int FieldF;
    private static int FieldG;
    [NonSerialized]
    public static int FieldH;
    [NonSerialized]
    private static int FieldI;


    [SerializeField]
    public static int FieldJ;
    [SerializeField]
    private static int FieldK;


    [NonSerialized]
    [ShowNonSerializedField]
    private string Display1;
    [NonSerialized]
    [ShowNonSerializedField]
    private string Display2;

    [Button]
    public void Increase()
    {
        FieldA += 1;
        FieldB += 2;
        FieldC += 3;
        FieldD += 4;
        
        FieldF += 5;
        FieldG += 6;
        FieldH += 7;
        FieldI += 8;
        FieldJ += 9;
        FieldK += 10;
    }

    protected override void Update()
    {
        //.
        UpdateField();
    }

    protected override void FixedUpdate()
    {
        //
    }

    protected override void LateUpdate()
    {
        
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        UpdateField();
        Debug.Log($" {Display1} {Display2}");
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        UpdateField();
        Debug.Log($" {Display1} {Display2}");
    }

    private void UpdateField()
    {
        Display1 = $"A:{FieldA} B:{FieldB} C:{FieldC} D:{FieldD}";
        Display2 = $"F:{FieldF} G:{FieldG} H:{FieldH} I:{FieldI} J:{FieldJ} K:{FieldK}";
    }
}
