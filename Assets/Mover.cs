using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Mover : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 direction;

    private void Start()
    {
        direction = Random.onUnitSphere;
    }

    private void Update()
    {
        var position = transform.position;
        position += direction * (speed * Time.deltaTime);
        transform.position = position;
    }
}
