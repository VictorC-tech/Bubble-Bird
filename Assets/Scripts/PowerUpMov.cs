using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMov : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.65f;

    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }

    
}
