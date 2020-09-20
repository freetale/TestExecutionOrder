using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class CommandTest : MonoBehaviour
{
    public GameObject Original;

    [Button]
    public void NewInstance()
    {
        Debug.Log("Before Instance");
        Instantiate(Original);
        Debug.Log("After Instance");
    }

    [Button]
    public void DestroyThis()
    {
        Debug.Log("Before Destory");
        Destroy(gameObject);
        Debug.Log("After Destory");
    }


    [Button]
    public void DestroyThisImmediate()
    {
        Debug.Log("Before DestroyImmediate");
        DestroyImmediate(gameObject);
        Debug.Log("After DestroyImmediate");
    }

    private IEnumerator holded;

    [Button]
    public void StartCoroutine()
    {
        Debug.Log("Before StartCoroutine");
        StartCoroutine(holded = Coroutine());
        Debug.Log("After StartCoroutine");
    }

    [Button]
    public void StopCoroutine()
    {
        Debug.Log("Before StopCoroutine");
        StopCoroutine(holded);
        Debug.Log("After StopCoroutine");
    }


    [Button]
    public void StartCoroutineString()
    {
        Debug.Log("Before StartCoroutine");
        StartCoroutine(nameof(Coroutine));
        Debug.Log("After StartCoroutine");
    }


    [Button]
    public void StopCoroutineString()
    {
        Debug.Log("Before StopCoroutine");
        StopCoroutine(nameof(Coroutine));
        Debug.Log("After StopCoroutine");
    }

    [Button]
    public void StopAllCoroutine()
    {
        Debug.Log("Before StopAllCoroutine");
        StopAllCoroutines();
        Debug.Log("After StopAllCoroutine");
    }

    public IEnumerator Coroutine()
    {
        Debug.Log("Begin Coroutine");
        while (true)
        {
            yield return null;
            Debug.Log($"{Time.frameCount} Yielded Coroutine");
        }
    }
}
