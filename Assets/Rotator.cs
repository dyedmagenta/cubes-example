using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 1f;
    
    void Update()
    {
        var rotation = transform.rotation.eulerAngles;
        var newY = rotation.y + speed * Time.deltaTime;
        rotation.y = newY;
        transform.rotation = Quaternion.Euler(rotation);
    }
}




