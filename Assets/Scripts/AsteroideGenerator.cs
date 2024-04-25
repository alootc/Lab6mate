using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideGenerator : MonoBehaviour
{
    [SerializeField] private Vector2 randomPosition;


    [SerializeField] private GameObject asteroide;

    [SerializeField] private float timeForGenerator;

    void Start()
    {
        StartCoroutine(Generator());
    }

    private IEnumerator Generator()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeForGenerator);

            Vector3 rnd = new Vector3(RandomPosition(randomPosition.x), RandomPosition(randomPosition.y) + transform.position.y, transform.position.z);

            GameObject a = Instantiate(asteroide, rnd, Quaternion.identity);
        }
    }

    private float RandomPosition(float eje)
    {
        return Random.Range(-eje, eje);
    }

}
