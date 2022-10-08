using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var direction = new Vector3(Random.Range(1f, 2f), Random.Range(1f, 2f), Random.Range(1f, 2f));
        transform.localScale = direction;
    }
}
