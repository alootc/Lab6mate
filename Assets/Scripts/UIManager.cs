using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Plane plane;

    private float timer;

    
    void Update()
    {
        timer += Time.deltaTime;

        scoreText.text = "Puntaje:" + Mathf.RoundToInt(timer);
        healthText.text = "Vidas: " + plane.Heart;
    }

}
