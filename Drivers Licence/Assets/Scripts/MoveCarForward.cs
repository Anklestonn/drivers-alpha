using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarForward : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
