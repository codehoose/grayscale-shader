using System.Collections;
using UnityEngine;

public class FadeToGray : MonoBehaviour
{
    [SerializeField] private Renderer[] _renderers;

    [SerializeField] private Material _grayScale;

    [SerializeField] private bool _changeAll;

    private void OnDestroy()
    {
        _grayScale.SetFloat("_Blend", 0);
    }

    public void DoTheFade(int index)
    {
        if (_changeAll)
        {
            StartCoroutine(DoTheFadeAll());
        }
        else
        {
            StartCoroutine(DoTheFadeCR(_renderers[index]));
        }
    }

    private IEnumerator DoTheFadeAll()
    {
        float time = 0;
        while (time < 1f)
        {
            _grayScale.SetFloat("_Blend", time);
            time += Time.deltaTime;
            yield return null;
        }

        _grayScale.SetFloat("_Blend", 1);
    }

    private IEnumerator DoTheFadeCR(Renderer renderer)
    {
        float time = 0;
        while (time < 1f)
        {
            renderer.material.SetFloat("_Blend", time);
            time += Time.deltaTime;
            yield return null;
        }

        renderer.material.SetFloat("_Blend", 1);
    }
}
