using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.65f;

    [SerializeField]

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }
}
