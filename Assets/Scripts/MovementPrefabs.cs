using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPrefabs : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    void Start()
    {
        RandomMovement();
    }

    
    void Update()
    {
        this.transform.position += direction.normalized * speed * Time.deltaTime;
    }

    private void RandomMovement()
    {
        float xcount = Random.Range(-1f, 1f);
        int zcount = Random.Range(-1, 1);
        direction = new Vector3(xcount, 0f, zcount);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
    }
}
