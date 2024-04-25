using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;
    private Rotation3DComplex r3D;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        r3D = GetComponent<Rotation3DComplex>();
    }


    void Start()
    {
        rb.velocity = Vector3.back ;
        r3D.angle = new Vector3(StartRotation(), StartRotation(), StartRotation());
        Destroy(this.gameObject, 5f);
    }

    void Update()
    {
        r3D.angle += Vector3.one * speed;

    }

    private float StartRotation()
    {
        return Random.Range(0, 180);
    }


}
