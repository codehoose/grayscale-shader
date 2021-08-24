using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToGray : MonoBehaviour
{
    public Material[] materials;


    public void DoTheFade(int index)
    {
        StartCoroutine(DoTheFadeCR(materials[index]));
    }

    private IEnumerator DoTheFadeCR(Material material)
    {
        float time = 0;
        while (time < 1f)
        {
            material.SetFloat("_Blend", time);
            time += Time.deltaTime;
            yield return null;
        }

        material.SetFloat("_Blend", 1);
    }
}
