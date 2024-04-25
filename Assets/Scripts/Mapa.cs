using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    private Rotacion3D r3D;

    void Start()
    {
        r3D = GetComponent<Rotacion3D>();
    }

    void Update()
    {
        r3D.angle -= Time.deltaTime;
    }
}
