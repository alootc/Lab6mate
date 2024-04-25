using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion3D : MonoBehaviour
{
    public float angle;

    [SerializeField] private Quaternion q = Quaternion.identity;

    private float angleSin;
    private float angleCos;

    void FixedUpdate()
    {
        angleSin = Mathf.Sin(Mathf.Deg2Rad * angle * 0.5f);
        angleCos = Mathf.Cos(Mathf.Deg2Rad * angle * 0.5f);
        q.Set(angleSin, 0, 0, angleCos);

        transform.rotation = q;

    }
}