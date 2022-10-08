using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    private void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}

