using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartInstantiate : MonoBehaviour
{
    public void Start()
    {
        transform.position = new Vector3(Random.Range(-1, 1.5f), Random.Range(0.5f, 2));
    }
}
