using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeForm : MonoBehaviour
{
    private MeshFilter meshFilter;
    [SerializeField] private Mesh[] meshes;

    private void OnCollisionEnter(Collision collision)
    {
        meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = meshes[Random.Range(0, meshes.Length)];
    }
}
