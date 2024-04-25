using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation3DComplex : MonoBehaviour
{
    public Vector3 angle;

    [SerializeField] private Quaternion qx = Quaternion.identity;
    [SerializeField] private Quaternion qy = Quaternion.identity;
    [SerializeField] private Quaternion qz = Quaternion.identity;

    [SerializeField] private Quaternion r = Quaternion.identity;

    private float angleSin;
    private float angleCos;


    private void FixedUpdate()
    {
        angleSin = Mathf.Sin(Mathf.Deg2Rad * angle.z * 0.5f);
        angleCos = Mathf.Cos(Mathf.Deg2Rad * angle.z * 0.5f);
        qz.Set(0, 0, angleSin, angleCos);

        angleSin = Mathf.Sin(Mathf.Deg2Rad * angle.x * 0.5f);
        angleCos = Mathf.Cos(Mathf.Deg2Rad * angle.x * 0.5f);
        qx.Set(angleSin, 0, 0,  angleCos);

        angleSin = Mathf.Sin(Mathf.Deg2Rad * angle.y * 0.5f);
        angleCos = Mathf.Cos(Mathf.Deg2Rad * angle.y * 0.5f);
        qy.Set(0, angleSin, 0,  angleCos);

        r = qy * qx * qz;

        transform.rotation = r;
    }

}
